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
    public partial class AddCategoryForm : Form
    {
        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        string catId;

        public AddCategoryForm(string _catId)
        {
            InitializeComponent();
            catId = _catId;
        }



        public void Clear()
        {
            text_CatName.Clear();
        }


        private void Button_Create_Click_1(object sender, EventArgs e)
        {

            MySqlConnection MConn = null;
            MySqlCommand Comm = null;
            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();

                if (MConn.State == ConnectionState.Open)
                {
                    
                    if (MessageBox.Show("Confirm Add category?", "Saving Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string queryString = "INSERT INTO dbims.tbCategory (catId, catName) VALUES (@catId, @catName)";
                        string newUuid = Guid.NewGuid().ToString();
                        Comm = new MySqlCommand(queryString, MConn);

                        Comm.Parameters.AddWithValue("catId", newUuid);
                        Comm.Parameters.AddWithValue("catName", text_CatName.Text);

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


        private void Button_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void Button_Update_Click_1(object sender, EventArgs e)
        {
            MySqlConnection MConn = null;
            MySqlCommand Comm = null;

            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();

                if (MConn.State == ConnectionState.Open)
                {
                    if (MessageBox.Show("Confirm Updating category?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string queryString = "UPDATE tbCategory SET catName=@catName WHERE catId LIKE '" + catId + "'";

                        Comm = new MySqlCommand(queryString, MConn);
                        Comm.Parameters.AddWithValue("catName", text_CatName.Text);

                        Comm.ExecuteNonQuery();
                        MConn.Close();
                        MessageBox.Show("Updated!");

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


    }
}
