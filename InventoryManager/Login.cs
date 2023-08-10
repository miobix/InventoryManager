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

namespace InventoryManager
{
    public partial class Login : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
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
            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();
                string queryString = "SELECT * FROM tbUser WHERE username=@username AND password=@password";
                Comm = new MySqlCommand(queryString, MConn);

                Comm.Parameters.AddWithValue("@username", textBox_Username.Text);
                Comm.Parameters.AddWithValue("@password", textBox_Pwd.Text);

                dr = Comm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome, " + dr["fullname"].ToString() + "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage homepage = new HomePage();
                    
                    this.Hide();
                    homepage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
