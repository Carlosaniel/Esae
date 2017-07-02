using System;

using Xamarin.Forms;

namespace App1
{
    public class Login : ContentPage
    {
        public Login()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

