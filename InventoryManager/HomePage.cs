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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            OpenChildForm(new ProductForm());
        }

        //show form on another form
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close the form
                activeForm.Dispose(); // Dispose of the form and its resources
            }
        
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
        }

        private void button_Purchases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseForm());
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportForm());
        }
    }
}
