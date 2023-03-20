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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            finance();
            Logistic();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Milkproduction Ob = new Milkproduction();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");
        private void finance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(IncAmt) from Incometbl", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(ExAmount) from  ExpenditureTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int inc, exp;
            double bal;
            inc = Convert.ToInt32(dt.Rows[0][0].ToString());
            Inclabe.Text = "Rs" + dt.Rows[0][0].ToString();
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            exp = Convert.ToInt32(dt.Rows[0][0].ToString());
            bal = inc - exp;
            Explbl.Text = "Rs" +dt1.Rows[0][0].ToString();
            ballabl.Text = "Rs" + bal;
            con.Close();
        }
        private void Logistic()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from CoweTbl", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Totalmilk) from  MilkTbl", con);
            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*) from  EmployeeTbl", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            cowsnumlabl.Text =  dt.Rows[0][0].ToString();
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            milknumlabl.Text =   dt.Rows[0][0].ToString()+"liters";
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            EmpNumlabl.Text = dt.Rows[0][0].ToString() + "liters";
            con.Close();
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

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Inclabe_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
