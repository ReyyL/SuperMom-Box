using App5.Models;
using App5.ViewModels;
using App5.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage : ContentPage
    {


        public BasketPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Box.GetUserBoxes();
            var label1 = new Label { Text = "Итого: ", TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 30 };
            if (Box.userBoxes != null && Box.userBoxes.Count!=0) 
            {
                var grid = new Grid {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition { Height = GridLength.Auto }
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }
                };
                
                var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = new Thickness(0, 0, 0, 50) };
                
                var price = new Label { Text = Box.GetUserBoxPrice(), TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 30 };
                for (int i = 0; i < 6; i++)
                {
                    Box box = new Box { id = -1 };
                    foreach (var elem in Box.userBoxes)
                    {
                        if (elem.id == i)
                        {
                            box = elem;
                        }
                    }
                    if (box.id != -1)
                    {
                        var seclayout = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(30, 30, 30, 10), HorizontalOptions = LayoutOptions.Center };
                        layout.Children.Add(seclayout);
                        //var frame = new Frame { BackgroundColor = Color.White, CornerRadius = 4, Margin = new Thickness(20)};
                        //Впихни сюда отображение количества плез, а то я хз как)
                        var image = new Image { Source = GetBoxImage(box.id), Scale = 0.65, Margin = new Thickness(-40, -32, -40, -40) };
                        seclayout.Children.Add(image);
                        var thlayout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = new Thickness(-5, 0, 0, 0) };
                        
                        seclayout.Children.Add(thlayout);
                        var label = new Label
                        {
                            Text = box.text,
                            TextColor = Color.Black,
                            FontSize = 16,
                            Margin = new Thickness(30, 10, 20, 0)
                        };
                        var label2 = new Label
                        {
                            Text = box.price,
                            TextColor = Color.Black,
                            FontSize = 20,
                            Margin = new Thickness(30, 0, 20, 0),
                            FontAttributes = FontAttributes.Bold
                        };
                        
                        var label3 = new Label
                        {
                            Text = "Количество: " + box.amount.ToString(),
                            TextColor = Color.Black,
                            FontSize = 15,
                            Margin = new Thickness(30, 0, 0, 8),
                            FontAttributes = FontAttributes.Bold
                        };
                        //var button = new Button { ImageSource = "deletebox.png", BackgroundColor = Color.Transparent ,Scale = 0.5, Margin = new Thickness(-30, 0, 0, 0) };
                        
                        var delete = new Label { Text = "Удалить бокс", Margin = new Thickness(0, -8, 0, -8), FontSize = 13, HorizontalOptions = LayoutOptions.CenterAndExpand, TextColor = Color.Black};
                        //var fourlay = new StackLayout { };
                        var frame2 = new Frame {Content = delete, BackgroundColor = Color.White, WidthRequest=120, Margin = new Thickness(30, 0, 0, 0), CornerRadius = 5};
                        //fourlay.Children.Add(delete);
                        
                        var button = new TapGestureRecognizer();
                        frame2.GestureRecognizers.Add(button);
                        thlayout.Children.Add(label);
                        thlayout.Children.Add(label2);
                        thlayout.Children.Add(label3);
                        thlayout.Children.Add(frame2);
                        //thlayout.Children.Add(button123);
                        button.Tapped += (sender, args) =>
                        {   if (box.amount == 1)
                            {
                                layout.Children.Remove(seclayout);
                            }
                            DeleteElem(box.id + 1);
                            label3.Text = "Количество: " + box.amount.ToString();
                            price.Text = Box.GetUserBoxPrice();
                            
                            if (!(Box.userBoxes != null && Box.userBoxes.Count != 0))
                            {
                                /* layout.Children.Remove(seclayout);
                                 layout.Children.Remove(label1);
                                 layout.Children.Add(new Image { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Source = "empty.png", Scale = 0.75, Margin = new Thickness(-30, 0, 0, 0) });
                                 this.Content = layout;*/
                                layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                                layout.Children.Add(new Image {  Source = "empty.png", Scale = 0.75, Margin = new Thickness(-30, 0, 0, 0) });
                                this.Content = layout;
                            }
                        };
                        
                    }
                    /*if (price.Text.Equals(0))
                    {
                        var layout1 = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                        var image1 = new Image { Source = "empty.png", Scale = 0.75, Margin = new Thickness(-30, 0, 0, 0) };
                        layout1.Children.Add(image1);
                        this.Content = layout;
                    }*/
                }
                var finlayout1 = new StackLayout {Orientation = StackOrientation.Horizontal, Margin = new Thickness(55,40,0,0), HorizontalOptions = LayoutOptions.Start};
                var finlayout2 = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(0, -45, 55, 70), HorizontalOptions = LayoutOptions.End };
                label1 = new Label { Text = "Итого: ", TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 30, Margin = new Thickness(0, 0, 0, 0) };
                var panGesture = new PanGestureRecognizer();
                panGesture.PanUpdated += (s, e) => {
                    this.Navigation.PopAsync();
                };

                layout.GestureRecognizers.Add(panGesture);
                finlayout1.Children.Add(label1);
                finlayout2.Children.Add(price);
                layout.Children.Add(finlayout1);
                layout.Children.Add(finlayout2);
                var scrollView = new ScrollView { Content = layout };
                grid.Children.Add(scrollView);
                Grid.SetColumnSpan(scrollView, 2);
                var text = new Label { Text = "Оформить заказ", FontSize = 23, Margin = new Thickness(0, -10, 0, -10), TextColor = Color.White, HorizontalOptions = LayoutOptions.CenterAndExpand, FontAttributes = FontAttributes.Bold };
                var frame3 = new Frame {Content=text, BackgroundColor = Color.FromHex("#FED22B"), Margin = new Thickness(25, -50, 25, 20), CornerRadius = 7, HorizontalOptions = LayoutOptions.FillAndExpand };
                grid.Children.Add(frame3, 0, 1);
                Grid.SetColumnSpan(frame3, 2);
                //<Button ImageSource="aapply.png" Clicked="Apply" BackgroundColor="Transparent" Margin="0,-60,0,0" Grid.Row="1"
                //Grid.ColumnSpan = "2" ></ Button >
                    this.Content = grid;
            }
            else
            {
                var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center};
                var image = new Image {Source = "empty.png", Scale = 0.75, Margin = new Thickness(-30,0,0,0) };
                layout.Children.Add(image);
                var panGesture = new PanGestureRecognizer();
                panGesture.PanUpdated += (s, e) => {
                    this.Navigation.PopAsync();
                };

                layout.GestureRecognizers.Add(panGesture);
                this.Content = layout;
            }
        }
        public void DeleteElem(int id)
        {
            var user = App.Database.GetItem(LoginPage.UserId);
            var boxes = user.Boxes.Split().ToList();
            boxes.Remove(id.ToString());
            user.Boxes = string.Join(" ", boxes);
            Box newBox = new Box();
            var flag = false;
            foreach(var elem in Box.userBoxes)
            {
                if(elem.id == id - 1)
                {
                    newBox = elem;
                    flag = true;
                }
            }
            if (flag)
            {
                Box.userBoxes.Remove(newBox);
                if (newBox.amount != 1)
                {
                    newBox.amount -= 1;
                    Box.userBoxes.Add(newBox);
                }
            }
            App.Database.SaveItem(user);
        }
        public string GetBoxImage(int id)
        {
            if (id == 0) return "azero.png";
            else if (id == 1) return "aone.png";
            else if (id == 2) return "atwo.png";
            else if (id == 3) return "athree.png";
            else if (id == 4) return "afour.png";
            else  return "afive.png";
        }
    }

}

