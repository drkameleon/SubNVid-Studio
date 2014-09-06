/*
 * SubNVid Studio [ v0.1 ]
 * ------------------------------
 * Subtitle and Video Workshop
 * Created by Dr.Kameleon
 * 
 * **************************
 * File : Utilities.cs
 * **************************
 */
 
using System;
using System.Windows.Forms;
using System.Globalization;

namespace SNVS.Utilities
{
	public sealed class Utils
	{
		public static string selectInFile ( string DTitle, string DFilters )
		{ 
		   	OpenFileDialog dialog = new OpenFileDialog(); 
		   	dialog.Filter = DFilters;
		   	dialog.InitialDirectory = @"C:/"; 
		   	dialog.Title = DTitle; 
		   	return ( dialog.ShowDialog() == DialogResult.OK )
		      ? dialog.FileName : null;	
		}
			
		public static string selectOutFile ( string DTitle, string DFilters )
		{ 
		   	SaveFileDialog dialog = new SaveFileDialog(); 
		   	dialog.Filter = DFilters;
		   	dialog.InitialDirectory = @"C:/"; 
		   	dialog.Title = DTitle; 
		   	return ( dialog.ShowDialog() == DialogResult.OK )
		      ? dialog.FileName : null;
		}
		
		public static string MsToString (int MS)
		{
			TimeSpan t = TimeSpan.FromMilliseconds( MS );
			
			string converted = string.Format("{0:D2}:{1:D2}:{2:D2},{3:D3}",
            	            t.Hours, 
                	        t.Minutes, 
                    	    t.Seconds, 
                        	t.Milliseconds);
			
			return converted;
		}
		
		public static int StringToMs (string str)
		{
			int converted = 0;
			
			DateTime result;
			CultureInfo provider = CultureInfo.InvariantCulture;
			
			string format = "hh:mm:ss,fff";
			result = DateTime.ParseExact(str, format, provider);
			
			converted += result.Hour * 60 * 60 * 1000;
			converted += result.Minute * 60 * 1000;
			converted += result.Second * 1000;
			converted += result.Millisecond;
			
			return converted;
		}
		
		public static bool isNum (string str)
		{
			int Num;
			return int.TryParse(str, out Num);
		}
	}
}