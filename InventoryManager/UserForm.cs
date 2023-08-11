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
    public partial class UserForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;

        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int index = 0;
            dgvUser.Rows.Clear();
            
            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbuser";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                index++;
                dgvUser.Rows.Add(index, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            MConn.Close();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                string userID = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                DataGridViewButtonCell editButtonCell = dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                editButtonCell.Tag = userID;

                AddUserForm userModule = new AddUserForm(userID);
                userModule.text_Username.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.text_RealName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.text_Password.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.text_RepeatPassword.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.text_Email.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                Console.WriteLine(userModule.text_Password.Text);
                Console.WriteLine(userModule.text_RepeatPassword.Text);
                userModule.Button_Create.Enabled = false;
                userModule.Button_Update.Enabled = true;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete?",  "Delete User Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();
                    string queryString = "DELETE FROM tbuser WHERE userId LIKE '" + dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString() + "'";
                    Comm = new MySqlCommand(queryString, MConn);
                    Comm.ExecuteNonQuery();
                    MConn.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadUser();
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm AddUser = new AddUserForm("no Id");
            AddUser.Button_Create.Enabled = true;
            AddUser.Button_Update.Enabled = false;
            AddUser.ShowDialog();
            LoadUser();
        }
    }
}
