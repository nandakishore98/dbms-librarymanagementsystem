using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Librarymgmtsystem
{
    public partial class Books_UserControl : UserControl
    {
        private static Books_UserControl _instance;

        public static Books_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Books_UserControl();
                }
                return _instance;
            }
        }
        public Books_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Librarymgmtsystem\Librarymgmtsystem\Database1.mdf;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Books_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void Pubname_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@book_id", Bookid_textBox.Text);
            cmd.Parameters.AddWithValue("@title", Title_textBox.Text);
            cmd.Parameters.AddWithValue("@author", Author_textBox.Text);
            cmd.Parameters.AddWithValue("@pubname", Pubname_comboBox.Text);
            cmd.Parameters.AddWithValue("@isbn", ISBN_textBox.Text);
            cmd.Parameters.AddWithValue("@no_of_copies", Copies_textBox.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid SQL OPERATION:" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid SQL OPERATION:" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch(Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("booksDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@book_id", Bookid_textBox.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Sql Operation: " + ex);

                }
                con.Close();
                refresh_DataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("booksSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@book_id", searchTextBox.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL OPERATION:" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            Bookid_textBox.Text = "";
            Title_textBox.Text = "";
            Pubname_comboBox.Text = "";
            ISBN_textBox.Text = "";
            Author_textBox.Text = "";
            Copies_textBox.Text = "";
        }
    }
}
