using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalManegment
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My_Documents\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string querycar = "Select Count(*) from CarTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCar.Text = dt.Rows[0][0].ToString();

            string querycust = "Select Count(*) from CustomerTbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblCust.Text = dt1.Rows[0][0].ToString();


            string queryuser = "Select Count(*) from UserTbl";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblUser.Text = dt2.Rows[0][0].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
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

    }
}
