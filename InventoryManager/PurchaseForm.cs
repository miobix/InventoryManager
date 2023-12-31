﻿using MySql.Data.MySqlClient;
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
    public partial class PurchaseForm : Form
    {

        string strSQL = "Server=127.0.0.1;Port=3306;Database=dbims;Uid=root;Pwd=admin12345;CharSet=utf8";
        MySqlConnection MConn = null;
        MySqlCommand Comm = null;
        MySqlDataReader dr;

        public PurchaseForm()
        {
            InitializeComponent();
            LoadPurchase();
        }

        public void LoadPurchase()
        {
            int index = 0;
            dgvPurchase.Rows.Clear();

            MConn = new MySqlConnection(strSQL);
            MConn.Open();
            string queryString = "SELECT * FROM tbPurchase";
            Comm = new MySqlCommand(queryString, MConn);
            dr = Comm.ExecuteReader();
            while (dr.Read())
            {
                index++;
                dgvPurchase.Rows.Add(index, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("yyyy/MM/dd"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            Console.WriteLine("Type of price on table:" + dr[5].ToString().GetType());
            dr.Close();
            MConn.Close();
        }



        private void Button_AddPurchase_Click(object sender, EventArgs e)
        {
            AddPurchaseForm AddPurchase = new AddPurchaseForm("no id", "");
            AddPurchase.Button_Create.Enabled = true;
            AddPurchase.Button_Update.Enabled = false;
            AddPurchase.EnableCellClickEventHandling = true;
            AddPurchase.ShowDialog();
            LoadPurchase();
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPurchase.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                
                string purchId = dgvPurchase.Rows[e.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show("Only possible to edit the purchased quantity", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewButtonCell editButtonCell = dgvPurchase.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                editButtonCell.Tag = purchId;

                string price = dgvPurchase.Rows[e.RowIndex].Cells[6].Value.ToString();

                
                AddPurchaseForm addPurchaseForm = new AddPurchaseForm(purchId, price);
                addPurchaseForm.text_ProdId.Text = dgvPurchase.Rows[e.RowIndex].Cells[1].Value.ToString();
                addPurchaseForm.date_PurchaseDate.Value = Convert.ToDateTime(dgvPurchase.Rows[e.RowIndex].Cells[2].Value.ToString());
                addPurchaseForm.text_ProdId.Text = dgvPurchase.Rows[e.RowIndex].Cells[3].Value.ToString();
                addPurchaseForm.text_UserId.Text = dgvPurchase.Rows[e.RowIndex].Cells[4].Value.ToString();
                addPurchaseForm.numeric_Quantity.Value = Convert.ToInt32(dgvPurchase.Rows[e.RowIndex].Cells[5].Value.ToString());
                //addPurchaseForm.text_Price.Text = dgvPurchase.Rows[e.RowIndex].Cells[6].Value.ToString();

                addPurchaseForm.text_Total.Text = dgvPurchase.Rows[e.RowIndex].Cells[7].Value.ToString();
                addPurchaseForm.Button_Create.Enabled = false;
                addPurchaseForm.Button_Update.Enabled = true;
                addPurchaseForm.EnableCellClickEventHandling = false;
                addPurchaseForm.ShowDialog();
                

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MConn = new MySqlConnection(strSQL);
                    MConn.Open();
                    string queryString = "DELETE FROM tbPurchase WHERE purchId LIKE '" + dgvPurchase.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    Comm = new MySqlCommand(queryString, MConn);
                    Comm.ExecuteNonQuery();
                    //MConn.Close();
                    MessageBox.Show("Record successfully deleted");


                    //update the remaining quantity after purchase
                    string queryUpdate = "UPDATE tbProduct SET prodQuantity= (prodQuantity + @prodQuantity) WHERE prodId LIKE '" + dgvPurchase.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
                    Comm = new MySqlCommand(queryUpdate, MConn);
                    Comm.Parameters.AddWithValue("prodQuantity", Convert.ToInt32(dgvPurchase.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    Comm.ExecuteNonQuery();
                    MConn.Close();

                    
                }
            }
            LoadPurchase();
        }
    }
}
