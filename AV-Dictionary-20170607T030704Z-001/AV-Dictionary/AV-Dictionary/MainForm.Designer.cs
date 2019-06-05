namespace AV_Dictionary
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mtDictionary = new MetroFramework.Controls.MetroTile();
            this.mtGrammar = new MetroFramework.Controls.MetroTile();
            this.mtTest = new MetroFramework.Controls.MetroTile();
            this.mtListening = new MetroFramework.Controls.MetroTile();
            this.mtSetting = new MetroFramework.Controls.MetroTile();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mtlClose = new MetroFramework.Controls.MetroLink();
            this.mtlMaximize = new MetroFramework.Controls.MetroLink();
            this.mtlMinimize = new MetroFramework.Controls.MetroLink();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mtlNormal = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtDictionary
            // 
            this.mtDictionary.ActiveControl = null;
            this.mtDictionary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtDictionary.AutoSize = true;
            this.mtDictionary.BackColor = System.Drawing.Color.DodgerBlue;
            this.mtDictionary.CausesValidation = false;
            this.mtDictionary.ForeColor = System.Drawing.Color.White;
            this.mtDictionary.Location = new System.Drawing.Point(115, 50);
            this.mtDictionary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtDictionary.Name = "mtDictionary";
            this.mtDictionary.Size = new System.Drawing.Size(305, 150);
            this.mtDictionary.TabIndex = 0;
            this.mtDictionary.Text = "Dictionary";
            this.mtDictionary.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDictionary.TileImage")));
            this.mtDictionary.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDictionary.UseCustomBackColor = true;
            this.mtDictionary.UseCustomForeColor = true;
            this.mtDictionary.UseSelectable = true;
            this.mtDictionary.UseTileImage = true;
            this.mtDictionary.Click += new System.EventHandler(this.mtDictionary_Click);
            // 
            // mtGrammar
            // 
            this.mtGrammar.ActiveControl = null;
            this.mtGrammar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtGrammar.AutoSize = true;
            this.mtGrammar.BackColor = System.Drawing.Color.Orange;
            this.mtGrammar.ForeColor = System.Drawing.Color.Black;
            this.mtGrammar.Location = new System.Drawing.Point(115, 205);
            this.mtGrammar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtGrammar.Name = "mtGrammar";
            this.mtGrammar.Size = new System.Drawing.Size(150, 150);
            this.mtGrammar.TabIndex = 0;
            this.mtGrammar.Text = "Grammar";
            this.mtGrammar.TileImage = ((System.Drawing.Image)(resources.GetObject("mtGrammar.TileImage")));
            this.mtGrammar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtGrammar.UseCustomBackColor = true;
            this.mtGrammar.UseCustomForeColor = true;
            this.mtGrammar.UseSelectable = true;
            this.mtGrammar.UseTileImage = true;
            this.mtGrammar.Click += new System.EventHandler(this.mtGrammar_Click);
            // 
            // mtTest
            // 
            this.mtTest.ActiveControl = null;
            this.mtTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtTest.AutoSize = true;
            this.mtTest.BackColor = System.Drawing.Color.Green;
            this.mtTest.ForeColor = System.Drawing.Color.White;
            this.mtTest.Location = new System.Drawing.Point(480, 205);
            this.mtTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtTest.Name = "mtTest";
            this.mtTest.Size = new System.Drawing.Size(150, 150);
            this.mtTest.TabIndex = 0;
            this.mtTest.Text = "Test";
            this.mtTest.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTest.TileImage")));
            this.mtTest.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtTest.UseCustomBackColor = true;
            this.mtTest.UseCustomForeColor = true;
            this.mtTest.UseSelectable = true;
            this.mtTest.UseTileImage = true;
            this.mtTest.Click += new System.EventHandler(this.mtTest_Click);
            // 
            // mtListening
            // 
            this.mtListening.ActiveControl = null;
            this.mtListening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtListening.AutoSize = true;
            this.mtListening.BackColor = System.Drawing.Color.LavenderBlush;
            this.mtListening.ForeColor = System.Drawing.Color.Black;
            this.mtListening.Location = new System.Drawing.Point(480, 50);
            this.mtListening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtListening.Name = "mtListening";
            this.mtListening.Size = new System.Drawing.Size(150, 150);
            this.mtListening.TabIndex = 0;
            this.mtListening.Text = "Listening";
            this.mtListening.TileImage = ((System.Drawing.Image)(resources.GetObject("mtListening.TileImage")));
            this.mtListening.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtListening.UseCustomBackColor = true;
            this.mtListening.UseCustomForeColor = true;
            this.mtListening.UseSelectable = true;
            this.mtListening.UseTileImage = true;
            this.mtListening.Click += new System.EventHandler(this.mtListening_Click);
            // 
            // mtSetting
            // 
            this.mtSetting.ActiveControl = null;
            this.mtSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtSetting.AutoSize = true;
            this.mtSetting.BackColor = System.Drawing.Color.Orange;
            this.mtSetting.ForeColor = System.Drawing.Color.Black;
            this.mtSetting.Location = new System.Drawing.Point(635, 205);
            this.mtSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtSetting.Name = "mtSetting";
            this.mtSetting.Size = new System.Drawing.Size(150, 150);
            this.mtSetting.TabIndex = 0;
            this.mtSetting.Text = "Setting";
            this.mtSetting.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSetting.TileImage")));
            this.mtSetting.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSetting.UseCustomBackColor = true;
            this.mtSetting.UseCustomForeColor = true;
            this.mtSetting.UseSelectable = true;
            this.mtSetting.UseTileImage = true;
            this.mtSetting.Click += new System.EventHandler(this.mtSetting_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mtlClose
            // 
            this.mtlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlClose.Image = ((System.Drawing.Image)(resources.GetObject("mtlClose.Image")));
            this.mtlClose.ImageSize = 32;
            this.mtlClose.Location = new System.Drawing.Point(855, 0);
            this.mtlClose.Name = "mtlClose";
            this.mtlClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlClose.NoFocusImage")));
            this.mtlClose.Size = new System.Drawing.Size(45, 45);
            this.mtlClose.TabIndex = 2;
            this.mtlClose.UseSelectable = true;
            this.mtlClose.Click += new System.EventHandler(this.mtlClose_Click);
            // 
            // mtlMaximize
            // 
            this.mtlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlMaximize.Image = ((System.Drawing.Image)(resources.GetObject("mtlMaximize.Image")));
            this.mtlMaximize.ImageSize = 32;
            this.mtlMaximize.Location = new System.Drawing.Point(810, 5);
            this.mtlMaximize.Name = "mtlMaximize";
            this.mtlMaximize.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlMaximize.NoFocusImage")));
            this.mtlMaximize.Size = new System.Drawing.Size(45, 45);
            this.mtlMaximize.TabIndex = 2;
            this.mtlMaximize.UseSelectable = true;
            this.mtlMaximize.Click += new System.EventHandler(this.mtlMaximize_Click);
            // 
            // mtlMinimize
            // 
            this.mtlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlMinimize.Image = ((System.Drawing.Image)(resources.GetObject("mtlMinimize.Image")));
            this.mtlMinimize.ImageSize = 32;
            this.mtlMinimize.Location = new System.Drawing.Point(765, 0);
            this.mtlMinimize.Name = "mtlMinimize";
            this.mtlMinimize.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlMinimize.NoFocusImage")));
            this.mtlMinimize.Size = new System.Drawing.Size(45, 45);
            this.mtlMinimize.TabIndex = 2;
            this.mtlMinimize.UseSelectable = true;
            this.mtlMinimize.Click += new System.EventHandler(this.mtlMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 50);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NLTDICT";
            // 
            // mtlNormal
            // 
            this.mtlNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlNormal.Image = ((System.Drawing.Image)(resources.GetObject("mtlNormal.Image")));
            this.mtlNormal.ImageSize = 32;
            this.mtlNormal.Location = new System.Drawing.Point(810, 0);
            this.mtlNormal.Name = "mtlNormal";
            this.mtlNormal.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlNormal.NoFocusImage")));
            this.mtlNormal.Size = new System.Drawing.Size(45, 45);
            this.mtlNormal.TabIndex = 2;
            this.mtlNormal.UseSelectable = true;
            this.mtlNormal.Visible = false;
            this.mtlNormal.Click += new System.EventHandler(this.mtlNormal_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.mtDictionary);
            this.panel1.Controls.Add(this.mtGrammar);
            this.panel1.Controls.Add(this.mtSetting);
            this.panel1.Controls.Add(this.mtTest);
            this.panel1.Controls.Add(this.mtListening);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 450);
            this.panel1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mtlMinimize);
            this.Controls.Add(this.mtlNormal);
            this.Controls.Add(this.mtlMaximize);
            this.Controls.Add(this.mtlClose);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(39, 115, 39, 39);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtDictionary;
        private MetroFramework.Controls.MetroTile mtGrammar;
        private MetroFramework.Controls.MetroTile mtTest;
        private MetroFramework.Controls.MetroTile mtListening;
        private MetroFramework.Controls.MetroTile mtSetting;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLink mtlClose;
        private MetroFramework.Controls.MetroLink mtlMaximize;
        private MetroFramework.Controls.MetroLink mtlMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink mtlNormal;
        private System.Windows.Forms.Panel panel1;
    }
}