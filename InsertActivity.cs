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
using System.IO;

namespace SQLite
{
    [Activity(Label = "InsertActivity")]
    public class InsertActivity : Activity
    {
        Button btncreate;
        EditText txtPname;
        EditText txtPrice;
        EditText txtQauntity;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.Insert);
            txtPname = FindViewById<EditText>(Resource.Id.txtname);
            txtPrice = FindViewById<EditText>(Resource.Id.txtprice);
            txtQauntity = FindViewById<EditText>(Resource.Id.txtquantity);
           
            btncreate = FindViewById<Button>(Resource.Id.btnsave);
            btncreate.Click += Btncreate_Click;
        }
        private void Btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "product.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<ProductTable>();
                ProductTable tbl = new ProductTable();
                tbl.ProductName = txtPname.Text;
                tbl.Price = txtPrice.Text;
                tbl.Quantity = txtQauntity.Text;
               
                db.Insert(tbl);
               
                clear();
                Toast.MakeText(this, "Record Added Successfully...,", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
        void clear()
        {
            txtPname.Text = "";
            txtPrice.Text = "";
            txtQauntity.Text = "";
           
            
        }
    }
}