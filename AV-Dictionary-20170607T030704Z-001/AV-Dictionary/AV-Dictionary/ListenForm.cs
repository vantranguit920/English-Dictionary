using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV_Dictionary
{
    public partial class frmListen : Form
    {
        public frmListen()
        {
            InitializeComponent();
            path = "";
            write = "";
        }
        #region Properties

        private string path;
        private string write;
        Boolean flag;
        int curX = 0;
        int curY = 0;

        #endregion

        #region Moving form

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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove();
        }

        #endregion

        #region Event

        public string getpath(int x)
        {
            path = Application.StartupPath + @"\Audio\Bai" + x.ToString() + ".mp3";
            return path;
        }
        public string getwrite(int x)
        {
            string str2;
            str2 = @"\Write\write" + x.ToString() + ".txt";
            FileStream fs = new FileStream(Application.StartupPath + str2, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.Default);
            write = rd.ReadToEnd();
            rd.Close();
            fs.Close();
            return write;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            try
            {
                axWindowsMediaPlayer1.URL = getpath(listBox1.SelectedIndex);
                txtInfor.Clear();
                txtInfor.Text = getwrite(listBox1.SelectedIndex);

            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại");
                txtInfor.Text = x.ToString();
            }
        }
        private void mtlClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            panel4.Size = new Size(800, 100);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            panel4.Size = new Size(800, 330);
        }

        #endregion

    }
}
