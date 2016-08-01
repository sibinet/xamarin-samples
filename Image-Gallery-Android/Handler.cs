using System;
using System.Drawing;
using Android.Graphics;
using System.Net;

namespace pagetest
{
	public class Handler
	{
		public static Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;
			try
			{
			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}
			}
			catch(Exception ex) {
				
			}
			return imageBitmap;
		}
	}
}

