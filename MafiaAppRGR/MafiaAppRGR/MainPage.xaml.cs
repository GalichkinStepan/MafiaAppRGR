using System;
using Xamarin.Forms;


namespace MafiaAppRGR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToInitPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InitPage());
        }
    }
}
