using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace displayalerts.Models2
{
    internal class UserList 
    {
        public List<User> users = new List<User>();

        public void Add(User user)
        {
            users.Add(user);
        }
    }
}
