using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventoryManager
{
    public partial class ReportForm : Form
    {
        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;        

        public ReportForm()
        {
            InitializeComponent();
            LoadReport();
        }

        public void LoadReport()
        {
            PopulateDataGridWeek();
            PopulateChart();
            PopulateDataGridSoldOut();
            PopulateSoldOutChart();
        }

        public DataTable GetWeeklySalesData()
        {
            DateTime endDate = DateTime.Now.Date;
            DateTime startDate = endDate.AddDays(-6); // 7 days ago

            string queryString = @"
                    SELECT DATE(purchDate) AS SalesDate, SUM(prodPrice * prodQuantity) AS TotalSales
                    FROM tbPurchase
                    WHERE purchDate >= CURDATE() - INTERVAL 7 DAY
                    GROUP BY DATE(purchDate)
                    ORDER BY SalesDate";
            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, MConn);
            DataTable salesData = new DataTable();
            adapter.Fill(salesData);
            return salesData;

        }

        public DataTable GetSouldOutProducts()
        {
            string queryString = @"
                SELECT prodName, prodQuantity, prodId, prodQuantity, prodPrice
                FROM tbProduct
                WHERE prodQuantity <= 10";

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, MConn);
            DataTable productsData = new DataTable();
            adapter.Fill(productsData);
            return productsData;
        }
         
        public void PopulateDataGridWeek()
        {
            DataTable salesData = GetWeeklySalesData();
            dataGridView_Report1.Columns.Clear();

            dataGridView_Report1.Columns.Add("Date", "Date");
            dataGridView_Report1.Columns.Add("Total Sales KRW", "Total Sales KRW");

            dataGridView_Report1.Columns["Date"].DefaultCellStyle.Format = "yy/MM/dd";
            // Populate rows with data
            foreach (DataRow row in salesData.Rows)
            {
                string saleDate = row["SalesDate"].ToString();
                
                int totalValue = Convert.ToInt32(row["TotalSales"]);
                //string prodId = row["prodId"].ToString(); ;

                dataGridView_Report1.Rows.Add(saleDate, totalValue);
            }
            dataGridView_Report1.RowHeadersVisible = false;
            dataGridView_Report1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
        }

        public void PopulateDataGridSoldOut()
        {
            DataTable productsData = GetSouldOutProducts();
            dataGridView_Report2.Columns.Clear();

            dataGridView_Report2.Columns.Add("ProductName", "Product Name");
            dataGridView_Report2.Columns.Add("RemainingQuantity", "Remaining Quantity");
            dataGridView_Report2.Columns.Add("ID", "ID");

            // Populate rows with data
            foreach (DataRow row in productsData.Rows)
            {
                string productName = row["prodName"].ToString();
                int remainingQuantity = Convert.ToInt32(row["prodQuantity"]);
                string prodId = row["prodId"].ToString(); ;

                dataGridView_Report2.Rows.Add(productName, remainingQuantity, prodId);
            }
            dataGridView_Report2.RowHeadersVisible = false;
            dataGridView_Report2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void PopulateChart()
        {
            DataTable weeklySalesData = GetWeeklySalesData();

            // Assuming you have added a Chart control named chart1 to your form
            chart_week.Series.Clear();
            Series series = chart_week.Series.Add("Total Volume");
            series.IsVisibleInLegend = false;

            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in weeklySalesData.Rows)
            {
                string salesDate = row["SalesDate"].ToString();
                decimal totalSales = Convert.ToDecimal(row["TotalSales"]);
                series.Points.AddXY(DateTime.Parse(salesDate), totalSales);
            }
           
            chart_week.ChartAreas[0].AxisY.Title = "KRW";

            chart_week.ChartAreas[0].AxisX.LabelStyle.Format = "yy/MM/dd";
            chart_week.Titles.Add("Total Sales, 7 days period");
            chart_week.Legends[0].Docking = Docking.Bottom;
            chart_week.Legends[0].Alignment = StringAlignment.Center;

        }

        public void PopulateSoldOutChart()
        {
            DataTable productsData = GetSouldOutProducts();

            chart_soldout.Series.Clear();
            Series series = chart_soldout.Series.Add("Total Value");
            series.IsVisibleInLegend = false;

            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in productsData.Rows)
            {
                string productName = row["prodName"].ToString();
                int remainingQuantity = Convert.ToInt32(row["prodQuantity"]);
                decimal price = Convert.ToDecimal(row["prodPrice"]);
                decimal productSales = price * (10 - remainingQuantity); // Assuming threshold is 10

                // Add data points to the series
                series.Points.AddXY(productName, productSales);
            }

            // Customize chart appearance if needed
            chart_soldout.Titles.Add("Total Product Value for Soon to be Sold Out Products, in KRW");
            chart_soldout.ChartAreas[0].AxisX.Interval = 1; // Display every label
        }



    }
}
