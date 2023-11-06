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
        int total_subject = 0, total_Added = 0, total_edited, total_deleted = 0;
        string active_id = "", active_Username = "", active_Email = "", active_Password = "";


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

        void get_no_of_Action()
        {
            string Table = "no_of_action ";
            string QUERY = "SELECT added, edited, deleted FROM " + Table;
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                total_Added = int.Parse(reader.GetString(0));
                total_edited = int.Parse(reader.GetString(1));
                total_deleted = int.Parse(reader.GetString(2));
            }
            reader.Close();
            added.Text = total_Added.ToString() + " recently added";
            deleted.Text = total_deleted.ToString() + " recently deleted";
        }


        void reset_no_of_Action()
        {

            DialogResult result = MessageBox.Show("Reset records?", "Notice", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string Table = "no_of_action ";
                string QUERY = "UPDATE " + Table + "SET added = 0, edited = 0, deleted = 0 WHERE added =" + total_Added;
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();
                get_no_of_Action();
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

        private void added_DoubleClick(object sender, EventArgs e)
        {
            reset_no_of_Action();
        }

        private void records_DoubleClick(object sender, EventArgs e)
        {
            reset_no_of_Action();
        }

        void get_Active_Account()
        {
            string Table = "account";
            string Col_id = "id,";
            string Col_user = "username,";
            string Col_email = "email,";
            string Col_pass = "password";

            string QUERY = " SELECT " + Col_id + Col_user + Col_email + Col_pass + " FROM " + Table + " WHERE status= 'active'";
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                active_id = read.GetString(0);
                active_Username = read.GetString(1);
                active_Email = read.GetString(2);
                active_Password = read.GetString(3);

                username_show.Text = active_Username;
            }
            read.Close();

        }



        private void username_show_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            get_no_of_Action();
            refresh_Table_Data();
            get_Active_Account();
        }
    }
}
