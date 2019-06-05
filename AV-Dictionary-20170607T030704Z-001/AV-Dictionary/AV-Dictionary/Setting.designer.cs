namespace AV_Dictionary
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.mtlClose = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbHD = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới Thiệu Phần Mềm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtlClose
            // 
            this.mtlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlClose.Image = ((System.Drawing.Image)(resources.GetObject("mtlClose.Image")));
            this.mtlClose.ImageSize = 32;
            this.mtlClose.Location = new System.Drawing.Point(719, 416);
            this.mtlClose.Name = "mtlClose";
            this.mtlClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mtlClose.NoFocusImage")));
            this.mtlClose.Size = new System.Drawing.Size(69, 35);
            this.mtlClose.TabIndex = 13;
            this.mtlClose.UseCustomBackColor = true;
            this.mtlClose.UseCustomForeColor = true;
            this.mtlClose.UseSelectable = true;
            this.mtlClose.UseStyleColors = true;
            this.mtlClose.Click += new System.EventHandler(this.mtlClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hướng Dẫn Sử Dụng";
            // 
            // ptbHD
            // 
            this.ptbHD.Location = new System.Drawing.Point(195, 145);
            this.ptbHD.Name = "ptbHD";
            this.ptbHD.Size = new System.Drawing.Size(488, 253);
            this.ptbHD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHD.TabIndex = 15;
            this.ptbHD.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Bước Tiếp Theo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(195, 21);
            this.txtGT.Multiline = true;
            this.txtGT.Name = "txtGT";
            this.txtGT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGT.Size = new System.Drawing.Size(488, 118);
            this.txtGT.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Quay Lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 453);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptbHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtlClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink mtlClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Button button2;
    }
}