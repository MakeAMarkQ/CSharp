namespace TestCustomCheckedListBox
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.BackgroundRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ForegroundRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UnderlineCB = new System.Windows.Forms.CheckBox();
            this.StrikeoutCB = new System.Windows.Forms.CheckBox();
            this.BoldCB = new System.Windows.Forms.CheckBox();
            this.ObliqueCB = new System.Windows.Forms.CheckBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.FontSizeRB = new System.Windows.Forms.RadioButton();
            this.customCheckedListBox1 = new Qodex.CustomCheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundRB
            // 
            this.BackgroundRB.AutoSize = true;
            this.BackgroundRB.Checked = true;
            this.BackgroundRB.Location = new System.Drawing.Point(8, 22);
            this.BackgroundRB.Name = "BackgroundRB";
            this.BackgroundRB.Size = new System.Drawing.Size(87, 17);
            this.BackgroundRB.TabIndex = 1;
            this.BackgroundRB.TabStop = true;
            this.BackgroundRB.Text = "Green/White";
            this.BackgroundRB.UseVisualStyleBackColor = true;
            this.BackgroundRB.CheckedChanged += new System.EventHandler(this.BackgroundRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.BackgroundRB);
            this.groupBox1.Location = new System.Drawing.Point(150, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Red/Blue";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.ForegroundRB);
            this.groupBox2.Location = new System.Drawing.Point(150, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foreground";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 45);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Gray/Orange";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ForegroundRB
            // 
            this.ForegroundRB.AutoSize = true;
            this.ForegroundRB.Checked = true;
            this.ForegroundRB.Location = new System.Drawing.Point(8, 20);
            this.ForegroundRB.Name = "ForegroundRB";
            this.ForegroundRB.Size = new System.Drawing.Size(77, 17);
            this.ForegroundRB.TabIndex = 1;
            this.ForegroundRB.TabStop = true;
            this.ForegroundRB.Text = "Black/Red";
            this.ForegroundRB.UseVisualStyleBackColor = true;
            this.ForegroundRB.CheckedChanged += new System.EventHandler(this.ForegroundRB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UnderlineCB);
            this.groupBox3.Controls.Add(this.StrikeoutCB);
            this.groupBox3.Controls.Add(this.BoldCB);
            this.groupBox3.Controls.Add(this.ObliqueCB);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.FontSizeRB);
            this.groupBox3.Location = new System.Drawing.Point(277, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font (rows 2-10)";
            // 
            // UnderlineCB
            // 
            this.UnderlineCB.AutoSize = true;
            this.UnderlineCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderlineCB.Location = new System.Drawing.Point(8, 129);
            this.UnderlineCB.Name = "UnderlineCB";
            this.UnderlineCB.Size = new System.Drawing.Size(71, 17);
            this.UnderlineCB.TabIndex = 8;
            this.UnderlineCB.Text = "Underline";
            this.UnderlineCB.UseVisualStyleBackColor = true;
            this.UnderlineCB.CheckedChanged += new System.EventHandler(this.UnderlineCB_CheckedChanged);
            // 
            // StrikeoutCB
            // 
            this.StrikeoutCB.AutoSize = true;
            this.StrikeoutCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrikeoutCB.Location = new System.Drawing.Point(8, 108);
            this.StrikeoutCB.Name = "StrikeoutCB";
            this.StrikeoutCB.Size = new System.Drawing.Size(68, 17);
            this.StrikeoutCB.TabIndex = 7;
            this.StrikeoutCB.Text = "Strikeout";
            this.StrikeoutCB.UseVisualStyleBackColor = true;
            this.StrikeoutCB.CheckedChanged += new System.EventHandler(this.StrikeoutCB_CheckedChanged);
            // 
            // BoldCB
            // 
            this.BoldCB.AutoSize = true;
            this.BoldCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldCB.Location = new System.Drawing.Point(8, 87);
            this.BoldCB.Name = "BoldCB";
            this.BoldCB.Size = new System.Drawing.Size(51, 17);
            this.BoldCB.TabIndex = 6;
            this.BoldCB.Text = "Bold";
            this.BoldCB.UseVisualStyleBackColor = true;
            this.BoldCB.CheckedChanged += new System.EventHandler(this.BoldCB_CheckedChanged);
            // 
            // ObliqueCB
            // 
            this.ObliqueCB.AutoSize = true;
            this.ObliqueCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObliqueCB.Location = new System.Drawing.Point(9, 66);
            this.ObliqueCB.Name = "ObliqueCB";
            this.ObliqueCB.Size = new System.Drawing.Size(62, 17);
            this.ObliqueCB.TabIndex = 5;
            this.ObliqueCB.Text = "Oblique";
            this.ObliqueCB.UseVisualStyleBackColor = true;
            this.ObliqueCB.CheckedChanged += new System.EventHandler(this.ObliqueCB_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(8, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "12";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // FontSizeRB
            // 
            this.FontSizeRB.AutoSize = true;
            this.FontSizeRB.Checked = true;
            this.FontSizeRB.Location = new System.Drawing.Point(8, 19);
            this.FontSizeRB.Name = "FontSizeRB";
            this.FontSizeRB.Size = new System.Drawing.Size(46, 17);
            this.FontSizeRB.TabIndex = 3;
            this.FontSizeRB.TabStop = true;
            this.FontSizeRB.Text = "8.25";
            this.FontSizeRB.UseVisualStyleBackColor = true;
            this.FontSizeRB.CheckedChanged += new System.EventHandler(this.FontSizeRB_CheckedChanged);
            // 
            // customCheckedListBox1
            // 
            this.customCheckedListBox1.CheckOnClick = true;
            this.customCheckedListBox1.DrawFocusedIndicator = true;
            this.customCheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCheckedListBox1.FormattingEnabled = true;
            this.customCheckedListBox1.Items.AddRange(new object[] {
            "Row 1",
            "Row 2",
            "Row 3",
            "Row 4",
            "Row 5",
            "Row 6",
            "Row 7",
            "Row 8",
            "Row 9",
            "Row 10"});
            this.customCheckedListBox1.Location = new System.Drawing.Point(12, 19);
            this.customCheckedListBox1.Name = "customCheckedListBox1";
            this.customCheckedListBox1.Size = new System.Drawing.Size(120, 154);
            this.customCheckedListBox1.TabIndex = 5;
            this.customCheckedListBox1.GetForeColor += new Qodex.CustomCheckedListBox.GetColorDelegate(this.customCheckedListBox1_GetForeColor);
            this.customCheckedListBox1.GetBackColor += new Qodex.CustomCheckedListBox.GetColorDelegate(this.customCheckedListBox1_GetBackColor);
            this.customCheckedListBox1.GetFont += new Qodex.CustomCheckedListBox.GetFontDelegate(this.customCheckedListBox1_GetFont);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 188);
            this.Controls.Add(this.customCheckedListBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CustomCheckedListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton BackgroundRB;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton ForegroundRB;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox UnderlineCB;
		private System.Windows.Forms.CheckBox StrikeoutCB;
		private System.Windows.Forms.CheckBox BoldCB;
		private System.Windows.Forms.CheckBox ObliqueCB;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton FontSizeRB;
		private Qodex.CustomCheckedListBox customCheckedListBox1;
	}
}

