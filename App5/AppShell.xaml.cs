using App5.ViewModels;
using App5.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App5
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Image image = new Image();
            image.Source = "profile.png";
            
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new BasketPage());
        }

    }
}
