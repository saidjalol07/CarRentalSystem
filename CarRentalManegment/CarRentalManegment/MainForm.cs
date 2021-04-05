using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManegment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
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
            toolTip.Show("MInimize", lbl_Minimize);
        }

        private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.LightGray;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Btn_Car_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarForm car = new CarForm();
            car.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalForm rent = new RentalForm();
            rent.Show();
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users();
            user.Show();
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnForm ret = new ReturnForm();
            ret.Show();

        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard board = new DashBoard();
            board.Show();
        }

    }
}
