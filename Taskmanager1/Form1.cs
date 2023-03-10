using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskmanager1
{
    public partial class Form1 : Form
    {

        #region User Defined Variables.
        public static string newprocpathandparm, mcname;
        //public static frmnewprcdetails objnewprocess;
        public System.Threading.Timer t = null;
        public System.Threading.Timer tclr = null;
        public bool erroccured = false;
        private System.Windows.Forms.MenuItem menuItem17 = null;
        public Hashtable presentprocdetails;
        public Process[] processes = null;
        #endregion

        #region User defined Methods.

        private void LoadAllProcessesOnStartup()
        {
            Process[] processes = null;
            try
            {
                processes = Process.GetProcesses(mcname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                return;
            }
            int threadscount = 0;
            foreach (Process p in processes)
            {
                try
                {
                    string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                    ListViewItem proc = new ListViewItem(prcdetails);
                    listView1.Items.Add(proc);
                    threadscount += p.Threads.Count;
                }
                catch { }
            }
            ToolStripProcesses.Text = "Processes : " + processes.Length.ToString();
            ToolStripThreads.Text = "Threads : " + (threadscount + 1).ToString();
        }

        private void LoadAllProcesses(object temp)
        {
            try
            {
                presentprocdetails.Clear();
                processes = Process.GetProcesses(mcname);
                bool runningproccountchanged = false;
                Hashtable lvprocesses = null;
                int threadscount = 0;
                foreach (Process p in processes)
                {
                    try
                    {
                        string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                        presentprocdetails.Add(prcdetails[1], prcdetails[0].ToString() + "#" + prcdetails[2].ToString() + "#" + prcdetails[3].ToString() + "#" + prcdetails[4].ToString() + "#" + prcdetails[5].ToString() + "#" + prcdetails[6].ToString() + "#" + prcdetails[7].ToString());
                        threadscount += p.Threads.Count;
                    }
                    catch { }
                }
                if ((processes.Length != listView1.Items.Count) || erroccured)
                {
                    runningproccountchanged = true;
                    lvprocesses = new Hashtable();
                    foreach (ListViewItem item in listView1.Items)
                    {
                        lvprocesses.Add(item.SubItems[1].Text, "");
                    }
                }
                if (runningproccountchanged || erroccured)
                {
                    erroccured = false;
                    foreach (Process p in Process.GetProcesses(mcname))
                    {
                        try
                        {
                            if (!lvprocesses.Contains(p.Id.ToString()))
                            {
                                string[] newprcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                                ListViewItem newprocess = new ListViewItem(newprcdetails);
                                listView1.Items.Add(newprocess);
                            }
                            IDictionaryEnumerator enlvprocesses = lvprocesses.GetEnumerator();
                            while (enlvprocesses.MoveNext())
                            {
                                if (!presentprocdetails.Contains(enlvprocesses.Key))
                                {
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.SubItems[1].Text.ToString().ToUpper() == enlvprocesses.Key.ToString().ToUpper())
                                        {
                                            listView1.Items.Remove(item);
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
                IDictionaryEnumerator enpresentprodetails = presentprocdetails.GetEnumerator();
                bool valchanged = false;
                while (enpresentprodetails.MoveNext())
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text.ToString().ToUpper() == enpresentprodetails.Key.ToString().ToUpper())
                        {
                            string[] presentprocessdetails = enpresentprodetails.Value.ToString().Split('#');
                            if (item.SubItems[3].Text.ToString() != presentprocessdetails[2].ToString())
                            {
                                valchanged = true;
                                item.SubItems[3].Text = presentprocessdetails[2].ToString();
                            }
                            if (item.SubItems[4].Text.ToString() != presentprocessdetails[3].ToString())
                            {
                                valchanged = true;
                                item.SubItems[4].Text = presentprocessdetails[3].ToString();
                            }
                            if (item.SubItems[5].Text.ToString() != presentprocessdetails[4].ToString())
                            {
                                valchanged = true;
                                item.SubItems[5].Text = presentprocessdetails[4].ToString();
                            }
                            if (item.SubItems[6].Text.ToString() != presentprocessdetails[5].ToString())
                            {
                                valchanged = true;
                                item.SubItems[6].Text = presentprocessdetails[5].ToString();
                            }
                            if (item.SubItems[7].Text.ToString() != presentprocessdetails[6].ToString())
                            {
                                valchanged = true;
                                item.SubItems[7].Text = presentprocessdetails[6].ToString();
                            }
                            if (menuItem17.Checked)
                            {
                                valchanged = false;
                            }
                            if (valchanged)
                            {
                                item.ForeColor = Color.Red;
                                valchanged = false;
                            }
                            else
                            {
                                item.ForeColor = Color.Black;
                            }
                            break;
                        }
                    }
                }
                ToolStripProcesses.Text = "Processes : " + processes.Length.ToString();
                ToolStripThreads.Text = "Threads : " + (threadscount + 1).ToString();
            }
            catch { }
        }

        #endregion


        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count >= 1)
            {
                try
                {
                    int selectedpid = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text.ToString());
                    Process.GetProcessById(selectedpid, mcname).Kill();
                }
                catch
                {
                    erroccured = true;
                }
            }
        }

      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEndTask_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >= 1)
            {
                try
                {
                    int selectedpid = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text.ToString());
                    Process.GetProcessById(selectedpid, mcname).Kill();
                }
                catch
                {
                    erroccured = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            mcname = ".";
            presentprocdetails = new Hashtable();
            LoadAllProcessesOnStartup();
            System.Threading.TimerCallback timerDelegate =
                new System.Threading.TimerCallback(this.LoadAllProcesses);
            t = new System.Threading.Timer(timerDelegate, null, 1000, 1000);
        }
    }
}
