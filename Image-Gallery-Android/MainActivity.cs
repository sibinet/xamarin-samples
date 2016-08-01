using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
namespace pagetest
{
	[Activity (Label = "pagetest", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
		CusotmListAdapter LstAdapter;
		List<Post> listData;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			listData = testData.getData ();

			LstAdapter=new CusotmListAdapter(this, listData);
			ListView listView = FindViewById<ListView> (Resource.Id.feedList);
			listView.ItemClick += OnListItemClick;
			listView.Adapter = LstAdapter;
		}
		void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e) {
	 
			Post item = listData [e.Position];
			var actdetails = new Intent (this, typeof(NewPage));
			actdetails.PutExtra ("Title", item.title);
			actdetails.PutExtra ("ImageURL", item.ImageURL);

			StartActivity (actdetails);
		}
	}
}


