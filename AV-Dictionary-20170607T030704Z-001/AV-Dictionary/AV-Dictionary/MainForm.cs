using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AV_Dictionary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Method

        private void timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 6);
            int num2 = rand.Next(1, 8);

            switch (num1)
            {
                case 1:
                    mtDictionary.BackColor = Color.Green;
                    break;
                case 2:
                    mtGrammar.BackColor = Color.LavenderBlush;
                    break;
                case 3:
                    mtTest.BackColor = Color.Green;
                    break;
                case 4:
                    mtListening.BackColor = Color.LavenderBlush;
                    break;
                case 5:
                    //mtGame.BackColor = Color.Green;
                    break;
                case 6:
                    mtSetting.BackColor = Color.LavenderBlush;
                    break;
            }
            switch (num2)
            {
                case 1:
                    mtDictionary.BackColor = Color.DodgerBlue;
                    break;
                case 2:
                    mtGrammar.BackColor = Color.Orange;
                    break;
                case 3:
                    mtTest.BackColor = Color.DodgerBlue;
                    break;
                case 4:
                    mtListening.BackColor = Color.Orange;
                    break;
                case 5:
                    //mtGame.BackColor = Color.DodgerBlue;
                    break;
                case 6:
                    mtSetting.BackColor = Color.Orange;
                    break;
            }
        }

        #region HandleMouseEvent
        Boolean flag;
        int curX = 0;
        int curY = 0;

        private void HandleMouseDown(MouseEventArgs e)
        {
            flag = true;
            curX = e.X;
            curY = e.Y;
        }

        private void HandleMouseUp()
        {
            flag = false;

        }

        private void HandleMouseMove()
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - curX, Cursor.Position.Y - curY);
            }
        }
        /// <summary>
        /// Handle Moving Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //
        //frmMain
        //
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove();
        }
        //
        //HeadPanel
        //
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove();
        }
        #endregion

        #region MetroLink_Click

        private void mtlClose_Click(object sender, EventArgs e)
        {
            DictionaryManager dictMan = new DictionaryManager();
            dictMan.ResetContent();
            Application.Exit();
            Refresh();
        }

        private void mtlMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.mtlNormal.Visible = true;
            this.mtlMaximize.Visible = false;
            this.panel1.Location = new Point(0, 50);
            this.panel1.Size = new Size(this.Width, this.Height - 50);

            int _height = this.Height - 50;
            int _width = this.Width;
            int size = (int)(((float)_height / 500) * 150);

            mtDictionary.Location = new Point(_width / 2 - (size * 2 + 5) - 20, _height / 2 - size);
            mtDictionary.Size = new Size(size * 2 + 5, size);

            mtGrammar.Location = new Point(mtDictionary.Location.X, mtDictionary.Location.Y + size + 5);
            mtGrammar.Size = new Size(size, size);

            mtListening.Location = new Point(mtDictionary.Location.X + 40 + mtDictionary.Width, mtDictionary.Location.Y);
            mtListening.Size = new Size(size, size);

            mtTest.Location = new Point(mtListening.Location.X, mtGrammar.Location.Y);
            mtTest.Size = new Size(size, size);

            mtSetting.Location = new Point(mtTest.Location.X + 5 + size, mtTest.Location.Y);
            mtSetting.Size = new Size(size, size);
        }

        private void mtlNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.mtlNormal.Visible = false;
            this.mtlMaximize.Visible = true;
            this.panel1.Location = new Point(0, 50);
            this.panel1.Size = new Size(900, 450);

            mtDictionary.Location = new Point(115, 50);
            mtDictionary.Size = new Size(305, 150);

            mtGrammar.Location = new Point(115, 205);
            mtGrammar.Size = new Size(150, 150);

            mtListening.Location = new Point(480, 50);
            mtListening.Size = new Size(150, 150);

            mtTest.Location = new Point(480, 205);
            mtTest.Size = new Size(150, 150);

            mtSetting.Location = new Point(635, 205);
            mtSetting.Size = new Size(150, 150);
        }

        private void mtlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mtDictionary_Click(object sender, EventArgs e)
        {

            frmDictionary frmDict = new frmDictionary();
            frmDict.ShowDialog();
        }

        #endregion

        #endregion

        private void mtGrammar_Click(object sender, EventArgs e)
        {
            frmGramar frm = new frmGramar();
            frm.ShowDialog();
        }

        private void mtListening_Click(object sender, EventArgs e)
        {
            frmListen frm = new frmListen();
            frm.ShowDialog();
        }

        private void mtTest_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.ShowDialog();
        }

        private void mtSetting_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }
    }
}
