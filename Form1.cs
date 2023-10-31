using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin : Form
    {
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

            this.Close();
        }

        private void homebutton_Hover(object sender, EventArgs e)
        {
            home_button.ForeColor = Color.LightSeaGreen;
        }

        private void home_button_MouseLeave(object sender, EventArgs e)
        {
            home_button.ForeColor = Color.Silver;
        }

        private void subjectbutton_Hover(object sender, EventArgs e)
        {
            subject_button.ForeColor = Color.LightSeaGreen;
        }
        private void subjectbutton_Leave(object sender, EventArgs e)
        {
            subject_button.ForeColor = Color.Silver;
        }

        //=======================================================
        Dashboard dashboard = new Dashboard();
        private void Admin_Load(object sender, EventArgs e)
        {
            change_Form(dashboard);
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
            Dashboard dashboard = new Dashboard();
            change_Form(dashboard);


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void student_button_Click(object sender, EventArgs e)
        {

        }

        private void subject_button_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            change_Form(subject);
        }

        private void student_button_MouseHover(object sender, EventArgs e)
        {
            student_button.ForeColor = Color.LightSeaGreen;
        }

        private void student_button_MouseLeave(object sender, EventArgs e)
        {
            student_button.ForeColor = Color.Silver;
        }






        //============================================================



    }
}

