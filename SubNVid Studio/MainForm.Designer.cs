/*
 * Created by SharpDevelop.
 * User: Dr.Kameleon
 * Date: 7/7/2009
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SubNVid_Studio
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ProcessButton = new System.Windows.Forms.Button();
			this.OptionsButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ConvertSubsFPS_DestinationFPS = new System.Windows.Forms.NumericUpDown();
			this.ConvertSubsFPS_OriginalFPS = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ConvertSubsFPS_Text = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ConvertSubsFPS_Button = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.MergeSubs_MergingPoint = new System.Windows.Forms.NumericUpDown();
			this.MergeSubs_LastSubNo = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MergeSubs_CD2_Text = new System.Windows.Forms.TextBox();
			this.MergeSubs_CD2_Button = new System.Windows.Forms.Button();
			this.MergeSubs_CD1_Text = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MergeSubs_CD1_Button = new System.Windows.Forms.Button();
			this.Tabz = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.AdjustSubs_TimeDifference = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.AdjustSubs_Text = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.AdjustSubs_Button = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ConvertSubsFPS_DestinationFPS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConvertSubsFPS_OriginalFPS)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MergeSubs_MergingPoint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MergeSubs_LastSubNo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.Tabz.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AdjustSubs_TimeDifference)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(2, 3);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(629, 32);
			this.ProgressBar.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 272);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(633, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// ProcessButton
			// 
			this.ProcessButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ProcessButton.Location = new System.Drawing.Point(492, 60);
			this.ProcessButton.Name = "ProcessButton";
			this.ProcessButton.Size = new System.Drawing.Size(140, 87);
			this.ProcessButton.TabIndex = 3;
			this.ProcessButton.Text = "&Process";
			this.ProcessButton.UseVisualStyleBackColor = true;
			this.ProcessButton.Click += new System.EventHandler(this.ProcessButtonClick);
			// 
			// OptionsButton
			// 
			this.OptionsButton.Location = new System.Drawing.Point(492, 153);
			this.OptionsButton.Name = "OptionsButton";
			this.OptionsButton.Size = new System.Drawing.Size(140, 30);
			this.OptionsButton.TabIndex = 4;
			this.OptionsButton.Text = "Pre&ferences";
			this.OptionsButton.UseVisualStyleBackColor = true;
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(492, 189);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(140, 30);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "&Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(480, 202);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Convert Subs /FPS";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.TabPage2Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ConvertSubsFPS_DestinationFPS);
			this.groupBox3.Controls.Add(this.ConvertSubsFPS_OriginalFPS);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(6, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(468, 117);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Options";
			// 
			// ConvertSubsFPS_DestinationFPS
			// 
			this.ConvertSubsFPS_DestinationFPS.Location = new System.Drawing.Point(130, 54);
			this.ConvertSubsFPS_DestinationFPS.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.ConvertSubsFPS_DestinationFPS.Name = "ConvertSubsFPS_DestinationFPS";
			this.ConvertSubsFPS_DestinationFPS.Size = new System.Drawing.Size(133, 20);
			this.ConvertSubsFPS_DestinationFPS.TabIndex = 7;
			// 
			// ConvertSubsFPS_OriginalFPS
			// 
			this.ConvertSubsFPS_OriginalFPS.Location = new System.Drawing.Point(130, 24);
			this.ConvertSubsFPS_OriginalFPS.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.ConvertSubsFPS_OriginalFPS.Name = "ConvertSubsFPS_OriginalFPS";
			this.ConvertSubsFPS_OriginalFPS.Size = new System.Drawing.Size(133, 20);
			this.ConvertSubsFPS_OriginalFPS.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(9, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 18);
			this.label9.TabIndex = 4;
			this.label9.Text = "Destination FPS";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(9, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(115, 18);
			this.label10.TabIndex = 1;
			this.label10.Text = "Original FPS";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ConvertSubsFPS_Text);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.ConvertSubsFPS_Button);
			this.groupBox4.Location = new System.Drawing.Point(6, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(468, 63);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "File(s)";
			// 
			// ConvertSubsFPS_Text
			// 
			this.ConvertSubsFPS_Text.Location = new System.Drawing.Point(72, 23);
			this.ConvertSubsFPS_Text.Name = "ConvertSubsFPS_Text";
			this.ConvertSubsFPS_Text.Size = new System.Drawing.Size(336, 20);
			this.ConvertSubsFPS_Text.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(9, 26);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 18);
			this.label12.TabIndex = 1;
			this.label12.Text = "Subs";
			this.label12.Click += new System.EventHandler(this.Label12Click);
			// 
			// ConvertSubsFPS_Button
			// 
			this.ConvertSubsFPS_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertSubsFPS_Button.Location = new System.Drawing.Point(414, 22);
			this.ConvertSubsFPS_Button.Name = "ConvertSubsFPS_Button";
			this.ConvertSubsFPS_Button.Size = new System.Drawing.Size(36, 22);
			this.ConvertSubsFPS_Button.TabIndex = 2;
			this.ConvertSubsFPS_Button.Text = "[...]";
			this.ConvertSubsFPS_Button.UseVisualStyleBackColor = true;
			this.ConvertSubsFPS_Button.Click += new System.EventHandler(this.ConvertSubsFPS_ButtonClick);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(480, 202);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Merge Subs";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.MergeSubs_MergingPoint);
			this.groupBox2.Controls.Add(this.MergeSubs_LastSubNo);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(6, 102);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(468, 90);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// MergeSubs_MergingPoint
			// 
			this.MergeSubs_MergingPoint.Location = new System.Drawing.Point(130, 54);
			this.MergeSubs_MergingPoint.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.MergeSubs_MergingPoint.Name = "MergeSubs_MergingPoint";
			this.MergeSubs_MergingPoint.Size = new System.Drawing.Size(133, 20);
			this.MergeSubs_MergingPoint.TabIndex = 7;
			// 
			// MergeSubs_LastSubNo
			// 
			this.MergeSubs_LastSubNo.Location = new System.Drawing.Point(130, 24);
			this.MergeSubs_LastSubNo.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.MergeSubs_LastSubNo.Name = "MergeSubs_LastSubNo";
			this.MergeSubs_LastSubNo.Size = new System.Drawing.Size(133, 20);
			this.MergeSubs_LastSubNo.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Merging Point (in ms)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "Last Sub No. (in CD1)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MergeSubs_CD2_Text);
			this.groupBox1.Controls.Add(this.MergeSubs_CD2_Button);
			this.groupBox1.Controls.Add(this.MergeSubs_CD1_Text);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.MergeSubs_CD1_Button);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(468, 90);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File(s)";
			// 
			// MergeSubs_CD2_Text
			// 
			this.MergeSubs_CD2_Text.Location = new System.Drawing.Point(72, 53);
			this.MergeSubs_CD2_Text.Name = "MergeSubs_CD2_Text";
			this.MergeSubs_CD2_Text.Size = new System.Drawing.Size(336, 20);
			this.MergeSubs_CD2_Text.TabIndex = 3;
			// 
			// MergeSubs_CD2_Button
			// 
			this.MergeSubs_CD2_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MergeSubs_CD2_Button.Location = new System.Drawing.Point(414, 52);
			this.MergeSubs_CD2_Button.Name = "MergeSubs_CD2_Button";
			this.MergeSubs_CD2_Button.Size = new System.Drawing.Size(36, 22);
			this.MergeSubs_CD2_Button.TabIndex = 5;
			this.MergeSubs_CD2_Button.Text = "[...]";
			this.MergeSubs_CD2_Button.UseVisualStyleBackColor = true;
			this.MergeSubs_CD2_Button.Click += new System.EventHandler(this.MergeSubs_CD2_ButtonClick);
			// 
			// MergeSubs_CD1_Text
			// 
			this.MergeSubs_CD1_Text.Location = new System.Drawing.Point(72, 23);
			this.MergeSubs_CD1_Text.Name = "MergeSubs_CD1_Text";
			this.MergeSubs_CD1_Text.Size = new System.Drawing.Size(336, 20);
			this.MergeSubs_CD1_Text.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "CD2 Subs";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "CD1 Subs";
			// 
			// MergeSubs_CD1_Button
			// 
			this.MergeSubs_CD1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MergeSubs_CD1_Button.Location = new System.Drawing.Point(414, 22);
			this.MergeSubs_CD1_Button.Name = "MergeSubs_CD1_Button";
			this.MergeSubs_CD1_Button.Size = new System.Drawing.Size(36, 22);
			this.MergeSubs_CD1_Button.TabIndex = 2;
			this.MergeSubs_CD1_Button.Text = "[...]";
			this.MergeSubs_CD1_Button.UseVisualStyleBackColor = true;
			this.MergeSubs_CD1_Button.Click += new System.EventHandler(this.MergeSubs_CD1_ButtonClick);
			// 
			// Tabz
			// 
			this.Tabz.Controls.Add(this.tabPage1);
			this.Tabz.Controls.Add(this.tabPage2);
			this.Tabz.Controls.Add(this.tabPage3);
			this.Tabz.Location = new System.Drawing.Point(2, 41);
			this.Tabz.Name = "Tabz";
			this.Tabz.SelectedIndex = 0;
			this.Tabz.Size = new System.Drawing.Size(488, 228);
			this.Tabz.TabIndex = 5;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Controls.Add(this.groupBox6);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(480, 202);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Adjust Subs";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.AdjustSubs_TimeDifference);
			this.groupBox5.Controls.Add(this.label13);
			this.groupBox5.Location = new System.Drawing.Point(6, 75);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(468, 117);
			this.groupBox5.TabIndex = 11;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Options";
			// 
			// AdjustSubs_TimeDifference
			// 
			this.AdjustSubs_TimeDifference.Location = new System.Drawing.Point(148, 25);
			this.AdjustSubs_TimeDifference.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.AdjustSubs_TimeDifference.Minimum = new decimal(new int[] {
									100000000,
									0,
									0,
									-2147483648});
			this.AdjustSubs_TimeDifference.Name = "AdjustSubs_TimeDifference";
			this.AdjustSubs_TimeDifference.Size = new System.Drawing.Size(133, 20);
			this.AdjustSubs_TimeDifference.TabIndex = 6;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(9, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(133, 18);
			this.label13.TabIndex = 1;
			this.label13.Text = "Time Difference (in ms)";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label13.Click += new System.EventHandler(this.Label13Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.AdjustSubs_Text);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Controls.Add(this.AdjustSubs_Button);
			this.groupBox6.Location = new System.Drawing.Point(6, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(468, 63);
			this.groupBox6.TabIndex = 10;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "File(s)";
			// 
			// AdjustSubs_Text
			// 
			this.AdjustSubs_Text.Location = new System.Drawing.Point(72, 23);
			this.AdjustSubs_Text.Name = "AdjustSubs_Text";
			this.AdjustSubs_Text.Size = new System.Drawing.Size(336, 20);
			this.AdjustSubs_Text.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(9, 26);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(57, 18);
			this.label14.TabIndex = 1;
			this.label14.Text = "Subs";
			// 
			// AdjustSubs_Button
			// 
			this.AdjustSubs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AdjustSubs_Button.Location = new System.Drawing.Point(414, 22);
			this.AdjustSubs_Button.Name = "AdjustSubs_Button";
			this.AdjustSubs_Button.Size = new System.Drawing.Size(36, 22);
			this.AdjustSubs_Button.TabIndex = 2;
			this.AdjustSubs_Button.Text = "[...]";
			this.AdjustSubs_Button.UseVisualStyleBackColor = true;
			this.AdjustSubs_Button.Click += new System.EventHandler(this.AdjustSubs_ButtonClick);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(130, 54);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(133, 20);
			this.numericUpDown1.TabIndex = 7;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(130, 24);
			this.numericUpDown2.Maximum = new decimal(new int[] {
									10000000,
									0,
									0,
									0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(133, 20);
			this.numericUpDown2.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Merging Point (in ms)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(9, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 18);
			this.label6.TabIndex = 1;
			this.label6.Text = "Last Sub No. (in CD1)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 20);
			this.textBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(414, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(36, 22);
			this.button1.TabIndex = 5;
			this.button1.Text = "[...]";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 23);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(336, 20);
			this.textBox2.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(9, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 18);
			this.label7.TabIndex = 4;
			this.label7.Text = "CD2 Subs";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 18);
			this.label8.TabIndex = 1;
			this.label8.Text = "CD1 Subs";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(414, 22);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(36, 22);
			this.button2.TabIndex = 2;
			this.button2.Text = "[...]";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 294);
			this.Controls.Add(this.Tabz);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.OptionsButton);
			this.Controls.Add(this.ProcessButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "SubNVid Studio [ v0.1 ] -- by Dr.Kameleon";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ConvertSubsFPS_DestinationFPS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConvertSubsFPS_OriginalFPS)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MergeSubs_MergingPoint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MergeSubs_LastSubNo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Tabz.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AdjustSubs_TimeDifference)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown AdjustSubs_TimeDifference;
		private System.Windows.Forms.TextBox AdjustSubs_Text;
		private System.Windows.Forms.Button AdjustSubs_Button;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.NumericUpDown ConvertSubsFPS_DestinationFPS;
		private System.Windows.Forms.NumericUpDown ConvertSubsFPS_OriginalFPS;
		private System.Windows.Forms.TextBox ConvertSubsFPS_Text;
		private System.Windows.Forms.Button ConvertSubsFPS_Button;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		//string[] Subs2;
		private System.Windows.Forms.TabControl Tabz;
		private System.Windows.Forms.Button MergeSubs_CD2_Button;
		private System.Windows.Forms.TextBox MergeSubs_CD2_Text;
		private System.Windows.Forms.Button MergeSubs_CD1_Button;
		private System.Windows.Forms.TextBox MergeSubs_CD1_Text;
		private System.Windows.Forms.NumericUpDown MergeSubs_LastSubNo;
		private System.Windows.Forms.NumericUpDown MergeSubs_MergingPoint;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button ProcessButton;
		private System.Windows.Forms.Button OptionsButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
	}
}
