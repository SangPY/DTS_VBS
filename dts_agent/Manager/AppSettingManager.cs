using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.Manager
{
    public class AppSettingManager
    {
        #region Constants and Read-only

        private static readonly AppSettingManager manager = new AppSettingManager();

        #endregion Constants and Read-only

        private NameValueCollection appSettings = null;

        public AppSettingManager()
        {
            appSettings = ConfigurationManager.AppSettings;
        }

        public string this[string name]
        {
            get
            {
                return appSettings[name];
            }
        }

        public static AppSettingManager Instance
        {
            get
            {
                return manager;
            }
        }

        public String WS_SERVER
        {
            get
            {
                return appSettings[AppSettingKey.WS_SERVER];
            }
        }
    }

    public sealed class AppSettingKey
    {
        public const string CAFE_SERVER = "CAFE_SERVER";
        public const string STORE_SERVER = "STORE_SERVER";
        public const string ADS_SERVER = "ADS_SERVER";
        public const string ANALYTICS_SERVER = "ANALYTICS_SERVER";
        public const string GAMEPASS_SERVER = "GAMEPASS_SERVER";
        public const string LOCAL_SERVER = "LOCAL_SERVER";
        public const string WS_SERVER = "WS_SERVER";
        public const string CurrencySign = "CurrencySign";
        public const string LogsLocation = "LogsLocation";
        public const string CanLogMoreDetails = "CanLogMoreDetails";
        public const string IsConfigDecrypted = "IsConfigDecrypted";
        public const string SaslUsername = "SaslUsername";
        public const string SaslPassword = "SaslPassword";
    }
}