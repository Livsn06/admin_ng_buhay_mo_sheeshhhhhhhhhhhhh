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
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Admin
{
    public partial class Admin : Form
    {


        MySqlConnection CONNECTION = new MySqlConnection();
        bool is_dash = false, is_subject = false, is_enrolee = false;
        string active_id = "", active_Username = "", active_Email = "", active_Password = "";
        void connect_To_Database()
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
                MessageBox.Show("Connected to database..", "Connection");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Subject Ford: Connection error");
            }

        }


        bool mouseDown;
        private Point offset;

        public Admin()
        {
            InitializeComponent();
        }


        //______________________________________________________
        void change_Form(Form form)
        {

                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                main_panel.Controls.Add(form);
                form.BringToFront();
                form.Show();

        }



        //================== FORM DRAG EVENT ==========================
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mouse_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit now? :(", "Notice", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void homebutton_Hover(object sender, EventArgs e)
        {
            home_button.ForeColor = Color.LightSeaGreen;

        }

        private void home_button_MouseLeave(object sender, EventArgs e)
        {
            if (is_dash)
            {
                home_button.ForeColor = Color.LightSeaGreen;
                subject_button.ForeColor = Color.Silver;
                student_button.ForeColor = Color.Silver;
            }
            else
            {
                home_button.ForeColor = Color.Silver;
            }

        }

        private void subjectbutton_Hover(object sender, EventArgs e)
        {
            subject_button.ForeColor = Color.LightSeaGreen;
        }
        private void subjectbutton_Leave(object sender, EventArgs e)
        {
            if (is_subject)
            {
                subject_button.ForeColor = Color.LightSeaGreen;
                home_button.ForeColor = Color.Silver;
                student_button.ForeColor = Color.Silver;
            }
            else
            {
                subject_button.ForeColor = Color.Silver;
            }
        }

        bool has_now_Active()
        {
            try
            {
                string Table = "account ";
                string Col_id = "id,";
                string Col_username = "username,";
                string Col_email = "email,";
                string Col_pass = "password";
                string Col_status = "status='";
                string status = "active";
                string QUERY = "Select " +  Col_id + Col_username + Col_email + Col_pass + " FROM " + Table + " WHERE " + Col_status + status + "'";
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    active_id = reader.GetString(0);
                    active_Username = reader.GetString(1);
                    active_Email = reader.GetString(2);
                    active_Password = reader.GetString(3);
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }

        }


        public bool login_Verification()
        {
            try
            {
                string activate_id = "";
                string Table = "account ";
                string Col_id = "id=";
                string Col_email = "email='";
                string Col_pass = "password='";
                string QUERY = "SELECT id, email, password FROM " + Table;
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[1].ToString().Equals(email_textbox.Text) && reader[2].ToString().Equals(pass_textbox.Text))
                    {
                        profile_button.Enabled = true;
                        activate_id = reader[0].ToString();
                        reader.Close();
                        set_Active(activate_id);
                        MessageBox.Show("Log in Successs!", "Verification");
                        email_validation_indicator.BackColor = Color.Lime;
                        pass_validation_indicator.BackColor = Color.Lime;
                        return true;
                    }
                }
                reader.Close();
                MessageBox.Show("Invalid email and password!", "Verification");
                email_validation_indicator.BackColor = Color.Red;
                pass_validation_indicator.BackColor = Color.Red;
                return false;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        void set_Active(string id)
        {
            try
            {
                string Table = "account ";
                string Col_id = "id='";
                string Col_status = "status='";
                string status = "active";
                string QUERY = "Update " + Table + " SET " + Col_status + status + "'" + " WHERE " + Col_id + id + "'";
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

        }

        void set_Inactive(string id)
        {
            try
            {
                string Table = "account ";
                string Col_id = "id='";
                string Col_status = "status='";
                string status = "inactive";
                string QUERY = "Update " + Table + " SET " + Col_status + status + "'" + " WHERE " + Col_id + id + "'";
                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

        }

        //=======================================================

        private void Admin_Load(object sender, EventArgs e)
        {
            connect_To_Database();
            if (has_now_Active())
            {
                home_button.Enabled = true;
                subject_button.Enabled = true;
                student_button.Enabled = true;
                profile_button.Enabled = true;
                home_button.ForeColor = Color.LightSeaGreen;
                subject_button.ForeColor = Color.Silver;
                Dashboard dashboard = new Dashboard();
                dashboard.username_show.Text = active_Username;
                change_Form(dashboard);
            }
            if (!has_now_Active())
            {
                home_button.ForeColor = Color.LightSeaGreen;
                subject_button.ForeColor= Color.Silver;
                home_button.Enabled = false;
                subject_button.Enabled = false;
                student_button.Enabled = false;
                profile_button.Enabled = false;
            }

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            is_dash = true;
            is_subject = false;
            is_enrolee  = false;
            Dashboard dashboard = new Dashboard();
            dashboard.username_show.Text = active_Username;
            change_Form(dashboard);


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void student_button_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Enrolee is not availabe due to \nsir acosta instruction... :)", "Wild Notification");
            if (d == DialogResult.OK)
            {
        /*        is_dash = false;
                is_subject = false;
                is_enrolee = true;
                Enrolee enrolee = new Enrolee();
                change_Form(enrolee);*/
            }
        }

        private void subject_button_Click(object sender, EventArgs e)
        {
            is_dash = false;
            is_subject = true;
            is_enrolee = false;
            Subject subject = new Subject();
            change_Form(subject);
        }

        private void edited_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

                if (login_Verification())
                {
                    home_button.Enabled = true;
                    subject_button.Enabled = true;
                    student_button.Enabled = true;
                    profile_button.Enabled = true;
                    home_button.ForeColor = Color.LightSeaGreen;
                    subject_button.ForeColor = Color.Silver;
                    is_dash =true;
                    is_subject =false;
                    is_enrolee=false;
                    Dashboard dashboard = new Dashboard();
                    dashboard.username_show.Text = active_Username;
                    change_Form(dashboard);
                }

        }

        private void profile_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void profile_view(object sender, EventArgs e)
        {

            main_panel.Controls.Add(profile_settings);
            profile_settings.Visible = true;
            profile_settings.Enabled = true;
            profile_settings.BringToFront();
            user_edit_textbox.Text = active_Username;
            email_edit_textbox.Text = active_Email;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (edit_profile_btn.Text == "Save")
            {

                DialogResult d = MessageBox.Show("Do you want to cancel editing?", "Warning!", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    profile_settings.Visible = false;
                    profile_settings.Enabled = false;
                    profile_settings.SendToBack();
                    user_edit_textbox.Enabled = false;
                    email_edit_textbox.Enabled = false;
                    edit_profile_btn.Text = "Edit";
                }
            }
            else
            {
                profile_settings.Visible = false;
                profile_settings.Enabled = false;
                profile_settings.SendToBack();
                user_edit_textbox.Enabled = false;
                email_edit_textbox.Enabled = false;
                edit_profile_btn.Text = "Edit";
            }
        }

        private void profile_Click_1(object sender, EventArgs e)
        {
            has_now_Active();
        }

        bool show_pass = true;
        private void show_Click(object sender, EventArgs e)
        {
            show_pass = !show_pass;
            if (show_pass)
            {
                show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                pass_textbox.PasswordChar = '*';
            }
            else
            {
                show.IconChar = FontAwesome.Sharp.IconChar.Eye;
                pass_textbox.PasswordChar = '\0';
            }
           
        }

        private void pass_textbox_TextChanged(object sender, EventArgs e)
        {
            pass_validation_indicator.BackColor = Color.Lime;
        }

        private void log_in_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(register_form);
            register_form.BringToFront();
            register_form.Enabled = true;
            register_form.Visible = true;

        }

        private void to_login_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(log_in_form);
            log_in_form.BringToFront();
            log_in_form.Enabled = true;
            log_in_form.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to log out your account?", "Warning!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                home_button.Enabled = false;
                subject_button.Enabled = false;
                student_button.Enabled = false;
                profile_button.Enabled = false;
                profile_settings.Visible = false;
                profile_settings.Enabled = false;
                profile_settings.SendToBack();
                user_edit_textbox.Enabled = false;
                email_edit_textbox.Enabled = false;
                edit_profile_btn.Text = "Edit";
                MessageBox.Show("Log out successfully ", "Warning!", MessageBoxButtons.OK);
                set_Inactive(active_id);
                main_panel.Controls.Clear();
                email_textbox.Text = "";
                pass_textbox.Text = "";
                main_panel.Controls.Add(log_in_form);


            }
        }


        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email_edit_textbox.Text);
            if (match.Success)
            {
                email_validation_indicator.BackColor = Color.Lime;
            }
            else
            {
                email_validation_indicator.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            add_Account();
        }


        void add_Account()
        {

            string new_email = reg_email.Text.Trim();
            string new_user = reg_user.Text.Trim();
            string new_pass = reg_pass.Text.Trim();
            string new_repass = reg_repass.Text.Trim();
            if (new_email.Equals("") || new_user.Equals("") || new_email.Equals("") || new_pass.Equals("") || new_repass.Equals(""))
            {
                MessageBox.Show("Please fill all form..", "Notice");
                return;
            }
            if (new_pass != new_repass)
            {
                MessageBox.Show("Password Confirmation does not match..", "Notice");
                return;
            }

            DialogResult d = MessageBox.Show("Create an account?", "Notice", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {
                return;
            }
            try {
                string Table = "account";
                string Col_user = "(username,";
                string Col_email = "email,";
                string Col_pass = "password,";
                string Col_status = "status)";

                string QUERY = "INSERT INTO " + Table + Col_user + Col_email + Col_pass + Col_status +
                               " VALUES ('" + new_user + "','" + new_email + "','" + new_pass + "','inactive')";

                MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                cmd.ExecuteNonQuery();

                reg_email.Text = reg_pass.Text = reg_user.Text = reg_repass.Text = "";

                DialogResult O = MessageBox.Show("Account successfully registered", "Notice", MessageBoxButtons.OK);
                if (O == DialogResult.OK)
                {
                    main_panel.Controls.Clear();
                    main_panel.Controls.Add(log_in_form);
                    log_in_form.BringToFront();
                    log_in_form.Enabled = true;
                    log_in_form.Visible = true;
                    return;
                }


            }
            catch(Exception e) {

                MessageBox.Show("Email already existing..", "Notice");

            }
        }


        bool update_Account()
        {
            try {

                DialogResult d = MessageBox.Show("Save changes?", "Note", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    string new_email = email_edit_textbox.Text.Trim();
                    string new_user = user_edit_textbox.Text.Trim();
                    string new_pass = pass_edit_textbox.Text.Trim();
                    string QUERY = "UPDATE  account SET email='" + new_email + "', username='" + new_user + "', password='" + new_pass + "' "
                                    + "WHERE  id=" + active_id + "";

                    MySqlCommand cmd = new MySqlCommand(QUERY, CONNECTION);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch(Exception e) 
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
           

        }



        private void edit_profile_btn_Click(object sender, EventArgs e)
        {
            if (edit_profile_btn.Text == "Edit")
            {
                DialogResult d = MessageBox.Show("Do you want to edit your personal info?", "Warning!", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    user_edit_textbox.Enabled = true;
                    email_edit_textbox.Enabled = true;
                    pass_edit_textbox.Enabled = true;
                    edit_profile_btn.Text = "Save";

                }
            }
            else
            {
                if (update_Account())
                {

                    MessageBox.Show("Please re-login your account..", "Session expired!", MessageBoxButtons.OK);
                    home_button.Enabled = false;
                    subject_button.Enabled = false;
                    student_button.Enabled = false;
                    profile_button.Enabled = false;
                    profile_settings.Visible = false;
                    profile_settings.Enabled = false;
                    profile_settings.SendToBack();
                    user_edit_textbox.Enabled = false;
                    email_edit_textbox.Enabled = false;
                    edit_profile_btn.Text = "Edit";
                    set_Inactive(active_id);
                    main_panel.Controls.Clear();
                    email_textbox.Text = "";
                    pass_textbox.Text = "";
                    main_panel.Controls.Add(log_in_form);

                }
            }
            
        }

        private void uaername_edit_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_button_MouseHover(object sender, EventArgs e)
        {

            student_button.ForeColor = Color.LightSeaGreen;
        }

        private void student_button_MouseLeave(object sender, EventArgs e)
        {
            if (is_enrolee)
            {
                home_button.ForeColor = Color.Silver;
                subject_button.ForeColor = Color.Silver;
                student_button.ForeColor = Color.LightSeaGreen;
            }
            else
            {
                student_button.ForeColor = Color.Silver;
            }

        }






        //============================================================



    }
}

