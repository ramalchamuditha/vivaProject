﻿namespace WindowsFormsApp1
{
    partial class addSalesOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSalesOrder));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_addMore = new System.Windows.Forms.Button();
            this.txt_s_o_No = new System.Windows.Forms.TextBox();
            this.combo_cus_No = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cus_NO_DataSet = new WindowsFormsApp1.cus_NO_DataSet();
            this.combo_fur_No = new System.Windows.Forms.ComboBox();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet2 = new WindowsFormsApp1.ProductsDataSet2();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new WindowsFormsApp1.cus_NO_DataSetTableAdapters.customerTableAdapter();
            this.furnitureTableAdapter = new WindowsFormsApp1.ProductsDataSet2TableAdapters.furnitureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_NO_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sales Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Furniture Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(673, 513);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 42);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(487, 513);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(121, 42);
            this.btn_payment.TabIndex = 15;
            this.btn_payment.Text = "Pay Now";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_addMore
            // 
            this.btn_addMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMore.Location = new System.Drawing.Point(301, 513);
            this.btn_addMore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addMore.Name = "btn_addMore";
            this.btn_addMore.Size = new System.Drawing.Size(121, 42);
            this.btn_addMore.TabIndex = 16;
            this.btn_addMore.Text = "Add More";
            this.btn_addMore.UseVisualStyleBackColor = true;
            this.btn_addMore.Click += new System.EventHandler(this.btn_addMore_Click);
            // 
            // txt_s_o_No
            // 
            this.txt_s_o_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_o_No.Location = new System.Drawing.Point(393, 95);
            this.txt_s_o_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_s_o_No.Name = "txt_s_o_No";
            this.txt_s_o_No.Size = new System.Drawing.Size(195, 28);
            this.txt_s_o_No.TabIndex = 17;
            this.txt_s_o_No.TextChanged += new System.EventHandler(this.txt_s_o_No_TextChanged);
            // 
            // combo_cus_No
            // 
            this.combo_cus_No.DataSource = this.customerBindingSource;
            this.combo_cus_No.DisplayMember = "cus_No";
            this.combo_cus_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cus_No.FormattingEnabled = true;
            this.combo_cus_No.Location = new System.Drawing.Point(393, 185);
            this.combo_cus_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_cus_No.Name = "combo_cus_No";
            this.combo_cus_No.Size = new System.Drawing.Size(195, 30);
            this.combo_cus_No.TabIndex = 18;
            this.combo_cus_No.ValueMember = "cus_No";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.cus_NO_DataSet;
            // 
            // cus_NO_DataSet
            // 
            this.cus_NO_DataSet.DataSetName = "cus_NO_DataSet";
            this.cus_NO_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_fur_No
            // 
            this.combo_fur_No.DataSource = this.furnitureBindingSource;
            this.combo_fur_No.DisplayMember = "fur_No";
            this.combo_fur_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_fur_No.FormattingEnabled = true;
            this.combo_fur_No.Location = new System.Drawing.Point(393, 263);
            this.combo_fur_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_fur_No.Name = "combo_fur_No";
            this.combo_fur_No.Size = new System.Drawing.Size(195, 30);
            this.combo_fur_No.TabIndex = 19;
            this.combo_fur_No.ValueMember = "fur_No";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "furniture";
            this.furnitureBindingSource.DataSource = this.productsDataSet2;
            // 
            // productsDataSet2
            // 
            this.productsDataSet2.DataSetName = "ProductsDataSet2";
            this.productsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(393, 341);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(195, 28);
            this.txt_qty.TabIndex = 20;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(393, 418);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(195, 28);
            this.txt_price.TabIndex = 21;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // addSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 594);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.combo_fur_No);
            this.Controls.Add(this.combo_cus_No);
            this.Controls.Add(this.txt_s_o_No);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_addMore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addSalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add SalesOrder";
            this.Load += new System.EventHandler(this.addSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_NO_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_addMore;
        private System.Windows.Forms.TextBox txt_s_o_No;
        private System.Windows.Forms.ComboBox combo_cus_No;
        private System.Windows.Forms.ComboBox combo_fur_No;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_price;
        private cus_NO_DataSet cus_NO_DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private cus_NO_DataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private ProductsDataSet2 productsDataSet2;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private ProductsDataSet2TableAdapters.furnitureTableAdapter furnitureTableAdapter;
    }
}