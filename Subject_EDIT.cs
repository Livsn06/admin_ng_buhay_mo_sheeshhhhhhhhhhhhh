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
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Subject_EDIT : Form
    {


        MySqlConnection CONNECTION = new MySqlConnection();
        public string id = "", year = "", descrip = "", unit = "";
        public string updated_id = "", updated_year = "", updated_descrip = "", updated_unit = "";
        int edited =0;

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


        void pass_Data_To_Field()
        {

            int temp_year = Convert.ToInt32(year);
            int temp_unit =  Convert.ToInt32(unit);
            year_textbox.SelectedIndex = temp_year - 1;
            unit_textbox.SelectedIndex = temp_unit - 1;

            updated_unit = unit_textbox.Text.ToString();
            updated_year = year_textbox.Text.ToString();
            updated_id = id_textbox.Text = id;
            updated_descrip = description_textbox.Text = descrip;

        }



       private bool is_field_Empty()
        {
            updated_id = id_textbox.Text;
            updated_descrip = organize_Desciption_Name(description_textbox.Text);
            updated_unit = unit_textbox.Text[0].ToString();
            updated_year = year_textbox.Text[0].ToString();   

            return (id_textbox.Text.Length == 0) || (description_textbox.Text.Length == 0) ||
                   (year_textbox.Text.Length == 0) || (unit_textbox.Text.Length == 0);
        }

        private void update_Data()
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

            if (!is_Unique_ID(updated_id))
            {
                MessageBox.Show("ID is already taken..", "Notice");
                return;
            }


            string message = "You are updating your data...\n\n" +
                             "ID: " + id;
             

            DialogResult choice = MessageBox.Show(message, "Update", MessageBoxButtons.OKCancel);

            if (choice == DialogResult.OK)
            {
                string Table = "subject_tbl ";
                string Col_id = "id='";
                string Col_desc = "',description='";
                string Col_unit = "',unit='";
                string Col_year = "',year='";
                string Selected_id = id;

                add_edited_Count();

                string Col_VALUES = Col_id + updated_id + Col_desc + updated_descrip + Col_unit + updated_unit + Col_year + updated_year;
                string QUERY = " UPDATE " + Table + " SET " + Col_VALUES + "' WHERE " + Col_id + Selected_id+"'";

                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully..", "Notice");
                this.Close();

            }
            else
            {
                MessageBox.Show("Update cancelled..", "Notice");
            }

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

        bool is_Number(string newid)
        {
            string regexPattern = "^[0-9]+$";
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

        string  organize_Desciption_Name(string name)
        {
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

        void add_edited_Count()
        {
            get_no_of_Action();
            string Table = "no_of_action ";
            string Col_id = "edited='";
            string QUERY = " UPDATE " + Table + " SET " + Col_id + ++edited + "'";
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            cmd.ExecuteNonQuery();
        }

        void get_no_of_Action()
        {
            string Table = "no_of_action ";
            string Col_id = "edited='";
            string QUERY = "SELECT edited FROM " + Table;
            MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                edited = int.Parse(reader.GetString(0));
            }
            reader.Close();
        }




        bool is_Unique_ID(string newid)
        {
            string Table = "subject_tbl ";
            string Col_id = "id='";
            string QUERY = "SELECT id FROM " + Table + " WHERE " + Col_id + newid + "' AND id <> '" + id + "'";
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

   
        public Subject_EDIT()
        {
            InitializeComponent();
        }

        private void description_textbox_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Subject_EDIT_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            pass_Data_To_Field();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            update_Data();

        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!is_Number(id_textbox.Text))
            {
                id_textbox.ForeColor = Color.Red;
                return;
            }
            if (id == id_textbox.Text)
            {
                id_textbox.ForeColor = Color.Orange;
                return;
            }
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


        private void edit_button_Click(object sender, EventArgs e)
        {
            if (edit_button.Text == "Generate")
            {
               id_textbox.Text = generate_Unique_ID() ;
                return;
            }

           DialogResult action = MessageBox.Show("Do you want to edit ID number?", "Warning!", MessageBoxButtons.OKCancel);
            if (action == DialogResult.OK)
            {
                id_textbox.ReadOnly = false;
                edit_button.IconColor = System.Drawing.Color.Transparent;
                edit_button.BackColor = System.Drawing.Color.FromArgb(32,31,35);
                edit_button.Text = "Generate";
            }
                
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult action = MessageBox.Show("Cancel the edited subject?", "Note", MessageBoxButtons.YesNo);
            if (action == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
