using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms.Design;
using System.IO.Compression;

namespace dolgozat_javito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private const string csc_path = "C:\\Windows\\Microsoft.NET\\Framework\\v3.5\\csc.exe";
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String src = openFileDialog1.FileName;
                string filepath = "";
                string filename = "";
                for (int i = src.Length - 1; i >= 0; i--)
                {

                    if (src[i] == '\\')
                    {
                        filepath = src.Substring(0, i);
                        break;
                    }
                    else
                    {
                        filename += src[i];
                    }
                }
                filename = Reverse(filename);
                label2.Text = filename;
                _filename = filename;
                _pathname = filepath;
            }

        }
        private string _filename = "";
        private string _pathname = "";
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ExecuteCommand(string filepath, string filename, string[]? param)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true,
                        RedirectStandardError = true,
                        FileName = "cmd.exe",
                        Arguments = $"/c cd {filepath} && {csc_path} {filename}.cs && {filename}.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };

                proc.Start();
                foreach (var item in param)
                {
                    proc.StandardInput.WriteLine(item);
                }
                string result = proc.StandardOutput.ReadToEnd();
                return result;
            }
            catch (Exception e)
            {
                return "ExecuteCommandSync failed" + e.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (_pathname == "" || _filename == "")
            {
                MessageBox.Show("Nincs file kiválasztva!");
                return;
            }
            string[] args = [];
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                args = textBox2.Text.Split(";");
            }
            //textBox1.Text = ExecuteCommand(_pathname, _filename.Replace(".cs", ""), args);
            string s = ExecuteCommand(_pathname, _filename.Replace(".cs", ""), args);
            bool b = false;
            string res = "Output: ";
            foreach (string word in s.Split(" "))
            {
                if (b)
                {
                    res += word + " ";
                }
                if (word.Contains("\r\n\r"))
                {
                    b = true;
                    res += word.Substring(14) + " ";
                }
            }
            richTextBox1.Text = res.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    this.folder = fbd.SelectedPath;
                    string[] folder = fbd.SelectedPath.Split("\\");

                    label4.Text = "";
                    richTextBox2.Text = "";
                    for (int i = folder.Length - 1; i > folder.Length - 2 && i >= 0; i--)
                    {
                        label4.Text = folder[i] + label4.Text;
                    }
                    if (folder.Length > 2)
                    {
                        label4.Text = "..." + label4.Text;
                    }
                    files.Where(x => x.Contains(".zip")).ToList().ForEach(x => this.files.Add(x.Replace(fbd.SelectedPath + "\\", "")));
                    foreach (string item in this.files)
                    {
                        richTextBox2.Text += item + "\n";
                    }
                }
            }
        }
        private string folder = "";
        private List<string> files = new();
        private void button4_Click(object sender, EventArgs e)
        {
            if (folder == "") {
                MessageBox.Show("Hibás elérési út!");
                return;
            }
            int count = 0;
            foreach (string item in this.files)
            {
                try
                {
                    var zipPath = folder + "\\" + item;
                    ZipFile.ExtractToDirectory(zipPath, folder + "\\" + item.Replace(".zip", ""));
                    count++;
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.ToString());
                }
            }
            MessageBox.Show(count + "db állomány ki lett csomagolva.");
        }
    }
}
