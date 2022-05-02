using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace displayalerts.Reader
{
    internal class PhoneNumberValidationBehavior : Behavior<Entry>
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
            var phoneNumberPattern = "^[0]{1}[0-9]{9}";


            if (Regex.IsMatch(userInput, phoneNumberPattern))
            {
                userEntry.TextColor = Color.Green;
                SignUpPage.PhoneNumberCorrect = true;
                signUpService.UserPhoneNumber = userInput;
            }
            else
            {
                userEntry.TextColor = Color.Red;
                SignUpPage.PhoneNumberCorrect = false;
            }
        }
    }
}
