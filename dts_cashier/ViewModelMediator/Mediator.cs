using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_cashier.ViewModelMediator
{
    public sealed class Mediator
    {
        //private readonly MultiDictionary<string, BaseModel> internalList = new MultiDictionary<string, BaseModel>();

        //static Mediator()
        //{
        //}

        //private Mediator()
        //{
        //}

        //public static Mediator Instance { get; } = new Mediator();

        //public void Register(BaseModel viewModel, string message)
        //{
        //    internalList.AddValue(message, viewModel);
        //}

        //public void UnRegister(BaseModel viewModel, string message)
        //{
        //    if (internalList.ContainsKey(message)) internalList.Remove(message);
        //}

        //public bool IsRegistered(string message)
        //{
        //    return internalList.ContainsKey(message);
        //}

        //public void NotifyViewModel(string viewModelName, string message, object args)
        //{
        //    if (internalList.ContainsKey(viewModelName))
        //        foreach (var viewModel in internalList[viewModelName])
        //            viewModel.SendData(message, args);
        //}

        //public void NotifyViewModels(List<string> viewModelList, string message, object args)
        //{
        //    foreach (var viewModelName in viewModelList)
        //        if (internalList.ContainsKey(viewModelName))
        //            foreach (var viewModel in internalList[viewModelName])
        //                viewModel.SendData(message, args);
        //}

        //public void ClearInternalList()
        //{
        //    internalList.Clear();
        //}
    }
}