using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dairy_Farm_Management_System
{
    public partial class MilkSales : Form
    {
        public MilkSales()
        {
            InitializeComponent();
            FillCowId();
            populate();
        }

        private void MilkSales_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void MilkSales_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Milkproduction Ob = new Milkproduction();
            Ob.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            CowHealth Ob = new CowHealth();
            Ob.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Breading Ob = new Breading();
            Ob.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCowId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select EmpId from EmployeeTbl ", con);
            SqlDataAdapter Rdr;
            //Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            //dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            // CowIdCb.DateSource = dt;
            con.Close();


        }
        private void populate()
        {
            con.Open();
            string query = "select * from MilkSalesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalesList.DataSource = ds.Tables[0];
            con.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
                
            NameTb.Text = "";
            Price.Text = "";
            PhoneTb.Text = "";
            Quantity.Text = "";
            Total.Text = "";
        }

        private void SaveTransaction()
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (EmpIdCb.SelectedIndex == -1 || NameTb.Text == "" || Price.Text == "" || PhoneTb.Text == "" || Quantity.Text == "" || Total.Text == "")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "inster into MilkSalesTbl values ( '" + date.Value.Date + "'," + Price.Text + ",'" + NameTb.Text + "','" + PhoneTb.Text + "','" + EmpIdCb.SelectedItem.ToString()+ "','" + Quantity.Text + "','" + Total.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Milk Sold successdully");
                    con.Close();
                    populate();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

            private void Quantity_Leave(object sender, EventArgs e)
            {

                int total = Convert.ToInt32(Price.Text) * Convert.ToInt32(Quantity.Text);
                Total.Text = "" + total;
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }

      
    }
