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
    public partial class Settings_UserControl : UserControl
    {
        private static Settings_UserControl _instance;

        public static Settings_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Settings_UserControl();
                }
                return _instance;
            }
        }
        public Settings_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Librarymgmtsystem\Librarymgmtsystem\Database3.mdf;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UserAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox2.Text);
            
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
                SqlCommand cmd = new SqlCommand("ShowAllUsers_SP", con);
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

        private void Settings_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DeleteUser_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
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
