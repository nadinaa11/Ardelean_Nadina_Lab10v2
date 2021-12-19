using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ardelean_Nadina_Lab10v2.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}