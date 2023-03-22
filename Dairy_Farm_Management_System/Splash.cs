using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dairy_Farm_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int Stratpoint = 0;
        void Splash_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Stratpoint += 1;
            if (Stratpoint == 100)
            {
                Stratpoint = 0;
                timer1.Stop();
                login Ob = new login();
                Ob.Show();
                this.Hide();
            }

        }
    }
}
