using dts_agent.Helper;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace dts_agent.Components.Login
{
    /// <summary>
    /// Interaction logic for LoginWiew.xaml
    /// </summary>
    public partial class LoginWiew : MetroWindow, IView
    {
        public LoginWiew()
        {
            InitializeComponent();
            this.Topmost = true;
        }
    }
}