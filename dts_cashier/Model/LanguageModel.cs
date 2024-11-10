using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_cashier.Model
{
    public class LanguageModel : BaseModel
    {
        private string iconSource;

        private bool isSelected;

        private int languageValue;

        private string name;
        private int sequence;

        public int Sequence
        {
            get => sequence;
            set
            {
                sequence = value;
                RaisePropertyChanged(nameof(Sequence));
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string IconSource
        {
            get => iconSource;
            set
            {
                iconSource = value;
                RaisePropertyChanged(nameof(IconSource));
            }
        }

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                RaisePropertyChanged(nameof(IsSelected));
            }
        }

        public int LanguageValue
        {
            get => languageValue;
            set
            {
                languageValue = value;
                RaisePropertyChanged(nameof(LanguageValue));
            }
        }
    }
}