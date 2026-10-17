using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FrmReceipt : Form
    {
        private string receiptText;


        public FrmReceipt(string text)
        {
            InitializeComponent();
            receiptText = text;
            rtbReceipt.Text = receiptText;
        }
        private void FrmReceipt_Load(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(receiptText, new Font("Arial", 20), Brushes.Black, 100, 100);
            };

            PrintDialog printDialog = new PrintDialog { Document = pd };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

