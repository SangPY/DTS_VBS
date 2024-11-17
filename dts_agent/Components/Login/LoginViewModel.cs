using dts_agent.Components.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Helper;
using System.Windows;
using dts_agent.ViewModelMediator;
using System.Windows.Threading;

namespace dts_agent.Components.Login
{
    public class LoginViewModel : BaseViewModel
    {
        #region Fields

        private const string LICENSE_KEY = "LicenseKey";
        private const string CYBERCAFE_ID = "CyberCafeID";
        private const string RESTART_ENABLED = "RestartEnabled";
        private const string LOGIN_IDLE_ENABLED = "LoginIdleEnabled";
        private const string SERVER_IPADDRESS = "ServerIPAddress";
        private const string SERVER_PORT = "ServerPort";
        private const string ASYNC_TIMEOUT = "AsyncTimeout";
        private const string INSUFFICIENT_NOTIFICATION_TIMER = "InsufficientNotificationTimer";
        private const string CAROUSEL_IMAGE_TIME = "CarouselChangeImageTime";
        private const string GAME_MENU_DIRECTORY = "GameMenuDirectory";
        private const string SHUTDOWN_TIMER_TIME = "ShutdownTimer";

        private DispatcherTimer currentDateTimeTimer = new DispatcherTimer();

        private readonly Window loginWindow;

        private bool isLoggingIn = false;

        #endregion Fields

        public LoginViewModel(IView view) : base(view)
        {
            loginWindow = (Window)view;
            Mediator.Instance.Register(this, Messages.LoginViewModel);
            SetIsProcessing(true);

            InitializeCurrentDateTimeTimer();
            //InitializeLanguages();
        }

        private void InitializeCurrentDateTimeTimer()
        {
            currentDateTimeTimer.Interval = TimeSpan.FromSeconds(5);
            currentDateTimeTimer.Tick += CurrentDateTimeTick;
            currentDateTimeTimer.Start();
        }

        private void CurrentDateTimeTick(object sender, EventArgs e)
        {
            LoginModel.CurrentDateTime = DateTime.Now.ToString("MMMM dd, yyyy (dddd) hh:mm tt");
        }

        protected void SetIsProcessing(bool value)
        {
            App.Current.Dispatcher.BeginInvoke((Action)delegate
            {
                IsProcessing = value;
            });
        }

        private bool isProcessing;

        public bool IsProcessing
        {
            get { return isProcessing; }
            set
            {
                isProcessing = value;
                RaisePropertyChanged(nameof(IsProcessing));
            }
        }

        #region get set

        private LoginModel loginModel;

        public LoginModel LoginModel
        {
            get { return loginModel; }
            set
            {
                loginModel = value;
                RaisePropertyChanged(nameof(LoginModel));
            }
        }

        #endregion get set
    }
}