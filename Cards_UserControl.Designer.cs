namespace Librarymgmtsystem
{
    partial class Cards_UserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CardAdd_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CardID_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.DeleteCard_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // CardAdd_button
            // 
            this.CardAdd_button.Location = new System.Drawing.Point(240, 205);
            this.CardAdd_button.Name = "CardAdd_button";
            this.CardAdd_button.Size = new System.Drawing.Size(88, 34);
            this.CardAdd_button.TabIndex = 15;
            this.CardAdd_button.Text = "Add new";
            this.CardAdd_button.UseVisualStyleBackColor = true;
            this.CardAdd_button.Click += new System.EventHandler(this.CardAdd_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(89, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Card ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(305, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(89, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // CardID_textBox
            // 
            this.CardID_textBox.Location = new System.Drawing.Point(150, 269);
            this.CardID_textBox.Name = "CardID_textBox";
            this.CardID_textBox.Size = new System.Drawing.Size(124, 22);
            this.CardID_textBox.TabIndex = 20;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(150, 309);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(124, 22);
            this.Email_textBox.TabIndex = 21;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(371, 269);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(124, 22);
            this.Phone_textBox.TabIndex = 22;
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(371, 312);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(124, 22);
            this.Address_textBox.TabIndex = 23;
            // 
            // DeleteCard_button
            // 
            this.DeleteCard_button.Location = new System.Drawing.Point(334, 205);
            this.DeleteCard_button.Name = "DeleteCard_button";
            this.DeleteCard_button.Size = new System.Drawing.Size(88, 34);
            this.DeleteCard_button.TabIndex = 24;
            this.DeleteCard_button.Text = "Delete";
            this.DeleteCard_button.UseVisualStyleBackColor = true;
            this.DeleteCard_button.Click += new System.EventHandler(this.DeleteCard_button_Click);
            // 
            // Cards_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteCard_button);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.CardID_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardAdd_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cards_UserControl";
            this.Size = new System.Drawing.Size(606, 419);
            this.Load += new System.EventHandler(this.Cards_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CardAdd_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CardID_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Button DeleteCard_button;
    }
}
