using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace AV_Dictionary
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
            //Start Dic with "a"
            mtsbWord.Value = dicManager.GetPosition("a");
            dicManager.LoadWordWithPosition(lbxWord, lbxOffLen, mtsbWord.Value);
            //Control Form
            lbxWord.BorderStyle = BorderStyle.None;
            lbxWord.DrawMode = DrawMode.OwnerDrawFixed;
            wbrDefinition.SendToBack();
        }
        #region Properties

        DictionaryManager dicManager = new DictionaryManager();
        ListBox lbxOffLen = new ListBox();
        SpeechSynthesizer spSyn = new SpeechSynthesizer();

        Boolean flag;
        int curX = 0;
        int curY = 0;

        bool flagSearchMode = false;
        bool flagDisplayMode = false;
        int sbVal = 0;
        int lbxValIndex = 0;

        #endregion

        #region Method


        //Tab
        #region Handle Tab Search Event

        private void mtlSearch_Click(object sender, EventArgs e)
        {
            mtlRecent.BackColor = Color.RoyalBlue;
            mtlRecent.ForeColor = Color.White;
            pnlRecent.Visible = false;

            mtlSearch.BackColor = Color.WhiteSmoke;
            mtlSearch.ForeColor = Color.DimGray;
            pnlSearch.Visible = true;

            mtsbWord.Visible = true;
        }

        #region Handle ScrollBar - mtsbWord Event

        private void mtsbWord_MouseDown(object sender, MouseEventArgs e)
        {
            flagSearchMode = true;
            flagDisplayMode = false;
            //Interact to other control
            mtlSearchOnline.Visible = false;
            mtlSpeaker.Visible = false;
            wbrDefinition.DocumentText = "";
        }

        private void mtsbWord_MouseUp(object sender, MouseEventArgs e)
        {
            flagSearchMode = false;
            flagDisplayMode = false;
            //Interact to other control
            txtSearch.SelectAll();
            txtSearch.Focus();
            lbxWord.SelectedIndex = -1;
        }
        #endregion

        #region Load Word With TextBox - txtSearch

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            flagSearchMode = false;
            flagDisplayMode = false;
            //Interact to other control
            mtlSearchOnline.Visible = false;
            mtlSpeaker.Visible = false;
            wbrDefinition.DocumentText = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (flagSearchMode == false && flagDisplayMode == false)
            {
                lbxValIndex = lbxWord.SelectedIndex = 0;
                dicManager.LoadWordWithText(lbxWord, lbxOffLen, txtSearch.Text);
                mtsbWord.Value = dicManager.GetPosition(txtSearch.Text);
                //Interact to other control
                mtlSpeaker.Visible = false;
            }
            if (txtSearch.Text == "")
            {
                lbxRelated.Visible = false;
            }
            else
            {
                lbxRelated.Visible = true;
                lbxRelated.SelectedIndex = -1;
                dicManager.LoadRelatedWord(lbxRelated, txtSearch.Text);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dicManager.isExistent == false)
                {
                    wbrDefinition.DocumentText = "<html><body><p><font size=\"5\" color=\"gray\">Can't find</font></p></body></html>";
                    lbxValIndex = lbxWord.SelectedIndex = -1;
                    lbxRelated.Visible = false;
                    //Interact to other control
                    mtlSearchOnline.Visible = true;
                }
                else
                {
                    DisplayDefinition(mtsbWord.Value);
                    //Interact to other control
                    mtlSpeaker.Visible = true;
                    mtlSearchOnline.Visible = false;
                }
            }
        }

        #endregion

        #region Handle Controlling Of ListBox - lbxWord

        private void lbxWord_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, Color.White, Color.LightGreen);

            e.DrawBackground();
            e.Graphics.DrawString(lbxWord.Items[e.Index].ToString(), e.Font, Brushes.Gray, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void lbxWord_MouseClick(object sender, MouseEventArgs e)
        {
            flagDisplayMode = true;
            flagSearchMode = true;
            if (lbxValIndex != lbxWord.SelectedIndex)
            {
                sbVal = mtsbWord.Value -= lbxValIndex;
                sbVal = mtsbWord.Value += lbxWord.SelectedIndex;
            }
            lbxValIndex = lbxWord.SelectedIndex;

            txtSearch.Text = lbxWord.Items[lbxValIndex].ToString().Trim();

            DisplayDefinition(lbxValIndex);
            //Interact to other control
            mtlSearchOnline.Visible = false;
            mtlSpeaker.Visible = true;
        }

        private void lbxWord_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    lbxValIndex--;
                    sbVal = mtsbWord.Value -= 1;
                    if (lbxValIndex >= 0)
                    {
                        DisplayDefinition(lbxValIndex);
                    }
                    break;

                case Keys.Down:
                    lbxValIndex++;
                    sbVal = mtsbWord.Value += 1;
                    if (lbxValIndex <= 14)
                    {
                        DisplayDefinition(lbxValIndex);
                    }
                    break;

                default:
                    break;
            }
        }

        #endregion

        #endregion

        #region Handle Tab Recent Event

        private void mtlRecent_Click(object sender, EventArgs e)
        {
            mtlSearch.BackColor = Color.RoyalBlue;
            mtlSearch.ForeColor = Color.White;
            pnlSearch.Visible = false;

            mtlRecent.BackColor = Color.WhiteSmoke;
            mtlRecent.ForeColor = Color.DimGray;
            pnlRecent.Visible = true;

            lbxValIndex = lbxWord.SelectedIndex = -1;
            mtlSearchOnline.Visible = false;
            wbrDefinition.DocumentText = "";
            mtsbWord.Visible = false;

            dicManager.Push(lbxRecent);
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            if (flagSearchMode == true && flagDisplayMode == false)
            {
                if (mtsbWord.Value != sbVal)
                {
                    dicManager.LoadWordWithPosition(lbxWord, lbxOffLen, mtsbWord.Value);
                    if (mtsbWord.Value >= 108843)
                    {
                        txtSearch.Text = lbxWord.Items[mtsbWord.Value - 108843 - 1].ToString().Trim();
                    }
                    else
                    {
                        txtSearch.Text = lbxWord.Items[0].ToString().Trim();

                    }
                    //Interact to other control
                    txtSearch.SelectAll();
                    txtSearch.Focus();
                    lbxValIndex = lbxWord.SelectedIndex = -1;
                    sbVal = mtsbWord.Value;
                }
            }

            if (flagDisplayMode == true && flagDisplayMode == true)
            {
                if (lbxValIndex < 0)
                {
                    dicManager.LoadWordWithPosition(lbxWord, lbxOffLen, mtsbWord.Value);

                    lbxValIndex = lbxWord.SelectedIndex = 0;

                    DisplayDefinition(lbxValIndex);
                }
                if (lbxValIndex > 14)
                {
                    dicManager.LoadWordWithPosition(lbxWord, lbxOffLen, mtsbWord.Value - 14);

                    lbxValIndex = lbxWord.SelectedIndex = 14;

                    DisplayDefinition(lbxValIndex);
                }
                txtSearch.Text = lbxWord.Items[lbxValIndex].ToString().Trim();
            }
        }


        //Control
        #region Handle Moving Form

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
        //HeadPanel2
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
        //
        //HeadPanel2
        //
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            curX = e.X + 275;
            curY = e.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseUp();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            HandleMouseMove();
        }


        #endregion

        private void mtlClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void mtlSpeaker_Click(object sender, EventArgs e)
        {
            spSyn.Speak(lbxWord.SelectedItem.ToString().Trim());
            flagDisplayMode = true;
            flagSearchMode = true;
            lbxWord.Focus();
        }


        //Other
        public void DisplayDefinition(int valIndex)
        {
            string meaning = "";

            meaning = dicManager.GetMeaning(lbxOffLen.Items[lbxValIndex].ToString());

            dicManager.SetRecentWord(lbxWord.Items[lbxValIndex].ToString().Trim());

            meaning = meaning.Replace(" - ", "-");
            meaning = meaning.Replace(" = ", "=");
            meaning = meaning.Replace("\n", " ");
            meaning = meaning.Trim();

            meaning = meaning.Replace(" /", "</font></p><p><font size=\"4\" color=\"gray\">/");
            meaning = meaning.Replace("/ ", "/</font></p><p>");
            meaning = meaning.Replace("* ", "</font></p><p><font size=\"5\" color=\"#0B2567\">");
            meaning = meaning.Replace("- ", "</font></p><p><font size=\"4\">- ");
            meaning = meaning.Replace(" =", "</font></p><p><font size=\"4\"><i>Ex: ");
            meaning = meaning.Replace("+", "</i></font></p><p><font size=\"4\" color=\"gray\">");
            meaning = meaning.Replace("@", "<p><font size=\"6\" color=\"#10F22A\">");
            meaning = "<html><body>" + meaning + "</font></p></body></html>";

            wbrDefinition.DocumentText = meaning;

        }

        private void mtlSearchOnline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tratu.soha.vn");
        }

        #endregion

        private void lbxRelated_MouseUp(object sender, MouseEventArgs e)
        {
            flagSearchMode = false;
            flagDisplayMode = false;
            txtSearch.Text = lbxRelated.Items[lbxRelated.SelectedIndex].ToString();
            DisplayDefinition(mtsbWord.Value);
            //Interact to other control
            lbxWord.SelectedIndex = -1;
            mtlSearchOnline.Visible = false;
            mtlSpeaker.Visible = true;
        }

        private void lbxRecent_MouseUp(object sender, MouseEventArgs e)
        {
            flagSearchMode = false;
            flagDisplayMode = false;
            txtSearch.Text = lbxRecent.Items[lbxRecent.SelectedIndex].ToString();
            DisplayDefinition(mtsbWord.Value);
            //Interact to other control
            mtlSearchOnline.Visible = false;
            mtlSpeaker.Visible = true;
        }
    }
}
