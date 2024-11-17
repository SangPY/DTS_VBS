using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static dts_agent.App;

namespace dts_agent.ResponseMessageResource
{
    public class DtsErrorMessageResource
    {
        //public static ResourceManager CurrentResourceManager = new ResourceManager("GocafeShared.ResponseMessageResource.ErrorMessageResource", typeof(ErrorMessageResource).Assembly);

        //public static void SetMessageResource(App.LanguageType languageType)
        //{
        //    switch (languageType)
        //    {
        //        case App.LanguageType.EnUS:
        //            CurrentResourceManager = new ResourceManager("GocafeShared.ResponseMessageResource.ErrorMessageResource", typeof(ErrorMessageResource).Assembly);
        //            break;

        //        case App.LanguageType.ViVN:
        //            CurrentResourceManager = new ResourceManager("GocafeShared.ResponseMessageResource.ErrorMessageResource-VN", typeof(ErrorMessageResource_VND).Assembly);
        //            break;

        //        default:
        //            CurrentResourceManager = new ResourceManager("GocafeShared.ResponseMessageResource.ErrorMessageResource", typeof(ErrorMessageResource).Assembly);
        //            break;
        //    }
        //}

        //public static string GetStringByValue(string resourceValue)
        //{
        //    var entry = dts_.ResponseMessageResource.ErrorMessageResource.ResourceManager.GetResourceSet(System.Threading.Thread.CurrentThread.CurrentCulture, true, true)
        //                                                                                         .OfType<DictionaryEntry>()
        //                                                                                         .FirstOrDefault(e => e.Value.ToString() == resourceValue);
        //    if (entry.Key == null)
        //        return resourceValue;

        //    var translatedResource = CurrentResourceManager.GetString(entry.Key.ToString());

        //    if (translatedResource == null)
        //        return resourceValue;

        //    return translatedResource;
        //}
    }
}