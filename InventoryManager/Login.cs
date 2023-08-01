using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Pwd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Pwd.Checked == false)
            {
                textBox_Pwd.UseSystemPasswordChar = true;
            }
            else
                textBox_Pwd.UseSystemPasswordChar = false;

        }

        private void Login_Bttn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Exit_Bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
