namespace InventoryManager
{
    partial class HomePage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Header_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Users = new System.Windows.Forms.Button();
            this.button_Categories = new System.Windows.Forms.Button();
            this.button_Purchases = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 22);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(794, 589);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Header_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 127);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.button_Products);
            this.Header_Panel.Controls.Add(this.button_Users);
            this.Header_Panel.Controls.Add(this.button_Categories);
            this.Header_Panel.Controls.Add(this.button_Purchases);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(3, 66);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(788, 58);
            this.Header_Panel.TabIndex = 6;
            this.Header_Panel.WrapContents = false;
            // 
            // button_Products
            // 
            this.button_Products.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Products.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Products.FlatAppearance.BorderSize = 0;
            this.button_Products.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Products.Location = new System.Drawing.Point(3, 3);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(190, 52);
            this.button_Products.TabIndex = 2;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = false;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Users
            // 
            this.button_Users.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Users.FlatAppearance.BorderSize = 0;
            this.button_Users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Users.Location = new System.Drawing.Point(199, 3);
            this.button_Users.Name = "button_Users";
            this.button_Users.Size = new System.Drawing.Size(190, 52);
            this.button_Users.TabIndex = 3;
            this.button_Users.Text = "Users";
            this.button_Users.UseVisualStyleBackColor = false;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // button_Categories
            // 
            this.button_Categories.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Categories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Categories.FlatAppearance.BorderSize = 0;
            this.button_Categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Categories.Location = new System.Drawing.Point(395, 3);
            this.button_Categories.Name = "button_Categories";
            this.button_Categories.Size = new System.Drawing.Size(190, 52);
            this.button_Categories.TabIndex = 4;
            this.button_Categories.Text = "Categories";
            this.button_Categories.UseVisualStyleBackColor = false;
            this.button_Categories.Click += new System.EventHandler(this.button_Categories_Click);
            // 
            // button_Purchases
            // 
            this.button_Purchases.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Purchases.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Purchases.FlatAppearance.BorderSize = 0;
            this.button_Purchases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Purchases.Location = new System.Drawing.Point(591, 3);
            this.button_Purchases.Name = "button_Purchases";
            this.button_Purchases.Size = new System.Drawing.Size(190, 52);
            this.button_Purchases.TabIndex = 5;
            this.button_Purchases.Text = "Purchases";
            this.button_Purchases.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(788, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Store Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Header_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Purchases;
        private System.Windows.Forms.Button button_Categories;
        private System.Windows.Forms.Button button_Users;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel Header_Panel;
    }
}