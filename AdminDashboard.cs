using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventMGTNew
{
    public partial class AdminDashboard : Form
    {
        public Point mouseLocation;

        private Button currentButton;
        private Random random;
        private int tempIndex;
        public AdminDashboard()
        {
            InitializeComponent();
            random = new Random();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); 
                    Color color = SelectThemeColor(); 
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Times New Roman", 18.5F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);

                    panel1.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            ResetButtonsInContainer(sidebar);
        }

        private void ResetButtonsInContainer(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = SystemColors.ActiveCaptionText;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                }
                else if (ctrl.HasChildren) 
                {
                    ResetButtonsInContainer(ctrl);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.Visible = true;
            adminEvents1.Visible = false;
            adminBookings1.Visible = false;
            newUser1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool sidebarExpand = true;

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            int sidebarMinWidth = 82;
            int sidebarMaxWidth = 250;
            int step = 5;

            if (sidebarExpand)
            {
                sidebar.Width -= step;
                if (sidebar.Width <= sidebarMinWidth)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += step;
                if (sidebar.Width >= sidebarMaxWidth)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }

            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is Panel) && !(ctrl.Parent is Panel)) 
                {
                    ctrl.Left = sidebar.Width + 10; 
                }
            }
        }



        private void ham_btn_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.Visible = false;
            adminEvents1.Visible = false;
            adminBookings1.Visible = true;
            newUser1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.Visible = false;
            adminEvents1.Visible = true;
            adminBookings1.Visible = false;
            newUser1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DialogResult result = MessageBox.Show("Do you really want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.Visible = false;
            adminEvents1.Visible = false;
            adminBookings1.Visible = false;
            newUser1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            dashboard1.Visible = false;
            adminEvents1.Visible = false;
            adminBookings1.Visible = false;
            newUser1.Visible = true;
        }

        private void newUser1_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
