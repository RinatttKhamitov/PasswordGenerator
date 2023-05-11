using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PasswordGenerator
{
    public partial class PasswordGenerateForm : Form
    {
        public PasswordGenerateForm()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (checkBoxCurse.Checked)
            {
                CursePasswordGenerate();
                return;
            }
            if (passwordLenght.Text.Equals(string.Empty))
            {
                return;
            }
            int len = int.Parse(passwordLenght.Text);

            List<char> allChar = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            List<char> allNum = new List<char>() { '2','3','4','5','6','7','8','9'};

            List<char> strangeChar   = new List<char>() { 'i', 'l', '1', 'L', 'o', '0', 'O' };

            List<char> mixedChar = new List<char>() { '{', '}', '[', ']', '(', ')', '/', '\\', '\'', '\"', '`', '~', ';', ':', '.', '<', '>'};
            allChar.AddRange(allNum);
            if (!checkBoxMixedChar.Checked)
            {
                allChar.AddRange(mixedChar);
            }
            if (!checkBoxStrnChar.Checked)
            {
                allChar.AddRange(strangeChar);
            }

            string password = "";
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                password = password + allChar[rand.Next(0, allChar.Count())];
            }
            textBoxPassword.Text = password;
        }

        private void CursePasswordGenerate()
        {
            List<string> сurseList = new List<string> { };
            string path = $"..\\..\\Resources\\badwords.txt";
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    сurseList.Add(line);
                }
            }
            if (passwordLenght.Text.Equals(string.Empty))
            {
                return;
            }
            int len = int.Parse(passwordLenght.Text);
            textBoxPassword.Text = CurseString(сurseList, "", len);
        }
        private static Random rnd = new Random();

        string CurseString(List<string> сurseList, string str, int len)
        {
            if (str.Length < len)
            {
                
                str = str + сurseList[rnd.Next(0, сurseList.Count)];
                return CurseString(сurseList, str, len);
            }
            if (str.Length > len)
            {
                return str.Substring(0, len);
            }
            return str;
        }
    }
}
