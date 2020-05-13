namespace PCDCompare
{
    partial class Frm_PcdCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PcdCompare));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBtn_Path = new System.Windows.Forms.ToolStripButton();
            this.SStrp_PcdCompare = new System.Windows.Forms.StatusStrip();
            this.SSabel_PCDCompare = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ChkLstBx_PcdC = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PicBx_X = new System.Windows.Forms.PictureBox();
            this.TckBr_X = new System.Windows.Forms.TrackBar();
            this.PicBx_Y = new System.Windows.Forms.PictureBox();
            this.TckBr_Y = new System.Windows.Forms.TrackBar();
            this.TckBr_Z = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            this.SStrp_PcdCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_Z)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_Path});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "TSrp_PcdCompare";
            // 
            // TSBtn_Path
            // 
            this.TSBtn_Path.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBtn_Path.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_Path.Image")));
            this.TSBtn_Path.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Path.Name = "TSBtn_Path";
            this.TSBtn_Path.Size = new System.Drawing.Size(68, 22);
            this.TSBtn_Path.Text = "Hakemisto";
            this.TSBtn_Path.ToolTipText = "Avaa hakemisto";
            this.TSBtn_Path.Click += new System.EventHandler(this.TSBtn_Path_Click);
            // 
            // SStrp_PcdCompare
            // 
            this.SStrp_PcdCompare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSabel_PCDCompare});
            this.SStrp_PcdCompare.Location = new System.Drawing.Point(0, 365);
            this.SStrp_PcdCompare.Name = "SStrp_PcdCompare";
            this.SStrp_PcdCompare.Size = new System.Drawing.Size(715, 22);
            this.SStrp_PcdCompare.TabIndex = 1;
            this.SStrp_PcdCompare.Text = "statusStrip1";
            // 
            // SSabel_PCDCompare
            // 
            this.SSabel_PCDCompare.Name = "SSabel_PCDCompare";
            this.SSabel_PCDCompare.Size = new System.Drawing.Size(31, 17);
            this.SSabel_PCDCompare.Text = "Start";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ChkLstBx_PcdC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.TckBr_Z);
            this.splitContainer1.Size = new System.Drawing.Size(715, 340);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 2;
            // 
            // ChkLstBx_PcdC
            // 
            this.ChkLstBx_PcdC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkLstBx_PcdC.FormattingEnabled = true;
            this.ChkLstBx_PcdC.Location = new System.Drawing.Point(0, 0);
            this.ChkLstBx_PcdC.Name = "ChkLstBx_PcdC";
            this.ChkLstBx_PcdC.Size = new System.Drawing.Size(136, 340);
            this.ChkLstBx_PcdC.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 340);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PicBx_X);
            this.splitContainer2.Panel1.Controls.Add(this.TckBr_X);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PicBx_Y);
            this.splitContainer2.Panel2.Controls.Add(this.TckBr_Y);
            this.splitContainer2.Size = new System.Drawing.Size(530, 340);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // PicBx_X
            // 
            this.PicBx_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBx_X.Location = new System.Drawing.Point(0, 0);
            this.PicBx_X.Name = "PicBx_X";
            this.PicBx_X.Size = new System.Drawing.Size(530, 117);
            this.PicBx_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBx_X.TabIndex = 1;
            this.PicBx_X.TabStop = false;
            // 
            // TckBr_X
            // 
            this.TckBr_X.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TckBr_X.Location = new System.Drawing.Point(0, 117);
            this.TckBr_X.Name = "TckBr_X";
            this.TckBr_X.Size = new System.Drawing.Size(530, 45);
            this.TckBr_X.TabIndex = 0;
            this.TckBr_X.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TckBr_X.ValueChanged += new System.EventHandler(this.TckBr_X_ValueChanged);
            // 
            // PicBx_Y
            // 
            this.PicBx_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBx_Y.Location = new System.Drawing.Point(0, 0);
            this.PicBx_Y.Name = "PicBx_Y";
            this.PicBx_Y.Size = new System.Drawing.Size(530, 129);
            this.PicBx_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBx_Y.TabIndex = 1;
            this.PicBx_Y.TabStop = false;
            // 
            // TckBr_Y
            // 
            this.TckBr_Y.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TckBr_Y.Location = new System.Drawing.Point(0, 129);
            this.TckBr_Y.Name = "TckBr_Y";
            this.TckBr_Y.Size = new System.Drawing.Size(530, 45);
            this.TckBr_Y.TabIndex = 0;
            this.TckBr_Y.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TckBr_Y.ValueChanged += new System.EventHandler(this.TckBr_Y_ValueChanged);
            // 
            // TckBr_Z
            // 
            this.TckBr_Z.Dock = System.Windows.Forms.DockStyle.Right;
            this.TckBr_Z.Location = new System.Drawing.Point(530, 0);
            this.TckBr_Z.Name = "TckBr_Z";
            this.TckBr_Z.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TckBr_Z.Size = new System.Drawing.Size(45, 340);
            this.TckBr_Z.TabIndex = 1;
            this.TckBr_Z.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // Frm_PcdCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 387);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.SStrp_PcdCompare);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_PcdCompare";
            this.Text = "PCDComapare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SStrp_PcdCompare.ResumeLayout(false);
            this.SStrp_PcdCompare.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TckBr_Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBtn_Path;
        private System.Windows.Forms.StatusStrip SStrp_PcdCompare;
        private System.Windows.Forms.ToolStripStatusLabel SSabel_PCDCompare;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox ChkLstBx_PcdC;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TrackBar TckBr_X;
        private System.Windows.Forms.PictureBox PicBx_Y;
        private System.Windows.Forms.TrackBar TckBr_Y;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBx_X;
        private System.Windows.Forms.TrackBar TckBr_Z;
    }
}

