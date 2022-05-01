using displayalerts.Reader;
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
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();


        }

        string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                HandleTextChanged();
            }
        }

        private void HandleTextChanged()
        {
            throw new NotImplementedException();
        }
        //public event EventHandler<string> EmailSent;
        //Readers reader = new Readers();
        //ForgotPassword forgotPassword = new ForgotPassword();

        private void ForgotPasswordEntry_Completed(object sender, EventArgs e)
        {
            emailLable.Text = $"Email has been sent to {emailEntry.Text}";
        }

        private void SendButton_Pressed(object sender, EventArgs e)
        {
            emailLable.Text = $"Email has been sent to {emailEntry.Text}";
        }

    }
}