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
    class clsInsert
    {
        int eId;
        string Ename, eLastName, eContact, eDestination, eSalary;


        public int Eid
        {
            get { return eId; }
            set { eId = value; }
        }

        public string eName
        {
            get { return Ename; }
            set { Ename= value; }
        }
        public string ELastName
        {
            get { return eLastName; }
            set { eLastName = value; }
        }
        public string EContact
        {
            get { return eContact; }
            set { eContact = value; }
        }
        public string Edesignation
        {
            get { return eDestination; }
            set { eDestination = value; }
        }
        public string ESalary
        {
            get { return eSalary; }
            set { eSalary = value; }
        }


        public void Insert()
        {
            string server = "localhost";
            string database = "hotel_schema";
            string uid = "root";
            string password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {

                string query = "insert into emp(empid,efname,elname,cell_no,designation,salary) values (@empid,@efname,@elname,@cell_no,@designation,@salary)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@empid", eId);
                cmd.Parameters.AddWithValue("@efname", Ename);
                cmd.Parameters.AddWithValue("@elname", eLastName);
                cmd.Parameters.AddWithValue("@cell_no", eContact);
                cmd.Parameters.AddWithValue("@designation", eDestination);
                cmd.Parameters.AddWithValue("@salary",  int.Parse(eSalary));


                cmd.ExecuteNonQuery();

            }
            catch (Exception em)
            {



                //  connection.close.MessageBox.Show(em.Message.ToString());
            }
        }
    }
}
