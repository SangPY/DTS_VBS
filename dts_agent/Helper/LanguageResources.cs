using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static dts_agent.App;

namespace dts_agent.Helper
{
    public class LanguageResources : ResourceDictionary
    {
        private Uri enUS;

        public Uri EnUS
        {
            get { return enUS; }
            set
            {
                enUS = value;
                UpdateSource();
            }
        }

        private Uri viVN;

        public Uri ViVN
        {
            get { return viVN; }
            set
            {
                viVN = value;
                UpdateSource();
            }
        }

        public void UpdateSource()
        {
            App.LanguageType languageType = Language;
            var value = EnUS;
            if (languageType == App.LanguageType.EnUS)
                value = EnUS;
            else if (languageType == App.LanguageType.ViVN)
                value = ViVN;
            if (value != null && base.Source != value)
                base.Source = value;
        }
    }
}