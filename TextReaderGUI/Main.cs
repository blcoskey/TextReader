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
using TextReaderClasses.Utilities;

namespace TextReaderGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string selectedFilePath
        {
            get
            {
                return tbFilePath.Text;
            }
            set
            {
                tbFilePath.Text = value;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }

        private void LoadNewFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilePath.Text))
            {
                MessageBox.Show("Please select a file");
            }
            else
            {
                var lines = "";
                try
                {
                    lines = File.ReadAllText(tbFilePath.Text).ToString();
                }
                catch (System.IO.FileNotFoundException exception)
                {
                    try
                    {
                        using (StreamWriter w = File.AppendText(@"ErrorLog\ErrorLog.log"))
                        {
                            Log(exception.Message, w);
                        }
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Exception: " + e2.Message);
                    }

                    MessageBox.Show(exception.Message);
                    goto Error;
                }

                TextReaderClasses.Utilities.TextReader reader = new TextReaderClasses.Utilities.TextReader(new ScrabbleScore());

                var words = reader.GetWords(lines);

                var output = reader.CalculateOutput(words);

                tbMostFrequentWord.Text = "Word: " + output.MostFrequentWord.Text + "," +
                    "Length: " + output.MostFrequentWord.Length + "," +
                    "Occurances: " + output.MostFrequentWord.Count + "," +
                    "Score: " + output.MostFrequentWord.Score
                    ;

                tbMostFrequent7LetterWord.Text = "Word: " + output.MostFrequent7LetterWord.Text + "," +
                    "Length: " + output.MostFrequent7LetterWord.Length + "," +
                    "Occurances: " + output.MostFrequent7LetterWord.Count + "," +
                    "Score: " + output.MostFrequent7LetterWord.Score
                    ;

                tbHighestScoredWord.Text = "Word: " + output.HighestScoredWord.Text + "," +
                    "Length: " + output.HighestScoredWord.Length + "," +
                    "Occurances: " + output.HighestScoredWord.Count + "," +
                    "Score: " + output.HighestScoredWord.Score
                    ;

            Error:;
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}

