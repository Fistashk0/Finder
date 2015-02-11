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
using System.Threading;
using System.Diagnostics;

namespace Finder
{
    public partial class Form1 : Form
    {
     
        private Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        public string message="";
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderTxtbox.Text = op.SelectedPath.ToString();
                string[] textforstartnode = folderTxtbox.Text.Split('\\');
                treeView1.Nodes.Add(textforstartnode[textforstartnode.Length-1]);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                    button1.Text = "Стоп";
                    sw.Start();
                    timer1.Start();
                }
                else { 

                    backgroundWorker1.CancelAsync();
                    button1.Text = "Остановка";
                    button1.Enabled = false;
                }
                
            }
            catch { }
        }
        
        private string[] findall() 
        {
            string[] allFoundFiles = Directory.GetFiles(folderTxtbox.Text.ToString(), filterTxtbox.Text.ToString() + "*", SearchOption.AllDirectories);
            return allFoundFiles;
        }
        private void addfolder(string text,TreeNode tn) 
        {
            tn.Nodes.Add(text);
        }
        private bool findintext(string path) 
        {
            StreamReader str = new StreamReader(path, Encoding.Default);
            while (!str.EndOfStream)
            {
                string st = str.ReadLine();
                if (st.Contains(textTxtbox.Text.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private Int32 isit(string s,TreeNode tn) 
        {
            Int32 i = 0;
            while (i < tn.Nodes.Count)
            {
                if (s == tn.Nodes[i].Text)
                { 
                    return i; }
                i++;
            }
            return -1;
        }
        private void addtotreenode(string[] text,TreeNode tn,Int32 count) 
        {
            if (count < text.Length)
            {
                if (tn != null)
                {
                    if (tn.Nodes.Count == 0)
                    {
                        addfolder(text[count], tn);
                        addtotreenode(text, tn.Nodes[tn.Nodes.Count - 1], count + 1);
                    }
                    else
                    {
                        Int32 thcount = isit(text[count], tn);
                        if (thcount != -1)
                        {
                            addtotreenode(text, tn.Nodes[thcount], count + 1);
                        }
                        else
                        {
                            addfolder(text[count], tn);
                            addtotreenode(text, tn.Nodes[tn.Nodes.Count - 1], count + 1);
                        }
                    }

                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            message = "Выполняется поиск всех файлов с заданным именем";
            string[] pathches = findall();
            Int32 i = 0;
            Int32 all=0;
            string current = "";
            while (backgroundWorker1.CancellationPending == false && i != pathches.Length) 
            {
                string s = pathches[i].Substring(folderTxtbox.Text.ToString().Length);
                string[] ss = s.Split('\\');
                current = ss[ss.Length - 1];
                message = "В данный момент обрабатывается файл : " + current.ToString() + " . Всего найдено файлов " + all.ToString();
                all++;
                if (findintext(pathches[i])) 
                {
                    
                   Invoke(new MethodInvoker(delegate
                    {
                        addtotreenode(ss, treeView1.TopNode, 1);
                    }));
                }
                i++;
            }
            message = "Задача завершена. Всего найдено  " + all.ToString() + " файлов.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Finder.Properties.Settings.Default.Setting != "") 
            {
                folderTxtbox.Text = Finder.Properties.Settings.Default.Setting;
            }

            if (Finder.Properties.Settings.Default.Setting1 != "")
            {
                filterTxtbox.Text = Finder.Properties.Settings.Default.Setting1;
            }

            if (Finder.Properties.Settings.Default.Setting2 != "")
            {
                textTxtbox.Text = Finder.Properties.Settings.Default.Setting2;
            }
            if (folderTxtbox.Text != "") { 

            string[] textforstartnode = folderTxtbox.Text.Split('\\');
            treeView1.Nodes.Add(textforstartnode[textforstartnode.Length - 1]);}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (!backgroundWorker1.IsBusy)
            {

                button1.Enabled = true;
                button1.Text = "Старт";
                timer1.Stop();
                sw.Stop();
            }
            label1.Text = message+" " +sw.Elapsed.Minutes.ToString()+ ":"+ sw.Elapsed.Seconds.ToString();
        }

        #region textboxcleaner
        private void folderTxtbox_Click(object sender, EventArgs e)
        {
            if (folderTxtbox.Text == "Введите путь")
            {
                folderTxtbox.Text = "";
            }
        }

        private void filterTxtbox_Click(object sender, EventArgs e)
        {
            if (filterTxtbox.Text == "Введите путь")
            {
                filterTxtbox.Text = "";
            }
        }

        private void textTxtbox_Click(object sender, EventArgs e)
        {
            if (textTxtbox.Text == "Введите текст в файле")
            {
                textTxtbox.Text = "";
            }

        }
        #endregion

    }
}
