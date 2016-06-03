using System;
using System.Net;
using System.IO;
using System.Xml;

namespace testXaDroid
{
	public class ColorHandler
	{
		public static  ColorPattern FetchColor ()
		{
			    Random randonGen = new Random ();

			     ColorPattern ReturnColorPattern = new ColorPattern ();
					
			     ReturnColorPattern.R = randonGen.Next (256);
			     ReturnColorPattern.G = randonGen.Next (256);
			     ReturnColorPattern.B = randonGen.Next (256);

                 return ReturnColorPattern;
		}
	}
	public class ColorPattern
	{
		public int R { get; set; }
		public int G { get; set; }
		public int B { get; set; }
	}
}

