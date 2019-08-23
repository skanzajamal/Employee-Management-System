using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace main
{
    class clsDelete
    {
        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        public void deleteRecord()
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
                string query = "Delete from emp where empid=@empid";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@empid", Id);
                MessageBox.Show(cmd.ExecuteNonQuery().ToString() + " Row Deleted");
                //connection.close();
            }
            catch (NullReferenceException em)
            {
                MessageBox.Show(em.Message.ToString());
            }
        }
    }
}
