using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.StandardMessage
{
    public class DtsMessageResource
    {
        // Sample Usage : VbsMessageResource.CurrentResourceManager.GetString("ResourceNameHere")

        public static ResourceManager CurrentResourceManager = new ResourceManager("dts_agent.StandardMessage.StandardMessageResource", Assembly.GetExecutingAssembly());

        public static void SetMessageResource(App.LanguageType languageType)
        {
            switch (languageType)
            {
                case App.LanguageType.EnUS:
                    CurrentResourceManager = new ResourceManager("dts_agent.StandardMessage.StandardMessageResource", Assembly.GetExecutingAssembly());
                    break;

                case App.LanguageType.ViVN:
                    CurrentResourceManager = new ResourceManager("dts_agent.StandardMessage.StandardMessageResource-VN", Assembly.GetExecutingAssembly());
                    break;

                default:
                    CurrentResourceManager = new ResourceManager("dts_agent.StandardMessage.StandardMessageResource", Assembly.GetExecutingAssembly());
                    break;
            }
        }
    }
}