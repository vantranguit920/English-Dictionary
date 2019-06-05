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
    public partial class frmGramar : Form
    {
        public frmGramar()
        {
            InitializeComponent();
            this.ActiveControl = panel2;
        }

        #region Moving Form
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
        private void mtlClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDown(e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove();
        }
        #endregion
        #region event
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button1.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button2.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button3.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button4.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button5.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button6.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button7.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button8.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button9.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button10.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button11.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button12.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button13.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button14.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string path = @"\Tense\" + button15.Text + ".txt";
            FileStream f = new FileStream(Application.StartupPath + path, FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.Default);
            textBox1.Text = rd.ReadToEnd();
            f.Close();
            rd.Close();
        }

        #endregion


    }
}
