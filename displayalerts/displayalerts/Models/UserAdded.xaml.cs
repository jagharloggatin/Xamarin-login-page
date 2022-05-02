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
    public partial class UserAdded : ContentPage
    {
        public UserAdded()
        {
            InitializeComponent();
        }

        protected void OnAppearing()
        {
            UserList userList = new UserList();

            foreach (var item in userList.users)
            {
                label1.Text = item.FirstName;
                label2.Text = item.LastName;
                label3.Text = item.Phonenumber.ToString();
            }

        }
    }

 
}