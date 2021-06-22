using System;
using System.Collections.Generic;
using System.Text;

namespace App5
{
    class Video
    {
        public static List<Video> webinars = new List<Video>()
        {
              new Video{id = 2, text = "Артем танцует после проекта на 100 баллов", source="https://www.youtube.com/embed/rkK-GUOV3BY" },
              new Video{id = 2, text = "???", source="https://www.youtube.com/embed/f4ZRK8YLmPc" }
        };
        public static List<Video> game_Videos = new List<Video>()
        {
              new Video{id = 1, text = "дот0ка", source="https://www.youtube.com/embed/0mNBLmuxnvg" },
              new Video{id = 1, text = "Димооооооон", source="https://www.youtube.com/embed/qrwlk7_GF9g" }
        };
        public int id { get; set; }
        public string text { get; set; }
        public string source { get; set; }

        public static void GetWebinars()
        {
            webinars = new List<Video>();
            if (App.Database.GetItem(1).Videos != null) {   
                var videos = App.Database.GetItem(1).Videos.Split('ↂ');
                if (videos != null && videos[0] != "")
                {
                    foreach (var elem in videos)
                    {
                        var video = elem.Split('~');
                        if (video[0] == "2")
                        {
                            webinars.Add(new Video { id = 2, text = video[1], source = video[2] });
                        }
                    }
                }
            }
        }
        public static void GetGameVideos()
        {
            game_Videos = new List<Video>();
            if (App.Database.GetItem(1).Videos != null) 
            { 
                var videos = App.Database.GetItem(1).Videos.Split('ↂ');
                if (videos != null && videos[0] != "")
                {
                    foreach (var elem in videos)
                    {
                        var video = elem.Split('~');
                        if (video[0] == "1")
                        {
                            game_Videos.Add(new Video { id = 1, text = video[1], source = video[2] });
                        }
                    }
                }
            }
        }
    }
}
