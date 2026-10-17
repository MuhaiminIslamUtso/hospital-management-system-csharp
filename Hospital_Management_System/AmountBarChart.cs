using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hospital_Management_System
{
    public partial class AmountBarChart : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private decimal totalIncome = 0;
        private decimal totalExpenses = 0;

        public AmountBarChart()
        {
            InitializeComponent();
        }

        private void AmountBarChart_Load(object sender, EventArgs e)
        {
            cmbChartType.Items.AddRange(new string[] { "Bar", "Pie" });
            cmbChartType.SelectedIndex = 0;

            LoadTotals();
            DrawChart(cmbChartType.SelectedItem.ToString());
            ShowProfit();


        }
        private void LoadTotals()
        {
            totalIncome = 0;
            totalExpenses = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdIncome = new SqlCommand("SELECT ISNULL(SUM(PaidAmount), 0) FROM Payments", con);
                totalIncome = Convert.ToDecimal(cmdIncome.ExecuteScalar());

                SqlCommand cmdExpenses = new SqlCommand(@"
                    SELECT ISNULL(SUM(Salary), 0) FROM SalaryDetails
                    UNION ALL
                    SELECT ISNULL(SUM(Amount), 0) FROM BalanceDetails WHERE Type = 'Manual Expense'", con);

                using (SqlDataReader reader = cmdExpenses.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalExpenses += reader.GetDecimal(0);
                    }
                }
            }
        }

        private void DrawChart(string chartType)
        {
            {
                chartAmount.Series.Clear();
                chartAmount.Titles.Clear();
                chartAmount.Legends.Clear();
                chartAmount.ChartAreas.Clear();

                ChartArea area = new ChartArea("MainArea");
                area.AxisX.Title = "Category";
                area.AxisY.Title = "Amount (৳)";
                area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                chartAmount.ChartAreas.Add(area);

                chartAmount.Titles.Add("Income vs Expenses");
                chartAmount.Legends.Add("Legend");
                chartAmount.Legends[0].Docking = Docking.Bottom;

                

                Series series = new Series("Balance");
                series.ChartType = chartType == "Pie" ? SeriesChartType.Pie : SeriesChartType.Bar;
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                series.Points.AddXY("Income", totalIncome);
                series.Points.AddXY("Expenses", totalExpenses);

                series.Points[0].Color = Color.Green;
                series.Points[1].Color = Color.Red;

                series.Points[0].ToolTip = $"Income: {totalIncome:C}";
                series.Points[1].ToolTip = $"Expenses: {totalExpenses:C}";

                chartAmount.Series.Add(series);

                if (chartType == "Pie")
                    chartAmount.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
        }
       
      private void ShowProfit()
        {
            decimal profit = totalIncome - totalExpenses;

            // Determine the label text and color in one go
            lblProfit.Text = profit >= 0 ? $"Profit: {profit:C}" : $"Loss: {profit * -1:C}";
            lblProfit.ForeColor = profit >= 0 ? Color.Green : Color.Red;

        }

        private void cmbCharType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart(cmbChartType.SelectedItem.ToString());


        }
        private void btnExportChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG Image|*.png",
                Title = "Save Chart as Image"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chartAmount.SaveImage(sfd.FileName, ChartImageFormat.Png);
                MessageBox.Show("Chart saved successfully.");
            }
        }

        private void btnExportChart_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG Image|*.png",
                Title = "Save Chart as Image"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chartAmount.SaveImage(sfd.FileName, ChartImageFormat.Png);
                MessageBox.Show("Chart saved successfully.");
            }
        }

        private void btnAbBAck_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AdHome homeForm)
                {
                    homeForm.Show();
                    this.Hide();

                    if (homeForm.Controls["pnladdes"] is Panel pnl)
                        pnl.Visible = true;

                    return;
                }
            }
        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }
    }
}


