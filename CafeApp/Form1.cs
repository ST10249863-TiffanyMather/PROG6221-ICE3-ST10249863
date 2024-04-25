using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>()
        {
            {"Coffee", 2.50m},
            {"Tea", 2.00m},
            {"Sandwich", 5.00m},
            {"Cake", 3.50m}
        };

        Dictionary<string, int> order = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            InitializeDropDown();
        }

        private void InitializeDropDown()
        {
            foreach (var item in menuItems.Keys)
            {
                cmbItem.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedItem = cmbItem.SelectedItem as string;
            if (selectedItem != null && nudQuantity.Value > 0)
            {
                int quantity = Convert.ToInt32(nudQuantity.Value);
                if (order.ContainsKey(selectedItem))
                {
                    order[selectedItem] += quantity;
                }
                else
                {
                    order.Add(selectedItem, quantity);
                }
                MessageBox.Show($"Added {quantity} {selectedItem}(s) to your order.");
            }
            else
            {
                MessageBox.Show("Please select an item and enter a quantity.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm(order, menuItems);
            receiptForm.ShowDialog();
        }
    }
}
