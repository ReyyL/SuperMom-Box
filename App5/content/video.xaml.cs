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
    public partial class video : ContentPage
    {
        public HtmlWebViewSource VideoSource { get; set; }
        public video()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Video.GetGameVideos();
            var videos = Video.game_Videos;
            var button = new Button { ImageSource = "addvideo.png", Scale = 0.7, VerticalOptions = LayoutOptions.StartAndExpand ,Margin = new Thickness(0, 0, 0, 0), BackgroundColor = Color.Transparent };
            button.Clicked += (sender, args) =>
            {
                var page = new AddVideoPage(1);
                this.Navigation.PushAsync(page);
            };

            if (videos != null && videos.Count != 0)
            {
                var layout = new StackLayout { Orientation = StackOrientation.Vertical };
                foreach (var elem in videos)
                {
                    var label = new Label
                    {
                        Text = elem.text,
                        TextColor = Color.Black,
                        FontSize = 20,
                        Margin = new Thickness(20, 20, 0, 20)
                    };
                    var delete = new Button { ImageSource = "delete.png", Scale = 0.8, BackgroundColor = Color.Transparent, Margin = new Thickness(0, -10, 20, 0) };
                    var frame = new Frame { BackgroundColor = Color.White, CornerRadius = 5, Margin = new Thickness(20)};
                    var seclayout = new StackLayout { };
                    WebView Video = new WebView { Source = elem.source, HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 250, Margin = new Thickness(15, 0, 15, 30) };
                    layout.Children.Add(frame);
                    frame.Content = seclayout;
                    seclayout.Children.Add(label);
                    seclayout.Children.Add(Video);
                    if (App.Database.GetItem(LoginPage.UserId).Email == "admin") seclayout.Children.Add(delete);
                    delete.Clicked += (sender, args) =>
                    {
                        DeleteVideo(elem.source);
                        layout.Children.Remove(frame);
                    };
                }
                if (App.Database.GetItem(LoginPage.UserId).Email == "admin") layout.Children.Add(button);
                var panGesture = new PanGestureRecognizer();
                panGesture.PanUpdated += (s, e) => {
                    this.Navigation.PopAsync();
                };

                layout.GestureRecognizers.Add(panGesture);
                var scrollView = new ScrollView { Content = layout };
                this.Content = scrollView;
            }
            else
            {
                var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                
                if (App.Database.GetItem(LoginPage.UserId).Email == "admin") layout.Children.Add(button);
                var panGesture = new PanGestureRecognizer();
                panGesture.PanUpdated += (s, e) => {
                    this.Navigation.PopAsync();
                };

                layout.GestureRecognizers.Add(panGesture);
                this.Content = layout;
            }
            
        }
        public void DeleteVideo(string source)
        {
            var new_vids = new List<Video>();
            foreach(var elem in Video.game_Videos)
            {
                if (elem.source != source)
                {
                    new_vids.Add(elem);
                }
            }
            foreach (var elem in Video.webinars)
            {
                new_vids.Add(elem);
            }
            var user = App.Database.GetItem(1);
            var sb = new StringBuilder();
            foreach(var elem in new_vids)
            {
                sb.Append('ↂ');
                sb.Append(elem.id);
                sb.Append('~');
                sb.Append(elem.text);
                sb.Append('~');
                sb.Append(elem.source);
            }
            user.Videos = sb.ToString().Trim('ↂ');
            App.Database.SaveItem(user);
        }
    }
}