using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace displayalerts.Reader
{
    internal class Readers
    {
        public static string EmailReader(string email)
        {
            var emailPattern = @"@";

            if (Regex.IsMatch(email, emailPattern))
            {
                return email;
            }
            else
                return $"{email} is not valid";
        }

        public static string NameReaderString(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
                return name;

            return name;
        }
        public static bool NameReaderBool(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
                return false;

            return true;
        }
        public static string PasswordReader(string password)
        {
            //var passwordPattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,15})";

            if (string.IsNullOrEmpty(string.Empty) || IsPasswordValid(password))
                return "not a valid input";

            return password;
        }

        private static bool IsPasswordValid(string password)
        {
            return password.Length >= 8 &&
                   password.Length <= 15 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsLetter) &&
                   (password.Any(char.IsSymbol) || password.Any(char.IsPunctuation));
        }
    }
}
