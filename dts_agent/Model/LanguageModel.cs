using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.Model
{
    public class LanguageModel : BaseModel
    {
        private int sequence;

        public int Sequence
        {
            get { return sequence; }
            set
            {
                sequence = value;
                RaisePropertyChanged(nameof(Sequence));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        private string iconSource;

        public string IconSource
        {
            get { return iconSource; }
            set
            {
                iconSource = value;
                RaisePropertyChanged(nameof(IconSource));
            }
        }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                RaisePropertyChanged(nameof(IsSelected));
            }
        }

        private int languageValue;

        public int LanguageValue
        {
            get { return languageValue; }
            set
            {
                languageValue = value;
                RaisePropertyChanged(nameof(LanguageValue));
            }
        }
    }
}