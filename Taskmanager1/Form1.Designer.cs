namespace Taskmanager1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripProcesses = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPUTIME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeakMemoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoOFHandles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberThreads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEndTask = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ProcessID,
            this.StartTime,
            this.CPUTIME,
            this.MemoryUsage,
            this.PeakMemoryUsage,
            this.NoOFHandles,
            this.NumberThreads});
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1100, 456);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProcesses,
            this.ToolStripThreads});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1124, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // ToolStripProcesses
            // 
            this.ToolStripProcesses.Name = "ToolStripProcesses";
            this.ToolStripProcesses.Size = new System.Drawing.Size(72, 20);
            this.ToolStripProcesses.Text = "Processes";
            this.ToolStripProcesses.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ToolStripThreads
            // 
            this.ToolStripThreads.Name = "ToolStripThreads";
            this.ToolStripThreads.Size = new System.Drawing.Size(61, 20);
            this.ToolStripThreads.Text = "Threads";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Process Name";
            this.ProcessName.Width = 200;
            // 
            // ProcessID
            // 
            this.ProcessID.Text = "ID";
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            // 
            // CPUTIME
            // 
            this.CPUTIME.Text = "Cpu Time";
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.Text = "Memory Usage";
            this.MemoryUsage.Width = 85;
            // 
            // PeakMemoryUsage
            // 
            this.PeakMemoryUsage.Text = "Peak Memory Usage";
            this.PeakMemoryUsage.Width = 150;
            // 
            // NoOFHandles
            // 
            this.NoOFHandles.Text = "No. Of Handles";
            this.NoOFHandles.Width = 120;
            // 
            // NumberThreads
            // 
            this.NumberThreads.Text = "No. Of Threads";
            this.NumberThreads.Width = 120;
            // 
            // BtnEndTask
            // 
            this.BtnEndTask.Location = new System.Drawing.Point(880, 489);
            this.BtnEndTask.Name = "BtnEndTask";
            this.BtnEndTask.Size = new System.Drawing.Size(121, 48);
            this.BtnEndTask.TabIndex = 2;
            this.BtnEndTask.Text = "End Task";
            this.BtnEndTask.UseVisualStyleBackColor = true;
            this.BtnEndTask.Click += new System.EventHandler(this.BtnEndTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 565);
            this.Controls.Add(this.BtnEndTask);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripProcesses;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripThreads;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader ProcessID;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader CPUTIME;
        private System.Windows.Forms.ColumnHeader MemoryUsage;
        private System.Windows.Forms.ColumnHeader PeakMemoryUsage;
        private System.Windows.Forms.ColumnHeader NoOFHandles;
        private System.Windows.Forms.ColumnHeader NumberThreads;
        private System.Windows.Forms.Button BtnEndTask;
    }
}

