using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using dts_cashier.Components.Login;
using dts_cashier.Helper.IViewHelper;

namespace dts_cashier
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public enum LanguageType
        {
            EnUS = 0,
            ThTHA = 1,
            ViVN = 2,
            IdIND = 3
        }

        private const string DesktopDirectory = @"C:\Windows\";
        private const string FromAddress = "no-reply@vikings.com.vn";
        private const string ToAddress = "dev@vikings.com.vn";
        private const string CultureName = "en-US";
        private const string appName = "Cashier";

        public static LanguageType Language { get; set; } = LanguageType.EnUS;

        protected override void OnStartup(StartupEventArgs e)
        {
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(CultureName);

            //var configSecurity = new ConfigDataProtector();

            ViewService.Instance.ShowView<LoginWindowViewModel>();
        }
    }
}