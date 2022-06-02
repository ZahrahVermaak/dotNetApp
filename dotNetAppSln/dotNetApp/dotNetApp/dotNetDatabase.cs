using System;
using System.Collections.Generic;
using System.Text;
using dotNetApp.Models;
using SQLite;


namespace dotNetApp
{
    public class dotNetDatabase
    {
        private SQLiteConnection _database;

        public static dotNetDatabase Instance = new dotNetDatabase();

        public dotNetDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            path = path + "orders.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<OrderItem>();
        }

        public List<OrderItem> GetOrders()
        {
            return _database.Table<OrderItem>().OrderByDescending(x => x.OrderDate).ToList();
        }

        public void SavedOrder(OrderItem order)
        {
            _database.Insert(order);
        }
            


       




    }
}
