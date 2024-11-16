using dts_agent.Components.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Helper;
using System.Windows;

namespace dts_agent.Components.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly Window loginWindow;

        public LoginViewModel(IView view) : base(view)
        {
            loginWindow = (Window)view;
            //Mediator.Instance.Register(this, Messages.LoginViewModel);

            //InitializeLanguages();
        }
    }
}