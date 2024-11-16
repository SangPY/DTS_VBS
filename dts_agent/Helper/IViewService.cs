using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace dts_agent.Helper
{
    public interface IViewService
    {
        ///// <summary>
        ///// Use this to show views whose view models do not have a parameter.
        ///// </summary>
        //void ShowView<TViewModel>() where TViewModel : BaseViewModel;

        ///// <summary>
        ///// Use this to show views whose view models do not have a parameter.
        ///// </summary>
        //void ShowDialog<TViewModel>(Window owner) where TViewModel : BaseViewModel;

        ///// <summary>
        ///// Use this to show views whose view models contain parameters.
        ///// The NewViewModelDelegate is responsible for returning the new instance of the view model given the view.
        ///// </summary>
        //void ShowView<TViewModel>(ViewService.NewViewModelDelegate nvmDelegate) where TViewModel : BaseViewModel;

        ///// <summary>
        ///// Use this to show views whose view models contain parameters.
        ///// The NewViewModelDelegate is responsible for returning the new instance of the view model given the view.
        ///// </summary>
        //void ShowDialog<TViewModel>(ViewService.NewViewModelDelegate nvmDelegate, Window owner) where TViewModel : BaseViewModel;
    }
}