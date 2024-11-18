using dts_cashier.Command;
using dts_cashier.Helper.IViewHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using dts_cashier.Components.Base.Database;

namespace dts_cashier.Components.Base
{
    public class AbstractViewModel : DbContextViewModelBase
    {
        protected readonly IViewService GenerateWindowService;

        private readonly IView view;

        protected AbstractViewModel(IView view)
        {
            this.view = view;
        }

        private string Name { get; }

        public ICommand CloseButton => new DelegateCommand(CloseView);

        protected void CloseView<T>() where T : Window
        {
            var window = Application.Current.Windows.OfType<T>().FirstOrDefault();
            if (window != null)
                window.Close();
        }

        protected void CloseView()
        {
            if (view != null) view.Close();
        }
    }
}