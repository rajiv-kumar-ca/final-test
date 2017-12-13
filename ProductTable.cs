using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SQLite
{
    class ProductTable
    {

        [PrimaryKey, AutoIncrement, Column("_Id")]

        public int id { get; set; } // AutoIncrement and set primarykey  

        [MaxLength(25)]

        public string ProductName { get; set; }

        [MaxLength(25)]
        public string Price { get; set; }
        [MaxLength(25)]
        public string Quantity { get; set; }
       
    }
}