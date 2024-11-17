using dts_agent.Components.Base;
using dts_agent.StandardMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.Components.Login
{
    public class LoginModel : BaseViewModel
    {
        #region Properties

        private const string ENTER_PASSWORD = "Enter Password";
        private const string DEFAULT_SHUTDOWN_TIME = "5:00";
        private bool usernameFirstLoad = true;

        #endregion Properties

        public LoginModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            Username = string.Empty;
            HasErrorOnPassword = false;
            IsCompanyHasLogo = false;
            CustomerType = MEMBER;
            ShutdownLoginTimer = DEFAULT_SHUTDOWN_TIME;
            ProceedToLoginVisibility = false;
            CurrentDateTime = DateTime.Now.ToString("MMMM dd, yyyy (dddd) hh:mm tt");
        }

        #region get set

        private bool proceedToLoginVisibility;

        public bool ProceedToLoginVisibility
        {
            get { return proceedToLoginVisibility; }
            set
            {
                proceedToLoginVisibility = value;
                RaisePropertyChanged(nameof(ProceedToLoginVisibility));
            }
        }

        private bool isCompanyHasLogo;

        public bool IsCompanyHasLogo
        {
            get { return isCompanyHasLogo; }
            set
            {
                isCompanyHasLogo = value;
                RaisePropertyChanged(nameof(IsCompanyHasLogo));
            }
        }

        private bool hasErrorOnUsername;

        public bool HasErrorOnUsername
        {
            get { return hasErrorOnUsername; }
            set
            {
                hasErrorOnUsername = value;
                RaisePropertyChanged(nameof(HasErrorOnUsername));
            }
        }

        private bool hasErrorOnPassword;

        public bool HasErrorOnPassword
        {
            get { return hasErrorOnPassword; }
            set
            {
                hasErrorOnPassword = value;
                RaisePropertyChanged(nameof(HasErrorOnPassword));
            }
        }

        private bool hasErrorOnValueChanged = true;

        public bool HasErrorOnValueChanged
        {
            get { return hasErrorOnValueChanged; }
            set
            {
                hasErrorOnValueChanged = value;
                RaisePropertyChanged(nameof(HasErrorOnValueChanged));
            }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                RaisePropertyChanged(nameof(Username));
            }
        }

        private string customerType;

        public string CustomerType
        {
            get { return customerType; }
            set
            {
                customerType = value;
                RaisePropertyChanged(nameof(CustomerType));
            }
        }

        private string shutdownLoginTimer;

        public string ShutdownLoginTimer
        {
            get { return shutdownLoginTimer; }
            set
            {
                shutdownLoginTimer = value;
                RaisePropertyChanged(nameof(ShutdownLoginTimer));
            }
        }

        private string currentDateTime;

        public string CurrentDateTime
        {
            get { return currentDateTime; }
            set
            {
                currentDateTime = value;
                RaisePropertyChanged(nameof(CurrentDateTime));
            }
        }

        private string error;

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                RaisePropertyChanged(nameof(Error));
            }
        }

        private string usernameTextboxToolTip;

        public string UsernameTextBoxToolTip
        {
            get { return usernameTextboxToolTip; }
            set
            {
                usernameTextboxToolTip = value;
                RaisePropertyChanged(nameof(UsernameTextBoxToolTip));
            }
        }

        #endregion get set

        public string this[string varName]
        {
            get
            {
                Error = null;

                if (varName == "Username")
                {
                    if (usernameFirstLoad)
                    {
                        usernameFirstLoad = false;
                        return string.Empty;
                    }

                    ValidateUsernameAndSetTooltip();
                    CheckForError();
                }

                return Error;
            }
        }

        #region Helpers

        public void ValidateUsernameAndSetTooltip()
        {
            if (Username == "" || Username.Length == 0)
            {
                HasErrorOnUsername = true;
                UsernameTextBoxToolTip = DtsMessageResource.CurrentResourceManager.GetString("ErrorUsernameIsEmpty");
            }
            else if (Username.Length < 3)
            {
                HasErrorOnUsername = true;
                UsernameTextBoxToolTip = DtsMessageResource.CurrentResourceManager.GetString("ErrorUsernameLessThan4");
            }
            else
            {
                HasErrorOnUsername = false;
                UsernameTextBoxToolTip = null;
            }
        }

        private void CheckForError()
        {
            if (HasErrorOnUsername || HasErrorOnPassword)
            {
                HasErrorOnValueChanged = true;
            }
            else
            {
                HasErrorOnValueChanged = false;
            }
        }

        #endregion Helpers
    }
}