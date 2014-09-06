/*
 * SubNVid Studio [ v0.1 ]
 * ------------------------------
 * Subtitle and Video Workshop
 * Created by Dr.Kameleon
 * 
 * **************************
 * File : Subtitles.cs
 * **************************
 */
 
using System;
using System.IO;

using SNVS.Utilities;

namespace SNVS.Subtitles
{
	public class Subs
	{
		string[] subs1, subs2;
		string[] Result;
		
		string outFile;
		
		double MulVal;
		int AddVal;
		
		int SubCNT;
		
		bool previousWasNum;

		string   subn1, subn2;
			
		int nofsubs;
		
		public void addFile(string filename)
		{
			if (nofsubs==0)
			{
				subn1 = filename;
				subs1 = File.ReadAllLines(filename);
			}
			else if (nofsubs==1)
			{
				subn2 = filename;
				subs2 = File.ReadAllLines(filename);
			}
			else
			{
				
			}
			
			this.nofsubs++;
		}
		
		public void setOutfile(string filename)
		{
			this.outFile = filename;
		}
		
		public string[] getResult()
		{
			return this.Result;
		}
		
		public void writeToFile()
		{
			StreamWriter sw = null;
		
			FileStream fs = File.Open(outFile, 
                                    FileMode.CreateNew, 
                                    FileAccess.Write);

            sw = new StreamWriter(fs, System.Text.Encoding.UTF8);      
            
            foreach (string line in Result)
            	sw.WriteLine(line);
            
            sw.Close();
            sw = null;
		}
		
		private string convertLine ( string subL, int noL )
		{
			if (Utils.isNum(subL))
			{
				previousWasNum = true;
				int dv = SubCNT;
				SubCNT++;
				return dv.ToString();
			}
			else if (previousWasNum)
			{
				previousWasNum = false;
				string[] timeStr = subL.Split(new string[] { " --> " },StringSplitOptions.None);
				int[] timeMS = { Utils.StringToMs(timeStr[0]) , Utils.StringToMs(timeStr[1]) };
				
				timeMS[0] = Convert.ToInt32(timeMS[0]*MulVal);
				timeMS[1] = Convert.ToInt32(timeMS[1]*MulVal);
				
				timeMS[0] += AddVal;
				timeMS[1] += AddVal;
				
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
		
		public void setValues(double mulval, int addval)
		{
			this.MulVal = Convert.ToDouble(mulval);
			this.AddVal = Convert.ToInt32(addval);
		}
		
		public void Adjust()
		{
			SubCNT = 1;
			int counter = 0;
            previousWasNum = false;
            
            foreach (string subLine in subs1)
            {
            	counter++;
            	string newSubLine = convertLine(subLine, counter);
            	Result[0] = newSubLine;
            }
		}
		
		public Subs()
		{
			nofsubs = 0;
			Result = new string[10000];
		}
	}
}
