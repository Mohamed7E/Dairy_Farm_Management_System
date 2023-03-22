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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\learn\learn C#\Dairy_Farm_Management_System\data_MOHAMED_EBRAHIM.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(UserName.Text==""||Password.Text=="")
            {
                MessageBox.Show("Enter username And password");

            }
            else
            {
                if (RoleCp.SelectedIndex > -1)
                {
                    if (RoleCp.SelectedItem.ToString() == "Admin")
                    {
                        if (UserName.Text == "Admin" && Password.Text == "Admin")
                        {
                            Employees emp = new Employees();
                            emp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin,Enter The Correct Id and Password ");

                        }

                    }
                    else
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select Cont(*) from EmployeeTbl where EmpName '" + UserName.Text + "' and Emppass'" + Password.Text + "'", con);
                        DataTable dt = new DataTable();
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Cows cow = new Cows();
                            cow.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("worng UserName or password");
                        }
                        con.Close();
                       

                    }
                }
                else
                {
                    MessageBox.Show("Worng Admin name or password");
                }
            }
            
            if (RoleCp.SelectedItem.ToString() == "Employee")
            {
                
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
