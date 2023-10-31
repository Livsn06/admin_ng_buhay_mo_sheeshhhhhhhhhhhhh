namespace Admin
{
    partial class Subject_EDIT
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
            this.save_button = new FontAwesome.Sharp.IconButton();
            this.cancel_button = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.unit_textbox = new System.Windows.Forms.ComboBox();
            this.year_textbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Label();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_button = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(5)))));
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.save_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.save_button.IconColor = System.Drawing.Color.Black;
            this.save_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.save_button.Location = new System.Drawing.Point(421, 547);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(162, 51);
            this.save_button.TabIndex = 30;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
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
            this.cancel_button.Location = new System.Drawing.Point(224, 547);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(162, 51);
            this.cancel_button.TabIndex = 29;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 140);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(-4, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 45);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.label4.Text = "Editing  Subject";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // unit_textbox
            // 
            this.unit_textbox.BackColor = System.Drawing.Color.White;
            this.unit_textbox.DropDownHeight = 300;
            this.unit_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.unit_textbox.FormattingEnabled = true;
            this.unit_textbox.IntegralHeight = false;
            this.unit_textbox.ItemHeight = 39;
            this.unit_textbox.Items.AddRange(new object[] {
            "1 unit",
            "2 unit",
            "3 unit",
            "4 unit"});
            this.unit_textbox.Location = new System.Drawing.Point(321, 223);
            this.unit_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.unit_textbox.Name = "unit_textbox";
            this.unit_textbox.Size = new System.Drawing.Size(262, 47);
            this.unit_textbox.TabIndex = 27;
            // 
            // year_textbox
            // 
            this.year_textbox.BackColor = System.Drawing.Color.White;
            this.year_textbox.DropDownHeight = 300;
            this.year_textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.year_textbox.FormattingEnabled = true;
            this.year_textbox.IntegralHeight = false;
            this.year_textbox.ItemHeight = 39;
            this.year_textbox.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year",
            "4th year"});
            this.year_textbox.Location = new System.Drawing.Point(37, 223);
            this.year_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(254, 47);
            this.year_textbox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(316, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 25;
            this.label3.Text = "Units : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(31, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Description : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.Black;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.home_button.Location = new System.Drawing.Point(33, 296);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(168, 40);
            this.home_button.TabIndex = 22;
            this.home_button.Text = "ID : ";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.UseCompatibleTextRendering = true;
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.description_textbox.Location = new System.Drawing.Point(37, 459);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(546, 47);
            this.description_textbox.TabIndex = 21;
            this.description_textbox.TextChanged += new System.EventHandler(this.description_textbox_TextChanged);
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_textbox.Location = new System.Drawing.Point(37, 336);
            this.id_textbox.MaxLength = 4;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(380, 47);
            this.id_textbox.TabIndex = 20;
            this.id_textbox.TextChanged += new System.EventHandler(this.id_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 47);
            this.label2.TabIndex = 24;
            this.label2.Text = "Year : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Crimson;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_button.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.edit_button.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.edit_button.IconSize = 30;
            this.edit_button.Location = new System.Drawing.Point(421, 334);
            this.edit_button.Name = "edit_button";
            this.edit_button.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.edit_button.Size = new System.Drawing.Size(162, 51);
            this.edit_button.TabIndex = 31;
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // Subject_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(615, 631);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.save_button);
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
            this.Name = "Subject_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject_EDIT";
            this.Load += new System.EventHandler(this.Subject_EDIT_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton save_button;
        private FontAwesome.Sharp.IconButton cancel_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox unit_textbox;
        private System.Windows.Forms.ComboBox year_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label home_button;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton edit_button;
    }
}