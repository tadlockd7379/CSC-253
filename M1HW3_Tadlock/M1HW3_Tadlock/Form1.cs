/**
* 9/14/2023
* CSC 253
* Drew Tadlock
* Open a file and write a file with the line numbers a word occurs
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace M1HW3_Tadlock
{
    public partial class Form1 : Form
    {
        string fileContent;
        string result;

        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

        public Form1()
        {
            InitializeComponent();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
            }

            string[] lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int line = 0; line < lines.Length; line++)
            {
                string[] words = Regex.Split(lines[line], @"\s+");

                foreach (string word in words)
                {
                    if (!dictionary.ContainsKey(word))
                    {
                        dictionary[word] = new List<int>();
                    }

                    dictionary[word].Add(line + 1);
                }
            }
            foreach (var pair in dictionary)
            {
                result += $"{pair.Key}: {string.Join(" ", pair.Value)}\n";
            }

            Console.WriteLine(result);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, result);
            }

            System.Environment.Exit(0);
        }
    }
}
