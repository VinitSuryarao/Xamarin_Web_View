using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Web_View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "http://" + entryURL.Text;
        }

        private void Check_Internet_Clicked(object sender, EventArgs e)
        {
            if(CrossConnectivity.Current.IsConnected)
            {
                DisplayAlert("Message", "Internet Connected", "Ok");
            }
            else
            {
                DisplayAlert("Message", "Internet Disconnected", "Ok");
            }
        }

        private void Browser_Navigated(object sender, EventArgs e)
        {
            ProgressBar.IsVisible = false;
            ProgressBar.IsRunning = false;
        }

        private void Browser_Navigating(object sender, EventArgs e)
        {
            ProgressBar.IsVisible = true;
            ProgressBar.IsRunning = true;
        }
    }
}
