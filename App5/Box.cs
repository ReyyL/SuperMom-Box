using App5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App5
{
    class Box
    {
        public static List<Box> boxes = new List<Box>()
        {
               new Box{id = 0, text = "Бокс для детей от 0-1 года", price = "1Р", amount = 1 },
               new Box{id = 1, text = "Бокс для детей от 1-2 года", price = "2Р", amount= 1 },
               new Box { id = 2, text = "Бокс для детей от 2-3 года", price = "3Р", amount = 1 },
               new Box { id = 3, text = "Бокс для детей от 3-4 года", price = "4Р", amount = 1 },
               new Box { id = 4, text = "Бокс для детей от 4-5 года", price = "5Р", amount = 1 },
               new Box { id = 5, text = "Бокс для детей от 5-6 года", price = "6Р", amount = 1 }
        };
        public int id { get; set; }
        public string text { get; set; }
        public string price { get; set; }

        public int amount { get; set; }

        public static List<Box> userBoxes = new List<Box>();
        public static string GetUserBoxPrice()
        {
            var result = 0;
            foreach (var elem in userBoxes)
            {
                result += Convert.ToInt32(elem.price.Substring(0, elem.price.Length - 1)) * elem.amount;
            }
            var sb = new StringBuilder();
            sb.Append(result);
            sb.Append("P");
            return sb.ToString();
        }
        public static void GetUserBoxes()
        {
            userBoxes = new List<Box>();
            if (App.Database.GetItem(LoginPage.UserId).Boxes != null)
            { 
                var boxes = App.Database.GetItem(LoginPage.UserId).Boxes.Split();
            
                if (boxes != null && boxes[0]!="")
                {
                    foreach (var elem in boxes)
                    {
                        var boxnum = Convert.ToInt32(elem) - 1;
                        var flag = true;
                        for (int i = 0; i < userBoxes.Count; i++)
                        {
                            if (userBoxes[i].id == boxnum)
                            {
                                userBoxes[i].amount += 1;
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            if (boxnum == 0)
                                userBoxes.Add(new Box { id = 0, text = "Бокс для детей от 0-1 года", price = "1Р", amount = 1 });
                            else if (boxnum == 1)
                                userBoxes.Add(new Box { id = 1, text = "Бокс для детей от 1-2 года", price = "2Р", amount = 1 });
                            else if (boxnum == 2)
                                userBoxes.Add(new Box { id = 2, text = "Бокс для детей от 2-3 года", price = "3Р", amount = 1 });
                            else if (boxnum == 3)
                                userBoxes.Add(new Box { id = 3, text = "Бокс для детей от 3-4 года", price = "4Р", amount = 1 });
                            else if (boxnum == 4)
                                userBoxes.Add(new Box { id = 4, text = "Бокс для детей от 4-5 года", price = "5Р", amount = 1 });
                            else if (boxnum == 5)
                                userBoxes.Add(new Box { id = 5, text = "Бокс для детей от 5-6 года", price = "6Р", amount = 1 });
                        }
                    }
                }
            }
        }
    }
    
}
