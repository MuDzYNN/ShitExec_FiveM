using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace shit_not_exec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            timer1.Start();
            string appData = Environment.GetEnvironmentVariable("LocalAppData");
            string fivemDir = appData + @"\FiveM\";
            textBox1.Text = fivemDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int a = 255;
        int r = 244;
        int g = 65;
        int b = 65;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (r <= 65)
                {
                    timer1.Stop();
                    timer2.Start();

                }
            }

            if (b <= 65)
            {
                r += 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (r >= 244)
                {
                    timer1.Stop();
                    timer2.Start();

                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (g >= 244)
                {
                    timer2.Stop();
                    timer3.Start();

                }
            }

            if (r >= 244)
            {
                g -= 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (g <= 65)
                {
                    timer2.Stop();
                    timer3.Start();

                }
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (b >= 244)
                {
                    timer3.Stop();
                    timer1.Start();

                }
            }

            if (g >= 244)
            {
                b -= 1;
                button1.ForeColor = Color.FromArgb(a, r, g, b);
                button2.ForeColor = Color.FromArgb(a, r, g, b);
                button3.ForeColor = Color.FromArgb(a, r, g, b);
                button4.ForeColor = Color.FromArgb(a, r, g, b);
                label1.ForeColor = Color.FromArgb(a, r, g, b);
                label2.ForeColor = Color.FromArgb(a, r, g, b);
                label3.ForeColor = Color.FromArgb(a, r, g, b);
                label4.ForeColor = Color.FromArgb(a, r, g, b);
                button5.ForeColor = Color.FromArgb(a, r, g, b);
                button6.ForeColor = Color.FromArgb(a, r, g, b);
                textBox1.ForeColor = Color.FromArgb(a, r, g, b);
                if (b <= 65)
                {
                    timer3.Stop();
                    timer1.Start();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "LUA")
            {
                comboBox2.Items.Insert(0, "DOPAMINE");
                comboBox2.Items.Insert(1, "FALOUT");
                comboBox2.Items.Insert(2, "LYNX");
                comboBox2.Items.Insert(3, "Editor");
            }
            if (comboBox1.Text == "JS")
            {
                comboBox2.Items.Insert(0, "Editor");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "LUA")
            {
                if (comboBox2.Text == "DOPAMINE")
                {
                    using (WebClient client = new WebClient())
                    {
                        string code = client.DownloadString("https://pastebin.com/raw/feH2kvRD");
                        fastColoredTextBox1.Text = code;
                    }
                }
                else if (comboBox2.Text == "FALOUT")
                {
                    using (WebClient client = new WebClient())
                    {
                        string code = client.DownloadString("https://pastebin.com/raw/b3ndcypT");
                        fastColoredTextBox1.Text = code;
                    }
                }
                else if (comboBox2.Text == "LYNX")
                {
                    using (WebClient client = new WebClient())
                    {
                        string code = client.DownloadString("https://pastebin.com/raw/qMg7KEMt");
                        fastColoredTextBox1.Text = code;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string fivemPath = @"\FiveM.app\citizen\scripting\lua\scheduler.lua";
            bool fivemStarted = false;
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    if (process.ProcessName == "FiveM_GTAProcess")
                    {
                        fivemStarted = true;
                    }
                }
            }

            if (!fivemStarted)
            {
                MessageBox.Show("First open your FiveM!", "SHIT EXEC",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.AppendAllText(path + fivemPath, Environment.NewLine + "AddEventHandler('playerSpawned', function()" + Environment.NewLine + "if GetCurrentResourceName() == 'spawnmanager' then" + Environment.NewLine + fastColoredTextBox1.Text + Environment.NewLine + "end" + Environment.NewLine + "end)");
            label4.Text = "INJECTED!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string backupDir = @"C:\MuDzYn";
            string backupFile = @"\scheduler.lua.backup";
            string appData = textBox1.Text;
            string fileDir = appData + @"\FiveM.app\citizen\scripting\lua";
            string scheluder = @"\scheduler.lua";

            if (!System.IO.Directory.Exists(backupDir))
            {
                System.IO.Directory.CreateDirectory(backupDir);
            }
            if (System.IO.Directory.Exists(fileDir))
            {
                System.IO.File.Copy(fileDir+scheluder, backupDir + backupFile, true);
                label4.Text = "BACKUP CREATED!";
            } else
            {
                label4.Text = "DIRECTORY DOESN'T EXIST!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string backupDir = @"C:\MuDzYn\scheduler.lua.backup";
            if (!System.IO.File.Exists(backupDir))
            {
                label4.Text = "YOU DOESN'T HAVE A BACKUP FILE!";
                return;
            }
            string fileDir = textBox1.Text + @"\FiveM.app\citizen\scripting\lua\scheduler.lua";
            System.IO.File.Copy(backupDir, fileDir, true);
            label4.Text = "FILE RESTORED!";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
