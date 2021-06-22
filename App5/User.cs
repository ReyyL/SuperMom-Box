using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App5
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Fio { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string BirthDate { get; set; }
        public int Sex { get; set; }
        public string ProfileImage { get; set; }
        public string Boxes { get; set; }
        public string Videos { get; set; }
        public int VipStatus { get; set; }
        public string Child1 { get; set; }
        public string Child2 { get; set; }
        public string Child3 { get; set; }
        public string Child4 { get; set; }
        public string Child5 { get; set; }
    }
}

