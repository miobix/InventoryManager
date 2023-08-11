namespace InventoryManager
{
    partial class AddPurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_RealName = new System.Windows.Forms.Label();
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.text_UserId = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.text_SearchUser = new System.Windows.Forms.TextBox();
            this.label_SearchUser = new System.Windows.Forms.Label();
            this.label_Customer = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Create = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Date = new System.Windows.Forms.Label();
            this.date_PurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label_ProdId = new System.Windows.Forms.Label();
            this.label_ProdName = new System.Windows.Forms.Label();
            this.text_ProdName = new System.Windows.Forms.TextBox();
            this.text_ProdId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Total = new System.Windows.Forms.Label();
            this.text_Total = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.numeric_Quantity = new System.Windows.Forms.NumericUpDown();
            this.text_SearchProduct = new System.Windows.Forms.TextBox();
            this.label_SearchProduct = new System.Windows.Forms.Label();
            this.label_Product = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Cancel.BackColor = System.Drawing.Color.Red;
            this.Button_Cancel.Location = new System.Drawing.Point(231, 9);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(110, 41);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding New Purchase Order...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 66);
            this.panel1.TabIndex = 11;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column1});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.RowTemplate.Height = 26;
            this.dgvUser.Size = new System.Drawing.Size(286, 247);
            this.dgvUser.TabIndex = 14;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "N";
            this.Column7.Name = "Column7";
            this.Column7.Width = 44;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 30;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "UserName";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.Width = 111;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.text_SearchUser);
            this.panel2.Controls.Add(this.label_SearchUser);
            this.panel2.Controls.Add(this.label_Customer);
            this.panel2.Controls.Add(this.dgvUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 543);
            this.panel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label_RealName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_UserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_UserId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Username, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 336);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 120);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label_RealName
            // 
            this.label_RealName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_RealName.AutoSize = true;
            this.label_RealName.Location = new System.Drawing.Point(3, 81);
            this.label_RealName.Name = "label_RealName";
            this.label_RealName.Size = new System.Drawing.Size(59, 18);
            this.label_RealName.TabIndex = 3;
            this.label_RealName.Text = "Name:";
            // 
            // text_UserName
            // 
            this.text_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_UserName.Enabled = false;
            this.text_UserName.Location = new System.Drawing.Point(105, 77);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(147, 26);
            this.text_UserName.TabIndex = 4;
            // 
            // text_UserId
            // 
            this.text_UserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_UserId.Enabled = false;
            this.text_UserId.Location = new System.Drawing.Point(105, 17);
            this.text_UserId.Name = "text_UserId";
            this.text_UserId.Size = new System.Drawing.Size(147, 26);
            this.text_UserId.TabIndex = 2;
            // 
            // label_Username
            // 
            this.label_Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(3, 21);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(80, 18);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Cust. ID: ";
            // 
            // text_SearchUser
            // 
            this.text_SearchUser.Location = new System.Drawing.Point(133, 253);
            this.text_SearchUser.Name = "text_SearchUser";
            this.text_SearchUser.Size = new System.Drawing.Size(131, 26);
            this.text_SearchUser.TabIndex = 18;
            this.text_SearchUser.TextChanged += new System.EventHandler(this.text_SearchUser_TextChanged);
            // 
            // label_SearchUser
            // 
            this.label_SearchUser.AutoSize = true;
            this.label_SearchUser.Location = new System.Drawing.Point(52, 256);
            this.label_SearchUser.Name = "label_SearchUser";
            this.label_SearchUser.Size = new System.Drawing.Size(66, 18);
            this.label_SearchUser.TabIndex = 17;
            this.label_SearchUser.Text = "Search:";
            // 
            // label_Customer
            // 
            this.label_Customer.AutoSize = true;
            this.label_Customer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customer.Location = new System.Drawing.Point(6, 297);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(88, 18);
            this.label_Customer.TabIndex = 15;
            this.label_Customer.Text = "Customer";
            // 
            // Button_Update
            // 
            this.Button_Update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Update.BackColor = System.Drawing.Color.NavajoWhite;
            this.Button_Update.Location = new System.Drawing.Point(117, 9);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(108, 41);
            this.Button_Update.TabIndex = 1;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Create
            // 
            this.Button_Create.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Create.ForeColor = System.Drawing.Color.White;
            this.Button_Create.Location = new System.Drawing.Point(3, 9);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(108, 41);
            this.Button_Create.TabIndex = 0;
            this.Button_Create.Text = "Save";
            this.Button_Create.UseVisualStyleBackColor = false;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Button_Create, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Update, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(241, 471);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 60);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.text_SearchProduct);
            this.panel3.Controls.Add(this.label_SearchProduct);
            this.panel3.Controls.Add(this.label_Product);
            this.panel3.Controls.Add(this.dgvProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(292, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 543);
            this.panel3.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label_Date, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.date_PurchaseDate, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label_ProdId, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_ProdName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.text_ProdName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.text_ProdId, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(17, 336);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(307, 120);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // label_Date
            // 
            this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(3, 91);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(116, 18);
            this.label_Date.TabIndex = 24;
            this.label_Date.Text = "Date:";
            // 
            // date_PurchaseDate
            // 
            this.date_PurchaseDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_PurchaseDate.CustomFormat = "yyyy/MM/dd";
            this.date_PurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_PurchaseDate.Location = new System.Drawing.Point(125, 87);
            this.date_PurchaseDate.MaxDate = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            this.date_PurchaseDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date_PurchaseDate.Name = "date_PurchaseDate";
            this.date_PurchaseDate.Size = new System.Drawing.Size(179, 26);
            this.date_PurchaseDate.TabIndex = 23;
            this.date_PurchaseDate.Value = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            // 
            // label_ProdId
            // 
            this.label_ProdId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ProdId.AutoSize = true;
            this.label_ProdId.Location = new System.Drawing.Point(3, 11);
            this.label_ProdId.Name = "label_ProdId";
            this.label_ProdId.Size = new System.Drawing.Size(80, 18);
            this.label_ProdId.TabIndex = 1;
            this.label_ProdId.Text = "Prod. ID: ";
            // 
            // label_ProdName
            // 
            this.label_ProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ProdName.AutoSize = true;
            this.label_ProdName.Location = new System.Drawing.Point(3, 51);
            this.label_ProdName.Name = "label_ProdName";
            this.label_ProdName.Size = new System.Drawing.Size(116, 18);
            this.label_ProdName.TabIndex = 3;
            this.label_ProdName.Text = "Prod Name:";
            // 
            // text_ProdName
            // 
            this.text_ProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ProdName.Enabled = false;
            this.text_ProdName.Location = new System.Drawing.Point(125, 47);
            this.text_ProdName.Name = "text_ProdName";
            this.text_ProdName.Size = new System.Drawing.Size(179, 26);
            this.text_ProdName.TabIndex = 4;
            // 
            // text_ProdId
            // 
            this.text_ProdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ProdId.Enabled = false;
            this.text_ProdId.Location = new System.Drawing.Point(125, 7);
            this.text_ProdId.Name = "text_ProdId";
            this.text_ProdId.Size = new System.Drawing.Size(179, 26);
            this.text_ProdId.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label_Total, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.text_Total, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_Price, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Quantity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.text_Price, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numeric_Quantity, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(341, 336);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(255, 120);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(3, 91);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(96, 18);
            this.label_Total.TabIndex = 6;
            this.label_Total.Text = "Total:";
            // 
            // text_Total
            // 
            this.text_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Total.Enabled = false;
            this.text_Total.Location = new System.Drawing.Point(105, 87);
            this.text_Total.Name = "text_Total";
            this.text_Total.Size = new System.Drawing.Size(147, 26);
            this.text_Total.TabIndex = 5;
            // 
            // label_Price
            // 
            this.label_Price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(3, 11);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(55, 18);
            this.label_Price.TabIndex = 1;
            this.label_Price.Text = "Price: ";
            // 
            // label_Quantity
            // 
            this.label_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(3, 51);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(96, 18);
            this.label_Quantity.TabIndex = 3;
            this.label_Quantity.Text = "Quantity:";
            // 
            // text_Price
            // 
            this.text_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Price.Enabled = false;
            this.text_Price.Location = new System.Drawing.Point(105, 7);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(147, 26);
            this.text_Price.TabIndex = 2;
            // 
            // numeric_Quantity
            // 
            this.numeric_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numeric_Quantity.Location = new System.Drawing.Point(105, 47);
            this.numeric_Quantity.Name = "numeric_Quantity";
            this.numeric_Quantity.Size = new System.Drawing.Size(147, 26);
            this.numeric_Quantity.TabIndex = 7;
            this.numeric_Quantity.ValueChanged += new System.EventHandler(this.numeric_Quantity_ValueChanged);
            // 
            // text_SearchProduct
            // 
            this.text_SearchProduct.Location = new System.Drawing.Point(350, 256);
            this.text_SearchProduct.Name = "text_SearchProduct";
            this.text_SearchProduct.Size = new System.Drawing.Size(235, 26);
            this.text_SearchProduct.TabIndex = 19;
            this.text_SearchProduct.TextChanged += new System.EventHandler(this.text_SearchProduct_TextChanged);
            // 
            // label_SearchProduct
            // 
            this.label_SearchProduct.AutoSize = true;
            this.label_SearchProduct.Location = new System.Drawing.Point(267, 259);
            this.label_SearchProduct.Name = "label_SearchProduct";
            this.label_SearchProduct.Size = new System.Drawing.Size(66, 18);
            this.label_SearchProduct.TabIndex = 18;
            this.label_SearchProduct.Text = "Search:";
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.Location = new System.Drawing.Point(26, 297);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(71, 18);
            this.label_Product.TabIndex = 16;
            this.label_Product.Text = "Product";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.CatId,
            this.CatName,
            this.Quantity,
            this.Price,
            this.Description,
            this.Category});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.RowTemplate.Height = 26;
            this.dgvProduct.Size = new System.Drawing.Size(608, 247);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "N";
            this.Number.Name = "Number";
            this.Number.Width = 44;
            // 
            // CatId
            // 
            this.CatId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CatId.HeaderText = "Product ID";
            this.CatId.MinimumWidth = 30;
            this.CatId.Name = "CatId";
            this.CatId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CatName
            // 
            this.CatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CatName.HeaderText = "Name";
            this.CatName.MinimumWidth = 100;
            this.CatName.Name = "CatName";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 96;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 68;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 115;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 102;
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPurchaseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button Button_Update;
        public System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_SearchUser;
        private System.Windows.Forms.Label label_SearchUser;
        private System.Windows.Forms.Label label_Customer;
        private System.Windows.Forms.TextBox text_SearchProduct;
        private System.Windows.Forms.Label label_SearchProduct;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_RealName;
        public System.Windows.Forms.TextBox text_UserName;
        public System.Windows.Forms.TextBox text_UserId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_ProdId;
        private System.Windows.Forms.Label label_ProdName;
        public System.Windows.Forms.TextBox text_ProdName;
        public System.Windows.Forms.TextBox text_ProdId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_Total;
        public System.Windows.Forms.TextBox text_Total;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Quantity;
        public System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.Label label_Date;
        public System.Windows.Forms.DateTimePicker date_PurchaseDate;
        public System.Windows.Forms.NumericUpDown numeric_Quantity;
    }
}