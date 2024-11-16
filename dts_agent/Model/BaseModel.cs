using dts_agent.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.StandardMessage;

namespace dts_agent.Model
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseModel()
        {
            CurrencySymbol = DataCacheContext.CurrencySign;
            PriceCurrencySymbol = DtsMessageResource.CurrentResourceManager.GetString("PriceLabel") + DataCacheContext.CurrencySign;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void SendData(string message, object data)
        {
        }

        private string currencySymbol;

        public string CurrencySymbol
        {
            get { return currencySymbol; }
            set
            {
                currencySymbol = value;
                RaisePropertyChanged(nameof(CurrencySymbol));
            }
        }

        private string priceCurrencySymbol;

        public string PriceCurrencySymbol
        {
            get { return priceCurrencySymbol; }
            set
            {
                priceCurrencySymbol = value;
                RaisePropertyChanged(nameof(PriceCurrencySymbol));
            }
        }
    }
}