using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildList : ContentPage
    {
        public ChildList()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();           
            Child.fill_childs();
            var layout = new StackLayout { Margin = new Thickness(20,30,20,0) };
            foreach (var elem in Child.childs)
            {
                if (elem != null)
                {
                    var frame = new Frame { CornerRadius = 6, BackgroundColor = Color.White, Margin = new Thickness(0, 0, 0, 20) };
                    layout.Children.Add(frame);
                    var seclayout = new StackLayout { Orientation = StackOrientation.Vertical };
                    frame.Content = seclayout;
                    var label = new Label { Text = elem.fio, TextColor = Color.Black, FontSize = 20, FontAttributes = FontAttributes.Bold };
                    seclayout.Children.Add(label);
                    var thlayout = new StackLayout { Orientation = StackOrientation.Horizontal };
                    seclayout.Children.Add(thlayout);
                    var image = new Image { Source = "photo.png", Margin = new Thickness(15, 20, 15, 0), BackgroundColor = Color.Transparent,  };
                    thlayout.Children.Add(image);
                    var fourlayout = new StackLayout { Orientation = StackOrientation.Vertical };
                    thlayout.Children.Add(fourlayout);
                    var label2 = new Label { Text = elem.sex == 1 ? "Мужской" : "Женский", TextColor = Color.Black, FontSize = 16, Margin = new Thickness(20, 20, 0, 0) };
                    var fiflayout = new StackLayout { Orientation = StackOrientation.Vertical, HorizontalOptions = LayoutOptions.End, Margin = new Thickness(0, -80, 0, 0) };
                    var label3 = new Label { Text = GetAge(elem.birthdate), TextColor = Color.Black, FontSize = 13, Margin = new Thickness(20, 20, 0, -50) };
                    var edit = new Button { ImageSource = "aedit.png", BackgroundColor = Color.Transparent, Margin = new Thickness(80, -30, -20, 40), Scale = 0.7 };
                    //var button = new Button { ImageSource = "delete.png", Scale = 0.8, BackgroundColor = Color.Transparent, Margin = new Thickness(0, -10, 20, 0) };
                    var button = new Label { Text = "Удалить", HorizontalOptions = LayoutOptions.CenterAndExpand, Margin = new Thickness(0, -10, 0, -10), FontSize = 13, TextColor = Color.Black };
                    var gest = new TapGestureRecognizer();
                    var frame2 = new Frame { Content = button, BorderColor=Color.Black, BackgroundColor = Color.White, WidthRequest = 120, Margin = new Thickness(0, 15, 10, 0), CornerRadius = 5, HorizontalOptions = LayoutOptions.CenterAndExpand };
                    var switchbutton = new Button { ImageSource = GetImage(GetAge_Only_Year(elem.birthdate)), BackgroundColor = Color.Transparent, Scale = 0.8, Margin = new Thickness(0, -10, 0, -10) };
                    frame2.GestureRecognizers.Add(gest);
                    edit.Clicked += (sender, args) =>
                    {
                        var page = new EditChild(elem.id);
                        Navigation.PushAsync(page);
                    };
                    switchbutton.Clicked += (sender, args) =>
                    {
                        var page = GetPageForChild(GetAge_Only_Year(elem.birthdate));
                        Navigation.PushAsync(page);
                    };
                    fourlayout.Children.Add(label2);
                    fourlayout.Children.Add(label3);
                    seclayout.Children.Add(fiflayout);
                    fiflayout.Children.Add(edit);
                    fiflayout.Children.Add(frame2);
                    seclayout.Children.Add(switchbutton);
                    gest.Tapped += (sender, args) =>
                    {
                        layout.Children.Remove(frame);
                        DeleteChild(elem.id);
                    };
                }
            }
            var button1 = new Button { 
                ImageSource = "aaddchild.png", 
                BackgroundColor = Color.Transparent,  
                Scale = 0.6, 
                Margin = new Thickness(-70, 0, -70, 0), 
                HorizontalOptions = LayoutOptions.Center
                };
            button1.Clicked += (sender, args) =>
            {
                AddChild();
            };
            layout.Children.Add(button1);
           
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += (s, e) => {
                this.Navigation.PopAsync();
            };
            
            layout.GestureRecognizers.Add(panGesture); 
            var scrollView = new ScrollView { Content = layout };
            scrollView.GestureRecognizers.Add(panGesture);
            this.Content = scrollView;
        }
        public string GetAge(string Birthdate)
        {
            int day, month, year;
            if (Birthdate.Contains('.'))
            {
                var birthDate = Birthdate.Split('.');
                var currDate = DateTime.Today.ToString("d").Split('.');
                month = Convert.ToInt32(currDate[1]) - Convert.ToInt32(birthDate[1]);
                 day = Convert.ToInt32(currDate[0]) - Convert.ToInt32(birthDate[0]);
                 year = Convert.ToInt32(currDate[2]) - Convert.ToInt32(birthDate[2]);
            }
            else 
            { 
                var birthDate = Birthdate.Split('/');
                var currDate = DateTime.Today.ToString("d").Split('/');
                 month = Convert.ToInt32(currDate[0]) - Convert.ToInt32(birthDate[0]);
                 day = Convert.ToInt32(currDate[1]) - Convert.ToInt32(birthDate[1]);
                 year = Convert.ToInt32(currDate[2]) - Convert.ToInt32(birthDate[2]);
            }
            if (day < 0) month -= 1;
            if (month < 0)
            {
                year -= 1;
                month += 12;
            }
            var sb = new StringBuilder();
            if (year > 0) 
            {
                sb.Append(year.ToString());
                if (year > 4)
                    sb.Append(" лет");
                else if (year % 10 == 1)
                    sb.Append(" год");
                else 
                    sb.Append(" года");
            }
            sb.Append(" ");
            sb.Append(month.ToString());
            if (month > 4 || month == 0)
                sb.Append(" месяцев");
            else if (month == 1)
                sb.Append(" месяц");
            else
                sb.Append(" месяца");
            return sb.ToString();
        }

        public int GetAge_Only_Year(string Birthdate)
        {
            int day, month, year;
            if (Birthdate.Contains('.'))
            {
                var birthDate = Birthdate.Split('.');
                var currDate = DateTime.Today.ToString("d").Split('.');
                month = Convert.ToInt32(currDate[1]) - Convert.ToInt32(birthDate[1]);
                day = Convert.ToInt32(currDate[0]) - Convert.ToInt32(birthDate[0]);
                year = Convert.ToInt32(currDate[2]) - Convert.ToInt32(birthDate[2]);
            }
            else
            {
                var birthDate = Birthdate.Split('/');
                var currDate = DateTime.Today.ToString("d").Split('/');
                month = Convert.ToInt32(currDate[0]) - Convert.ToInt32(birthDate[0]);
                day = Convert.ToInt32(currDate[1]) - Convert.ToInt32(birthDate[1]);
                year = Convert.ToInt32(currDate[2]) - Convert.ToInt32(birthDate[2]);
            }
            if (day < 0) month -= 1;
            if (month < 0)
            {
                year -= 1;
                month += 12;
            }
           
            return year;
        }

        public static Page GetPageForChild(int year)
        {
            Box.GetUserBoxes();
            if( year == 0)
            {               
                foreach(var elem in Box.userBoxes)
                {
                    if (elem.id == 0) return new boxgames1();
                }
                return new more1();
            }
            else if (year == 1)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 1) return new boxgames2();
                }
                return new more2();
            }
            else if (year == 2)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 2) return new boxgames3();
                }
                return new more3();
            }
            else if (year == 3)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 3) return new boxgames4();
                }
                return new more4();
            }
            else if (year == 4)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 4) return new boxgames5();
                }
                return new more5();
            }
            else if (year == 5)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 5) return new boxgames6();
                }
                return new more6();
            }
            return new CatalogPage();
        }

        public static string GetImage(int year)
        {
            Box.GetUserBoxes();
            if (year == 0)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 0) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            else if (year == 1)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 1) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            else if (year == 2)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 2) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            else if (year == 3)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 3) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            else if (year == 4)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 4) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            else if (year == 5)
            {
                foreach (var elem in Box.userBoxes)
                {
                    if (elem.id == 5) return "aboxgames.png";
                }
                return "abuybox.png";
            }
            return "abuybox.png";
        }
        public void DeleteChild(int id)
        {
            if (id == 1)
            {
                var user = App.Database.GetItem(LoginPage.UserId);
                user.Child1 = null;
                App.Database.SaveItem(user);
            }
            if (id == 2)
            {
                var user = App.Database.GetItem(LoginPage.UserId);
                user.Child2 = null;
                App.Database.SaveItem(user);
            }
            if (id == 3)
            {
                var user = App.Database.GetItem(LoginPage.UserId);
                user.Child3 = null;
                App.Database.SaveItem(user);
            }
            if (id == 4)
            {
                var user = App.Database.GetItem(LoginPage.UserId);
                user.Child4 = null;
                App.Database.SaveItem(user);
            }
            if (id == 5)
            {
                var user = App.Database.GetItem(LoginPage.UserId);
                user.Child5 = null;
                App.Database.SaveItem(user);
            }
        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.Navigation.PushAsync(new ProfilePage());
        }
        private async void AddChild()
        {
            var page = new AddChild();
            await Navigation.PushAsync(page);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Child.childs = new List<Child>();
        }
    }/*<StackLayout Margin="20,20,20,0">
            <Frame CornerRadius="6"  BackgroundColor="White">
                <StackLayout Orientation="Vertical">
                    <Label Text="adsdasdadasdasdadssd"
                           TextColor="Black"
                           FontSize="20"
                           FontAttributes="Bold"/>
                    <StackLayout Orientation="Horizontal">
                        <Image Source="photo.png" Margin="0,20,0,0" BackgroundColor="Silver"/>
                        <Label Text="Мужской" TextColor="Black" FontSize="16" Margin="20,20,0,0"/>
                        <Button ImageSource="edit.png" BackgroundColor="Transparent" Margin="20,0,0,30" Scale="1.2"/>
                    </StackLayout>
                </StackLayout>
            </Frame>
        </StackLayout>*/
}