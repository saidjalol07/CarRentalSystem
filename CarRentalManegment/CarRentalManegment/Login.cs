using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalManegment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My_Documents\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        private void UserNametxt_Click(object sender, EventArgs e)
        {
            UserNametxt.Clear();
            pictureBoxUserName.BackgroundImage = Properties.Resources.usericon;
            UserPanel.BackColor = Color.FromArgb(135, 236, 235);
            UserNametxt.ForeColor = Color.FromArgb(135, 236, 235);

            pictureBoxPassword.BackgroundImage = Properties.Resources.passwordicon;
            PasswordPanel.BackColor = Color.WhiteSmoke;
            Passwordtxt.ForeColor = Color.WhiteSmoke;
        }

        private void Passwordtxt_Click(object sender, EventArgs e)
        {
            Passwordtxt.Clear();
            Passwordtxt.PasswordChar = '.';

            pictureBoxPassword.BackgroundImage = Properties.Resources.passwordicon;
            PasswordPanel.BackColor = Color.FromArgb(135, 236, 235);
            Passwordtxt.ForeColor = Color.FromArgb(135, 236, 235);

            pictureBoxUserName.BackgroundImage = Properties.Resources.usericon;
            UserPanel.BackColor = Color.WhiteSmoke;
            UserNametxt.ForeColor = Color.WhiteSmoke;
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            UserNametxt.Text = "";
            Passwordtxt.Text = "";
        }

        ToolTip toolTip = new ToolTip();

        private void lbl_Exit_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Exit.BackColor = Color.Red;
            toolTip.Show("Close", lbl_Exit);
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Exit.BackColor = Color.LightGray;
        }

        private void lbl_Minimize_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.Gray;
            toolTip.Show("Minimize", lbl_Minimize);
        }

        private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.LightGray;
        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select count(*) from UserTbl  where Uname='"+ UserNametxt.Text +"'  and Upass ='"+ Passwordtxt.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User or Password");
            }

            Con.Close();
        }

    }
}
