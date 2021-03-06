﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class UserMainPlatform : Form
    {
        private User currUser;
        private String connString;
        private ProductHandler productHandler;
        private List<string> productList;

        public UserMainPlatform(User newUser, String connString)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
            purchaseErrorLabel.Hide();
            productHandler = new ProductHandler(connString);

            productList = this.productHandler.GetAllApprovedProductsNames();

            foreach (var iterator in productList)
            {
                //Console.WriteLine(iterator.GetProductInfo().GetName());
                ItemsComboBox.Items.Add(iterator);
            }
        }

        private void UserMainPlatform_Load(object sender, EventArgs e)
        {

        }

        private void UserMainPlatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            if (ItemsComboBox.Text == "")
            {
                purchaseErrorLabel.Show();
            }
            else
            {
                Product chosenProduct = productHandler.GetProductWithName(ItemsComboBox.Text);
                int quantity = productHandler.GetQuantity(chosenProduct);
                Console.WriteLine(chosenProduct.GetProductInfo().GetName() + " " + quantity.ToString());
                PurchaseItemForm purchaseItemForm = new PurchaseItemForm(currUser, connString, chosenProduct.GetProductInfo().GetName(), chosenProduct.GetProductInfo().GetBrand().GetName(), quantity, chosenProduct.GetProductInfo().GetPrice());
                purchaseItemForm.Show();
            }
        }

        private void purchaseErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
