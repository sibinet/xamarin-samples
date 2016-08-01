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
	public class CusotmListAdapter : BaseAdapter<Post>
	{
		Activity context;
		List<Post> list;

		public CusotmListAdapter (Activity _context, List<Post> _list)
			:base()
		{
			this.context = _context;
			this.list = _list;
		}

		public override int Count {
			get { return list.Count; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Post this[int index] {
			get { return list [index]; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView; 

			// re-use an existing view, if one is available
			// otherwise create a new one
			if (view == null)
				view = context.LayoutInflater.Inflate (Resource.Layout.MyListView, parent, false);

			Post item = this [position];
			view.FindViewById<TextView> (Resource.Id.Title).Text = item.title;
			view.FindViewById<TextView>(Resource.Id.Description).Text = item.description;
			ImageView imageView = view.FindViewById<ImageView> (Resource.Id.Thumbnail);
			var imageBitmap = Handler.GetImageBitmapFromUrl(item.ImageURL);
			imageView.SetImageBitmap (imageBitmap);
			//using (var imageView = view.FindViewById<ImageView> (Resource.Id.Thumbnail)) {
			//string url = Android.Text.Html.FromHtml (item.thumbnail).ToString ();

			//Download and display image
			//Koush.UrlImageViewHelper.SetUrlDrawable (imageView, 
			//	url, Resource.Drawable.Placeholder);
			//}
			return view;
		}
	}

}
