using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            Register<LoginViewModel, LoginWiew>();
        }

        public static ViewService Instance
        {
            get
            {
                return instance;
            }
        }

        public delegate BaseViewModel NewViewModelDelegate(IView view);

        private void Register<TViewModel, TView>() where TViewModel : BaseViewModel
                                                  where TView : IView
        {
            if (Mappings.ContainsKey(typeof(TViewModel)))
            {
                throw new ArgumentException($"Type {typeof(TViewModel)} is already mapped to type {typeof(TView)}");
            }

            Mappings.Add(typeof(TViewModel), typeof(TView));
        }

        public void ShowView<TViewModel>() where TViewModel : BaseViewModel
        {
            // chưa khai báo  Mappings = new Dictionary<Type, Type>();
            //if (Mappings == null)
            //{
            //    throw new InvalidOperationException("Mappings chưa được khởi tạo.");
            //}

            // chưa đăng ký Register<LoginViewModel, LoginWiew>();
            //if (!Mappings.TryGetValue(typeof(TViewModel), out Type viewType))
            //{
            //    throw new KeyNotFoundException($"Không tìm thấy key cho ViewModel {typeof(TViewModel).Name} trong Mappings.");
            //}

            Type viewType = Mappings[typeof(TViewModel)];
            IView view = (IView)Activator.CreateInstance(viewType);
            view.DataContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), new object[] { view });
            view.Show();
        }

        public void ShowView<TViewModel>(NewViewModelDelegate nvmDelegate) where TViewModel : BaseViewModel
        {
            Type viewType = Mappings[typeof(TViewModel)];
            IView view = (IView)Activator.CreateInstance(viewType);
            view.DataContext = nvmDelegate(view);
            view.Show();
        }

        public void ShowDialog<TViewModel>(Window owner) where TViewModel : BaseViewModel
        {
            Type viewType = Mappings[typeof(TViewModel)];

            IView view = (IView)Activator.CreateInstance(viewType);

            view.DataContext = (TViewModel)Activator.CreateInstance(typeof(TViewModel), new object[] { view });
            view.Owner = owner;
            view.ShowDialog();
        }

        public void ShowDialog<TViewModel>(NewViewModelDelegate nvmDelegate, Window owner) where TViewModel : BaseViewModel
        {
            Type viewType = Mappings[typeof(TViewModel)];

            IView view = (IView)Activator.CreateInstance(viewType);

            view.DataContext = nvmDelegate(view);
            view.Owner = owner;
            view.ShowDialog();
        }
    }
}