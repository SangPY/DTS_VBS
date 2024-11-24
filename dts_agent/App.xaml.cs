﻿using dts_agent.Cache;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using dts_logger.Logger;
using System.Threading;
using dts_cryptography;
using dts_agent.Helper;
using dts_agent.Components.Login;
using dts_agent.StandardMessage;
using dts_agent.ResponseMessageResource;
using dts_agent.NamedPipe;
using dts_agent.ViewModelMediator;
using System.Diagnostics;
using dts_shared.Utilities;
using dts_agent.Analytics;

namespace dts_agent
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string DriveDirectory = @"C:\Windows\";
        private const string FromAddress = "no-reply@vikings.com.vn";
        private const string ToAddress = "dev@vikings.com.vn";
        private DispatcherTimer analyticsSendingTimer = new DispatcherTimer();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static LanguageType Language { get; set; } = LanguageType.EnUS;

        public enum LanguageType
        {
            ThTHA = 0,
            EnUS = 1,
            ViVN = 2,
            IdIND = 3
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            DataCacheContext.IsUserLoggedIn = false;

            // Instantiate first to generate a valid key.
            var configSecurity = new ConfigDataProtector();

            try
            {
                ViewService.Instance.ShowView<LoginViewModel>();
            }
            catch (Exception ex)
            {
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
            Process currentProcess = Process.GetCurrentProcess();
            var runningProcess = (from process in Process.GetProcesses()
                                  where
                                    process.Id != currentProcess.Id &&
                                    process.ProcessName.Equals(
                                      currentProcess.ProcessName,
                                      StringComparison.Ordinal)
                                  select process).FirstOrDefault();
            if (runningProcess != null)
            {
                SetForegroundWindow(runningProcess.MainWindowHandle);
            }

            InitializeAnalyticsSendingTimer();
            // theo dõi  tiến trình shutdown
            TimerServiceMonitor.Initialize();
        }

        #region handel

        private void InitializeAnalyticsSendingTimer()
        {
            //analyticsSendingTimer.Tick += SendAdActivities;
            analyticsSendingTimer.Interval = new TimeSpan(0, 30, 0);
            analyticsSendingTimer.Start();
        }

        //private void SendAdActivities(object sender, EventArgs e)
        //{
        //    if (ServerConnectionUtility.IsOfflineMode)
        //    {
        //        return;
        //    }

        //    foreach (int adId in DataCacheContext.ActivatedAds)
        //    {
        //        int clickCount = 0;
        //        int impressionCount = 0;
        //        int viewCount = 0;

        //        if (DataCacheContext.AdsImpressionCounts.ContainsKey(adId))
        //        {
        //            impressionCount = DataCacheContext.AdsImpressionCounts[adId];
        //        }

        //        if (DataCacheContext.AdsViewCounts.ContainsKey(adId))
        //        {
        //            viewCount = DataCacheContext.AdsViewCounts[adId];
        //        }

        //        if (viewCount > 0 || impressionCount > 0)
        //        {
        //            Task.Run(async () =>
        //            {
        //                AnalyticsClient.Instance.SendAdAnalytics(adId, clickCount, impressionCount, viewCount);
        //            });
        //        }
        //    }
        //    AdsUtil.ClearAllCounts();
        //}

        public void ChangeLanguage(int selectedLanguage)
        {
            foreach (ResourceDictionary dict in Resources.MergedDictionaries)
            {
                if (dict is LanguageResources langDict)
                {
                    langDict.UpdateSource();
                    DtsMessageResource.SetMessageResource(Language);
                    DtsErrorMessageResource.SetMessageResource(Language);
                }
                else
                    dict.Source = dict.Source;
            }

            NamedPipeClientModel.Instance.SendToServer(Guid.NewGuid(), Messages.ChangeLanguage, selectedLanguage);
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            //CreateExceptionMessage(ex, "CurrentDomain_UnhandledException()");
            CodedLogger.LogException(ex);
            SendExceptionToCashier(ex);
        }

        private void SendExceptionToCashier(Exception ex)
        {
            //string macAddress = string.IsNullOrEmpty(vbs_network.Helper.NetworkInterfaceHelper.GetMacAddress().ToString()) ?
            //    "MacAddress - NA" :
            //    vbs_network.Helper.NetworkInterfaceHelper.GetMacAddress().ToString();

            //string branchName = string.IsNullOrEmpty(DataCacheContext.BranchName) ?
            //    "BranchName - NA" :
            //    DataCacheContext.BranchName;

            //string pcName = "PC - NA";

            //if (DataCacheContext.StationInformationModel != null)
            //{
            //    if (!string.IsNullOrEmpty(DataCacheContext.StationInformationModel.Name))
            //    {
            //        pcName = DataCacheContext.StationInformationModel.Name;
            //    }
            //}

            //string userSessionName = "User - NA";

            //if (DataCacheContext.UserAccountInstance != null)
            //{
            //    if (!string.IsNullOrEmpty(DataCacheContext.UserAccountInstance.UserName))
            //    {
            //        userSessionName = DataCacheContext.UserAccountInstance.UserName;
            //    }
            //}

            //if (NetworkClient.Instance.IsConnectionToServerAcknowledged)
            //{
            //    string networkMessage = $"[Agent Exception] BranchName - {branchName}, MacAddress - {macAddress}, PCName - {pcName}, UserName - {userSessionName}, Target - {ex.TargetSite.ReflectedType.FullName}, Message - {ex.Message}";

            //    NetworkClient.Instance.SendMessageToServer(NetworkMessageType.EXCEPTION_EVENT, networkMessage);
            //}
        }

        #endregion handel
    }
}