using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Compresson
{
    public partial class frmCompressorForm : Form
    {
        string Data_String;

        public frmCompressorForm()
        {
            InitializeComponent();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            lblTimeElapsed.Text = "From " + DateTime.Now.ToLongTimeString() + " to ";

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string EncodedDataString = "";

                Thread t = new Thread(GetFileData);
                t.Start(ofd.FileName);

                MessageBox.Show("");

                string EncodedData = RunLengthEncoded(Data_String);

                for (int i = 0; i < EncodedDataString.Length; i++)
                {
                    EncodedDataString += EncodedDataString[i].ToString();
                }

                richTextBox1.Text = Data_String;
                richTextBox2.Text = RunLengthEncoded(Data_String);

                lblTimeElapsed.Text += DateTime.Now.ToLongTimeString();
                //byte[] EncodedFileData = Array.ConvertAll(EncodedData, Byte.Parse);
            }
        }

        void GetFileData(object fileName)
        {
            byte[] FileData = File.ReadAllBytes(fileName.ToString());
            Data_String = "";

            for (int i = 0; i < FileData.Length; i++)
            {
                Data_String += FileData[i].ToString() + " ";
            }
        }

        private string RunLengthEncoded(string dataString)
        {
            string[] SplitData = dataString.Split(' ');
            string[] EncodedData = new string[SplitData.Length];
            int[] CharValues = new int[SplitData.Length];
            char[] SplitCharData = new char[SplitData.Length];
            string Encoded = "";

            int CharRepetitionCount = 1;

            for (int i = 0; i < SplitData.Length; i++)
            {
                if (i > 0 && i < SplitData.Length - 1 && SplitData[i] == SplitData[i + 1])
                {
                    CharRepetitionCount++;
                }
                else
                {
                    richTextBox2.Text = SplitData[i];
                    try
                    {
                        CharValues[i] = Convert.ToInt32(SplitData[i]);
                        SplitCharData[i] = Convert.ToChar(CharValues[i]);
                        EncodedData[i] = CharRepetitionCount.ToString() + "x" + SplitCharData[i] + " ";
                        CharRepetitionCount = 1;
                    }
                    catch
                    {

                        MessageBox.Show("no");
                    }
                }

                Encoded += EncodedData[i];
            }

            return Encoded;
        }
    }
}