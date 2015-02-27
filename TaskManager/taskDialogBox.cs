using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class taskDialogBox : Form
    {
        bool ask = false;
        public string name, info;
        public int time;

        public taskDialogBox()
        {
            InitializeComponent();
            cancle.DialogResult = DialogResult.Cancel;
            AcceptButton = ok;
            CancelButton = cancle;
        }

        public taskDialogBox(string nName, string nInfo, int nTime)
        {
            InitializeComponent();
            tname.Text = nName;
            tname.ReadOnly = true;
            tInfo.Text = nInfo;
            tInfo.ReadOnly = true;
            tTime.Text = nTime.ToString();
            tTime.ReadOnly = true;

            ok.DialogResult = DialogResult.OK;
            cancle.DialogResult = DialogResult.Cancel;
            AcceptButton = ok;
            CancelButton = cancle;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (tname.Text == "")
            {
                MessageBox.Show("You must write a task name");
                return;
            }
            if (tTime.Text == "")
            {
                MessageBox.Show("You must write a task time");
                return;
            }

            if (!ask)
            {
                name = tname.Text;
                info = tInfo.Text;
                time = Convert.ToInt32(tTime.Text);
                ask = true;
                ok.DialogResult = DialogResult.OK;
                ok.PerformClick();
            }
            
        }

        private void cancle_Click(object sender, EventArgs e)
        {
        }

        private void tTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
