using App5.Models;
using App5.ViewModels;
using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        private void Registr(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistrPage();
        }
    }
}