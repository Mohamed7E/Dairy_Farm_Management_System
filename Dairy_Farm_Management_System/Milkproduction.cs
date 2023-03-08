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
    public partial class Milkproduction : Form
    {
        public Milkproduction()
        {
            InitializeComponent();
            FillCowId();
            populate();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Milkproduction_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

            Milkproduction Ob = new Milkproduction();
            Ob.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {
            CowHealth Ob = new CowHealth();
            Ob.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCowId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CowId from CowTbl ", con);
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
            string query = "select * from MilkSalesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Dailylist.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Clear()
        {
            CowIdCb.Text = "";
            Cownametb.Text = "";
            Amt.Text = "";
            Noontb.Text = "";
            PmTb.Text = "";
            TotalTb.Text = "";
        }
        private void GetCowName()
        {
            con.Open();
            string query = "select * from CowTbl where CowId =" + CowIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            DateTabl dt = new DateTabl();
            SqlDataAdapter sde = new SqlDataAdapter(cmd);
            sde.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Cownametb.Text = dr["CowName"].ToString();
            }
            con.Close();

        }
            private void button4_Click(object sender, EventArgs e)
        {

            if (CowIdCb.SelectedIndex== -1 || Cownametb.Text == "" || Amt.Text == "" || Noontb.Text == "" || PmTb.Text == "" || TotalTb.Text == "")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "inster into MilkTbl values ( '" + CowIdCb.SelectedValue.ToString() + "','" + Cownametb.Text + "','" + Amt.Text + "','" + Noontb.Text + "','" + TotalTb.Text + "','" + PmTb.Text + "','" + data.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cow Saved successdully");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CowIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCowName();
        }

        private void PmTb_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void PmTb_TextChanged(object sender, EventArgs e)
        {
                int total = Convert.ToInt32(Amt.Text) + Convert.ToInt32(PmTb.Text) + Convert.ToInt32(Noontb.Text);
                TotalTb.Text = "" + total;
            
        }
        int key = 0;
        private void Dailylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CowIdCb.SelectedValue = Dailylist.SelectedRows[0].Cells[1].Value.ToString();
            Cownametb.Text = Dailylist.SelectedRows[0].Cells[2].Value.ToString();
            Amt.Text = Dailylist.SelectedRows[0].Cells[3].Value.ToString();
            Noontb.Text = Dailylist.SelectedRows[0].Cells[4].Value.ToString();
            PmTb.Text = Dailylist.SelectedRows[0].Cells[5].Value.ToString();
            TotalTb.Text = Dailylist.SelectedRows[0].Cells[6].Value.ToString();
            data.Text = Dailylist.SelectedRows[0].Cells[7].Value.ToString();
            if (Cownametb.Text == "")
            {
                key = 0;
                            }
            else
            {

                key = Convert.ToInt32(Dailylist.SelectedRows[0].Cells[0].Value.ToString());
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select  Milk data ");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "delete from MilkTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
