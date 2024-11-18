using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dts_cashier.Components.Container
{
    public class CashierMainControlViewModel
    {
        #region Private properties

        private int windowPopupCount;

        #endregion Private properties

        public CashierMainControlViewModel()
        {
            //Mediator.Instance.Register(this, Messages.CashierViewModel);
            windowPopupCount = 0;
        }
    }
}