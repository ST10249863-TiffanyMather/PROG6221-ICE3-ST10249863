using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class ReceiptForm : Form
    {
        private Dictionary<string, int> order;
        private Dictionary<string, decimal> menuItems;

        private ListBox lstDisplay;

        public ReceiptForm(Dictionary<string, int> order, Dictionary<string, decimal> menuItems)
        {
            InitializeComponent();
            this.order = order;
            this.menuItems = menuItems;
            GenerateReceipt();
        }

        private void InitializeComponent()
        {
            lstDisplay = new ListBox();
            lstDisplay.Dock = DockStyle.Fill;
            this.Controls.Add(lstDisplay);
        }

        private void GenerateReceipt()
        {
            decimal total = 0;

            foreach (var item in order)
            {
                string itemName = item.Key;
                int quantity = item.Value;
                decimal price = menuItems[itemName];
                decimal subtotal = price * quantity;

                lstDisplay.Items.Add($"{itemName}: {quantity} x {price:C} = {subtotal:C}");
                total += subtotal;
            }

            lstDisplay.Items.Add($"Total: {total:C}");
        }
    }
}