namespace InventoryManager
{
    partial class AddUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.text_RealName = new System.Windows.Forms.TextBox();
            this.label_RealName = new System.Windows.Forms.Label();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_RepeatPassword = new System.Windows.Forms.TextBox();
            this.label_RepeatPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding New User...";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(3, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(103, 18);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "User Name: ";
            // 
            // text_Username
            // 
            this.text_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Username.Location = new System.Drawing.Point(198, 3);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(288, 26);
            this.text_Username.TabIndex = 2;
            // 
            // text_RealName
            // 
            this.text_RealName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_RealName.Location = new System.Drawing.Point(198, 59);
            this.text_RealName.Name = "text_RealName";
            this.text_RealName.Size = new System.Drawing.Size(288, 26);
            this.text_RealName.TabIndex = 4;
            // 
            // label_RealName
            // 
            this.label_RealName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RealName.AutoSize = true;
            this.label_RealName.Location = new System.Drawing.Point(3, 56);
            this.label_RealName.Name = "label_RealName";
            this.label_RealName.Size = new System.Drawing.Size(189, 18);
            this.label_RealName.TabIndex = 3;
            this.label_RealName.Text = "Name:";
            // 
            // text_Password
            // 
            this.text_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Password.Location = new System.Drawing.Point(198, 115);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(288, 26);
            this.text_Password.TabIndex = 6;
            // 
            // label_Password
            // 
            this.label_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(3, 112);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(189, 18);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password:";
            // 
            // text_Email
            // 
            this.text_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Email.Location = new System.Drawing.Point(198, 227);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(288, 26);
            this.text_Email.TabIndex = 11;
            // 
            // label_Email
            // 
            this.label_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(3, 224);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(189, 18);
            this.label_Email.TabIndex = 11;
            this.label_Email.Text = "email:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.text_RepeatPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_RepeatPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_RealName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_Password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_RealName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Password, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_Username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_Email, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Email, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 284);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // text_RepeatPassword
            // 
            this.text_RepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_RepeatPassword.Location = new System.Drawing.Point(198, 171);
            this.text_RepeatPassword.Name = "text_RepeatPassword";
            this.text_RepeatPassword.Size = new System.Drawing.Size(288, 26);
            this.text_RepeatPassword.TabIndex = 8;
            // 
            // label_RepeatPassword
            // 
            this.label_RepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RepeatPassword.AutoSize = true;
            this.label_RepeatPassword.Location = new System.Drawing.Point(3, 168);
            this.label_RepeatPassword.Name = "label_RepeatPassword";
            this.label_RepeatPassword.Size = new System.Drawing.Size(189, 18);
            this.label_RepeatPassword.TabIndex = 8;
            this.label_RepeatPassword.Text = "Repeat Password:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Button_Create, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Update, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Cancel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(88, 418);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 60);
            this.tableLayoutPanel2.TabIndex = 10;
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
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 515);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_RealName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button Button_Create;
        public System.Windows.Forms.Button Button_Update;
        public System.Windows.Forms.Button Button_Cancel;
        public System.Windows.Forms.TextBox text_Username;
        public System.Windows.Forms.TextBox text_RealName;
        public System.Windows.Forms.TextBox text_Password;
        public System.Windows.Forms.TextBox text_Email;
        public System.Windows.Forms.TextBox text_RepeatPassword;
        private System.Windows.Forms.Label label_RepeatPassword;
    }
}