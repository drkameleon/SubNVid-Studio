/*
 * SubNVid Studio [ v0.1 ]
 * ------------------------------
 * Subtitle and Video Workshop
 * Created by Dr.Kameleon
 * 
 * **************************
 * File : MainForm.cs
 * **************************
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using SNVS.Utilities;
using SNVS.Subtitles;
using SNVS.Videos;

namespace SubNVid_Studio
{
	public partial class MainForm : Form
	{
		Subs Sub;

		//string[] Subs1;
		
		int SubCNT;

		
		bool previousWasNum;
		
		public MainForm()
		{
			InitializeComponent();
			Sub = new Subs();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = DateTime.Now.ToString();	
		}
		
		private string MergeSubs_Line ( string subL, int noL )
		{
			if (Utils.isNum(subL))
			{
				previousWasNum = true;
				int dv = SubCNT + Convert.ToInt32(MergeSubs_LastSubNo.Value);
				SubCNT++;
				return dv.ToString();
			}
			else if (previousWasNum)
			{
				previousWasNum = false;
				string[] timeStr = subL.Split(new string[] { " --> " },StringSplitOptions.None);
				int[] timeMS = { Utils.StringToMs(timeStr[0]) , Utils.StringToMs(timeStr[1]) };
				//MergeSubs_MergingPoint.Value
				//timeMS[0] += Convert.ToInt32();
				timeMS[1] += Convert.ToInt32(MergeSubs_MergingPoint.Value);
				
				timeStr[0] = Utils.MsToString(timeMS[0]);
				timeStr[1] = Utils.MsToString(timeMS[1]);
				
				return timeStr[0] + " --> " + timeStr[1];
			}
			else 
			{
				previousWasNum = false;
				return subL;
			}
		}
		
		void MergeSubs()
		{
			/*Sub.addFile(MergeSubs_CD1_Text.Text);
			Sub.addFile(MergeSubs_CD2_Text.Text);
			
			Subs1 = File.ReadAllLines(MergeSubs_CD1_Text.Text);
			Subs2 = File.ReadAllLines(MergeSubs_CD2_Text.Text);
			
			StreamWriter sw = null;
			
			SubCNT = 1;
			
			FileStream fs = File.Open(outFilename, 
                                    FileMode.CreateNew, 
                                    FileAccess.Write);

            sw = new StreamWriter(fs, System.Text.Encoding.UTF8);       
  
            foreach (string subLine in Subs1)
            	sw.WriteLine(subLine);
            
            int counter = 0;
            previousWasNum = false;
            
            foreach (string subLine in Subs2)
            {
            	counter++;
            	string newSubLine = MergeSubs_Line(subLine, counter);
            	sw.WriteLine(newSubLine);
            }
            
            sw.Close();
            sw = null;*/
		}
		
		void ProcessButtonClick(object sender, EventArgs e)
		{
			Sub.setOutfile(Utils.selectOutFile(
				"Where will the output be saved?",
				"Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
			));
							
			switch(Tabz.SelectedTab.Text)
			{
				case "Merge Subs":
					Sub.addFile(MergeSubs_CD1_Text.Text);
					Sub.addFile(MergeSubs_CD2_Text.Text);
					Sub.setValues(1,Convert.ToInt32(MergeSubs_MergingPoint.Value));
					Sub.Adjust();
					Sub.writeToFile();
					break;
				case "Convert Subs /FPS":
					Sub.addFile(ConvertSubsFPS_Text.Text);
					Sub.setValues(Convert.ToDouble(ConvertSubsFPS_OriginalFPS.Value/ConvertSubsFPS_DestinationFPS.Value),0);
					Sub.Adjust();
					Sub.writeToFile();
					break;
				case "Adjust Subs":
					Sub.addFile(AdjustSubs_Text.Text);
					Sub.setValues(1,Convert.ToInt32(AdjustSubs_TimeDifference.Value));
					Sub.Adjust();
					Sub.writeToFile();
					break;
			}
			
			Sub = new Subs();
		}
		
		void MergeSubs_CD1_ButtonClick(object sender, EventArgs e)
		{
			MergeSubs_CD1_Text.Text = Utils.selectInFile(
					"Select a .SRT Subtitle file",
					"Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
				);
		}
		
		void MergeSubs_CD2_ButtonClick(object sender, EventArgs e)
		{
			MergeSubs_CD2_Text.Text = Utils.selectInFile(
					"Select a .SRT Subtitle file",
					"Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
				);
		}
		
		void Label12Click(object sender, EventArgs e)
		{
			
		}
		
		void ConvertSubsFPS_ButtonClick(object sender, EventArgs e)
		{
			ConvertSubsFPS_Text.Text = Utils.selectInFile(
					"Select a .SRT Subtitle file",
					"Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
				);
		}
		
		void Label13Click(object sender, EventArgs e)
		{
			
		}
		
		void AdjustSubs_ButtonClick(object sender, EventArgs e)
		{
			AdjustSubs_Text.Text = Utils.selectInFile(
					"Select a .SRT Subtitle file",
					"Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
				);
		}
		
		void TabPage2Click(object sender, EventArgs e)
		{
			
		}
	}
}
