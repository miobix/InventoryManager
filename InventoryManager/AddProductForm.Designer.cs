namespace InventoryManager
{
    partial class AddProductForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Panel panel1;
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.text_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.text_Quantity = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.text_ProductName = new System.Windows.Forms.TextBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label_Title = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(this.Button_Create, 0, 0);
            tableLayoutPanel2.Controls.Add(this.Button_Update, 1, 0);
            tableLayoutPanel2.Controls.Add(this.Button_Cancel, 2, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(88, 417);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(344, 60);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // Button_Create
            // 
            this.Button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Create.ForeColor = System.Drawing.Color.White;
            this.Button_Create.Location = new System.Drawing.Point(3, 3);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(108, 41);
            this.Button_Create.TabIndex = 0;
            this.Button_Create.Text = "Create";
            this.Button_Create.UseVisualStyleBackColor = false;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.NavajoWhite;
            this.Button_Update.Location = new System.Drawing.Point(117, 3);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(108, 41);
            this.Button_Update.TabIndex = 1;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Red;
            this.Button_Cancel.Location = new System.Drawing.Point(231, 3);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(110, 41);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(this.text_Description, 1, 3);
            tableLayoutPanel1.Controls.Add(this.label_Description, 0, 3);
            tableLayoutPanel1.Controls.Add(this.label_ProductName, 0, 0);
            tableLayoutPanel1.Controls.Add(this.label_Quantity, 0, 1);
            tableLayoutPanel1.Controls.Add(this.text_Price, 1, 2);
            tableLayoutPanel1.Controls.Add(this.text_Quantity, 1, 1);
            tableLayoutPanel1.Controls.Add(this.label_Price, 0, 2);
            tableLayoutPanel1.Controls.Add(this.text_ProductName, 1, 0);
            tableLayoutPanel1.Controls.Add(this.label_Category, 0, 4);
            tableLayoutPanel1.Controls.Add(this.comboBox_Category, 1, 4);
            tableLayoutPanel1.Location = new System.Drawing.Point(26, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(489, 284);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // text_Description
            // 
            this.text_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Description.Location = new System.Drawing.Point(198, 171);
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(288, 26);
            this.text_Description.TabIndex = 8;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(3, 168);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(189, 18);
            this.label_Description.TabIndex = 8;
            this.label_Description.Text = "Description:";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(3, 0);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(126, 18);
            this.label_ProductName.TabIndex = 1;
            this.label_ProductName.Text = "Product Name: ";
            // 
            // label_Quantity
            // 
            this.label_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(3, 56);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(189, 18);
            this.label_Quantity.TabIndex = 3;
            this.label_Quantity.Text = "Quantity:";
            // 
            // text_Price
            // 
            this.text_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Price.Location = new System.Drawing.Point(198, 115);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(288, 26);
            this.text_Price.TabIndex = 6;
            // 
            // text_Quantity
            // 
            this.text_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Quantity.Location = new System.Drawing.Point(198, 59);
            this.text_Quantity.Name = "text_Quantity";
            this.text_Quantity.Size = new System.Drawing.Size(288, 26);
            this.text_Quantity.TabIndex = 4;
            // 
            // label_Price
            // 
            this.label_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(3, 112);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(189, 18);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Price:";
            // 
            // text_ProductName
            // 
            this.text_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ProductName.Location = new System.Drawing.Point(198, 3);
            this.text_ProductName.Name = "text_ProductName";
            this.text_ProductName.Size = new System.Drawing.Size(288, 26);
            this.text_ProductName.TabIndex = 2;
            // 
            // label_Category
            // 
            this.label_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(3, 224);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(189, 18);
            this.label_Category.TabIndex = 11;
            this.label_Category.Text = "Category:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(198, 227);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(288, 26);
            this.comboBox_Category.TabIndex = 12;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.Controls.Add(this.label_Title);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(527, 66);
            panel1.TabIndex = 11;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(23, 24);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(188, 18);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Adding New Product...";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 476);
            this.Controls.Add(tableLayoutPanel2);
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Button_Create;
        public System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_Quantity;
        public System.Windows.Forms.TextBox text_Price;
        public System.Windows.Forms.TextBox text_Quantity;
        private System.Windows.Forms.Label label_Price;
        public System.Windows.Forms.TextBox text_ProductName;
        public System.Windows.Forms.Button Button_Update;
        public System.Windows.Forms.TextBox text_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Title;
        public System.Windows.Forms.ComboBox comboBox_Category;
    }
}