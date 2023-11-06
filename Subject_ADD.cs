using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Subject_ADD : Form
    {

        MySqlConnection CONNECTION = new MySqlConnection();
        public string id = "", year = "", descrip = "", unit = "";
        public string updated_id = "", updated_year = "", updated_descrip = "", updated_unit = "";
        int added;

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

        void add_added_Count()
        {
            get_no_of_Action();
            string Table = "no_of_action ";
            string Col_id = "added='";
            string QUERY = " UPDATE " + Table + " SET " + Col_id + ++added + "'";
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            cmd.ExecuteNonQuery();
        }

        void get_no_of_Action()
        {
            string Table = "no_of_action ";
            string QUERY = "SELECT added FROM " + Table;
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                added = int.Parse(reader.GetString(0));
            }
            reader.Close();
        }

        bool is_Valid_ID(string newid)
        {
            string regexPattern = "^1[0-9]{3}$";
            Regex regex = new Regex(regexPattern);
            Match match = regex.Match(newid);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void add_Data()
        {
            if (is_field_Empty())
            {
                MessageBox.Show("Please fill all form..", "Notice");
                return;
            }

            if (!is_Valid_ID(id_textbox.Text))
            {
                MessageBox.Show("Invalid id..", "Warning!");
                return;
            }

            if (!is_Unique_ID(id_textbox.Text))
            {
                MessageBox.Show("ID is already taken..", "Notice");
                return;
            }


            string message = "Do you want to add " +  id_textbox.Text + "?";
            DialogResult choice = MessageBox.Show(message, "Insert", MessageBoxButtons.OKCancel);

            if (choice == DialogResult.OK)
            {
                string Table = "subject_tbl";
                string Col_id = "id,";
                string Col_desc = "description,";
                string Col_unit = "unit,";
                string Col_year = "year";
                string Value_id = id_textbox.Text;
                string Value_desc = organize_Desciption_Name(description_textbox.Text);
                string Value_year = year_textbox.Text[0].ToString();
                string Value_unit = unit_textbox.Text[0].ToString();

                add_added_Count();
                string COLUMNS = Col_id + Col_desc + Col_unit + Col_year;
                string VALUES = Value_id + "','" + Value_desc + "','" + Value_unit + "','" + Value_year;

                string QUERY = " INSERT INTO " + Table + " (" + COLUMNS + ") VALUES ('" + VALUES + "')";

                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully..", "Notice");
                this.Close();
            }
            else
            {
                MessageBox.Show("Adding cancelled..", "Notice");
            }

        }




        private bool is_field_Empty()
        {
            return (id_textbox.Text.Length == 0) || (description_textbox.Text.Length == 0) ||
                   (year_textbox.Text == "--- -- ---") || (unit_textbox.Text == "--- -- ---");
        }

        string organize_Desciption_Name(string name)
        {
            name = name.Trim();
            name = name.ToLower();
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            name = textInfo.ToTitleCase(name);
            return name;
        }

        string generate_Unique_ID()
        {
            Random random = new Random();
            string incoming_ID = random.Next(1000, 2000).ToString();
            if (!is_Unique_ID(incoming_ID))
            {
                generate_Unique_ID();
            }
            return incoming_ID;


        }

        bool is_Unique_ID(string newid)
        {
            try
            {
                string Table = "subject_tbl ";
                string Col_id = "id=";
                string QUERY = "SELECT id FROM " + Table + " WHERE " + Col_id + newid + "";
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.Close();
                    return false;
                }
                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public Subject_ADD()
        {
            InitializeComponent();
        }


        private void Subject_ADD_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            year_textbox.SelectedIndex = 0;
            unit_textbox.SelectedIndex = 0;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            add_Data();
        }

        private void search_selection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            id_textbox.Text = generate_Unique_ID();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {

            if (is_Unique_ID(id_textbox.Text))
            {
                id_textbox.ForeColor = Color.Green;
                return;
            }
            else
            {
                id_textbox.ForeColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult action = MessageBox.Show("Cancel adding subject?", "Note", MessageBoxButtons.YesNo);
            if (action == DialogResult.Yes)
            {
                this.Close();
            }
        }



    }
}
