﻿using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace displayalerts.Reader
{
    internal class LastNameValidationBehavior : Behavior<Entry>
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
            string namePattern = "^[A-Za-z]{3,}";
            

            if (Regex.IsMatch(userInput, namePattern))
            {
                userEntry.TextColor = Color.Green;
                SignUpPage.LastNameCorrect = true;
                signUpService.UserLastName = userInput;
            }
            else
            {
                userEntry.TextColor = Color.Red;
                SignUpPage.LastNameCorrect = false;
            }
        }
    }
}
