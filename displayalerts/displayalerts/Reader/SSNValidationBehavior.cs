using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace displayalerts.Reader
{
    internal class SSNValidationBehavior : Behavior<Entry>
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
            var socialSecurityNumber = "^[0-9]{10}$";

            if (Regex.IsMatch(userInput, socialSecurityNumber))
            {
                userEntry.BackgroundColor = Color.GreenYellow;
                SignUpPage.SSNCorrect = true;
                signUpService.UserSSN = userInput;
            }
            else
            {
                userEntry.BackgroundColor = Color.PaleVioletRed;
                SignUpPage.SSNCorrect = false;
            }
        }
    }
}
