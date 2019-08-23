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
    public partial class frmDelete : Form
    {
        fController fController1;
        public frmDelete()
        {
            
            InitializeComponent();
           
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            fController1 = new fController(this.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

          clsDelete clsDelete1;
           clsDelete1 =new clsDelete();
           
               clsDelete1.Id1 = int.Parse(textBox1.Text);
               clsDelete1.deleteRecord();
               Hide(); 

           
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
