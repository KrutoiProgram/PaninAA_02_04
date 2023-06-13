using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PaninAA_02_04
{
    public partial class MainPage :ContentPage
    {
        public MainPage ()
        {
            InitializeComponent();   
            if(Preferences.ContainsKey("Login")&&Preferences.ContainsKey("Password"))
            {
                Navigation.PushModalAsync(new CalculatorPage());
            }
        }

        private void Click_RegButton (object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Login_Entry.Text) && !string.IsNullOrWhiteSpace(Password_Entry.Text))
            {
                Preferences.Set("Login",Login_Entry.Text);
                Preferences.Set("Password", Password_Entry.Text);
                Navigation.PushModalAsync(new CalculatorPage());
            }
            else
            {
                DisplayAlert("Ошибка ввода", "Логин и пароль не могут быть пустыми", "OK");
            }
        }
    }
}
