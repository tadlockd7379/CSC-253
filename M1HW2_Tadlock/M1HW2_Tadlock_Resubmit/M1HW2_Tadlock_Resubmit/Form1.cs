/**
* 9/14/2023
* CSC 253
* Drew Tadlock
* Simple file decryption/encryption
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace M1HW2_Tadlock_Resubmit
{
    public partial class Form1 : Form
    {
        static Dictionary<char, char> encryptionCodes = new Dictionary<char, char>()
        {
           { 'A', '!' }, { 'a', 'q' }, { 'B', 'a' }, { 'b', 'z' }, { 'C', '@' }, { 'c', 'w' },
           { 'D', 's' }, { 'd', 'x' }, { 'E', '#' }, { 'e', 'c' }, { 'F', 'd' }, { 'f', 'e' },
           { 'G', '$' }, { 'g', 'r' }, { 'H', 'f' }, { 'h', 'v' }, { 'I', '%' }, { 'i', 't' },
           { 'J', 'g' }, { 'j', 'b' }, { 'K', '^' }, { 'k', 'y' }, { 'L', 'h' }, { 'l', 'n' },
           { 'M', '&' }, { 'm', 'u' }, { 'N', 'j' }, { 'n', 'm' }, { 'O', '*' }, { 'o', 'i' },
           { 'P', 'k' }, { 'p', '<' }, { 'Q', '(' }, { 'q', 'o' }, { 'R', 'l' }, { 'r', '>' },
           { 'S', ')' }, { 's', 'p' }, { 'T', ':' }, { 't', '/' }, { 'U', '-' }, { 'u', '[' },
           { 'V', '"' }, { 'v', '+' }, { 'W', ']' }, { 'w', '\\'}, { 'X', ';' }, { 'x', '.'},
           { 'Y', ',' }, { 'y', '|' }, { 'Z', '=' }, { 'z', '_' }, { ' ', '~' }, { ',', 'X' },
           { '.', '2' }, { '?', '3' }, { '\n', '\t' }, {'\t', ' ' }
        };

        static Dictionary<char, char> decryptionCodes = encryptionCodes.ToDictionary(x => x.Value, x => x.Key);

        string method;

        public Form1()
        {
            InitializeComponent();
        }

        private void File()
        {
            string fileContent = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);   
            }

            string result = EncryptOrDecrypt(method, fileContent);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        private string EncryptOrDecrypt(string option, string text)
        {
            Dictionary<char, char> dictionaryToUse = option == "encrypt" ? encryptionCodes : decryptionCodes;
            char[] chars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (dictionaryToUse.ContainsKey(text[i]))
                {
                    chars[i] = dictionaryToUse[text[i]];
                }
                else
                {
                    chars[i] = text[i];
                }
            }

            return new string(chars);
        }

        private void encryptButton_CheckedChanged(object sender, EventArgs e)
        {
            method = "encrypt";
            File();
        }

        private void decryptButton_CheckedChanged(object sender, EventArgs e)
        {
            method = "decrypt";
            File();
        }
    }
}
