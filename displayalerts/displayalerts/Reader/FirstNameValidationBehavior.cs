using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace displayalerts.Reader
{
    internal class FirstNameValidationBehavior : Behavior<Entry>
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
            string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";


            if (Regex.IsMatch(userInput, namePattern))
            {
                userEntry.BackgroundColor = Color.GreenYellow;
                SignUpPage.FirstNameCorrect = true;
                signUpService.UserFirstName = userInput;
            }
            else
            {
                userEntry.BackgroundColor = Color.PaleVioletRed;
                SignUpPage.FirstNameCorrect = false;
            }
        }
    }
}
