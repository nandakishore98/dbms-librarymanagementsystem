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
    public partial class Cards_UserControl : UserControl
    {
        private static Cards_UserControl _instance;

        public static Cards_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cards_UserControl();
                }
                return _instance;
            }
        }
        public Cards_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Librarymgmtsystem\Librarymgmtsystem\Database1.mdf;Integrated Security=True");

        private void CardAdd_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CardsAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid", CardID_textBox.Text);
            cmd.Parameters.AddWithValue("@email", Email_textBox.Text);
            cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
            cmd.Parameters.AddWithValue("@address", Address_textBox.Text);
            
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
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllCards_SP", con);
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

        private void Cards_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void DeleteCard_button_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("cardsDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardid", CardID_textBox.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
