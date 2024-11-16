using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Components.Base;

namespace dts_agent.Helper
{
    public sealed class ViewService : IViewService
    {
        private static readonly ViewService instance = new ViewService();
        public IDictionary<Type, Type> Mappings { get; }

        public static ViewService Instance
        {
            get
            {
                return instance;
            }
        }

        public delegate BaseViewModel NewViewModelDelegate(IView view);

        public void ShowView<TViewModel>() where TViewModel : BaseViewModel
        {
            Type viewType = Mappings[typeof(TViewModel)];
            IView view = (IView)Activator.CreateInstance(viewType);
            view.DataContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), new object[] { view });
            view.Show();
        }
    }
}