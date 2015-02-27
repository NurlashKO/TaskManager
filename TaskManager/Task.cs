using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task : UserControl
    {
        bool finished;
        public string info, name;
        public int time, curTime, id;

        public Task()
        {
            InitializeComponent();
        }

        public void Init()
        {
            tname.Text = name;
            pgTask.Value = curTime;
            pgTask.Maximum = time;
        }

        private void starter_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            Task t = (Task)b.Parent;
            if (b.Text == "Start")
            {
                b.Text = "Stop";
                t.Status.Text = "Timer Started!";
                t.timer1.Start();
            }
            else
            {
                b.Text = "Start";
                t.Status.Text = "Inactive";
                if (finished)
                    t.Status.Text = "Task is finished";
                t.timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgTask.Maximum == pgTask.Value)
            {
                finished = true;
                starter.PerformClick();
                MessageBox.Show("Task " + name + " is finished! GJ");
                return;
            }
            pgTask.Value++;
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            taskDialogBox dlg = new taskDialogBox(name, info, time);
            dlg.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ((Tasks)this.Parent.Parent).deleteTask(id);
        }
    }
}
