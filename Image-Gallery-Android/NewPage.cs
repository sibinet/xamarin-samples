
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

namespace pagetest
{
	[Activity (Label = "NewPage")]			
	public class NewPage : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			this.Title = Intent.GetStringExtra("Title");
			ActionBar.SetDisplayHomeAsUpEnabled (true);
			ActionBar.SetDisplayShowHomeEnabled (true);
			ActionBar.SetIcon (Android.Resource.Color.Transparent);
			SetContentView (Resource.Layout.NewPage);
			var imageBitmap = Handler.GetImageBitmapFromUrl(Intent.GetStringExtra("ImageURL"));
			ImageView imgfull = FindViewById<ImageView> (Resource.Id.fullimg);
			imgfull.SetImageBitmap (imageBitmap);
			// Create your application here
		
		}
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
			case Android.Resource.Id.Home:
				this.Finish();
				return true;
			
			}         
			return base.OnOptionsItemSelected(item);
		}
	}
}

