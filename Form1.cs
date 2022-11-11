using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr5SimHomoCrypt
{
    public partial class Form1 : Form
    {
        string[] alphabetLetter = new string[33];
        string[] alphabetCode = new string[32];
        public Form1()
        {
            InitializeComponent();
            FillAlphabetLetter();
            FillAlphabetCode();
        }

        void FillAlphabetLetter()
        {
            int i = 0;
            for (char c = 'А'; c <= 'Я'; c++)
            {
                alphabetLetter[i] = c.ToString();
                i++;
            }

        }
        void FillAlphabetCode()
        {
            for (int i = 0; i < alphabetCode.Length; i++)
            {
                if (i + 1 < 10)
                {
                    alphabetCode[i] = "0" + (i + 1).ToString();
                }
                else { alphabetCode[i] = (i + 1).ToString(); }
            }

        }

        public bool IsValidEnterStroke(string stroke, string regEx)
        {
            Regex regex = new Regex(regEx);
            return regex.IsMatch(stroke);
        }
        string MatchLetterToCode(string letter)
        {
            return alphabetCode[Array.IndexOf(alphabetLetter, letter)]; ;
        }

        string EncryptStroke(string stroke)
        {
            string encryptedStroke = "";

            for (int i = 0; i < stroke.Length; i++)
            {
                encryptedStroke += MatchLetterToCode(stroke[i].ToString());
            }

            return encryptedStroke;
        }
        string MatchCodeToLetter(string code)
        {
            return alphabetLetter[Array.IndexOf(alphabetCode, code)]; ;
        }
        string DecryptStroke(string stroke)
        {
            string decryptedStroke = "";
            string codeLetter = "";

            int separator = 1;

            for (int i = 0; i < stroke.Length; i++)
            {
                codeLetter += stroke[i];
                separator++;
                if (separator > 2)
                {
                    decryptedStroke += MatchCodeToLetter(codeLetter);
                    codeLetter = "";
                    separator = 1;
                }
            }

            return decryptedStroke;
        }
        private void encryptB_Click(object sender, EventArgs e)
        {
            if (IsValidEnterStroke(enterTextTBX.Text, @"^[А-Я\s]+$"))
            {
                string encryptedStroke = "";

                encryptedStroke = EncryptStroke(enterTextTBX.Text);

                encryptedTextTBX.Text = encryptedStroke;
            }
            else { MessageBox.Show("Можно вводить только заглавные буквы русского алфавита от А до Я, кроме Ё"); }
        }

        private void enterTextTBX_TextChanged(object sender, EventArgs e)
        {
            encryptedTextTBX.Text = "";
            decryptedTextTBX.Text = "";
        }

        private void decryptB_Click(object sender, EventArgs e)
        {
            string decryptedStroke = "";

            decryptedStroke = DecryptStroke(encryptedTextTBX.Text);

            decryptedTextTBX.Text = decryptedStroke;
        }
    }
}
