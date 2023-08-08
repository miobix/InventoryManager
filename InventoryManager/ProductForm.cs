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
    public partial class ProductForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;

        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int index = 0;
            dgvProduct.Rows.Clear();

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbProduct";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                index++;
                dgvProduct.Rows.Add(index, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            MConn.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                string prodID = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                DataGridViewButtonCell editButtonCell = dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                editButtonCell.Tag = prodID;

                AddProductForm prodModule = new AddProductForm(prodID);
                prodModule.text_ProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                prodModule.text_Quantity.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                prodModule.text_Price.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                prodModule.text_Description.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                prodModule.comboBox_Category.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                prodModule.Button_Create.Enabled = false;
                prodModule.Button_Update.Enabled = true;
                prodModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete User Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();
                    string queryString = "DELETE FROM tbProduct WHERE prodId LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    Comm = new MySqlCommand(queryString, MConn);
                    Comm.ExecuteNonQuery();
                    MConn.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadProduct();
        }


        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            AddProductForm AddProduct = new AddProductForm("no Id");
            AddProduct.Button_Create.Enabled = true;
            AddProduct.Button_Update.Enabled = false;
            AddProduct.ShowDialog();
            LoadProduct();
        }
    }
}
