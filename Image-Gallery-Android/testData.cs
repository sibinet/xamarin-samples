using System;
using System.Collections.Generic;
namespace pagetest
{
	public class testData
	{
		public static List<Post> getData ()
		{
			Post newpost;
			List<Post> listData=new List<Post>();

			newpost = new Post ();
			newpost.title = "Image 1";
			newpost.description = "Image 1 description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/1/";
			listData.Add (newpost);

			newpost = new Post ();
			newpost.title = "Image 2";
			newpost.description = "Image 2 description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/2/";
			listData.Add (newpost);

			newpost = new Post ();
			newpost.title = "Image 3";
			newpost.description = "Image 3 description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/3/";
			listData.Add (newpost);

			newpost = new Post ();
			newpost.title = "Image 4";
			newpost.description = "Image 4 description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/5/";
			listData.Add (newpost);


			newpost = new Post ();
			newpost.title = "Image 5";
			newpost.description = "Image 5 decription";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/6/";
			listData.Add (newpost);


			newpost = new Post ();
			newpost.title = "Image 6";
			newpost.description = "Image description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/7/";
			listData.Add (newpost);


			newpost = new Post ();
			newpost.title = "Image 7";
			newpost.description = "Image description";
			newpost.ImageURL = "http://lorempixel.com/400/200/sports/8/";
			listData.Add (newpost);
			return listData;
		}
	}
}

