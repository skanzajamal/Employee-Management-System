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
    public partial class frmSearch : Form
    {

        public frmSearch()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clsSearch clsSearch1;
                clsSearch1 = new clsSearch();

                clsSearch1.Eid = int.Parse(textBox7.Text);
                clsSearch1.Search();

                textBox1.Text = clsSearch1.Eid.ToString();
                textBox2.Text = clsSearch1.eName.ToString();
                textBox3.Text = clsSearch1.ELastName.ToString();
                textBox4.Text = clsSearch1.EContact.ToString();
                textBox5.Text = clsSearch1.Edesignation.ToString();
                textBox6.Text = clsSearch1.ESalary.ToString();
            }

            catch (Exception em)
            {
               
            }

        }

        
    }
}
