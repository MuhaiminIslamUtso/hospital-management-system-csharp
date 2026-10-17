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
    public partial class RcHome : Form
    {
        public RcHome()
        {
            InitializeComponent();
        }

        private void btnRcLogout_Click(object sender, EventArgs e)
        {
            //LogingFrom l1 = new LogingFrom();
            //l1.Show();
            //this.Hide();
            LogingFrom l1 = new LogingFrom();
            l1.Show();
            this.Hide();

        }

        private void btnRcPatientma_Click(object sender, EventArgs e)
        {
            RcPatient r1 = new RcPatient();
            r1.Show();
            this.Hide();

        }

        private void btnRcAppointment_Click(object sender, EventArgs e)
        {
            RcAppointment a1 = new RcAppointment();
            a1.Show();
            this.Hide();
        }

        private void btnRcRoom_Click(object sender, EventArgs e)
        {
            RcRoom rc = new RcRoom();
            rc.Show();
            this.Hide();
        }

        private void btnRcTest_Click(object sender, EventArgs e)
        {
            RcTest t1 = new RcTest();
            t1.Show();
            this.Hide();

        }

        private void btnRcBilling_Click(object sender, EventArgs e)
        {
            RcBilling r1 = new RcBilling();
            r1.Show();
            this.Hide();    

        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
         Absence a1 = new Absence();
            a1.Show();
            this.Hide();
        }
    }
}
