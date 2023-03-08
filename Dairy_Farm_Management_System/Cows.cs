using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dairy_Farm_Management_System
{
    public partial class Cows : Form
    {
        
        public Cows()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Breading Ob = new Breading();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Cows_Load(object sender, EventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from CowTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CowsList1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Clear()
        {
            CowNameTb.Text = "";
            EarTagTb.Text = "";
            ColorTb.Text = "";
            BreadTb.Text = "";
            WeigtatBirthTb.Text = "";
            AgeTb.Text = "";
            PastureTb.Text = "";
            key = 0;

        }
        int age = 0;
        private void SaveBtu_Click(object sender, EventArgs e)
        {
            if(CowNameTb.Text==""|| EarTagTb.Text==""|| ColorTb.Text==""|| BreadTb.Text==""|| AgeTb.Text==""|| WeigtatBirthTb.Text==""|| PastureTb.Text=="")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "inster into CowTbl values ( '" + CowNameTb.Text + "','" + EarTagTb.Text + "','" + ColorTb.Text + "','" + BreadTb.Text + "','" + age + "','" + WeigtatBirthTb.Text + "','" + PastureTb.Text + "')";
                    SqlCommand cmd = new SqlCommand( Query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cow Saved successdully");
                    con.Close();
                    populate();
                    Clear();


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DateOfBirthTb_ValueChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32((DateTime.Today.Date-DateOfBirthTb.Value.Date).Days)/365;
          
        }

        private void DateOfBirthTb_MouseLeave(object sender, EventArgs e)
        {
            age = Convert.ToInt32((DateTime.Today.Date - DateOfBirthTb.Value.Date).Days) / 365;
            AgeTb.Text = "" + age;
        }

        private void UpdateBtu_Click(object sender, EventArgs e)
        {
            Clear();
        }
        int key = 0;
        private void CowsList1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            CowNameTb.Text = CowsList1.SelectedRows[0].Cells[1].Value.ToString();
            EarTagTb.Text = CowsList1.SelectedRows[0].Cells[2].Value.ToString();
            ColorTb.Text = CowsList1.SelectedRows[0].Cells[3].Value.ToString();
            BreadTb.Text = CowsList1.SelectedRows[0].Cells[4].Value.ToString();
            AgeTb.Text = CowsList1.SelectedRows[0].Cells[5].Value.ToString();
            WeigtatBirthTb.Text = CowsList1.SelectedRows[0].Cells[6].Value.ToString();
            PastureTb.Text = CowsList1.SelectedRows[0].Cells[7].Value.ToString();
            if(CowNameTb.Text=="")
            {
                key = 0;
                age = 0;
            }
            else
            {
                
                    key = Convert.ToInt32(CowsList1.SelectedRows[0].Cells[0].Value.ToString());
                    age = Convert.ToInt32(CowsList1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtu_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("select data ");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query ="delete from CowTbl where CowId="+key+";" ;
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cow Delete successdully");
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

        private void EditBtu_Click(object sender, EventArgs e)
        {
            if (CowNameTb.Text == "" || EarTagTb.Text == "" || ColorTb.Text == "" || BreadTb.Text == "" || AgeTb.Text == "" || WeigtatBirthTb.Text == "" || PastureTb.Text == "")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "update CowTbl set CowName ='" + CowNameTb.Text + "',EarTag='" + EarTagTb.Text + "',Color='" + ColorTb.Text + "',Bread='" + BreadTb.Text + "',Age='" + age + "',WeigtAtBirth='" + WeigtatBirthTb.Text + "',Pasture='" + PastureTb.Text + "')";
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
