using displayalerts.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace displayalerts.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        public static bool FirstNameCorrect = false;
        public static bool LastNameCorrect = false;
        public static bool EmailCorrect = false;
        public static bool PhoneNumberCorrect = false;
        public static bool SSNCorrect = false;
        public static bool PassWordCorrect = false;


        #region private properties

        private string _userFirstName;
        private string _userLastName;
        private string _userEmail;
        private string _userPhoneNumber;
        private string _userSSN;
        private string _userPassword;

        #endregion

        #region public properties
        public string UserFirstName
        {
            get
            {
                return _userFirstName;
            }
            set
            {
                _userFirstName = value;
            }
        }
        public string UserLastName
        {
            get
            {
                return _userLastName;
            }
            set
            {
                _userLastName = value;
            }
        }

        public string UserEmail
        {
            get
            {
                return _userEmail;
            }
            set
            {
                _userEmail = value;
            }
        }

        public string UserPhoneNumber
        {
            get
            {
                return _userPhoneNumber;
            }
            set
            {
                _userPhoneNumber = value;
            }
        }

        public string UserSSN
        {
            get
            {
                return _userSSN;
            }
            set
            {
                _userSSN = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return _userPassword;
            }
            set
            {
                _userPassword = value;
            }
        }

        #endregion

        private async void SignUp_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void ForgotPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

        private async void AlreadySignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void RegisterButton_Pressed(object sender, EventArgs e)
        {
            bool Completeregistration = FirstNameCorrect 
                                        && LastNameCorrect 
                                        && EmailCorrect 
                                        && PhoneNumberCorrect 
                                        && SSNCorrect && PassWordCorrect;

            if (Completeregistration)
            {
                var user = new User();
                var userList = new UserList();

                user.FirstName = _userFirstName;
                user.LastName = _userLastName;
                user.Email = _userEmail;
                user.Password = _userPassword;
                user.Ssn = (long)Convert.ToDouble(_userSSN);
                user.Phonenumber = (long)Convert.ToDouble(_userPhoneNumber);
                user.UserTypeId = 1;
                user.Id = 1;

                userList.users.Add(user);

                await Navigation.PushAsync(new UserAdded());
            }

        }

 
    }


}