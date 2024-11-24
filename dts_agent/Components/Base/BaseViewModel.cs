using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Model;
using dts_agent.Helper;
using dts_agent.StandardMessage;
using System.Windows;
using dts_agent.Cache;
using dts_agent.ViewModelMediator;
using dts_logger.Logger;
using dts_agent.Components.Global;

namespace dts_agent.Components.Base
{
    public class BaseViewModel : BaseModel
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lp1, string lp2);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);

        private readonly IView view;

        //Member Type
        protected const string MEMBER = "MEMBER";

        protected const string GUEST = "GUEST";
        protected const string PARTNER = "PARTNER";
        protected const string SUPER_ADMIN = "SUPER ADMIN";
        protected const string TECHNICIAN = "TECHNICIAN";

        private GenericDialogWindow genericWindow;

        public BaseViewModel()
        {
        }

        protected BaseViewModel(IView view)
        {
            this.view = view;
        }

        protected bool ShowConfirmationWindow(string warningMessage, string mode, Window owner = null)
        {
            if (warningMessage == DtsMessageResource.CurrentResourceManager.GetString("ErrorUnexpected"))
            {
                if (DataCacheContext.IsUnexpectedErrorWindowOpen) return false;

                DataCacheContext.IsUnexpectedErrorWindowOpen = true;
            }

            bool? windowDialogResult = false;

            return Application.Current.Dispatcher.Invoke(() =>
            {
                genericWindow = new GenericDialogWindow();

                try
                {
                    genericWindow.Owner = owner ?? Application.Current.MainWindow;
                }
                catch (Exception ex)
                {
                    CodedLogger.LogException(ex);
                }

                Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel, Messages.ConfirmationWindow,
                    genericWindow, DataCacheContext.GenericDialogWindowCount);
                Mediator.Instance.NotifyViewModel(Messages.ConfirmationWindowViewModel, mode, warningMessage,
                    DataCacheContext.GenericDialogWindowCount);

                genericWindow.Deactivated += (sender, e) => GenericWindow_Deactivated(sender, e, warningMessage);
                ;
                windowDialogResult = genericWindow.ShowDialog();

                if (warningMessage == "Incorrect old password.")
                    Mediator.Instance.NotifyViewModel(Messages.MyAccountUserControl, Messages.InvalidPassword, null);
                else if (warningMessage == DtsMessageResource.CurrentResourceManager.GetString("ErrorUnexpected"))
                    DataCacheContext.IsUnexpectedErrorWindowOpen = false;

                return windowDialogResult.Value;
            });
        }

        private void GenericWindow_Deactivated(object sender, EventArgs e, string message)
        {
            try
            {
                if (message == DtsMessageResource.CurrentResourceManager.GetString("ErrorUnexpected"))
                    DataCacheContext.IsUnexpectedErrorWindowOpen = false;

                Mediator.Instance.NotifyViewModel(Messages.MainDashboardUserControl, Messages.ShowBlurBackground,
                    false);
                Mediator.Instance.NotifyViewModel(Messages.LoginViewModel, Messages.ShowBlurBackground, false);
                genericWindow.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}