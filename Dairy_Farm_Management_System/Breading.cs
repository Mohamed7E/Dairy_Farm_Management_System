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
           // Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CowId", typeof(int));
           /// dt.Load(Rdr);
            CowIdCb.ValueMember = "CowId";
           // CowIdCb.DateSource = dt;
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
                CowAgeTb.Text = dr["Age"].ToString();
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
                    string Query = "insert into BreedTbl values ( '" + HealDate.Value.Date + "','" + BreedDate .Value.Date+ "','" +CowIdCb.SelectedValue.ToString()+ "','" +CowNametb.Text+ "','" + pregDate.Value.Date + "','" + EXDate.Value.Date + "','" + DateCaved.Value.Date + "'," +CowAgeTb.Text + "','" + RemarksTb.Text + "' )";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Breeding Report Saved ");
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

        private void CowIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCowName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
        int key = 0;
        private void Breedlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            HealDate.Text = Breedlist.SelectedRows[0].Cells[1].Value.ToString();
            BreedDate.Text = Breedlist.SelectedRows[0].Cells[2].Value.ToString();
            CowIdCb.SelectedValue = Breedlist.SelectedRows[0].Cells[3].Value.ToString();
            CowNametb.Text = Breedlist.SelectedRows[0].Cells[4].Value.ToString();
            pregDate.Text = Breedlist.SelectedRows[0].Cells[5].Value.ToString();
            EXDate.Text = Breedlist.SelectedRows[0].Cells[6].Value.ToString();
            DateCaved.Text = Breedlist.SelectedRows[0].Cells[7].Value.ToString();
            CowAgeTb.Text = Breedlist.SelectedRows[0].Cells[8].Value.ToString();
            RemarksTb.Text= Breedlist.SelectedRows[0].Cells[9].Value.ToString();
            if (CowNametb.Text == "")
            {
                key = 0;
            }
            else
            {

                key = Convert.ToInt32(Breedlist.SelectedRows[0].Cells[0].Value.ToString());

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select Breed Report to be  deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "delete from BreedTbl where BrId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Breed  Delete successdully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(CowIdCb.SelectedIndex == -1 || CowNametb.Text == "" || RemarksTb.Text == "" || CowAgeTb.Text == "")

            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "update BreedTbl set HeatDate=" + HealDate.Value.Date + ",BreedDate='" + BreedDate.Value.Date + "',CowId='" + CowIdCb.SelectedValue.ToString() + "'CowName='" + CowNametb.Text + "',pregDate='" + pregDate.Value.Date + "',ExpDateCalve='" + EXDate.Value.Date + "',DateCaved='" + DateCaved.Value.Date + "',CowAge='" + CowAgeTb.Text + "',Remarks='" + RemarksTb.Text + "'where BrId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Breed  Update successdully");
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
    }
}
