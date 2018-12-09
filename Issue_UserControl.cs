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
    public partial class Issue_UserControl : UserControl
    {
        private static Issue_UserControl _instance;

        public static Issue_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Issue_UserControl();
                }
                return _instance;
            }
        }
        public Issue_UserControl()
        {
            InitializeComponent();
        }
        public string Book1, Book2, Book3, Borrower;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Librarymgmtsystem\Librarymgmtsystem\Database1.mdf;Integrated Security=True");

        private void Issue_UserControl_Load(object sender, EventArgs e)
        {

        }

        
        public SqlCommand cmd;

        private void IssueBook_button_Click(object sender, EventArgs e)
        {
            //see if the book is borrowed by someone
            searchBooks_button.PerformClick();
            SearchCard_button.PerformClick();
            if(Borrower!="")
            {
                //someone has borrowed the book
                MessageBox.Show("Book is already borrowed by some other borrower id: \n" + Borrower);
                return;
            }
            //see if Borrower has alread borrowed 3 books
            if((Book1!="")&&(Book2!="")&&(Book3!=""))
            {
                MessageBox.Show("borrower has already borrowed maximum number of books");
                return;
            }
            //continue issue process
            //first set the value of book1 or book2 or book3 as the book_id being issued
            SqlCommand cmd;
            try
            {
                if(Book1=="")
                {
                    //book_id must be updated in book1 slot
                    cmd = new SqlCommand("Tranasact_Update_Book1_SP", con);
          
                }
                else if(Book2=="")
                {
                    cmd = new SqlCommand("Tranasact_Update_Book2_SP", con);
                }
                else
                {
                    cmd= new SqlCommand("Tranasact_Update_Book3_SP",con);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("book_id", BookId_textBox.Text);
                cmd.Parameters.AddWithValue("cardno", CardNo_textBox.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("invalid Sql operation: " + ex);

                }
                con.Close();
            }
            catch(Exception exe)
            {
                MessageBox.Show(""+exe);
            }
            cmd = new SqlCommand("Transact_Update_Borrowers_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("book_id", BookId_textBox.Text);
            cmd.Parameters.AddWithValue("cardno", CardNo_textBox.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception exa)
            {
                MessageBox.Show("Invalid Sql Operation" + exa);
            }
            con.Close();
            searchBooks_button.PerformClick();
            SearchCard_button.PerformClick();
            MessageBox.Show("Book is sucessfully issued");
            SqlCommand cmd1 = new SqlCommand("IssuesAdd_SP", con);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@cid", CardNo_textBox.Text);
            cmd1.Parameters.AddWithValue("@bookid", BookId_textBox.Text);
         
            con.Open();
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL OPERATION:" + ex);
            }
            con.Close();
            
        }

        private void ReturnBook_button_Click(object sender, EventArgs e)
        {
            //see if the book is borrowed by someone
            searchBooks_button.PerformClick();
            SearchCard_button.PerformClick();
            if ((BookId_textBox.Text!=Book1)&&(BookId_textBox.Text != Book2)&& (BookId_textBox.Text != Book3))
            {
                
                MessageBox.Show("The borrower has not borrwed the book" + Borrower);
                return;
            }
          
            //continue issue process
            //first set the value of book1 or book2 or book3 as the book_id being issued
            try
            {
                if (Book1 == BookId_textBox.Text)
                {
                    //book_id must be updated in book1 slot
                    cmd = new SqlCommand("Tranasact_Update_Book1_SP", con);

                }
                else if (Book2 == BookId_textBox.Text)
                {
                    cmd = new SqlCommand("Tranasact_Update_Book2_SP", con);
                }
                else
                {
                    cmd = new SqlCommand("Tranasact_Update_Book3_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("book_id", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("cardno", CardNo_textBox.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid Sql operation: " + ex);

                }
                con.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }
            cmd = new SqlCommand("Transact_Update_Borrowers_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("book_id", BookId_textBox.Text);
            cmd.Parameters.AddWithValue("cardno", (object)DBNull.Value);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exa)
            {
                MessageBox.Show("Invalid Sql Operation" + exa);
            }
            con.Close();
            searchBooks_button.PerformClick();
            SearchCard_button.PerformClick();
            MessageBox.Show("Book is sucessfully recieved");
            SqlCommand cmd1 = new SqlCommand("IssuesDelete_SP", con);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@cid", CardNo_textBox.Text);
            cmd1.Parameters.AddWithValue("@bookid", BookId_textBox.Text);

            con.Open();
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL OPERATION:" + ex);
            }
            con.Close();

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            BookId_textBox.Text = "";
            CardNo_textBox.Text = "";
        }

        private void ShowLog_button_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllIssuesData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public SqlDataReader dr;
        private void searchBooks_button_Click(object sender, EventArgs e)
        {
            //to get cardno

            con.Open();
            String syntax4 = "Select borrower from books where book_id='" + BookId_textBox.Text + "'";
            cmd = new SqlCommand(syntax4, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label10.Text =Borrower= dr[0].ToString();
            con.Close();
        }

        private void SearchCard_button_Click(object sender, EventArgs e)
        {
            //to get book1
           
            con.Open();
            String syntax = "Select book1 From cardno Where cid='" + CardNo_textBox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label6.Text = Book1= dr[0].ToString();
            con.Close();

            //to get book2

            con.Open();
            String syntax1 = "Select book2 from cardno where cid='" + CardNo_textBox.Text + "'";
            cmd = new SqlCommand(syntax1, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label7.Text = Book2= dr[0].ToString();
            con.Close();

            //to get book1

            con.Open();
            String syntax3 = "Select book3 from cardno where cid='" + CardNo_textBox.Text + "'";
            cmd = new SqlCommand(syntax3, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label8.Text = Book3= dr[0].ToString();
            con.Close();

        }
    }
}
