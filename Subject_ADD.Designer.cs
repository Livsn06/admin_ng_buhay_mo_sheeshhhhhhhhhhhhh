namespace Admin
{
    partial class Subject_ADD
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
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.home_button = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.ComboBox();
            this.unit_textbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_button = new FontAwesome.Sharp.IconButton();
            this.add_button = new FontAwesome.Sharp.IconButton();
            this.generate_button = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.description_textbox.Location = new System.Drawing.Point(35, 453);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(546, 47);
            this.description_textbox.TabIndex = 5;
            this.description_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(29, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(31, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Year : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(314, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Units : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id_textbox.Location = new System.Drawing.Point(35, 334);
            this.id_textbox.MaxLength = 4;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(378, 47);
            this.id_textbox.TabIndex = 3;
            this.id_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.Black;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.home_button.Location = new System.Drawing.Point(31, 294);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(168, 40);
            this.home_button.TabIndex = 10;
            this.home_button.Text = "ID : ";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.UseCompatibleTextRendering = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // year_textbox
            // 
            this.year_textbox.BackColor = System.Drawing.Color.White;
            this.year_textbox.DropDownHeight = 300;
            this.year_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_textbox.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.year_textbox.FormattingEnabled = true;
            this.year_textbox.IntegralHeight = false;
            this.year_textbox.ItemHeight = 37;
            this.year_textbox.Items.AddRange(new object[] {
            "--- -- ---",
            "1st year",
            "2nd year",
            "3rd year",
            "4th year"});
            this.year_textbox.Location = new System.Drawing.Point(35, 221);
            this.year_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(254, 45);
            this.year_textbox.TabIndex = 15;
            this.year_textbox.SelectedIndexChanged += new System.EventHandler(this.search_selection_SelectedIndexChanged);
            // 
            // unit_textbox
            // 
            this.unit_textbox.BackColor = System.Drawing.Color.White;
            this.unit_textbox.DropDownHeight = 300;
            this.unit_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_textbox.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.unit_textbox.FormattingEnabled = true;
            this.unit_textbox.IntegralHeight = false;
            this.unit_textbox.ItemHeight = 37;
            this.unit_textbox.Items.AddRange(new object[] {
            "--- -- ---",
            "1 unit",
            "2 unit",
            "3 unit",
            "4 unit"});
            this.unit_textbox.Location = new System.Drawing.Point(319, 221);
            this.unit_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.unit_textbox.Name = "unit_textbox";
            this.unit_textbox.Size = new System.Drawing.Size(262, 45);
            this.unit_textbox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 140);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(-4, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 45);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(0, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(615, 72);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adding Subject";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Crimson;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancel_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancel_button.IconColor = System.Drawing.Color.Black;
            this.cancel_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancel_button.Location = new System.Drawing.Point(218, 545);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(162, 51);
            this.cancel_button.TabIndex = 18;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(5)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_button.IconColor = System.Drawing.Color.Black;
            this.add_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_button.Location = new System.Drawing.Point(419, 545);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(162, 51);
            this.add_button.TabIndex = 19;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // generate_button
            // 
            this.generate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generate_button.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.generate_button.IconColor = System.Drawing.Color.Transparent;
            this.generate_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.generate_button.IconSize = 30;
            this.generate_button.Location = new System.Drawing.Point(419, 334);
            this.generate_button.Name = "generate_button";
            this.generate_button.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.generate_button.Size = new System.Drawing.Size(162, 47);
            this.generate_button.TabIndex = 32;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = false;
            this.generate_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // Subject_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(609, 627);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unit_textbox);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subject_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subject";
            this.Load += new System.EventHandler(this.Subject_ADD_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label home_button;
        private System.Windows.Forms.ComboBox year_textbox;
        private System.Windows.Forms.ComboBox unit_textbox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton cancel_button;
        private FontAwesome.Sharp.IconButton add_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton generate_button;
    }
}