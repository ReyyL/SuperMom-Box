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
    public partial class Content : ContentPage
    {
        public Content()
        {
            InitializeComponent();
        }

        public async void videoclick(object sender, EventArgs e)
        {
            var page = new video();
            await Navigation.PushAsync(page);
        }

        public async void webclick(object sender, EventArgs e)
        {
            var page = new web();
            await Navigation.PushAsync(page);
        }

        public async void taskclick(object sender, EventArgs e)
        {
            var page = new tasks();
            await Navigation.PushAsync(page);
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}