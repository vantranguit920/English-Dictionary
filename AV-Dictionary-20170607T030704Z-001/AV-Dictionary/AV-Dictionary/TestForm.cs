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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace AV_Dictionary
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        int n = 0;
        string[] Astr;
        int k = 0;
        SpeechRecognitionEngine Regcon = new SpeechRecognitionEngine();
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void getline(ref int n)
        {
            string str = null;
            string path = "\\Test\\Word.txt";
            FileStream fs = new FileStream(Application.StartupPath+path,FileMode.Open);
            StreamReader Rd = new StreamReader(fs,Encoding.Default);
            do
            {
                str = Rd.ReadLine();
                if (str != null)
                { n = n + 1; }

            } while (str != null);
            Rd.Close();
        }
        private void loadword(ref string[] str, int j)
        {
            string path1 = @"\Test\Word.txt";
            FileStream fs = new FileStream(Application.StartupPath + path1, FileMode.Open);
            StreamReader Rds = new StreamReader(fs,Encoding.Default);
            str = new string[j];
            for (int i = 0; i < n; i++)
            {
                str[i] = Rds.ReadLine();
            }
            Rds.Close();

        }
        private void mtlClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Choices choice = new Choices();
            getline(ref n);
            loadword(ref Astr, n);
            choice.Add(Astr);
            GrammarBuilder grb = new GrammarBuilder();
            grb.Append(choice);
            Grammar gra = new Grammar(grb);
            Regcon.LoadGrammarAsync(gra);
            Regcon.SetInputToDefaultAudioDevice();
            Regcon.SpeechRecognized += Regcon_SpeechRecognized;
        }

        private void Regcon_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            if (e.Result.Text == textBox1.Text)
            {
                MessageBox.Show("Good!");
                Regcon.RecognizeAsyncStop();
                metroButton2.Enabled = true;

            }
            else
            {
                MessageBox.Show("No!");
                Regcon.RecognizeAsyncStop();
                metroButton2.Enabled = true;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Astr[k];
            if (k < n - 1)
            {
                k++;
            }

            Regcon.RecognizeAsyncStop();
            metroButton2.Enabled = true;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Astr[k];
            if (0<k)
            {
                k--;
            }
            metroButton2.Enabled = true;
            Regcon.RecognizeAsyncStop();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Regcon.RecognizeAsync(RecognizeMode.Multiple);
            metroButton2.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            sp.SpeakAsync(textBox1.Text);
            metroButton2.Enabled = true;
            Regcon.RecognizeAsyncStop();
        }
    }
}
