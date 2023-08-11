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
    public partial class AddPurchaseForm : Form
    {
        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlCommand commUpdate = null;
        MySqlDataReader dr;

        string purchId;
        string price;
        public bool EnableCellClickEventHandling { get; set; }

        //store amount of item on inventory
        int inventoryQuantity = 0;

        public AddPurchaseForm(string _purchId, string _price)
        {
            InitializeComponent();
            LoadUser();
            LoadProduct();
            purchId = _purchId;
            price = _price;
            dgvUser.CellClick += dgvUser_CellClick;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadUser()
        {
            int index = 0;
            dgvUser.Rows.Clear();

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbuser WHERE CONCAT(username, email,userId) LIKE '%" + text_SearchUser.Text + "%'";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                index++;
                dgvUser.Rows.Add(index, dr[4].ToString(), dr[0].ToString() );
            }
            dr.Close();
            MConn.Close();
        }

        public void LoadProduct()
        {
            int index = 0;
            dgvProduct.Rows.Clear();

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbProduct WHERE CONCAT(prodId, prodName,prodPrice,prodDescription,prodCat) LIKE '%" + text_SearchProduct.Text + "%'";
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

        private void text_SearchUser_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void text_SearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void numeric_Quantity_ValueChanged(object sender, EventArgs e)
        {
            getInventoryQty();
            int recordedQty = getRecordedQty();
            int desiredQuantity = Convert.ToInt32(numeric_Quantity.Value);
            if (recordedQty > 0 && desiredQuantity - recordedQty > inventoryQuantity)
            {
                MessageBox.Show("Not enough stock for this purchase", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numeric_Quantity.Value = numeric_Quantity.Value - 1; 
                return;
            }


            if(desiredQuantity > 0)
            {
                int total;
                if (EnableCellClickEventHandling)
                {
                    total = Convert.ToInt32(text_Price.Text) * desiredQuantity;
                }
                else if (!EnableCellClickEventHandling)
                {
                    total = Convert.ToInt32(price) * desiredQuantity;
                }
                else total = 0;
                text_Total.Text = total.ToString();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!EnableCellClickEventHandling)
            {
                // If event handling is disabled, return without further action
                return;
            }
            text_UserId.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_UserName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!EnableCellClickEventHandling)
            {
                // If event handling is disabled, return without further action
                return;
            }
            text_ProdId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_ProdName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Price.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
         
            try
            {
                MConn = new MySqlConnection(strSQL);
                MConn.Open();

                if (MConn.State == ConnectionState.Open)
                {
                    if(text_UserId.Text == "")
                    {
                        MessageBox.Show("Select a customer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (text_ProdId.Text == "")
                    {
                        MessageBox.Show("Select a product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (MessageBox.Show("Confirm Add purchase?", "Saving Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //insert the new purhcase order
                        string queryString = "INSERT INTO dbims.tbPurchase (purchId, purchDate, prodId, userId, prodQuantity, prodPrice, purchTotal) VALUES (@purchId, @purchDate, @prodId, @userId, @prodQuantity, @prodPrice, @purchTotal)";
                        string newUuid = Guid.NewGuid().ToString();
                        Comm = new MySqlCommand(queryString, MConn);
                        Comm.Parameters.AddWithValue("purchId", newUuid);
                        Comm.Parameters.AddWithValue("purchDate", date_PurchaseDate.Value);
                        Comm.Parameters.AddWithValue("prodId", text_ProdId.Text);
                        Comm.Parameters.AddWithValue("userId", text_UserId.Text);
                        Comm.Parameters.AddWithValue("prodQuantity", numeric_Quantity.Value);
                        Comm.Parameters.AddWithValue("prodPrice", Convert.ToInt32(text_Price.Text));
                        Comm.Parameters.AddWithValue("purchTotal", Convert.ToInt32(text_Total.Text));
                        Comm.ExecuteNonQuery();

                        //MConn.Close();
                        MessageBox.Show("Saved!");
                        

                        //update the remaining quantity after purchase
                        string queryUpdate = "UPDATE tbProduct SET prodQuantity= (prodQuantity - @prodQuantity) WHERE prodId LIKE '" + text_ProdId.Text + "'";
                        Comm = new MySqlCommand(queryUpdate, MConn);
                        Comm.Parameters.AddWithValue("prodQuantity", Convert.ToInt32(numeric_Quantity.Value));
                        Comm.ExecuteNonQuery();
                        MConn.Close();

                        Clear();
                        LoadProduct();
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


        public void Clear()
        {
            text_UserId.Clear();
            text_UserName.Clear();
            text_ProdId.Clear();
            text_ProdName.Clear();
            text_Price.Clear();
            text_Total.Clear();
            numeric_Quantity.Value = 0;
            date_PurchaseDate.Value = DateTime.Now;
        }

        public void getInventoryQty()
        {
            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT prodQuantity FROM tbProduct WHERE prodId LIKE '" + text_ProdId.Text + "'";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                inventoryQuantity = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            MConn.Close();
        }

        public int getRecordedQty()
        {
            int returnValue = 0;
            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT prodQuantity FROM tbPurchase WHERE purchId LIKE '" + purchId + "'";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                returnValue = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            MConn.Close();
            return returnValue;
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            
                try
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();

                    if (MConn.State == ConnectionState.Open)
                    {
                        if (MessageBox.Show("Confirm Updating purchase?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string queryString = "UPDATE tbPurchase SET prodQuantity=@prodQuantity, purchTotal=@purchTotal WHERE purchId LIKE '" + purchId + "'";

                            Comm = new MySqlCommand(queryString, MConn);
                            Comm.Parameters.AddWithValue("prodQuantity", numeric_Quantity.Value);
                            Comm.Parameters.AddWithValue("purchTotal", Convert.ToInt32(text_Total.Text));
                            Comm.ExecuteNonQuery();
                          
                            MessageBox.Show("Updated!");

                        int recordedQty = getRecordedQty();
                        string queryUpdate = "UPDATE tbProduct SET prodQuantity= (prodQuantity + @prodQuantity) WHERE prodId LIKE '" + text_ProdId.Text + "'";
                        commUpdate = new MySqlCommand(queryUpdate, MConn);
                        int updateValue = Convert.ToInt32(numeric_Quantity.Value) - recordedQty;
                        commUpdate.Parameters.AddWithValue("prodQuantity", updateValue);
                        commUpdate.ExecuteNonQuery();
                        MConn.Close();
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
