using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginRegister.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [assembly: Dependency(typeof(MyDemo.Droid.CustomRenderers.Statusbar))]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            recoverhere.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Task", "youclicked on me", "ok");
                })
            });

            signupLable.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    gettingToRegisterScreen();
                })
            });


        }


        private void LoginButtonClicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await this.DisplayAlert("Error", "Enter the UserName", "Cancle");
            });

        }


        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Register());
        }

        private async void gettingToRegisterScreen()
        {
            await this.Navigation.PushAsync(new Register());
        }
    }
}