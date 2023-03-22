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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeList.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Clear()
        {
            NameTb.Text = "";
            GenderCb.SelectedIndex =-1 ;
            AddressTb.Text = "";
            PhoneTb.Text ="";
            key = 0;
            PasswordTb.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || AddressTb.Text == "" || PhoneTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "insert into EmployeeTbl values ( '" + NameTb.Text + "','" + data.Value.Date + "','" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + PasswordTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Emplyoee Saved ");
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

        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            data.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            PasswordTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;

            }
            else
            {

                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select  Employee to be  deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "delete from EmployeeTbl where EmpId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Delete successdully");
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
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || AddressTb.Text == "" || PhoneTb.Text == "")

            {
                MessageBox.Show("missing informatiom");
            }
            else
            {
                try
                {
                    con.Open();
                    string Query = "update EmployeeTbl set EmpName ='" + NameTb.Text + "',EmpDob='" + data.Value.Date + "',Gender='" + GenderCb.SelectedItem.ToString() + "',Phone='" + PhoneTb.Text + "',Address='" + AddressTb.Text + "',Emppass='" + PasswordTb.Text + "'where EmpId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update successdully");
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
