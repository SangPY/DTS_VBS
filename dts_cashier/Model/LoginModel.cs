using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace dts_cashier.Model
{
    public class LoginModel : BaseModel
    {
        public LoginModel()
        {
            PasswordBorderBrush = Brushes.Transparent;
            ErrorList = new List<string>();
            PasswordKeyUp = false;
            ButtonIsEnabled = false;
            HasErrorOnValueChange = true;
            HasInputUsername = false;
        }

        #region Properties

        private bool usernameFirstLoad = true;
        private bool onFirstLoad = true;

        private bool buttonIsEnabled;

        public bool ButtonIsEnabled
        {
            get => buttonIsEnabled;
            set
            {
                buttonIsEnabled = value;
                RaisePropertyChanged(nameof(ButtonIsEnabled));
            }
        }

        private bool passwordKeyUp;

        public bool PasswordKeyUp
        {
            get => passwordKeyUp;
            set
            {
                passwordKeyUp = value;
                RaisePropertyChanged(nameof(PasswordKeyUp));
            }
        }

        private int passwordLength;

        public int PasswordLength
        {
            get => passwordLength;
            set
            {
                passwordLength = value;
                RaisePropertyChanged(nameof(PasswordLength));
            }
        }

        private bool hasInputUsername;

        public bool HasInputUsername
        {
            get => hasInputUsername;
            set
            {
                hasInputUsername = value;
                RaisePropertyChanged(nameof(HasInputUsername));
            }
        }

        private bool hasInputPassword;

        public bool HasInputPassword
        {
            get => hasInputPassword;
            set
            {
                hasInputPassword = value;
                RaisePropertyChanged(nameof(HasInputPassword));
            }
        }

        private string username;

        public string Username
        {
            get => username;
            set
            {
                username = value;
                RaisePropertyChanged(nameof(Username));
                if (string.IsNullOrEmpty(Username))
                    HasInputUsername = false;
                else
                    HasInputUsername = true;
            }
        }

        private string error;

        public string Error
        {
            get => error;
            set
            {
                error = value;
                RaisePropertyChanged(nameof(Error));
            }
        }

        private List<string> errorList;

        public List<string> ErrorList
        {
            get => errorList;
            set
            {
                errorList = value;
                RaisePropertyChanged(nameof(ErrorList));
            }
        }

        private bool isErrorMessageShown;

        public bool IsErrorMessageShown
        {
            get => isErrorMessageShown;
            set
            {
                isErrorMessageShown = value;
                RaisePropertyChanged(nameof(IsErrorMessageShown));
            }
        }

        private SolidColorBrush usernameBorderBrush;

        public SolidColorBrush UsernameBorderBrush
        {
            get => usernameBorderBrush;
            set
            {
                usernameBorderBrush = value;
                RaisePropertyChanged(nameof(UsernameBorderBrush));
            }
        }

        private SolidColorBrush passwordBorderBrush;

        public SolidColorBrush PasswordBorderBrush
        {
            get => passwordBorderBrush;
            set
            {
                passwordBorderBrush = value;
                RaisePropertyChanged(nameof(PasswordBorderBrush));
            }
        }

        private string passwordErrorMessage;

        public string PasswordErrorMessage
        {
            get => passwordErrorMessage;
            set
            {
                passwordErrorMessage = value;
                RaisePropertyChanged(nameof(PasswordErrorMessage));
            }
        }

        private string usernameErrorMessage;

        public string UsernameErrorMessage
        {
            get => usernameErrorMessage;
            set
            {
                usernameErrorMessage = value;
                RaisePropertyChanged(nameof(UsernameErrorMessage));
            }
        }

        private bool isUsernameInvalid;

        public bool IsUsernameInvalid
        {
            get => isUsernameInvalid;
            set
            {
                isUsernameInvalid = value;
                RaisePropertyChanged(nameof(IsUsernameInvalid));
            }
        }

        private bool isPasswordInvalid;

        public bool IsPasswordInvalid
        {
            get => isPasswordInvalid;
            set
            {
                isPasswordInvalid = value;
                RaisePropertyChanged(nameof(IsPasswordInvalid));
            }
        }

        private bool hasErrorOnValueChange;

        public bool HasErrorOnValueChange
        {
            get => hasErrorOnValueChange;
            set
            {
                hasErrorOnValueChange = value;
                RaisePropertyChanged(nameof(HasErrorOnValueChange));
            }
        }

        private string usernameAndPasswordErrorMessage;

        public string UsernameAndPasswordErrorMessage
        {
            get => usernameAndPasswordErrorMessage;
            set
            {
                usernameAndPasswordErrorMessage = value;
                RaisePropertyChanged(nameof(UsernameAndPasswordErrorMessage));
            }
        }

        private bool isUsernameAndPasswordInvalid;

        public bool IsUsernameAndPasswordInvalid
        {
            get => isUsernameAndPasswordInvalid;
            set
            {
                isUsernameAndPasswordInvalid = value;
                RaisePropertyChanged(nameof(IsUsernameAndPasswordInvalid));
            }
        }

        #endregion Properties
    }
}