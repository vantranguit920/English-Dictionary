using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;
using System.Windows.Forms;

namespace AV_Dictionary
{
    class DictionaryManager
    {
        #region Properties

        private string offsetFilePath = Properties.Settings.Default._offsetFilePath;
        private string meaningFilePath = Properties.Settings.Default._meaningFilePath;
        private string recentFilePath = Properties.Settings.Default._recentFilePath;
        private int numOfWord = Properties.Settings.Default._numOfWord;
        public bool isExistent = false;

        #endregion

        #region Method

        public int GetDecimalValue(string s)
        {
            string base64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
            int decValue = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                int pos = base64.IndexOf(s[i]);
                decValue += (int)Math.Pow(64, length - i - 1) * pos;
            }

            return decValue;
        }

        public int GetPosition(string text)
        {
            int counter = 0;
            string line = "";

            FileStream fs = new FileStream(offsetFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);

            while ((line = sr.ReadLine()) != null)
            {
                counter++;
                if (line.Contains(text) && line.IndexOf(text) == 0)
                {
                    isExistent = true;
                    break;
                }
                isExistent = false;
            }

            sr.Close();

            return counter;
        }

        public void LoadWordWithPosition(ListBox listWord, ListBox listOffLen, int position)
        {
            listOffLen.Items.Clear();

            string word = "";
            string sWord = "";
            string sData = "";
            string[] lines = new string[15];

            if (position >= numOfWord - 14)
            {
                lines = File.ReadLines(offsetFilePath).Skip(numOfWord - 15).Take(15).ToArray();
            }
            else
            {
                lines = File.ReadLines(offsetFilePath).Skip(position - 1).Take(15).ToArray();

            }

            for (int i = 0; i < 15; i++)
            {
                if (lines[i].Length >= 2)
                {
                    word = lines[i];

                    int pos = word.IndexOf("\t");
                    sWord = word.Substring(0, pos);
                    sData = word.Substring(pos + 1, word.Length - pos - 1);

                    if (sData.IndexOf("\n") > 0)
                    {
                        sData = sData.Substring(0, sData.Length - 1);
                    }

                    if (sWord.Length >= 1)
                    {
                        listWord.Items[i] = "    " + sWord;
                        listOffLen.Items.Add(sData);
                    }
                }
            }
        }

        public void LoadWordWithText(ListBox listWord, ListBox listOffLen, string text)
        {
            LoadWordWithPosition(listWord, listOffLen, GetPosition(text));
        }
        public void LoadRelatedWord(ListBox listRelated, string text)
        {
            int position = GetPosition(text) - 7;

            string word = "";
            string sWord = "";
            string[] lines = new string[15];

            if (position >= numOfWord - 14)
            {
                lines = File.ReadLines(offsetFilePath).Skip(numOfWord - 15).Take(15).ToArray();
            }
            else
            {
                if (position<15)
                {
                    lines = File.ReadLines(offsetFilePath).Skip(0).Take(15).ToArray();
                }
                else
                {
                    lines = File.ReadLines(offsetFilePath).Skip(position - 1).Take(15).ToArray();
                }             
            }

            for (int i = 0; i < 15; i++)
            {
                if (lines[i].Length >= 2)
                {
                    word = lines[i];

                    int pos = word.IndexOf("\t");
                    sWord = word.Substring(0, pos);

                    if (sWord.Length >= 1)
                    {
                        listRelated.Items[i] = sWord;
                    }
                }
            }
        }
        public void SetRecentWord(string text)
        {
            if (Has(text))
            {
                return;
            }
            StreamWriter sw = new StreamWriter(recentFilePath, true, Encoding.UTF8);
            sw.WriteLine(text);
            sw.Close();
        }
        public bool Has(string text)
        {
            string line = "";
            FileStream fs = new FileStream(recentFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(text) && line.IndexOf(text) == 0)
                {
                    sr.Close();
                    return true;
                }
            }
            sr.Close();
            return false;
        }
        public void Push(ListBox list)
        {
            list.Items.Clear();
            List<string> lines = new List<string>();
            FileStream fs = new FileStream(recentFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                lines.Add(sr.ReadLine());
            }
            for (int i = lines.Count-1; i > 0; i--)
            {
                list.Items.Add(lines[i]);
            }
            sr.Close();
        }
        public void ResetContent()
        {
            File.WriteAllText(recentFilePath, String.Empty); 
        }
        public string GetMeaning(string sOffLen)
        {
            if (sOffLen != "")
            {
                int iOffset = 0;
                int iLength = 0;
                string offset = "";
                string length = "";

                int pos = sOffLen.IndexOf("\t");

                offset = sOffLen.Substring(0, pos);
                length = sOffLen.Substring(pos + 1);
                iOffset = GetDecimalValue(offset);
                iLength = GetDecimalValue(length);

                using (FileStream fs = File.Open(meaningFilePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] b = new byte[iLength];

                    fs.Position = iOffset;
                    fs.Read(b, 0, b.Length);

                    return System.Text.Encoding.UTF8.GetString(b).Trim();
                }
            }
            isExistent = false;
            return "";
        }

        #endregion
    }
}
