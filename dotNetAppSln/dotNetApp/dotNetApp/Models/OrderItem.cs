using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace dotNetApp.Models
{
    public class OrderItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public string tshirtsize { get; set; }

        public DateTime OrderDate { get; set; }

        public string tshirtcolor { get; set; }

        public string Address { get; set; }
    }
}
