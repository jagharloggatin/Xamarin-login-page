using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using displayalerts.Models;

namespace displayalerts.Reader
{
    internal class EmailValidationBehaviour : Behavior<Entry>
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
            var emailPattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}$";
            var userEntry = sender as Entry;

            if (Regex.IsMatch(userInput, emailPattern))
            {
                userEntry.TextColor = Color.Green;
                SignUpPage.EmailCorrect = true;
                signUpService.UserEmail = userInput;
            }
            else
            {
                userEntry.TextColor = Color.Red;
                SignUpPage.EmailCorrect = false;

            }
        }
    }
}
