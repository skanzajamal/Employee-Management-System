using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace main
{
    class clsSearch
    {
        DataTable DataTable1;
        public MySqlDataReader Data_read;

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
            set { Ename = value; }
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
        public void Search()
        {

            MySqlDataReader MySqlDataReader1 = SearchRecord();
            try
            {
                Ename = MySqlDataReader1[1].ToString();
                eLastName = MySqlDataReader1[2].ToString();
                eContact = MySqlDataReader1[9].ToString();
                eDestination = MySqlDataReader1[14].ToString();
                eSalary = MySqlDataReader1[15].ToString();
            }
            catch (Exception em)
            {
                MessageBox.Show("Not Found");            }
        }



        public MySqlDataReader SearchRecord()
        {
            string server = "localhost";
            string database = "hotel_schema";
            string uid = "root";
            string password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string vQuery = "Select * from emp where empid=@empid";
            MySqlCommand cmd = new MySqlCommand(vQuery, connection);
            cmd.Parameters.AddWithValue("@empid", eId);
            Data_read = cmd.ExecuteReader();
            Data_read.Read();
            return Data_read;

        }

       
    }
}
