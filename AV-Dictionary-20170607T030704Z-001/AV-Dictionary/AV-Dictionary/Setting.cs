using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AV_Dictionary
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }
        TextBox txt = new TextBox();
        int x = 0;
        string pathpic;
        private void label1_Click(object sender, EventArgs e)
        {
           
            
           
        }

        private void mtlClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(x)
            {
                case 0:
                    pathpic = "\\GT\\GT1.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath+pathpic);
                    x++;
                    break;
                case 1:
                    pathpic = "\\GT\\GT2.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x++;
                    break;
                case 2:
                    pathpic = "\\GT\\GT3.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x++;
                    break;
                case 3:
                    pathpic = "\\GT\\GT4.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x++;
                    break;
                case 4:
                    pathpic = "\\GT\\GT5.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x++;
                    break;
                case 5:
                    pathpic = "\\GT\\GT6.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            pathpic = "\\GT\\GT1.png";
            ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
            x++;
            string str2;
            str2 = "\\GT\\Gioithieu.txt";
            FileStream fs = new FileStream(Application.StartupPath + str2, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.Default);
            txtGT.Text = rd.ReadToEnd();
            rd.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x > 5) { x = 5; }
            switch (x)
            {
                case 6:
                    pathpic = "\\GT\\GT1.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
                case 5:
                    pathpic = "\\GT\\GT2.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
                case 4:
                    pathpic = "\\GT\\GT3.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
                case 3:
                    pathpic = "\\GT\\GT4.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
                case 2:
                    pathpic = "\\GT\\GT5.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;
                case 1:
                    pathpic = "\\GT\\GT6.png";
                    ptbHD.Image = Image.FromFile(Application.StartupPath + pathpic);
                    x--;
                    break;

            }
        }
    }
}
