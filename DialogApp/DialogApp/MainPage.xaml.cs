using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialogApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            string osloveni = osloveniEntry.Text;
            await DisplayAlert($"Ahoj {osloveni}!", "Vítej v první multiplatformní aplikaci.", "OK");
        }
        
    }
    
}
