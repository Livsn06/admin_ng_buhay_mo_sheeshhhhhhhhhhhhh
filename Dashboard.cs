using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Dashboard : Form
    {




        MySqlConnection CONNECTION = new MySqlConnection();
        int total_subject = 0, total_Added = 0, total_deleted = 0;



        private void connect_To_Database()
        {
            try
            {
                string server = "server=localhost;";
                string password = "pass=;";
                string uid = "userid=root;";
                string database = "database=crud;";
                string Connection_INFO = server + uid + password + database;

                CONNECTION.ConnectionString = Connection_INFO;

                CONNECTION.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Subject Ford: Connection error");
            }


        }


        private void refresh_Table_Data()
        {
            total_subject = 0;
            string Table = "subject_tbl";
            string Col_id = "id,";
            string Col_description = "description,";
            string Col_unit = "unit,";
            string Col_year = "year";

            string QUERY = " SELECT " + Col_id + Col_description + Col_unit + Col_year + " FROM " + Table;

            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                total_sub.Text = ++total_subject + " total";
 
            }
            read.Close();

        }



        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            refresh_Table_Data();

        }
    }
}
