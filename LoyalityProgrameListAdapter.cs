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
using Java.Lang;

namespace SQLite
{
  
    public class LoyalityProgrameListAdapter : BaseAdapter
    {
        string[] items;
        int[] itemsicons;
        Activity context;
        public LoyalityProgrameListAdapter(Activity context, string[] items, int[] itemsicons) : base()
        {
            this.context = context;
            this.items = items;
            this.itemsicons = itemsicons;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
     
        public override int Count
        {
            get { return items.Length; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            var itemsicon = itemsicons[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.ChildListView, null);
           // view.FindViewById<ImageView>(Resource.Id.LoyalityImage).SetImageResource(itemsicon);
            view.FindViewById<TextView>(Resource.Id.LoyalityProgrameText).Text = item;
            return view;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return items[position];
           // throw new NotImplementedException();
        }
    }
}