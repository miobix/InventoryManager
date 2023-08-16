namespace InventoryManager
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayout_Report = new System.Windows.Forms.TableLayoutPanel();
            this.chart_week = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_Report1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Report2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_soldout = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayout_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_week)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_soldout)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout_Report
            // 
            this.tableLayout_Report.ColumnCount = 2;
            this.tableLayout_Report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.37037F));
            this.tableLayout_Report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.62963F));
            this.tableLayout_Report.Controls.Add(this.chart_soldout, 1, 1);
            this.tableLayout_Report.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayout_Report.Controls.Add(this.chart_week, 1, 0);
            this.tableLayout_Report.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayout_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Report.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Report.Name = "tableLayout_Report";
            this.tableLayout_Report.RowCount = 2;
            this.tableLayout_Report.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Report.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Report.Size = new System.Drawing.Size(810, 650);
            this.tableLayout_Report.TabIndex = 4;
            // 
            // chart_week
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_week.ChartAreas.Add(chartArea2);
            this.chart_week.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_week.Legends.Add(legend2);
            this.chart_week.Location = new System.Drawing.Point(329, 3);
            this.chart_week.Name = "chart_week";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_week.Series.Add(series2);
            this.chart_week.Size = new System.Drawing.Size(478, 319);
            this.chart_week.TabIndex = 0;
            this.chart_week.Text = "chart1";
            // 
            // dataGridView_Report1
            // 
            this.dataGridView_Report1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Report1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView_Report1.Name = "dataGridView_Report1";
            this.dataGridView_Report1.ReadOnly = true;
            this.dataGridView_Report1.Size = new System.Drawing.Size(314, 247);
            this.dataGridView_Report1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Report1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.07801F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 319);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail of Daily Sales";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Report2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92199F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.07801F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 319);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dataGridView_Report2
            // 
            this.dataGridView_Report2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Report2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Report2.Location = new System.Drawing.Point(3, 69);
            this.dataGridView_Report2.Name = "dataGridView_Report2";
            this.dataGridView_Report2.ReadOnly = true;
            this.dataGridView_Report2.Size = new System.Drawing.Size(314, 247);
            this.dataGridView_Report2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products soon to be sold out";
            // 
            // chart_soldout
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_soldout.ChartAreas.Add(chartArea1);
            this.chart_soldout.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_soldout.Legends.Add(legend1);
            this.chart_soldout.Location = new System.Drawing.Point(329, 328);
            this.chart_soldout.Name = "chart_soldout";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_soldout.Series.Add(series1);
            this.chart_soldout.Size = new System.Drawing.Size(478, 319);
            this.chart_soldout.TabIndex = 5;
            this.chart_soldout.Text = "chart2";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 650);
            this.Controls.Add(this.tableLayout_Report);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.tableLayout_Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_week)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_soldout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayout_Report;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_week;
        private System.Windows.Forms.DataGridView dataGridView_Report1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_Report2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_soldout;
    }
}