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
    public partial class CategoryForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;

        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int index = 0;
            dgvCategory.Rows.Clear();

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbCategory";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            
            while (dr.Read())
            {
                index++;
                dgvCategory.Rows.Add(index, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            MConn.Close();
        }
        
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
 
            if (colName == "Edit")
            {
                string catId = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                DataGridViewButtonCell editButtonCell = dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                editButtonCell.Tag = catId;

                AddCategoryForm CategoryModule = new AddCategoryForm(catId);
                CategoryModule.text_CatName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();


                CategoryModule.Button_Create.Enabled = false;
                CategoryModule.Button_Update.Enabled = true;
                CategoryModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Category Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();
                    string queryString = "DELETE FROM tbCategory WHERE catId LIKE '" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    Comm = new MySqlCommand(queryString, MConn);
                    Comm.ExecuteNonQuery();
                    MConn.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadCategory();
        }

        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm AddCategory = new AddCategoryForm("no Id");
            AddCategory.Button_Create.Enabled = true;
            AddCategory.Button_Update.Enabled = false;
            AddCategory.ShowDialog();
            LoadCategory();
        }
    }
}
