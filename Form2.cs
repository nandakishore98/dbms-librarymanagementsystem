using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Librarymgmtsystem
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       

        private void SlidingPannel_ToggleButton_Click(object sender, EventArgs e)
        {
           
        }

 
        private void SlidingPannel_Timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Issue_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Issue_UserControl.Instance);
                Issue_UserControl.Instance.Dock = DockStyle.Fill;
                Issue_UserControl.Instance.BringToFront();
            }
            else
            {
                Issue_UserControl.Instance.BringToFront();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContentPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(! ContentPannel.Controls.Contains(Books_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Books_UserControl.Instance);
                Books_UserControl.Instance.Dock = DockStyle.Fill;
                Books_UserControl.Instance.BringToFront();
            }
            else
            {
                Books_UserControl.Instance.BringToFront();
          
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Cards_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Cards_UserControl.Instance);
                Cards_UserControl.Instance.Dock = DockStyle.Fill;
                Cards_UserControl.Instance.BringToFront();
            }
            else
            {
                Cards_UserControl.Instance.BringToFront();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPannel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();

            }
        }
    }
}
