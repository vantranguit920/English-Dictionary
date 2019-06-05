namespace AV_Dictionary
{
    partial class frmListen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtlClose = new MetroFramework.Controls.MetroLink();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtInfor = new System.Windows.Forms.TextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.metroLink3);
            this.panel1.Controls.Add(this.mtlClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 330);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.metroLink2);
            this.panel2.Controls.Add(this.metroLink1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 120);
            this.panel2.TabIndex = 1;
            // 
            // mtlClose
            // 
            this.mtlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlClose.Image = ((System.Drawing.Image)(resources.GetObject("mtlClose.Image")));
            this.mtlClose.ImageSize = 32;
            this.mtlClose.Location = new System.Drawing.Point(751, 2);
            this.mtlClose.Name = "mtlClose";
            this.mtlClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlClose.NoFocusImage")));
            this.mtlClose.Size = new System.Drawing.Size(45, 45);
            this.mtlClose.TabIndex = 8;
            this.mtlClose.UseCustomBackColor = true;
            this.mtlClose.UseSelectable = true;
            this.mtlClose.Click += new System.EventHandler(this.mtlClose_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Bài 1    :           Intro",
            "Bài 2    :           Earthquakes Conversation",
            "Bài 3    :           Bad Choice",
            "Bài 4    :           Double Standard Audio",
            "Bài 5    :           Greek Family",
            "Bài 6    :           Longtime Affair Audio",
            "Bài 7    :           Lost Custody Audio",
            "Bài 8    :           Meddling Mother-In-Law Comm",
            "Bài 9    :           Nudist",
            "Bài 10  :           Obsessive Behavior"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 120);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtInfor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 230);
            this.panel3.TabIndex = 2;
            // 
            // txtInfor
            // 
            this.txtInfor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfor.ForeColor = System.Drawing.Color.DimGray;
            this.txtInfor.Location = new System.Drawing.Point(0, 0);
            this.txtInfor.Multiline = true;
            this.txtInfor.Name = "txtInfor";
            this.txtInfor.ReadOnly = true;
            this.txtInfor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfor.Size = new System.Drawing.Size(800, 230);
            this.txtInfor.TabIndex = 0;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(612, 62);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(135, 45);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Hide transcript";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink2.Image = ((System.Drawing.Image)(resources.GetObject("metroLink2.Image")));
            this.metroLink2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink2.ImageSize = 32;
            this.metroLink2.Location = new System.Drawing.Point(612, 15);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(135, 45);
            this.metroLink2.TabIndex = 8;
            this.metroLink2.Text = "Show transcript";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 330);
            this.panel4.TabIndex = 3;
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink3.ForeColor = System.Drawing.Color.White;
            this.metroLink3.Image = ((System.Drawing.Image)(resources.GetObject("metroLink3.Image")));
            this.metroLink3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroLink3.ImageSize = 35;
            this.metroLink3.Location = new System.Drawing.Point(34, 1);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(133, 47);
            this.metroLink3.TabIndex = 9;
            this.metroLink3.Text = "Listening";
            this.metroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink3.UseCustomBackColor = true;
            this.metroLink3.UseCustomForeColor = true;
            this.metroLink3.UseSelectable = true;
            // 
            // frmListen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtInfor;
        private MetroFramework.Controls.MetroLink mtlClose;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLink metroLink3;
    }
}