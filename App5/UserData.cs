using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SQLite;

namespace App5
{
    public class UserData
    {
        SQLiteConnection database;
        static object locker = new object();

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
        public UserData(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
        }
        public IEnumerable<User> GetItems()
        {
            return database.Table<User>().ToList();
        }
        public User GetItem(int id)
        {
            //if (database.Get<User>(id) != null)
                return database.Get<User>(id);
            //return 0;
        }
        public int SaveItem(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}