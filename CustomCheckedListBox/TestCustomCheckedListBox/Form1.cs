///////////////////////////////////////////////////////////////////////////
//
// Copyright 2015 Qodex Software.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
///////////////////////////////////////////////////////////////////////////
//
//        FILE: TestCustomCheckedListBox.cs
//
//      AUTHOR: Tim Bomgardner
//
// DESCRIPTION: Simple test driver for CustomCheckedListBox.
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Qodex;


namespace TestCustomCheckedListBox
{
	public partial class Form1 : Form
	{
		Color BackGreen = Color.LightGreen;
		Color BackWhite = Color.Ivory;
		Color BackRed = Color.LightPink;
		Color BackBlue = Color.LightCyan;
		Color ForeBlack = Color.Black;
		Color ForeRed = Color.Red;
		Color ForeGray = Color.Gray;
		Color ForeOrange = Color.Orange;

		Status[] rowStatus = new Status[10];
		Font currentFont;
		public float size = 8.25F;
		public bool oblique;
		public bool bold;
		public bool strikeout;
		public bool underline;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < rowStatus.Length; i++)
			{
				rowStatus[i] = new Status();
			}
			updateForeground();
			updateBackground();
			BuildFont();
		}

		private Color customCheckedListBox1_GetForeColor(CustomCheckedListBox listbox, DrawItemEventArgs e)
		{
			return rowStatus[e.Index].foreground;
		}

		private Color customCheckedListBox1_GetBackColor(CustomCheckedListBox listbox, DrawItemEventArgs e)
		{
			return rowStatus[e.Index].background;
		}

		private Font customCheckedListBox1_GetFont(CustomCheckedListBox listbox, DrawItemEventArgs e)
		{
            if (e.Index == 0)
				return new Font(FontFamily.GenericSerif, currentFont.Size, FontStyle.Strikeout, GraphicsUnit.Point);
			else
				return currentFont;
		}

		private void updateForeground()
		{
            // These value will be pcked up by customCheckedListBox1_GetForeColor()
            for (int i = 0; i < rowStatus.Length; i += 2)
			{
				rowStatus[i].foreground = (ForegroundRB.Checked) ? ForeBlack: ForeGray;
				rowStatus[i + 1].foreground = (ForegroundRB.Checked) ? ForeRed : ForeOrange;
			}
			customCheckedListBox1.Refresh();
		}

		private void ForegroundRB_CheckedChanged(object sender, EventArgs e)
		{
			updateForeground();
		}

		private void updateBackground()
		{
            // These value will be pcked up by customCheckedListBox1_GetBackColor()
            for (int i = 0; i < rowStatus.Length; i += 2)
			{
				rowStatus[i].background = (BackgroundRB.Checked) ? BackGreen : BackRed;
				rowStatus[i + 1].background = (BackgroundRB.Checked) ? BackWhite : BackBlue;
			}
			customCheckedListBox1.Refresh();
		}

		private void BackgroundRB_CheckedChanged(object sender, EventArgs e)
		{
			updateBackground();
		}

		private void FontSizeRB_CheckedChanged(object sender, EventArgs e)
		{
			size = (FontSizeRB.Checked) ? 8.25F : 12.0F;
			BuildFont();
			customCheckedListBox1.Refresh();
		}

		private void ObliqueCB_CheckedChanged(object sender, EventArgs e)
		{
			oblique = ObliqueCB.Checked;
			BuildFont();
			customCheckedListBox1.Refresh();
		}

		private void BoldCB_CheckedChanged(object sender, EventArgs e)
		{
			bold = BoldCB.Checked;
			BuildFont();
			customCheckedListBox1.Refresh();
		}

		private void StrikeoutCB_CheckedChanged(object sender, EventArgs e)
		{
			strikeout = StrikeoutCB.Checked;
			BuildFont();
			customCheckedListBox1.Refresh();
		}

		private void UnderlineCB_CheckedChanged(object sender, EventArgs e)
		{
			underline = UnderlineCB.Checked;
			BuildFont();
			customCheckedListBox1.Refresh();
		}

		private void BuildFont()
		{
            // The current font will be pcked up by customCheckedListBox1_GetFont()
            FontStyle style = new FontStyle();
			if (oblique) style |= FontStyle.Italic;
			if (bold) style |= FontStyle.Bold;
			if (strikeout) style |= FontStyle.Strikeout;
			if (underline) style |= FontStyle.Underline;
			currentFont = new Font(customCheckedListBox1.Font.FontFamily, size, style);
		}

	}

	struct Status
	{
		public Color background;
		public Color foreground;
	}

}
