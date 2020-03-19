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
    public partial class Register : ContentPage
    {
        public Register()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        public void SignupButtonClicked(object sender, EventArgs e)
        {
            goingToNextPage();
            /*var username = SignupEntryUsername.Text;
            var password = SignupEntryPasword.Text;
            var email = SignupEntryPasword.Text;
            var phoneNumber = SignupEntryPhoneNumber.Text;

            if (username.Equals(""))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Enter the UserName", "Cancle");
                });
            }
            else if (password.Equals(""))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Enter the password", "Cancle");
                });
            }
            else if (email.Equals(""))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Enter the Email", "Cancle");
                });
            }
            else if (phoneNumber.Equals(""))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Enter the Phone number", "Cancle");
                });
            }
            else
            {
                goingToNextPage();
            }*/

        }

        private async void goingToNextPage()
        {
            await this.Navigation.PushAsync(new PhoneNumberVarification());
        }
    }
}