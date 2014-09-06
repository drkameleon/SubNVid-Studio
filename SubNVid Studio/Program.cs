/*
 * SubNVid Studio [ v0.1 ]
 * ------------------------------
 * Subtitle and Video Workshop
 * Created by Dr.Kameleon
 * 
 * **************************
 * File : Program.cs
 * **************************
 */
 
using System;
using System.Windows.Forms;

namespace SubNVid_Studio
{
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
