using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_cashier.Components.Base;
using dts_cashier.Components.Login;

namespace dts_cashier.Helper.IViewHelper
{
    public class ViewService : IViewService
    {
        public delegate AbstractViewModel NewViewModelDelegate(IView view);

        private ViewService()
        {
            Mappings = new Dictionary<Type, Type>();

            //Register<MainViewModel, MainWindow>();
            Register<LoginWindowViewModel, LoginWindow>();
        }

        public IDictionary<Type, Type> Mappings { get; }

        public static ViewService Instance { get; } = new ViewService();

        public void ShowView<TViewModel>() where TViewModel : AbstractViewModel
        {
            var viewType = Mappings[typeof(TViewModel)];
            var view = (IView)Activator.CreateInstance(viewType);
            view.DataContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), view);
            view.Show();
        }

        private void Register<TViewModel, TView>() where TViewModel : AbstractViewModel
            where TView : IView
        {
            if (Mappings.ContainsKey(typeof(TViewModel)))
                throw new ArgumentException($"Type {typeof(TViewModel)} is already mapped to type {typeof(TView)}");

            Mappings.Add(typeof(TViewModel), typeof(TView));
        }
    }
}