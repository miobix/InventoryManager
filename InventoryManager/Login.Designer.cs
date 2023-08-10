namespace InventoryManager
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Bttn = new System.Windows.Forms.Button();
            this.Exit_Bttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Pwd = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 93);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store Management System";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";

            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(50, 223);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(200, 21);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(50, 302);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(200, 21);
            this.textBox_Pwd.TabIndex = 4;
            this.textBox_Pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // Login_Bttn
            // 
            this.Login_Bttn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_Bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Bttn.Location = new System.Drawing.Point(51, 364);
            this.Login_Bttn.Name = "Login_Bttn";
            this.Login_Bttn.Size = new System.Drawing.Size(199, 35);
            this.Login_Bttn.TabIndex = 5;
            this.Login_Bttn.Text = "Login";
            this.Login_Bttn.UseVisualStyleBackColor = false;
            this.Login_Bttn.Click += new System.EventHandler(this.Login_Bttn_Click);
            // 
            // Exit_Bttn
            // 
            this.Exit_Bttn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Exit_Bttn.Location = new System.Drawing.Point(51, 418);
            this.Exit_Bttn.Name = "Exit_Bttn";
            this.Exit_Bttn.Size = new System.Drawing.Size(199, 35);
            this.Exit_Bttn.TabIndex = 6;
            this.Exit_Bttn.Text = "Exit";
            this.Exit_Bttn.UseVisualStyleBackColor = false;
            this.Exit_Bttn.Click += new System.EventHandler(this.Exit_Bttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(81, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login to continue";
            // 
            // checkBox_Pwd
            // 
            this.checkBox_Pwd.AutoSize = true;
            this.checkBox_Pwd.Location = new System.Drawing.Point(52, 329);
            this.checkBox_Pwd.Name = "checkBox_Pwd";
            this.checkBox_Pwd.Size = new System.Drawing.Size(117, 16);
            this.checkBox_Pwd.TabIndex = 8;
            this.checkBox_Pwd.Text = "Show Password";
            this.checkBox_Pwd.UseVisualStyleBackColor = true;
            this.checkBox_Pwd.CheckedChanged += new System.EventHandler(this.checkBox_Pwd_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.checkBox_Pwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit_Bttn);
            this.Controls.Add(this.Login_Bttn);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS - Cris";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_Bttn;
        private System.Windows.Forms.Button Exit_Bttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Pwd;
    }
}

