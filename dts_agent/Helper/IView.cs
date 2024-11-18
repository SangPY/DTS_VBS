using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace dts_agent.Helper
{
    public interface IView
    {
        object DataContext { get; set; }
        Window Owner { get; set; }

        void Close();

        void Show();

        void Hide();

        bool Activate();

        bool? ShowDialog();
    }
}