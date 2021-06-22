using App5.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace App5
{
    class Child
    {
        public static List<Child> childs = new List<Child>();

        public int id { get; set; }
        public string fio { get; set; }
        public string birthdate { get; set; }
        public int sex { get; set; }

        public static void fill_childs()
        {
            var user = App.Database.GetItem(LoginPage.UserId);
            if(user.Child1 != null)
            {
                var child = user.Child1.Split();
                var sb = new StringBuilder();
                sb.Append(child[0]);
                sb.Append(" ");
                sb.Append(child[1]);
                sb.Append(" ");
                sb.Append(child[2]);
                childs.Add(new Child { id = 1, fio = sb.ToString(), birthdate = child[3], sex = Convert.ToInt32(child[4])});
            }
            if (user.Child2 != null)
            {
                var child = user.Child2.Split();
                var sb = new StringBuilder();
                sb.Append(child[0]);
                sb.Append(" ");
                sb.Append(child[1]);
                sb.Append(" ");
                sb.Append(child[2]);
                childs.Add(new Child { id = 2, fio = sb.ToString(), birthdate = child[3], sex = Convert.ToInt32(child[4]) });
            }
            if (user.Child3 != null)
            {
                var child = user.Child3.Split();
                var sb = new StringBuilder();
                sb.Append(child[0]);
                sb.Append(" ");
                sb.Append(child[1]);
                sb.Append(" ");
                sb.Append(child[2]);
                childs.Add(new Child { id = 3, fio = sb.ToString(), birthdate = child[3], sex = Convert.ToInt32(child[4]) });
            }
            if (user.Child4 != null)
            {
                var child = user.Child4.Split();
                var sb = new StringBuilder();
                sb.Append(child[0]);
                sb.Append(" ");
                sb.Append(child[1]);
                sb.Append(" ");
                sb.Append(child[2]);
                childs.Add(new Child { id = 4, fio = sb.ToString(), birthdate = child[3], sex = Convert.ToInt32(child[4]) });
            }
            if (user.Child5 != null)
            {
                var child = user.Child5.Split();
                var sb = new StringBuilder();
                sb.Append(child[0]);
                sb.Append(" ");
                sb.Append(child[1]);
                sb.Append(" ");
                sb.Append(child[2]);
                childs.Add(new Child { id = 5, fio = sb.ToString(), birthdate = child[3], sex = Convert.ToInt32(child[4]) });
            }
        }

    }
}
