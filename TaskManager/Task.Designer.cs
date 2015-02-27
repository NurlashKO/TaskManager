namespace WindowsFormsApplication1
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tname = new System.Windows.Forms.Label();
            this.starter = new System.Windows.Forms.Button();
            this.pgTask = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infobtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tname
            // 
            this.tname.AutoSize = true;
            this.tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tname.Location = new System.Drawing.Point(7, 24);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(81, 20);
            this.tname.TabIndex = 0;
            this.tname.Text = "taskName";
            // 
            // starter
            // 
            this.starter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.starter.Location = new System.Drawing.Point(250, 18);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(75, 26);
            this.starter.TabIndex = 1;
            this.starter.Text = "Start";
            this.starter.UseVisualStyleBackColor = true;
            this.starter.Click += new System.EventHandler(this.starter_Click);
            // 
            // pgTask
            // 
            this.pgTask.Location = new System.Drawing.Point(340, 21);
            this.pgTask.Name = "pgTask";
            this.pgTask.Size = new System.Drawing.Size(182, 23);
            this.pgTask.TabIndex = 2;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(337, 58);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(45, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Inactive";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // infobtn
            // 
            this.infobtn.Location = new System.Drawing.Point(46, 48);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(77, 23);
            this.infobtn.TabIndex = 4;
            this.infobtn.Text = "TaskInfo";
            this.infobtn.UseVisualStyleBackColor = true;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(432, 48);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete Task";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pgTask);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.tname);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(543, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tname;
        private System.Windows.Forms.Button starter;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button infobtn;
        public System.Windows.Forms.ProgressBar pgTask;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.Timer timer1;
    }
}
