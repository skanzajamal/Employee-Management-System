using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace main
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUpdate clsUpdate1;
            clsUpdate1 = new clsUpdate();
            clsUpdate1.Eid = int.Parse(textBox1.Text);
            clsUpdate1.eName = textBox2.Text;
            clsUpdate1.ELastName = textBox3.Text;
            clsUpdate1.EContact = textBox4.Text;
            clsUpdate1.Edesignation = textBox5.Text;
            clsUpdate1.ESalary = textBox6.Text;
            clsUpdate1.Update_1();
            Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
