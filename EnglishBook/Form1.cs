using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;
using System.ComponentModel;

namespace EnglishBook
{
    public partial class Form1 : Form
    {
        private Button[] btnAdd = new Button[10];
        string dirName = "C://Program Files (x86)/englishbook/";
        int lol = 0;
        bool[] dirorfile = new bool[10];
        string kek;
        //string[] namedirfiles;
        string[] namedirfiles = new string[10];

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            dircheck();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void but_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (dirorfile[int.Parse(button.Name)])
            {
                Process.Start(namedirfiles[int.Parse(button.Name)]);
            }
            else
            {
                for(int i = 0; i != lol; i++)
                {
                    btnAdd[i].Visible = false;
                }
                dirName = namedirfiles[int.Parse(button.Name)];
                lol = 0;
                dircheck();
            }
        }

        void dircheck()
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                    btnAdd[lol] = new Button();
                    this.Controls.Add(btnAdd[lol]);
                    this.btnAdd[lol].Visible = true;
                    this.btnAdd[lol].Name = lol.ToString();
                    namedirfiles[lol] = s.ToString();
                    string name123 = namedirfiles[lol].Substring(36);
                    label2.Text = "";
                    while (name123.IndexOf("\\") != -1)
                    {
                        label2.Text = name123.Substring(0, name123.IndexOf("\\"));
                        name123 = name123.Substring(name123.IndexOf("\\") + 1);
                    }
                    label2.Update();
                    this.btnAdd[lol].Text = name123;
                    this.btnAdd[lol].Location = new System.Drawing.Point(30, 130 + lol * 55);
                    this.btnAdd[lol].Size = new System.Drawing.Size(425, 50);
                    this.btnAdd[lol].Click += but_Click;
                    this.btnAdd[lol].ForeColor = SystemColors.ButtonFace;
                    this.btnAdd[lol].Font = new Font("Arial", 18, FontStyle.Bold);
                    dirorfile[lol] = false;
                    lol++;

                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                    btnAdd[lol] = new Button();
                    this.Controls.Add(btnAdd[lol]);
                    this.btnAdd[lol].Visible = true;
                    this.btnAdd[lol].Name = lol.ToString();
                    namedirfiles[lol] = s.ToString();
                    string name123 = namedirfiles[lol].Substring(36);
                    label2.Text = "";
                    while (name123.IndexOf("\\") != -1)
                    {
                        label2.Text = name123.Substring(0, name123.IndexOf("\\"));
                        name123 = name123.Substring(name123.IndexOf("\\")+1);
                    }
                    label2.Update();
                    this.btnAdd[lol].Text = name123;
                    this.btnAdd[lol].Location = new System.Drawing.Point(30, 130 + lol * 55);
                    this.btnAdd[lol].Size = new System.Drawing.Size(425, 50);
                    this.btnAdd[lol].Click += but_Click;
                    this.btnAdd[lol].ForeColor = SystemColors.ButtonFace;
                    this.btnAdd[lol].Font = new Font("Arial", 18, FontStyle.Bold);
                    dirorfile[lol] = true;
                    lol++;
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i != lol; i++)
                {
                    btnAdd[i].Visible = false;
                }
                dirName = "C://Program Files (x86)/englishbook/";
                lol = 0;
                dircheck();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
