using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }
        List<Task> tasks = new List<Task>();
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("SaveTasks.ini"))
                {
                    while (!sr.EndOfStream)
                    {
                        string name = sr.ReadLine();
                        string info = sr.ReadLine();
                        int curTime = Convert.ToInt32(sr.ReadLine());
                        int time = Convert.ToInt32(sr.ReadLine());
                        addTask(createTask(name, info, time, curTime));
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private Task createTask(string name, string info, int time, int curTime = 0)
        {
            Task task = new Task();
            if (tasks.Count == 0)
                task.Top = 0;
            else
                task.Top = tasks.Last().Top + task.Height;
            task.Name = "Task " + (tasks.Count + 1);
            task.name = name;
            task.info = info;
            task.time = time;
            task.id = cnt++;
            task.curTime = curTime;
            task.Init();
            return task;
        }

        void addTask(Task t)
        {
            tasks.Add(t);
            this.panel1.Controls.Add(t);
            panel1.Refresh();
            Refresh();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            taskDialogBox dlg = new taskDialogBox();

            if (dlg.ShowDialog() == DialogResult.OK)
                addTask(createTask(dlg.name, dlg.info, dlg.time * 60));
        }

        int next(int p)
        {
            if (p == 0 || tasks[p].Top != tasks[p - 1].Top)
                return p - 1;
            return next(p - 1);
        }

        public void deleteTask(int x)
        {
            panel1.Controls[x].Visible = tasks[x].Visible = false;
            for (int i = tasks.Count - 1; i > x; i--)
            {
                int ne = next(i);
                if (ne < x)
                    return;
                tasks[i].Top = panel1.Controls[i].Top = tasks[ne].Top;
            }
        }

        private void Tasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            System.IO.File.WriteAllText("SaveTasks.ini", string.Empty);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("SaveTasks.ini", true))
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (!tasks[i].Visible) continue;

                    file.WriteLine(tasks[i].name);
                    file.WriteLine(tasks[i].info);
                    file.WriteLine(tasks[i].pgTask.Value);
                    file.WriteLine(tasks[i].pgTask.Maximum);
                }
            }
        }
    }
}
