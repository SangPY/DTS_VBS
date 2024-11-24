using dts_agent.Manager;
using dts_cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.ServiceProvider
{
    public class ServiceProvider : ServiceProviderBase
    {
        protected AppSettingManager manager = AppSettingManager.Instance;

        protected string CAFE_SERVER
        {
            get
            {
#if DEBUG
                return manager[AppSettingKey.CAFE_SERVER];
#endif
#if RELEASE
                return Decrypt(manager[AppSettingKey.CAFE_SERVER]);
#endif
            }
        }

        protected string STORE_SERVER
        {
            get
            {
#if DEBUG
                return manager[AppSettingKey.STORE_SERVER];
#endif
#if RELEASE
                return Decrypt(manager[AppSettingKey.STORE_SERVER]);
#endif
            }
        }

        protected string ADS_SERVER
        {
            get
            {
#if DEBUG
                return manager[AppSettingKey.ADS_SERVER];
#endif
#if RELEASE
                return Decrypt(manager[AppSettingKey.ADS_SERVER]);
#endif
            }
        }

        protected string ANALYTICS_SERVER
        {
            get
            {
#if DEBUG
                return manager[AppSettingKey.ANALYTICS_SERVER];
#endif
#if RELEASE
                return Decrypt(manager[AppSettingKey.ANALYTICS_SERVER]);
#endif
            }
        }

        protected string GAMEPASS_SERVER
        {
            get
            {
#if DEBUG
                return manager[AppSettingKey.GAMEPASS_SERVER];
#endif
#if RELEASE
                return Decrypt(manager[AppSettingKey.GAMEPASS_SERVER]);
#endif
            }
        }

        //protected string LOCAL_SERVER
        //{
        //    get
        //    {
        //        return manager[AppSettingKey.LOCAL_SERVER];
        //    }
        //}

        public override string Decrypt(string encryptedValue)
        {
            return ConfigDataProtector.NewDecrypt(Convert.FromBase64String(encryptedValue));
        }
    }
}