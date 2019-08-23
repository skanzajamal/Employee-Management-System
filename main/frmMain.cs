using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsert m = new frmInsert();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUpdate m = new frmUpdate();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDelete m = new frmDelete();
            m.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSearch m = new frmSearch();
            m.Show();
        }
    }
}
