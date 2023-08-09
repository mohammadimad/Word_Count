using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnArabic_Click(object sender, EventArgs e)
        {
            Form frm = new frmArabic();
            this.Hide();
            this.Enabled = false;
            frm.ShowDialog();
            this.Close();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnglish();
            this.Hide();
            this.Enabled = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
