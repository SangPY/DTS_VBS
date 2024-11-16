using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Components.Base;
using dts_agent.Components.Login;

namespace dts_agent.Helper
{
    public sealed class ViewService : IViewService
    {
        private static readonly ViewService instance = new ViewService();
        public IDictionary<Type, Type> Mappings { get; }

        private ViewService()
        {
            Mappings = new Dictionary<Type, Type>();
            //Register<DashboardViewModel, DashboardView>();
            //Register<LoginViewModel, LoginView>();
        }

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
            if (Mappings == null)
            {
                throw new InvalidOperationException("Mappings chưa được khởi tạo.");
            }

            //if (!Mappings.TryGetValue(typeof(TViewModel), out Type viewType))
            //{
            //    throw new KeyNotFoundException($"Không tìm thấy key cho ViewModel {typeof(TViewModel).Name} trong Mappings.");
            //}

            Type viewType = Mappings[typeof(TViewModel)];
            IView view = (IView)Activator.CreateInstance(viewType);
            view.DataContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), new object[] { view });
            view.Show();
        }
    }
}