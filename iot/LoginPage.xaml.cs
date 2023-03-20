using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var username = Preferences.Get("username", null);

            if (username != null)
            {
                Navigation.PushAsync(new MainPage());
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var username = usernameEditor.Text;
            var password = passwordEditor.Text;
            var mockData = new MockData();
            var user = mockData.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var newPage = new MainPage();
                await Navigation.PushAsync(newPage);

                usernameEditor.Text = "";
                passwordEditor.Text = "";

                Preferences.Set("username", username);
            }
            else
            {
                await DisplayAlert("Alert", "Username or password invalid.", "OK");
            }
        }
    }
}