﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dairy_Farm_Management_System
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
            populateEXp();
            populateInc();
            FillCowId();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
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
        
        private void populateEXp()
        {
            con.Open();
            string query = "select * from ExpenditureTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExDate.DataSource = ds.Tables[0];
            con.Close();

        }
        private void populateInc()
        {
            con.Open();
            string query = "select * from IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeList.DataSource = ds.Tables[0];
            con.Close();

        }
        private void FliterIncme()
        {
            con.Open();
            string query = "select * from IncomeTbl Where IncDate='" + IncomeDateFilter.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeList.DataSource = ds.Tables[0];
            con.Close();

        }
        private void FliterExp()
        {
            con.Open();
            string query = "select * from ExpenditureTbl Where ExpDate='" +ExDateRFilter.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExDate.DataSource = ds.Tables[0];
            con.Close();

        }
        private void ClearEXp()
        {
            AmountTb.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (PurposeTb.SelectedIndex == -1 || AmountTb.Text == ""|| EmpIdCb.SelectedIndex==-1)
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "insert into ExpenditureTbl values (' " + date.Value.Date + "','" + PurposeTb.SelectedItem.ToString() + "','" + AmountTb.Text + "','" + EmpIdCb.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expenditure Saved successdully");
                    con.Close();
                    populateEXp();
                    ClearEXp();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
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
        private void ClearInc()
        {
            IncPutCb.SelectedItem = -1;
            IncAmount.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IncPutCb.SelectedIndex == -1 || IncAmount.Text == ""|| EmpIdCb.SelectedIndex==-1)
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "insert into IncomeTbl values (' " + IncDate.Value.Date + "','" + IncPutCb.SelectedItem.ToString() + "','" + IncAmount.Text + "','" + EmpIdCb.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("IncomeTbl Saved successdully");
                    con.Close();
                    populateInc();
                    ClearInc();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void IncomeDateFilter_ValueChanged(object sender, EventArgs e)
        {
            FliterIncme();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            populateInc();

        }

        private void ExDateRFilter_ValueChanged(object sender, EventArgs e)
        {
            FliterExp();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            populateEXp();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
