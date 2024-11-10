using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dts_cashier.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action action;
        private Action<string> gotFocus;
        private DelegateCommand openDropDown;

        public DelegateCommand(Action action)
        {
            this.action = action;
        }

        public DelegateCommand(DelegateCommand openDropDown)
        {
            this.openDropDown = openDropDown;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }

    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> action;

        public DelegateCommand(Action<T> action)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action((T)parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}