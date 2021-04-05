using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace CarRentalManegment
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My_Documents\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "insert into CustomerTbl values('" + txtID.Text + "', '" + txtName.Text + "', '" + txtAddress.Text + "',  '" + txtPhone.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Successfully Added");
                        Con.Close();
                        Get_Data();

                        txtID.Text = "";
                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Something happened wrong ");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "update CustomerTbl set CustName= '" + txtName.Text + "',  CustAdd='" + txtAddress.Text + "',  Phone='" + txtPhone.Text + "'  where CustId= " + txtID.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Successfully Edited");
                        Con.Close();

                        Get_Data();

                        txtID.Text = "";
                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "delete from CustomerTbl where CustId='" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully!!!!!!");
                    Con.Close();

                    Get_Data();

                    txtID.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Get_Data()
        {
            Con.Open();
            string query = "Select * from CustomerTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Get_Data();
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Panel1_MouseHover(object sender, EventArgs e)
        {
            this.Panel1.BackColor = Color.LightGray;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Panel1.BackColor = Color.Maroon;
        }

        private void lbl_Minimize_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Minimize.BackColor = Color.Gray;
            toolTip.Show("MInimize", lbl_Minimize);
        }

        private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.Panel1.BackColor = Color.Maroon;
        }

        ToolTip toolTip = new ToolTip();

        private void lbl_Exit_MouseHover(object sender, EventArgs e)
        {
            this.lbl_Exit.BackColor = Color.Red;
            toolTip.Show("Close", lbl_Exit);
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Exit.BackColor = Color.Maroon;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
