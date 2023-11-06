namespace Admin
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.student_button = new System.Windows.Forms.Label();
            this.subject_button = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profile_button = new System.Windows.Forms.PictureBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.log_in_form = new System.Windows.Forms.Panel();
            this.pass_validation_indicator = new System.Windows.Forms.FlowLayoutPanel();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.show = new FontAwesome.Sharp.IconButton();
            this.email_validation_indicator = new System.Windows.Forms.FlowLayoutPanel();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new FontAwesome.Sharp.IconButton();
            this.register_btn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_form = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.reg_repass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.register = new FontAwesome.Sharp.IconButton();
            this.to_login = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_pass = new System.Windows.Forms.TextBox();
            this.reg_user = new System.Windows.Forms.TextBox();
            this.profile_settings = new System.Windows.Forms.Panel();
            this.pass_edit_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.email_edit_textbox = new System.Windows.Forms.TextBox();
            this.user_edit_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edit_profile_btn = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).BeginInit();
            this.main_panel.SuspendLayout();
            this.log_in_form.SuspendLayout();
            this.pass_validation_indicator.SuspendLayout();
            this.email_validation_indicator.SuspendLayout();
            this.register_form.SuspendLayout();
            this.profile_settings.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 95);
            this.panel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.student_button);
            this.flowLayoutPanel1.Controls.Add(this.subject_button);
            this.flowLayoutPanel1.Controls.Add(this.home_button);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(469, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(454, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // student_button
            // 
            this.student_button.BackColor = System.Drawing.Color.Transparent;
            this.student_button.Enabled = false;
            this.student_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.ForeColor = System.Drawing.Color.Silver;
            this.student_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.student_button.Location = new System.Drawing.Point(333, 0);
            this.student_button.Margin = new System.Windows.Forms.Padding(0);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(121, 38);
            this.student_button.TabIndex = 10;
            this.student_button.Text = "Enrollee";
            this.student_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.student_button.UseCompatibleTextRendering = true;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            this.student_button.MouseLeave += new System.EventHandler(this.student_button_MouseLeave);
            this.student_button.MouseHover += new System.EventHandler(this.student_button_MouseHover);
            // 
            // subject_button
            // 
            this.subject_button.BackColor = System.Drawing.Color.Transparent;
            this.subject_button.Enabled = false;
            this.subject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_button.ForeColor = System.Drawing.Color.Silver;
            this.subject_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subject_button.Location = new System.Drawing.Point(210, 0);
            this.subject_button.Margin = new System.Windows.Forms.Padding(0);
            this.subject_button.Name = "subject_button";
            this.subject_button.Size = new System.Drawing.Size(123, 38);
            this.subject_button.TabIndex = 11;
            this.subject_button.Text = "Subject";
            this.subject_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subject_button.UseCompatibleTextRendering = true;
            this.subject_button.Click += new System.EventHandler(this.subject_button_Click);
            this.subject_button.MouseLeave += new System.EventHandler(this.subjectbutton_Leave);
            this.subject_button.MouseHover += new System.EventHandler(this.subjectbutton_Hover);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.Enabled = false;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.Silver;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.Location = new System.Drawing.Point(90, 0);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(120, 39);
            this.home_button.TabIndex = 9;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home_button.UseCompatibleTextRendering = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            this.home_button.MouseLeave += new System.EventHandler(this.home_button_MouseLeave);
            this.home_button.MouseHover += new System.EventHandler(this.homebutton_Hover);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(98, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 41);
            this.label15.TabIndex = 7;
            this.label15.Text = "AdminGo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.UseCompatibleTextRendering = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(1072, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "⨯";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            this.label6.DoubleClick += new System.EventHandler(this.mouse_DoubleClick);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.profile_button);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(959, 28);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(45, 45);
            this.panel3.TabIndex = 2;
            // 
            // profile_button
            // 
            this.profile_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_button.Enabled = false;
            this.profile_button.Image = ((System.Drawing.Image)(resources.GetObject("profile_button.Image")));
            this.profile_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile_button.InitialImage")));
            this.profile_button.Location = new System.Drawing.Point(5, 5);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(35, 35);
            this.profile_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_button.TabIndex = 9;
            this.profile_button.TabStop = false;
            this.profile_button.Click += new System.EventHandler(this.profile_Click_1);
            this.profile_button.DoubleClick += new System.EventHandler(this.profile_view);
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.main_panel.Controls.Add(this.register_form);
            this.main_panel.Controls.Add(this.log_in_form);
            this.main_panel.Controls.Add(this.profile_settings);
            this.main_panel.Location = new System.Drawing.Point(0, 93);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1131, 607);
            this.main_panel.TabIndex = 10;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // log_in_form
            // 
            this.log_in_form.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.log_in_form.Controls.Add(this.pass_validation_indicator);
            this.log_in_form.Controls.Add(this.email_validation_indicator);
            this.log_in_form.Controls.Add(this.login_btn);
            this.log_in_form.Controls.Add(this.register_btn);
            this.log_in_form.Controls.Add(this.label1);
            this.log_in_form.Controls.Add(this.label2);
            this.log_in_form.Location = new System.Drawing.Point(44, 59);
            this.log_in_form.Name = "log_in_form";
            this.log_in_form.Size = new System.Drawing.Size(1042, 488);
            this.log_in_form.TabIndex = 1;
            this.log_in_form.Paint += new System.Windows.Forms.PaintEventHandler(this.log_in_form_Paint);
            // 
            // pass_validation_indicator
            // 
            this.pass_validation_indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_validation_indicator.BackColor = System.Drawing.Color.Lime;
            this.pass_validation_indicator.Controls.Add(this.pass_textbox);
            this.pass_validation_indicator.Controls.Add(this.show);
            this.pass_validation_indicator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pass_validation_indicator.Location = new System.Drawing.Point(180, 280);
            this.pass_validation_indicator.Name = "pass_validation_indicator";
            this.pass_validation_indicator.Padding = new System.Windows.Forms.Padding(1);
            this.pass_validation_indicator.Size = new System.Drawing.Size(678, 49);
            this.pass_validation_indicator.TabIndex = 28;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pass_textbox.Location = new System.Drawing.Point(1, 1);
            this.pass_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.PasswordChar = '*';
            this.pass_textbox.Size = new System.Drawing.Size(626, 47);
            this.pass_textbox.TabIndex = 21;
            this.pass_textbox.TextChanged += new System.EventHandler(this.pass_textbox_TextChanged);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.White;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.show.IconColor = System.Drawing.Color.DimGray;
            this.show.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.show.IconSize = 30;
            this.show.Location = new System.Drawing.Point(627, 1);
            this.show.Margin = new System.Windows.Forms.Padding(0);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(50, 47);
            this.show.TabIndex = 26;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // email_validation_indicator
            // 
            this.email_validation_indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_validation_indicator.BackColor = System.Drawing.Color.Lime;
            this.email_validation_indicator.Controls.Add(this.email_textbox);
            this.email_validation_indicator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email_validation_indicator.Location = new System.Drawing.Point(182, 140);
            this.email_validation_indicator.Name = "email_validation_indicator";
            this.email_validation_indicator.Padding = new System.Windows.Forms.Padding(1);
            this.email_validation_indicator.Size = new System.Drawing.Size(676, 49);
            this.email_validation_indicator.TabIndex = 27;
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.email_textbox.Location = new System.Drawing.Point(1, 1);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(674, 47);
            this.email_textbox.TabIndex = 20;
            this.email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(5)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.login_btn.IconColor = System.Drawing.Color.Black;
            this.login_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.login_btn.Location = new System.Drawing.Point(696, 362);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(162, 51);
            this.login_btn.TabIndex = 25;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Crimson;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.register_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.register_btn.IconColor = System.Drawing.Color.Black;
            this.register_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.register_btn.Location = new System.Drawing.Point(499, 362);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(162, 51);
            this.register_btn.TabIndex = 24;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(175, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(180, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // register_form
            // 
            this.register_form.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_form.Controls.Add(this.label9);
            this.register_form.Controls.Add(this.reg_repass);
            this.register_form.Controls.Add(this.label7);
            this.register_form.Controls.Add(this.reg_email);
            this.register_form.Controls.Add(this.register);
            this.register_form.Controls.Add(this.to_login);
            this.register_form.Controls.Add(this.label3);
            this.register_form.Controls.Add(this.label5);
            this.register_form.Controls.Add(this.reg_pass);
            this.register_form.Controls.Add(this.reg_user);
            this.register_form.Enabled = false;
            this.register_form.Location = new System.Drawing.Point(27, 17);
            this.register_form.Name = "register_form";
            this.register_form.Size = new System.Drawing.Size(1067, 566);
            this.register_form.TabIndex = 3;
            this.register_form.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Location = new System.Drawing.Point(180, 363);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 40);
            this.label9.TabIndex = 30;
            this.label9.Text = "Re-type password : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // reg_repass
            // 
            this.reg_repass.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_repass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reg_repass.Location = new System.Drawing.Point(182, 406);
            this.reg_repass.Name = "reg_repass";
            this.reg_repass.Size = new System.Drawing.Size(679, 47);
            this.reg_repass.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(177, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 40);
            this.label7.TabIndex = 28;
            this.label7.Text = "Email : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reg_email.Location = new System.Drawing.Point(181, 194);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(681, 47);
            this.reg_email.TabIndex = 27;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(5)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.register.IconChar = FontAwesome.Sharp.IconChar.None;
            this.register.IconColor = System.Drawing.Color.Black;
            this.register.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.register.Location = new System.Drawing.Point(700, 481);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(162, 51);
            this.register.TabIndex = 25;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // to_login
            // 
            this.to_login.BackColor = System.Drawing.Color.Crimson;
            this.to_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to_login.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.to_login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.to_login.IconColor = System.Drawing.Color.Black;
            this.to_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.to_login.Location = new System.Drawing.Point(514, 481);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(162, 51);
            this.to_login.TabIndex = 24;
            this.to_login.Text = "Log in";
            this.to_login.UseVisualStyleBackColor = false;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(175, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(176, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Username : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // reg_pass
            // 
            this.reg_pass.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reg_pass.Location = new System.Drawing.Point(181, 301);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.Size = new System.Drawing.Size(680, 47);
            this.reg_pass.TabIndex = 21;
            // 
            // reg_user
            // 
            this.reg_user.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_user.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reg_user.Location = new System.Drawing.Point(183, 89);
            this.reg_user.Name = "reg_user";
            this.reg_user.Size = new System.Drawing.Size(679, 47);
            this.reg_user.TabIndex = 20;
            this.reg_user.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // profile_settings
            // 
            this.profile_settings.BackColor = System.Drawing.Color.White;
            this.profile_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_settings.Controls.Add(this.pass_edit_textbox);
            this.profile_settings.Controls.Add(this.label10);
            this.profile_settings.Controls.Add(this.logout);
            this.profile_settings.Controls.Add(this.email_edit_textbox);
            this.profile_settings.Controls.Add(this.user_edit_textbox);
            this.profile_settings.Controls.Add(this.label8);
            this.profile_settings.Controls.Add(this.edit_profile_btn);
            this.profile_settings.Controls.Add(this.label4);
            this.profile_settings.Controls.Add(this.back);
            this.profile_settings.Controls.Add(this.panel5);
            this.profile_settings.Enabled = false;
            this.profile_settings.Location = new System.Drawing.Point(384, 7);
            this.profile_settings.Name = "profile_settings";
            this.profile_settings.Size = new System.Drawing.Size(428, 550);
            this.profile_settings.TabIndex = 2;
            this.profile_settings.Visible = false;
            // 
            // pass_edit_textbox
            // 
            this.pass_edit_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pass_edit_textbox.Enabled = false;
            this.pass_edit_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_edit_textbox.ForeColor = System.Drawing.Color.Black;
            this.pass_edit_textbox.Location = new System.Drawing.Point(32, 425);
            this.pass_edit_textbox.MaxLength = 300;
            this.pass_edit_textbox.Multiline = true;
            this.pass_edit_textbox.Name = "pass_edit_textbox";
            this.pass_edit_textbox.PasswordChar = '*';
            this.pass_edit_textbox.Size = new System.Drawing.Size(362, 34);
            this.pass_edit_textbox.TabIndex = 35;
            this.pass_edit_textbox.Text = "pass@123";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(32, 393);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 31);
            this.label10.TabIndex = 34;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.IndianRed;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.logout.IconColor = System.Drawing.Color.Black;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.Location = new System.Drawing.Point(260, 493);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(137, 37);
            this.logout.TabIndex = 33;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // email_edit_textbox
            // 
            this.email_edit_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_edit_textbox.Enabled = false;
            this.email_edit_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_edit_textbox.ForeColor = System.Drawing.Color.Black;
            this.email_edit_textbox.Location = new System.Drawing.Point(35, 341);
            this.email_edit_textbox.MaxLength = 300;
            this.email_edit_textbox.Multiline = true;
            this.email_edit_textbox.Name = "email_edit_textbox";
            this.email_edit_textbox.Size = new System.Drawing.Size(362, 34);
            this.email_edit_textbox.TabIndex = 32;
            this.email_edit_textbox.Text = "admin@gmail.com";
            // 
            // user_edit_textbox
            // 
            this.user_edit_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_edit_textbox.Enabled = false;
            this.user_edit_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_edit_textbox.ForeColor = System.Drawing.Color.Black;
            this.user_edit_textbox.Location = new System.Drawing.Point(35, 257);
            this.user_edit_textbox.MaxLength = 300;
            this.user_edit_textbox.Multiline = true;
            this.user_edit_textbox.Name = "user_edit_textbox";
            this.user_edit_textbox.Size = new System.Drawing.Size(362, 34);
            this.user_edit_textbox.TabIndex = 31;
            this.user_edit_textbox.Text = "Joel Admin";
            this.user_edit_textbox.TextChanged += new System.EventHandler(this.uaername_edit_textbox_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(33, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "Username:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.BackColor = System.Drawing.Color.LightGray;
            this.edit_profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_profile_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_profile_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_profile_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.edit_profile_btn.IconColor = System.Drawing.Color.Black;
            this.edit_profile_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_profile_btn.Location = new System.Drawing.Point(154, 160);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(128, 33);
            this.edit_profile_btn.TabIndex = 26;
            this.edit_profile_btn.Text = "Edit";
            this.edit_profile_btn.UseVisualStyleBackColor = false;
            this.edit_profile_btn.Click += new System.EventHandler(this.edit_profile_btn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(35, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.IndianRed;
            this.back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(383, 13);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.TabIndex = 8;
            this.back.Text = "⨯";
            this.back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back.UseCompatibleTextRendering = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(157, 27);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(125, 125);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.log_in_form.ResumeLayout(false);
            this.pass_validation_indicator.ResumeLayout(false);
            this.pass_validation_indicator.PerformLayout();
            this.email_validation_indicator.ResumeLayout(false);
            this.email_validation_indicator.PerformLayout();
            this.register_form.ResumeLayout(false);
            this.register_form.PerformLayout();
            this.profile_settings.ResumeLayout(false);
            this.profile_settings.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label subject_button;
        private System.Windows.Forms.Label student_button;
        private System.Windows.Forms.Label home_button;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel log_in_form;
        private FontAwesome.Sharp.IconButton login_btn;
        private FontAwesome.Sharp.IconButton register_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.PictureBox profile_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel profile_settings;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton edit_profile_btn;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton logout;
        private System.Windows.Forms.TextBox email_edit_textbox;
        private System.Windows.Forms.TextBox user_edit_textbox;
        private FontAwesome.Sharp.IconButton show;
        private System.Windows.Forms.Panel register_form;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reg_repass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reg_email;
        private FontAwesome.Sharp.IconButton register;
        private FontAwesome.Sharp.IconButton to_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_pass;
        private System.Windows.Forms.TextBox reg_user;
        private System.Windows.Forms.TextBox pass_edit_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel email_validation_indicator;
        private System.Windows.Forms.FlowLayoutPanel pass_validation_indicator;
    }
}

