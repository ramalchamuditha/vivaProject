﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class payment : UserControl
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void btn_salesReport_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you wants to add sales order from new customer ?", "Add sales Order", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                addCustomer adc = new addCustomer();
                adc.Show();
            }
            else if(dialog == DialogResult.No)
            {
                addSalesOrder aso = new addSalesOrder();
                aso.Show();
            }
                        
        }

        private void btn_stockStatues_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_purchaseOrder_Click(object sender, EventArgs e)
        {
            SoInvoice aso = new SoInvoice();
            aso.Show();
        }
    }
}
