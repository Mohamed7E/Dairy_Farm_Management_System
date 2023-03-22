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
    public partial class CowHealth : Form
    {
        public CowHealth()
        {
            InitializeComponent();
            populate();
            FillCowId();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CowHealth_Load(object sender, EventArgs e)
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

        private void label15_Click(object sender, EventArgs e)
        {

            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCowId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CowId from HealthTbl ", con);
            SqlDataAdapter Rdr;
           // Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CowId", typeof(int));
           // dt.Load(Rdr);
            CowIdCb.ValueMember = "CowId";
           // CowIdCb.DateSource = dt;
            con.Close();

            
        }
        private void populate()
        {
            con.Open();
            string query = "select * from HealthTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Healthlist.DataSource = ds.Tables[0];
            con.Close();

        }
        private void GetCowName()
        {
            con.Open();
            string query = "select * from HealthTbl where CowId =" + CowIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sde = new SqlDataAdapter(cmd);
            sde.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CowNAmeTb.Text = dr["CowName"].ToString();
            }
            con.Close();

        }
        private void Clear()
        {
            CowNAmeTb.Text = "";
            EventTb.Text = "";
            DiagnosisTb.Text = "";
            TreatmentTb.Text = "";
            CostTb.Text = "";
            VetNameTb.Text = "";
            key = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (CowIdCb.SelectedIndex == -1 || CowNAmeTb.Text == "" || EventTb.Text == "" || DiagnosisTb.Text == "" || TreatmentTb.Text == "" || CostTb.Text == "" || VetNameTb.Text == "")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "insert into HealthTbl values ( '" + CowIdCb.SelectedValue.ToString() + "','" + CowNAmeTb.Text + "','" + data.Value.Date + "','" + EventTb.Text + "','" + DiagnosisTb.Text + "','" + TreatmentTb.Text + "','" + CostTb.Text + "','" + VetNameTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Health issue Saved ");
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

        private void CowIdCb_CausesValidationChanged(object sender, EventArgs e)
        {

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
        private void Healthlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CowIdCb.SelectedValue = Healthlist.SelectedRows[0].Cells[1].Value.ToString();
            CowNAmeTb.Text = Healthlist.SelectedRows[0].Cells[2].Value.ToString();
            data.Text = Healthlist.SelectedRows[0].Cells[3].Value.ToString();
            EventTb.Text = Healthlist.SelectedRows[0].Cells[4].Value.ToString();
            DiagnosisTb.Text = Healthlist.SelectedRows[0].Cells[5].Value.ToString();
            TreatmentTb.Text = Healthlist.SelectedRows[0].Cells[6].Value.ToString();
            CostTb.Text = Healthlist.SelectedRows[0].Cells[7].Value.ToString();
            VetNameTb.Text = Healthlist.SelectedRows[0].Cells[8].Value.ToString();
            if (CowNAmeTb.Text == "")
            {
                key = 0;
            }
            else
            {

                key = Convert.ToInt32(Healthlist.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select  product to be  deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "delete from HealthTbl where RepId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report Delete successdully");
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

            if (CowIdCb.SelectedIndex == -1 || CowNAmeTb.Text == "" || EventTb.Text == "" || DiagnosisTb.Text == "" || TreatmentTb.Text == "" || CostTb.Text == "" || VetNameTb.Text == "")

            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "update HealthTbl set CowId="+CowIdCb.SelectedValue.ToString()+",cowname='"+CowNAmeTb.Text+"',RepDate='"+data.Value.Date+"'Event='"+EventTb.Text +"','" + DiagnosisTb.Text + "','" + TreatmentTb.Text + "','" + CostTb.Text + "','" + VetNameTb.Text + "'where RepId=" +key+";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product  Update successdully");
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
