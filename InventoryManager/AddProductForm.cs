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
    public partial class AddProductForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        string productId;

        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;


        public AddProductForm(string _productId)
        {
            InitializeComponent();
            LoadCategory();
            productId = _productId;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();

                    if (MConn.State == ConnectionState.Open)
                    {
                        if (MessageBox.Show("Confirm Add product?", "Saving Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string queryString = "INSERT INTO dbims.tbProduct (prodId, prodName, prodQuantity,prodPrice,prodDescription,prodCat) VALUES (@prodId, @prodName, @prodQuantity, @prodPrice, @prodDescription, @prodCat)";
                            string newUuid = Guid.NewGuid().ToString();
                            Comm = new MySqlCommand(queryString, MConn);
                            Comm.Parameters.AddWithValue("prodId", newUuid);
                            Comm.Parameters.AddWithValue("prodName", text_ProductName.Text);
                            Comm.Parameters.AddWithValue("prodQuantity", Convert.ToInt16(text_Quantity.Text));
                            Comm.Parameters.AddWithValue("prodPrice", Convert.ToInt16(text_Price.Text));
                            Comm.Parameters.AddWithValue("prodDescription", text_Description.Text);
                            Comm.Parameters.AddWithValue("prodCat", comboBox_Category.Text);
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
            
        }

        public void LoadCategory()
        {
            comboBox_Category.Items.Clear();


            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT catName FROM tbCategory";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                comboBox_Category.Items.Add(dr[0].ToString());
            }
            dr.Close();
            MConn.Close();
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void Clear()
        {
            text_Description.Clear();
            text_ProductName.Clear();
            text_Price.Clear();
            text_Quantity.Clear();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            MySqlConnection MConn = null;
            MySqlCommand Comm = null;

            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();

                if (MConn.State == ConnectionState.Open)
                {
                    if (MessageBox.Show("Confirm Updating product?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string queryString = "UPDATE tbProduct SET prodName=@prodName, prodQuantity=@prodQuantity, prodPrice=@prodPrice,prodDescription=@prodDescription,prodCat=@prodCat WHERE prodId LIKE '" + productId + "'";

                        Comm = new MySqlCommand(queryString, MConn);
                        Comm.Parameters.AddWithValue("prodName", text_ProductName.Text);
                        Comm.Parameters.AddWithValue("prodQuantity", Convert.ToInt16(text_Quantity.Text));
                        Comm.Parameters.AddWithValue("prodPrice", Convert.ToInt16(text_Price.Text));
                        Comm.Parameters.AddWithValue("prodDescription", text_Description.Text);
                        Comm.Parameters.AddWithValue("prodCat", comboBox_Category.Text);
                        Comm.ExecuteNonQuery();
                        MConn.Close();
                        MessageBox.Show("Updated!");
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

    }

}