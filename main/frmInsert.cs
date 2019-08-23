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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInsert clsInsert1;
            clsInsert1 = new clsInsert();
            clsInsert1.Eid = int.Parse(textBox1.Text);
            clsInsert1.eName = textBox2.Text;
            clsInsert1.ELastName = textBox3.Text;
            clsInsert1.EContact = textBox4.Text;
            clsInsert1.Edesignation = textBox5.Text;
            clsInsert1.ESalary = textBox6.Text;
            clsInsert1.Insert();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
