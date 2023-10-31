using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Subject : Form
    {

        MySqlConnection CONNECTION = new MySqlConnection();
        string id = "", year="", descrip="", unit="";
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
            subject_table.Rows.Clear();
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
                ++total_subject;
                subject_table.Rows.Add(read[0], read[1], read[2], read[3]);
            }
            read.Close();

        }

        private void delete_Data()
        {
            if (id.Length == 0)
            {
                MessageBox.Show("Please select row..", "Notice");
                id = "";
                descrip = "";
                year = "";
                unit = "";
                return;
            }

            DialogResult choice = MessageBox.Show("Are you sure?\n\nID: " + id + "\nDESCRIPTION: " + descrip, "Delete", MessageBoxButtons.OKCancel);

            if (choice == DialogResult.OK)
            {

                string Table = "subject_tbl";
                string Col_id = "id=";
                string Selected_id = id;

                string QUERY = " DELETE FROM " + Table + " WHERE " + Col_id + Selected_id;
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully..", "Notice");

            }
            else
            {
                MessageBox.Show("Deleted cancelled.." , "Notice");
            }
            id = "";
            descrip = "";
            year = "";
            unit = "";
        }


        private void get_Selected_Data()
        {
            id = subject_table.SelectedCells[0].Value.ToString();
            descrip = subject_table.SelectedCells[1].Value.ToString();
            unit = subject_table.SelectedCells[2].Value.ToString();
            year = subject_table.SelectedCells[3].Value.ToString();
        }


        public void edit_Data()
        {

            if (id.Length == 0)
            {
                MessageBox.Show("Please select row..", "Notice");
                id = "";
                descrip = "";
                year = "";
                unit = "";
                return;
            }

            DialogResult result = MessageBox.Show("Edit id number " + id + " ?", "Notice", MessageBoxButtons.OKCancel);

            if (!(result == DialogResult.OK))
            {
                return;
            }

            Subject_EDIT edit = new Subject_EDIT();
            edit.id = id;
            edit.descrip = descrip;
            edit.year = year;
            edit.unit = unit;
            edit.ShowDialog();

            id = "";
            descrip = "";
            year = "";
            unit = "";
        }


        void enabled_Dropdown_Sorting(string value)
        {

            subject_table.Rows.Clear();
            string Table = "subject_tbl";
            string Col_id = "id,";
            string Col_description = "description,";
            string Col_unit = "unit,";
            string Col_year = "year";
           

            string QUERY = " SELECT " + Col_id + Col_description + Col_unit + Col_year + " FROM " + Table ;

            if (search_selection.Text.Equals("ID"))
            {
                QUERY += " WHERE id LIKE '" + value + "%'";
            }
            if (search_selection.Text.Equals("Description"))
            {
                QUERY += " WHERE description LIKE '" + value + "%'";
            }
            if (search_selection.Text.Equals("Unit"))
            {
                QUERY += " WHERE unit LIKE '" + value + "%'";
            }
            if (search_selection.Text.Equals("Year Availability"))
            {
                QUERY += " WHERE year LIKE '" + value + "%'";
            }
            if (search_selection.Text.Equals("---  --  ---"))
            {
                QUERY += " WHERE CONCAT_WS(' ',id,description,unit,year) LIKE '%" + value + "%'";
            }
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                subject_table.Rows.Add(read[0], read[1], read[2], read[3]);
            }
            read.Close();
        }




        public Subject()
        {
            InitializeComponent();
           
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            refresh_Table_Data();
            search_selection.SelectedIndex = 0;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_Data();
            refresh_Table_Data();
        }

        private void subject_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            get_Selected_Data();
   
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Subject_ADD add = new Subject_ADD();
            add.ShowDialog();
            refresh_Table_Data();
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            enabled_Dropdown_Sorting(search_textbox.Text);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            edit_Data();
            refresh_Table_Data();
        }


        private void search_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void subject_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    
    }
}
