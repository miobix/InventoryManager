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
        public PurchaseForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_AddPurchase_Click(object sender, EventArgs e)
        {
            AddPurchaseForm AddPurchase = new AddPurchaseForm();
            AddPurchase.Button_Create.Enabled = true;
            AddPurchase.Button_Update.Enabled = false;
            AddPurchase.ShowDialog();
            //LoadPurchase();
        }
    }
}
