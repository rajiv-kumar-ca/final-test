using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace SQLite
{
    [Activity(Label = "SQLite", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btninsert;
        Button btnselect;
        Button btnupdate;
        Button btndelete;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            btninsert = FindViewById<Button>(Resource.Id.btninsert);
            btnselect = FindViewById<Button>(Resource.Id.btnselect);
            btnupdate = FindViewById<Button>(Resource.Id.btnupdate);
           

            CreateDB(); //Calling DB Creation method

            btninsert.Click += delegate { StartActivity(typeof(InsertActivity)); };
            btnselect.Click += delegate { StartActivity(typeof(SelectActivity)); };
           
            

        }
         public string CreateDB()
        {
            var output = "";
            output += "Creating Databse if it doesnt exists";
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "product.db3"); //Create New Database  
            var db = new SQLiteConnection(dpPath);
            output += "\n Database Created....";
            return output;
        }
    }
}

