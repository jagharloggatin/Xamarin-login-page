using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace displayalerts.Reader
{
    internal class PasswordValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += BindAbleOnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= BindAbleOnTextChanged;
        }

        private void BindAbleOnTextChanged(object sender, TextChangedEventArgs e)
        {
            var signUpService = new SignUpPage();
            var userInput = e.NewTextValue;
            var userEntry = sender as Entry;
            var passwordPattern = "^[a-zA-z0-9]{5,}[0-9]{1,}$";

            if (Regex.IsMatch(userInput, passwordPattern))
            {
                userEntry.BackgroundColor = Color.GreenYellow;
                SignUpPage.PassWordCorrect = true;
                signUpService.UserPassword = userInput;
            }
            else
            {
                userEntry.BackgroundColor = Color.PaleVioletRed;
                SignUpPage.PassWordCorrect = false;
            }
        }
    }
}
