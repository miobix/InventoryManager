using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManager
{
    public partial class AddUserForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Create_Click(object sender, EventArgs e)
        {

            MySqlConnection MConn = null;
            MySqlCommand Comm = null;

            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();

                if (MConn.State == ConnectionState.Open)
                {
                    if (MessageBox.Show("Confirm Add user?", "Saving Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      
                        string queryString = "INSERT INTO dbims.tbuser (username, fullname, password,email,userId) VALUES (@username, @fullname, @password, @email, @userId)";
                        string newUuid = Guid.NewGuid().ToString();
                        Comm = new MySqlCommand(queryString, MConn);
                        Comm.Parameters.AddWithValue("username", text_Username.Text);
                        Comm.Parameters.AddWithValue("fullname", text_RealName.Text);
                        Comm.Parameters.AddWithValue("password", text_Password.Text);
                        Comm.Parameters.AddWithValue("email", text_Email.Text);
                        Comm.Parameters.AddWithValue("userId", newUuid);
                        Comm.ExecuteNonQuery();

                        MConn.Close();
                        MessageBox.Show("Saved!");
                        Clear();
                    }

                   
                }

                if (Comm != null) Comm.Dispose();

                if (MConn != null)
                {
                    if (MConn.State == ConnectionState.Open)
                        MConn.Close();
                    MConn.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (Comm != null) Comm.Dispose();

                if (MConn != null)
                {
                    if (MConn.State == ConnectionState.Open)
                        MConn.Close();
                    MConn.Dispose();
                }

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            text_Username.Clear();
            text_RealName.Clear();
            text_Password.Clear();
            text_Email.Clear();

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
