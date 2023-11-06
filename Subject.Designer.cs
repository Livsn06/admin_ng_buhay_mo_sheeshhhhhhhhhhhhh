namespace Admin
{
    partial class Subject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subject_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new FontAwesome.Sharp.IconButton();
            this.search_selection = new System.Windows.Forms.ComboBox();
            this.add_button = new FontAwesome.Sharp.IconButton();
            this.delete_button = new FontAwesome.Sharp.IconButton();
            this.edit_button = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.subject_table)).BeginInit();
            this.SuspendLayout();
            // 
            // subject_table
            // 
            this.subject_table.AllowUserToAddRows = false;
            this.subject_table.AllowUserToDeleteRows = false;
            this.subject_table.AllowUserToResizeColumns = false;
            this.subject_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subject_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.subject_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.subject_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subject_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.subject_table.ColumnHeadersHeight = 40;
            this.subject_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.subject_table.EnableHeadersVisualStyles = false;
            this.subject_table.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subject_table.Location = new System.Drawing.Point(21, 107);
            this.subject_table.MultiSelect = false;
            this.subject_table.Name = "subject_table";
            this.subject_table.ReadOnly = true;
            this.subject_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.subject_table.RowHeadersVisible = false;
            this.subject_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            this.subject_table.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.subject_table.RowTemplate.Height = 28;
            this.subject_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subject_table.Size = new System.Drawing.Size(1091, 382);
            this.subject_table.TabIndex = 0;
            this.subject_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subject_table_CellClick);
            this.subject_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subject_table_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Year Availability";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.search_textbox.Location = new System.Drawing.Point(671, 41);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(341, 47);
            this.search_textbox.TabIndex = 1;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.search_button.IconColor = System.Drawing.Color.White;
            this.search_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.search_button.IconSize = 30;
            this.search_button.Location = new System.Drawing.Point(1018, 41);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(87, 45);
            this.search_button.TabIndex = 2;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_selection
            // 
            this.search_selection.BackColor = System.Drawing.Color.White;
            this.search_selection.DropDownHeight = 300;
            this.search_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_selection.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_selection.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.search_selection.FormattingEnabled = true;
            this.search_selection.IntegralHeight = false;
            this.search_selection.ItemHeight = 37;
            this.search_selection.Items.AddRange(new object[] {
            "---  --  ---",
            "ID",
            "Description",
            "Unit",
            "Year Availability"});
            this.search_selection.Location = new System.Drawing.Point(439, 41);
            this.search_selection.Margin = new System.Windows.Forms.Padding(5);
            this.search_selection.Name = "search_selection";
            this.search_selection.Size = new System.Drawing.Size(224, 45);
            this.search_selection.TabIndex = 3;
            this.search_selection.SelectedIndexChanged += new System.EventHandler(this.search_selection_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_button.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.add_button.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.add_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.add_button.IconSize = 30;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(965, 517);
            this.add_button.Name = "add_button";
            this.add_button.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.add_button.Size = new System.Drawing.Size(147, 51);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Crimson;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_button.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delete_button.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.delete_button.IconSize = 30;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_button.Location = new System.Drawing.Point(783, 517);
            this.delete_button.Name = "delete_button";
            this.delete_button.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.delete_button.Size = new System.Drawing.Size(149, 51);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_button.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.edit_button.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_button.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.edit_button.IconSize = 30;
            this.edit_button.Location = new System.Drawing.Point(23, 41);
            this.edit_button.Name = "edit_button";
            this.edit_button.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.edit_button.Size = new System.Drawing.Size(94, 51);
            this.edit_button.TabIndex = 6;
            this.edit_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 605);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.search_selection);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.subject_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subject_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_textbox;
        private FontAwesome.Sharp.IconButton search_button;
        private System.Windows.Forms.ComboBox search_selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridView subject_table;
        private FontAwesome.Sharp.IconButton add_button;
        private FontAwesome.Sharp.IconButton delete_button;
        private FontAwesome.Sharp.IconButton edit_button;
    }
}