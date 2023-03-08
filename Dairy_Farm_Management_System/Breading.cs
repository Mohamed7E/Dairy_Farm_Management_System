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
    public partial class Breading : Form
    {
        public Breading()
        {
            InitializeComponent();
            FillCowId();
            populate();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Breading_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("select CowId from BreedTbl ", con);
            SqlDataAdapter Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CowId", typeof(int));
            dt.Load(Rdr);
            CowIdCb.ValueMember = "CowId";
            CowIdCb.DateSource = dt;
            con.Close();


        }
        private void populate()
        {
            con.Open();
            string query = "select * from BreedTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Breedlist.DataSource = ds.Tables[0];
            con.Close();

        }
        private void GetCowName()
        {
            con.Open();
            string query = "select * from CowTbl where CowId =" + CowIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sde = new SqlDataAdapter(cmd);
            sde.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CowNametb.Text = dr["CowName"].ToString();
            }
            con.Close();

        }

        private void Clear()
        {
            CowNametb.Text = "";
            RemarksTb.Text = "";
            CowAgeTb.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (CowIdCb.SelectedIndex == -1 || CowNametb.Text == "" || RemarksTb.Text == "" || CowAgeTb.Text == "" )
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "inster into HealthTbl values ( '" + HealDate.Value.Date + "','" + BreedDate .Value.Date+ "','" +CowIdCb.SelectedValue.ToString()+ "','" +CowNametb.Text+ "','" + pregDate.Value.Date + "','" + EXDate.Value.Date + "','" + DateCaved.Value.Date + "'," +CowAgeTb.Text + "','" + RemarksTb.Text + "' )";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Breeding Report Saved ");
                    con.Close();
                    populate();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CowIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCowName();
        }
    }
}
