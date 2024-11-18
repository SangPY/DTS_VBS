using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using dts_cashier.Cache;
using dts_cashier.Components.Base;
using dts_cashier.Helper.IViewHelper;
using dts_cashier.Model;
using dts_cashier.ViewModelMediator;
using System.Windows;
using dts_cashier.Properties;

namespace dts_cashier.Components.Login
{
    public class LoginWindowViewModel : AbstractViewModel
    {
        public LoginWindowViewModel(IView view) : base(view)
        {
            LoginModel = new LoginModel();
            Mediator.Instance.Register(this, Messages.LoginWindows);

            GetStationInformation();

            InitializeLanguages();
        }

        private async Task GetStationInformation()
        {
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            try
            {
                Version = "Nimbus v" + currentVersion;
            }
            catch
            {
                Version = DataCacheContext.Version;
            }
        }

        //private void ChangeLanguage(int selectedLanguage)
        //{
        //    Language = (App.LanguageType)selectedLanguage;
        //    DataCacheContext.LanguageSelected = Language.ToString();
        //    (Application.Current as App).ChangeLanguage();
        //}

        //public void ChangeLanguage()
        //{
        //    foreach (var dict in Resources.MergedDictionaries)
        //        if (dict is LanguageResources langDict)
        //        {
        //            langDict.UpdateSource();
        //            VbsMessageResource.SetMessageResource(Language);
        //            NimbusErrorMessageResource.SetMessageResource(Language);
        //        }
        //        else
        //        {
        //            dict.Source = dict.Source;
        //        }
        //}

        private void InitializeLanguages()
        {
            Languages = new ObservableCollection<LanguageModel>
            {
                new LanguageModel
                {
                    IconSource = @"pack://application:,,,/Resources/LanguageFlags/AmericanFlag.png",
                    IsSelected = true,
                    Name = "English (EN)",
                    Sequence = 0,
                    LanguageValue = (int)App.LanguageType.EnUS
                },
                /*new LanguageModel
                {
                    IconSource = @"pack://application:,,,/Resources/LanguageFlags/ThailandFlag.png",
                    IsSelected = false,
                    Name = "Thai (THA)",
                    Sequence = 1,
                    LanguageValue = (int)LanguageType.ThTHA
                },*/
                new LanguageModel
                {
                    IconSource = @"pack://application:,,,/Resources/LanguageFlags/VietnamFlag.png",
                    IsSelected = false,
                    Name = "Vietnamese (VN)",
                    Sequence = 1,
                    LanguageValue = (int)App.LanguageType.ViVN
                }/*,
                new LanguageModel
                {
                    IconSource = @"pack://application:,,,/Resources/LanguageFlags/IndonesiaFlag.png",
                    IsSelected = false,
                    Name = "BAHASA (IND)",
                    Sequence = 3,
                    LanguageValue = (int)LanguageType.IdIND
                }*/
            };
            Languages = new ObservableCollection<LanguageModel>(Languages.OrderBy(x => x.Sequence));
            SelectedLanguage = Languages.FirstOrDefault(x => x.Sequence == 0);
            //ChangeLanguage(SelectedLanguage.LanguageValue);
        }

        #region Properties

        private ObservableCollection<LanguageModel> languages;

        public ObservableCollection<LanguageModel> Languages
        {
            get => languages;
            set
            {
                languages = value;
                RaisePropertyChanged(nameof(Languages));
            }
        }

        private LanguageModel selectedLanguage;

        public LanguageModel SelectedLanguage
        {
            get => selectedLanguage;
            set
            {
                selectedLanguage = value;
                RaisePropertyChanged(nameof(SelectedLanguage));
            }
        }

        private LoginModel loginModel;

        public LoginModel LoginModel
        {
            get => loginModel;
            set
            {
                loginModel = value;
                RaisePropertyChanged(nameof(LoginModel));
            }
        }

        private string version;

        public string Version
        {
            get => version;
            set
            {
                version = value;
                RaisePropertyChanged(nameof(Version));
            }
        }

        #endregion Properties
    }
}