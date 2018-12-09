namespace Librarymgmtsystem
{
    partial class Books_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pubname_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bookid_textBox = new System.Windows.Forms.TextBox();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Copies_textBox = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pubname_comboBox
            // 
            this.Pubname_comboBox.FormattingEnabled = true;
            this.Pubname_comboBox.Items.AddRange(new object[] {
            "MC GREW HILL",
            "PEARSON",
            "RAMCHANDRA",
            "VTU",
            "RNSIT"});
            this.Pubname_comboBox.Location = new System.Drawing.Point(104, 354);
            this.Pubname_comboBox.Name = "Pubname_comboBox";
            this.Pubname_comboBox.Size = new System.Drawing.Size(134, 24);
            this.Pubname_comboBox.TabIndex = 1;
            this.Pubname_comboBox.SelectedIndexChanged += new System.EventHandler(this.Pubname_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title";
            // 
            // Bookid_textBox
            // 
            this.Bookid_textBox.Location = new System.Drawing.Point(104, 284);
            this.Bookid_textBox.Name = "Bookid_textBox";
            this.Bookid_textBox.Size = new System.Drawing.Size(134, 22);
            this.Bookid_textBox.TabIndex = 5;
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(104, 319);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(134, 22);
            this.Title_textBox.TabIndex = 6;
            this.Title_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Author_textBox
            // 
            this.Author_textBox.Location = new System.Drawing.Point(364, 284);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(121, 22);
            this.Author_textBox.TabIndex = 7;
            // 
            // ISBN_textBox
            // 
            this.ISBN_textBox.Location = new System.Drawing.Point(364, 319);
            this.ISBN_textBox.Name = "ISBN_textBox";
            this.ISBN_textBox.Size = new System.Drawing.Size(121, 22);
            this.ISBN_textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(287, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(287, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "ISBN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightPink;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(71, 234);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 30);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add Book";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(287, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Price";
            // 
            // Copies_textBox
            // 
            this.Copies_textBox.Location = new System.Drawing.Point(364, 361);
            this.Copies_textBox.Name = "Copies_textBox";
            this.Copies_textBox.Size = new System.Drawing.Size(121, 22);
            this.Copies_textBox.TabIndex = 16;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.LightPink;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.ForeColor = System.Drawing.Color.Black;
            this.Delete_button.Location = new System.Drawing.Point(179, 234);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(86, 30);
            this.Delete_button.TabIndex = 17;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(130, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(236, 22);
            this.searchTextBox.TabIndex = 18;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.LightPink;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.ForeColor = System.Drawing.Color.Black;
            this.Searchbutton.Location = new System.Drawing.Point(385, 14);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(86, 30);
            this.Searchbutton.TabIndex = 19;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(67, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Book ID";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.LightPink;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.ForeColor = System.Drawing.Color.Black;
            this.Clearbutton.Location = new System.Drawing.Point(290, 234);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(86, 30);
            this.Clearbutton.TabIndex = 21;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Copies_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ISBN_textBox);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.Title_textBox);
            this.Controls.Add(this.Bookid_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pubname_comboBox);
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(606, 419);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Pubname_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Bookid_textBox;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.TextBox ISBN_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Copies_textBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clearbutton;
    }
}
