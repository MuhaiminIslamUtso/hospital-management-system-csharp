using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AdHome : Form
    {
        public AdHome()
        {
            InitializeComponent();
           }

        private void btnDashboard_Click(object sender, EventArgs e)
        
        {
            
            if (pnladdes != null)
            {
                pnladdes.Visible = true;
            }
            else
            {
                MessageBox.Show("Error: pnladdes is not initialized.");
            }
        }

        private void AdHome_Load(object sender, EventArgs e)
        {

            pnladdes.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LogingFrom l1 = new LogingFrom();
            l1.Show();
            this.Hide();
        }

        private void btnadDoctor_Click(object sender, EventArgs e)
        {

            AdDoctor d1 = new AdDoctor();
            d1.Show();
            this.Hide();
        }

        private void btndsnursem_Click(object sender, EventArgs e)
        {
            ADNurse d2 = new ADNurse();
            d2.Show();
            this.Hide();
        }

        private void btnadEmp_Click(object sender, EventArgs e)
        {
            AdEmployee d3 = new AdEmployee();
            d3.Show();
            this.Hide();
        }

        private void btnadTest_Click(object sender, EventArgs e)
        {
            AdTest d4 = new AdTest ();
            d4.Show();
            this.Hide();
        }

        private void btnadRoom_Click(object sender, EventArgs e)
        {
            AdRoom d5 = new AdRoom();
            d5.Show();
            this.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            User a1 = new User();
            a1.Show();
            this.Hide();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
           Balance bl = new Balance ();
            bl.Show();
            this.Hide();
        }

        private void btnAmBc_Click(object sender, EventArgs e)
        {
            AmountBarChart bc = new AmountBarChart();
            bc.Show();
            this.Hide();
        }
    }
    }
    

