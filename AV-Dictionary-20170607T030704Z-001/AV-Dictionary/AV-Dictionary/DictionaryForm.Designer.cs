namespace AV_Dictionary
{
    partial class frmDictionary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.mtsbWord = new MetroFramework.Controls.MetroScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtlRecent = new MetroFramework.Controls.MetroLink();
            this.mtlSearch = new MetroFramework.Controls.MetroLink();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtlSpeaker = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.mtlClose = new MetroFramework.Controls.MetroLink();
            this.lbxWord = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.wbrDefinition = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mtlSearchOnline = new MetroFramework.Controls.MetroLink();
            this.lbxRelated = new System.Windows.Forms.ListBox();
            this.lbxRecent = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtsbWord
            // 
            this.mtsbWord.HighlightOnWheel = true;
            this.mtsbWord.LargeChange = 2;
            this.mtsbWord.Location = new System.Drawing.Point(275, 116);
            this.mtsbWord.Maximum = 108857;
            this.mtsbWord.Minimum = 0;
            this.mtsbWord.MouseWheelBarPartitions = 10;
            this.mtsbWord.Name = "mtsbWord";
            this.mtsbWord.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.mtsbWord.ScrollbarSize = 10;
            this.mtsbWord.Size = new System.Drawing.Size(10, 379);
            this.mtsbWord.TabIndex = 1;
            this.mtsbWord.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtsbWord.UseBarColor = true;
            this.mtsbWord.UseSelectable = true;
            this.mtsbWord.Value = 1;
            this.mtsbWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mtsbWord_MouseDown);
            this.mtsbWord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtsbWord_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.metroLink1);
            this.panel2.Controls.Add(this.mtlRecent);
            this.panel2.Controls.Add(this.mtlSearch);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 70);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroLink1.ForeColor = System.Drawing.Color.White;
            this.metroLink1.Location = new System.Drawing.Point(3, 3);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(120, 23);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "A - V Dictionary";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // mtlRecent
            // 
            this.mtlRecent.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtlRecent.ForeColor = System.Drawing.Color.White;
            this.mtlRecent.Location = new System.Drawing.Point(132, 35);
            this.mtlRecent.Name = "mtlRecent";
            this.mtlRecent.Size = new System.Drawing.Size(110, 35);
            this.mtlRecent.TabIndex = 4;
            this.mtlRecent.Text = "Recent";
            this.mtlRecent.UseCustomBackColor = true;
            this.mtlRecent.UseCustomForeColor = true;
            this.mtlRecent.UseSelectable = true;
            this.mtlRecent.Click += new System.EventHandler(this.mtlRecent_Click);
            // 
            // mtlSearch
            // 
            this.mtlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtlSearch.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtlSearch.ForeColor = System.Drawing.Color.DimGray;
            this.mtlSearch.Location = new System.Drawing.Point(15, 35);
            this.mtlSearch.Name = "mtlSearch";
            this.mtlSearch.Size = new System.Drawing.Size(116, 35);
            this.mtlSearch.TabIndex = 4;
            this.mtlSearch.Text = "Search";
            this.mtlSearch.UseCustomBackColor = true;
            this.mtlSearch.UseCustomForeColor = true;
            this.mtlSearch.UseSelectable = true;
            this.mtlSearch.Click += new System.EventHandler(this.mtlSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.mtlSpeaker);
            this.panel3.Controls.Add(this.metroLink2);
            this.panel3.Controls.Add(this.metroLink3);
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 70);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // mtlSpeaker
            // 
            this.mtlSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("mtlSpeaker.Image")));
            this.mtlSpeaker.ImageSize = 32;
            this.mtlSpeaker.Location = new System.Drawing.Point(323, 28);
            this.mtlSpeaker.Name = "mtlSpeaker";
            this.mtlSpeaker.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlSpeaker.NoFocusImage")));
            this.mtlSpeaker.Size = new System.Drawing.Size(45, 45);
            this.mtlSpeaker.TabIndex = 7;
            this.mtlSpeaker.UseCustomBackColor = true;
            this.mtlSpeaker.UseSelectable = true;
            this.mtlSpeaker.Visible = false;
            this.mtlSpeaker.Click += new System.EventHandler(this.mtlSpeaker_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink2.ForeColor = System.Drawing.Color.White;
            this.metroLink2.Location = new System.Drawing.Point(23, 35);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(110, 35);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.Text = "Definition";
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink3.ForeColor = System.Drawing.Color.White;
            this.metroLink3.Location = new System.Drawing.Point(421, 35);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(78, 35);
            this.metroLink3.TabIndex = 4;
            this.metroLink3.Text = "Related";
            this.metroLink3.UseCustomBackColor = true;
            this.metroLink3.UseCustomForeColor = true;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.mtlRecent_Click);
            // 
            // mtlClose
            // 
            this.mtlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlClose.Image = ((System.Drawing.Image)(resources.GetObject("mtlClose.Image")));
            this.mtlClose.ImageSize = 32;
            this.mtlClose.Location = new System.Drawing.Point(840, 435);
            this.mtlClose.Name = "mtlClose";
            this.mtlClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlClose.NoFocusImage")));
            this.mtlClose.Size = new System.Drawing.Size(45, 45);
            this.mtlClose.TabIndex = 7;
            this.mtlClose.UseSelectable = true;
            this.mtlClose.Click += new System.EventHandler(this.mtlClose_Click);
            // 
            // lbxWord
            // 
            this.lbxWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbxWord.ForeColor = System.Drawing.Color.Gray;
            this.lbxWord.FormattingEnabled = true;
            this.lbxWord.ItemHeight = 25;
            this.lbxWord.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.lbxWord.Location = new System.Drawing.Point(0, 46);
            this.lbxWord.Name = "lbxWord";
            this.lbxWord.Size = new System.Drawing.Size(275, 379);
            this.lbxWord.TabIndex = 4;
            this.lbxWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxWord_MouseClick);
            this.lbxWord.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxWord_DrawItem);
            this.lbxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxWord_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lbxWord);
            this.pnlSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.Location = new System.Drawing.Point(0, 70);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(275, 425);
            this.pnlSearch.TabIndex = 8;
            // 
            // pnlRecent
            // 
            this.pnlRecent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRecent.Controls.Add(this.lbxRecent);
            this.pnlRecent.ForeColor = System.Drawing.Color.Gray;
            this.pnlRecent.Location = new System.Drawing.Point(0, 70);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Size = new System.Drawing.Size(275, 425);
            this.pnlRecent.TabIndex = 8;
            this.pnlRecent.Visible = false;
            // 
            // wbrDefinition
            // 
            this.wbrDefinition.Location = new System.Drawing.Point(285, 70);
            this.wbrDefinition.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrDefinition.Name = "wbrDefinition";
            this.wbrDefinition.Size = new System.Drawing.Size(380, 425);
            this.wbrDefinition.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(651, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 425);
            this.panel1.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(647, 461);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 34);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(647, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(18, 34);
            this.panel6.TabIndex = 12;
            // 
            // mtlSearchOnline
            // 
            this.mtlSearchOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlSearchOnline.Image = ((System.Drawing.Image)(resources.GetObject("mtlSearchOnline.Image")));
            this.mtlSearchOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlSearchOnline.ImageSize = 32;
            this.mtlSearchOnline.Location = new System.Drawing.Point(324, 116);
            this.mtlSearchOnline.Name = "mtlSearchOnline";
            this.mtlSearchOnline.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlSearchOnline.NoFocusImage")));
            this.mtlSearchOnline.Size = new System.Drawing.Size(118, 45);
            this.mtlSearchOnline.TabIndex = 7;
            this.mtlSearchOnline.Text = "Search Online";
            this.mtlSearchOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtlSearchOnline.UseCustomBackColor = true;
            this.mtlSearchOnline.UseCustomForeColor = true;
            this.mtlSearchOnline.UseSelectable = true;
            this.mtlSearchOnline.Visible = false;
            this.mtlSearchOnline.Click += new System.EventHandler(this.mtlSearchOnline_Click);
            // 
            // lbxRelated
            // 
            this.lbxRelated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxRelated.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRelated.ForeColor = System.Drawing.Color.DimGray;
            this.lbxRelated.FormattingEnabled = true;
            this.lbxRelated.ItemHeight = 20;
            this.lbxRelated.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.lbxRelated.Location = new System.Drawing.Point(671, 78);
            this.lbxRelated.Name = "lbxRelated";
            this.lbxRelated.Size = new System.Drawing.Size(214, 340);
            this.lbxRelated.TabIndex = 13;
            this.lbxRelated.Visible = false;
            this.lbxRelated.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbxRelated_MouseUp);
            // 
            // lbxRecent
            // 
            this.lbxRecent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRecent.ForeColor = System.Drawing.Color.DimGray;
            this.lbxRecent.FormattingEnabled = true;
            this.lbxRecent.ItemHeight = 20;
            this.lbxRecent.Location = new System.Drawing.Point(16, 18);
            this.lbxRecent.Name = "lbxRecent";
            this.lbxRecent.Size = new System.Drawing.Size(257, 380);
            this.lbxRecent.TabIndex = 13;
            this.lbxRecent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbxRecent_MouseUp);
            // 
            // frmDictionary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 495);
            this.Controls.Add(this.lbxRelated);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.mtlSearchOnline);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wbrDefinition);
            this.Controls.Add(this.mtsbWord);
            this.Controls.Add(this.pnlRecent);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.mtlClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 484);
            this.Name = "frmDictionary";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlRecent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroScrollBar mtsbWord;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink mtlSearch;
        private MetroFramework.Controls.MetroLink mtlRecent;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLink mtlClose;
        private System.Windows.Forms.ListBox lbxWord;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlRecent;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink mtlSpeaker;
        private System.Windows.Forms.WebBrowser wbrDefinition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLink mtlSearchOnline;
        private System.Windows.Forms.ListBox lbxRelated;
        private System.Windows.Forms.ListBox lbxRecent;
    }
}