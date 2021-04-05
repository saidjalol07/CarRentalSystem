using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CarRentalManegment
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My_Documents\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Get_Data()
        {
            Con.Open();
            string query = "Select * from CarTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            Get_Data();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegNo.Text == "" || txtBrand.Text == "" || txtModel.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "insert into CarTbl values('" + txtRegNo.Text + "', '" + txtBrand.Text + "', '" + txtModel.Text + "', '" + cmbAv.SelectedItem.ToString() + "', '" + txtPrice.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Successfully Added");
                        Con.Close();
                        Get_Data();

                        txtRegNo.Text = "";
                        txtBrand.Text = "";
                        txtModel.Text = "";
                        txtPrice.Text = "";
                        cmbAv.SelectedItem = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something happened wrong ");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegNo.Text == "" || txtBrand.Text == "" || txtModel.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "update CarTbl set Brand= '" + txtBrand.Text + "',  Model='" + txtModel.Text + "', Available='"+ cmbAv.SelectedItem.ToString() + "', Price='" + txtPrice.Text + "'  where RegNum= " + txtRegNo.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Successfully Edited");
                        Con.Close();

                        Get_Data();

                        txtRegNo.Text = "";
                        txtBrand.Text = "";
                        txtModel.Text = "";
                        txtPrice.Text = "";
                        cmbAv.SelectedItem = "";
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

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegNo.Text = CarDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtBrand.Text = CarDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtModel.Text = CarDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmbAv.SelectedItem = CarDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = CarDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "delete from CarTbl where RegNum='" + txtRegNo.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car deleted successfully!!!!!!");
                    Con.Close();

                    Get_Data();

                    txtRegNo.Text = "";
                    txtBrand.Text = "";
                    txtModel.Text = "";
                    cmbAv.SelectedItem = "";
                    txtPrice.Text = "";

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Get_Data();
        }


        string flag = "";

        private void cmbSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {


            Con.Open();
            string query = "select * from CarTbl where Available='" + flag + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();

            if (cmbSearch.SelectedIndex.ToString() == "1")
            {
                flag = "YES";
            }
            else
            {
                flag = "NO";
            }

        }

        private void lbl_Maximize_Click(object sender, EventArgs e)
        {
            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }
    }
}
