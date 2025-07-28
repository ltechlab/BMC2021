using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMC2021

{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInv = new System.Windows.Forms.TabControl();
            this.tab_summary = new System.Windows.Forms.TabPage();
            this.progressBarz = new System.Windows.Forms.ProgressBar();
            this.btn_exp_peritem = new System.Windows.Forms.Button();
            this.btn_exp_sum = new System.Windows.Forms.Button();
            this.grid_summary = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsinstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsavailableforsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVENTORY_SUMMARY_NEW = new BMC2021.INVENTORY_SUMMARY_NEW();
            this.tab_peritem = new System.Windows.Forms.TabPage();
            this.btn_allitems = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.NumericUpDown();
            this.tb_price = new System.Windows.Forms.NumericUpDown();
            this.tb_purchaseprice = new System.Windows.Forms.NumericUpDown();
            this.cb_condition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_itemdescription = new System.Windows.Forms.TextBox();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.tb_itemname = new System.Windows.Forms.TextBox();
            this.tb_itembrand = new System.Windows.Forms.TextBox();
            this.tb_supplier = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grid_peritem = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invPeritemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDBDataSet1 = new BMC2021.POSDBDataSet1();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_rall = new System.Windows.Forms.Button();
            this.btn_rsearch = new System.Windows.Forms.Button();
            this.txtbox_rejects = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_deleteReject = new System.Windows.Forms.Button();
            this.btn_removefrrej = new System.Windows.Forms.Button();
            this.grid_reject = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembrandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_cuser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inv_PeritemTableAdapter = new BMC2021.POSDBDataSet1TableAdapters.Inv_PeritemTableAdapter();
            this.inv_SummaryTableAdapter = new BMC2021.INVENTORY_SUMMARY_NEWTableAdapters.Inv_SummaryTableAdapter();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabInv.SuspendLayout();
            this.tab_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_SUMMARY_NEW)).BeginInit();
            this.tab_peritem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_purchaseprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invPeritemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reject)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT";
            // 
            // tabInv
            // 
            this.tabInv.Controls.Add(this.tab_summary);
            this.tabInv.Controls.Add(this.tab_peritem);
            this.tabInv.Controls.Add(this.tabPage1);
            this.tabInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabInv.Location = new System.Drawing.Point(0, 84);
            this.tabInv.Name = "tabInv";
            this.tabInv.Padding = new System.Drawing.Point(10, 5);
            this.tabInv.SelectedIndex = 0;
            this.tabInv.Size = new System.Drawing.Size(1066, 637);
            this.tabInv.TabIndex = 1;
            // 
            // tab_summary
            // 
            this.tab_summary.Controls.Add(this.progressBarz);
            this.tab_summary.Controls.Add(this.btn_exp_peritem);
            this.tab_summary.Controls.Add(this.btn_exp_sum);
            this.tab_summary.Controls.Add(this.grid_summary);
            this.tab_summary.Location = new System.Drawing.Point(4, 29);
            this.tab_summary.Name = "tab_summary";
            this.tab_summary.Padding = new System.Windows.Forms.Padding(3);
            this.tab_summary.Size = new System.Drawing.Size(1058, 604);
            this.tab_summary.TabIndex = 0;
            this.tab_summary.Text = "STOCKS SUMMARY";
            this.tab_summary.UseVisualStyleBackColor = true;
            // 
            // progressBarz
            // 
            this.progressBarz.Location = new System.Drawing.Point(24, 581);
            this.progressBarz.Name = "progressBarz";
            this.progressBarz.Size = new System.Drawing.Size(979, 13);
            this.progressBarz.TabIndex = 6;
            // 
            // btn_exp_peritem
            // 
            this.btn_exp_peritem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_exp_peritem.FlatAppearance.BorderSize = 0;
            this.btn_exp_peritem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exp_peritem.Image = ((System.Drawing.Image)(resources.GetObject("btn_exp_peritem.Image")));
            this.btn_exp_peritem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exp_peritem.Location = new System.Drawing.Point(24, 518);
            this.btn_exp_peritem.Name = "btn_exp_peritem";
            this.btn_exp_peritem.Size = new System.Drawing.Size(463, 57);
            this.btn_exp_peritem.TabIndex = 4;
            this.btn_exp_peritem.Text = "   EXPORT SUMMARY";
            this.btn_exp_peritem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exp_peritem.UseVisualStyleBackColor = false;
            this.btn_exp_peritem.Click += new System.EventHandler(this.btn_exp_peritem_Click);
            // 
            // btn_exp_sum
            // 
            this.btn_exp_sum.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_exp_sum.FlatAppearance.BorderSize = 0;
            this.btn_exp_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exp_sum.Image = ((System.Drawing.Image)(resources.GetObject("btn_exp_sum.Image")));
            this.btn_exp_sum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exp_sum.Location = new System.Drawing.Point(493, 518);
            this.btn_exp_sum.Name = "btn_exp_sum";
            this.btn_exp_sum.Size = new System.Drawing.Size(511, 57);
            this.btn_exp_sum.TabIndex = 3;
            this.btn_exp_sum.Text = "  EXPORT ALL ITEMS";
            this.btn_exp_sum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exp_sum.UseVisualStyleBackColor = false;
            this.btn_exp_sum.Click += new System.EventHandler(this.btn_exp_sum_Click);
            // 
            // grid_summary
            // 
            this.grid_summary.AutoGenerateColumns = false;
            this.grid_summary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_summary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_summary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.unitsinstockDataGridViewTextBoxColumn,
            this.unitsavailableforsaleDataGridViewTextBoxColumn,
            this.stockvalueDataGridViewTextBoxColumn,
            this.salepriceDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn2});
            this.grid_summary.DataSource = this.invSummaryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_summary.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_summary.EnableHeadersVisualStyles = false;
            this.grid_summary.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_summary.Location = new System.Drawing.Point(24, 22);
            this.grid_summary.Name = "grid_summary";
            this.grid_summary.ReadOnly = true;
            this.grid_summary.RowTemplate.Height = 24;
            this.grid_summary.Size = new System.Drawing.Size(976, 482);
            this.grid_summary.TabIndex = 0;
            this.grid_summary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_summary_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // unitsinstockDataGridViewTextBoxColumn
            // 
            this.unitsinstockDataGridViewTextBoxColumn.DataPropertyName = "unitsinstock";
            this.unitsinstockDataGridViewTextBoxColumn.HeaderText = "units in stock";
            this.unitsinstockDataGridViewTextBoxColumn.Name = "unitsinstockDataGridViewTextBoxColumn";
            this.unitsinstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitsavailableforsaleDataGridViewTextBoxColumn
            // 
            this.unitsavailableforsaleDataGridViewTextBoxColumn.DataPropertyName = "unitsavailableforsale";
            this.unitsavailableforsaleDataGridViewTextBoxColumn.HeaderText = "units available for sale";
            this.unitsavailableforsaleDataGridViewTextBoxColumn.Name = "unitsavailableforsaleDataGridViewTextBoxColumn";
            this.unitsavailableforsaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockvalueDataGridViewTextBoxColumn
            // 
            this.stockvalueDataGridViewTextBoxColumn.DataPropertyName = "stockvalue";
            this.stockvalueDataGridViewTextBoxColumn.HeaderText = "stock value";
            this.stockvalueDataGridViewTextBoxColumn.Name = "stockvalueDataGridViewTextBoxColumn";
            this.stockvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "saleprice";
            this.salepriceDataGridViewTextBoxColumn.HeaderText = "sale price";
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            this.salepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn2
            // 
            this.barcodeDataGridViewTextBoxColumn2.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn2.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn2.Name = "barcodeDataGridViewTextBoxColumn2";
            this.barcodeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // invSummaryBindingSource
            // 
            this.invSummaryBindingSource.DataMember = "Inv_Summary";
            this.invSummaryBindingSource.DataSource = this.iNVENTORY_SUMMARY_NEW;
            // 
            // iNVENTORY_SUMMARY_NEW
            // 
            this.iNVENTORY_SUMMARY_NEW.DataSetName = "INVENTORY_SUMMARY_NEW";
            this.iNVENTORY_SUMMARY_NEW.Namespace = "http://tempuri.org/INVENTORY_SUMMARY_NEW.xsd";
            this.iNVENTORY_SUMMARY_NEW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_peritem
            // 
            this.tab_peritem.Controls.Add(this.btn_allitems);
            this.tab_peritem.Controls.Add(this.btn_search);
            this.tab_peritem.Controls.Add(this.txt_SearchName);
            this.tab_peritem.Controls.Add(this.label15);
            this.tab_peritem.Controls.Add(this.groupBox2);
            this.tab_peritem.Controls.Add(this.btn_edit);
            this.tab_peritem.Controls.Add(this.btn_delete);
            this.tab_peritem.Controls.Add(this.btn_add);
            this.tab_peritem.Controls.Add(this.grid_peritem);
            this.tab_peritem.Location = new System.Drawing.Point(4, 29);
            this.tab_peritem.Name = "tab_peritem";
            this.tab_peritem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_peritem.Size = new System.Drawing.Size(1058, 604);
            this.tab_peritem.TabIndex = 1;
            this.tab_peritem.Text = "PER ITEM INVENTORY";
            this.tab_peritem.UseVisualStyleBackColor = true;
            // 
            // btn_allitems
            // 
            this.btn_allitems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_allitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_allitems.Location = new System.Drawing.Point(396, 13);
            this.btn_allitems.Name = "btn_allitems";
            this.btn_allitems.Size = new System.Drawing.Size(58, 23);
            this.btn_allitems.TabIndex = 9;
            this.btn_allitems.Text = "ALL";
            this.btn_allitems.UseVisualStyleBackColor = false;
            this.btn_allitems.Click += new System.EventHandler(this.btn_allitems_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(456, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(533, 13);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(181, 23);
            this.txt_SearchName.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(333, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "All inventory items in good condition, ready for sale.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_qty);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.tb_purchaseprice);
            this.groupBox2.Controls.Add(this.cb_condition);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb_date);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_itemdescription);
            this.groupBox2.Controls.Add(this.tb_barcode);
            this.groupBox2.Controls.Add(this.tb_itemname);
            this.groupBox2.Controls.Add(this.tb_itembrand);
            this.groupBox2.Controls.Add(this.tb_supplier);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(732, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 377);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD ITEMS TO INVENTORY";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(15, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(270, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Make sure that your barcode value is UNIQUE per item.";
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(150, 308);
            this.tb_qty.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(150, 23);
            this.tb_qty.TabIndex = 24;
            this.tb_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_price
            // 
            this.tb_price.DecimalPlaces = 2;
            this.tb_price.Location = new System.Drawing.Point(150, 278);
            this.tb_price.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(150, 23);
            this.tb_price.TabIndex = 23;
            this.tb_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_purchaseprice
            // 
            this.tb_purchaseprice.DecimalPlaces = 2;
            this.tb_purchaseprice.Location = new System.Drawing.Point(148, 137);
            this.tb_purchaseprice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tb_purchaseprice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_purchaseprice.Name = "tb_purchaseprice";
            this.tb_purchaseprice.Size = new System.Drawing.Size(151, 23);
            this.tb_purchaseprice.TabIndex = 22;
            this.tb_purchaseprice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_condition
            // 
            this.cb_condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_condition.FormattingEnabled = true;
            this.cb_condition.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cb_condition.Location = new System.Drawing.Point(148, 221);
            this.cb_condition.Name = "cb_condition";
            this.cb_condition.Size = new System.Drawing.Size(152, 24);
            this.cb_condition.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "SET SALE PRICE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "UNITS";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(146, 35);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(54, 17);
            this.lb_date.TabIndex = 16;
            this.lb_date.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Condition (0 or 1)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Barcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // tb_itemdescription
            // 
            this.tb_itemdescription.Location = new System.Drawing.Point(148, 190);
            this.tb_itemdescription.Name = "tb_itemdescription";
            this.tb_itemdescription.Size = new System.Drawing.Size(152, 23);
            this.tb_itemdescription.TabIndex = 6;
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(148, 164);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(152, 23);
            this.tb_barcode.TabIndex = 5;
            // 
            // tb_itemname
            // 
            this.tb_itemname.Location = new System.Drawing.Point(148, 112);
            this.tb_itemname.Name = "tb_itemname";
            this.tb_itemname.Size = new System.Drawing.Size(152, 23);
            this.tb_itemname.TabIndex = 3;
            // 
            // tb_itembrand
            // 
            this.tb_itembrand.Location = new System.Drawing.Point(148, 85);
            this.tb_itembrand.Name = "tb_itembrand";
            this.tb_itembrand.Size = new System.Drawing.Size(152, 23);
            this.tb_itembrand.TabIndex = 2;
            // 
            // tb_supplier
            // 
            this.tb_supplier.Location = new System.Drawing.Point(148, 59);
            this.tb_supplier.Name = "tb_supplier";
            this.tb_supplier.Size = new System.Drawing.Size(152, 23);
            this.tb_supplier.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(732, 529);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(318, 58);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "   MOVE TO REJECT";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(732, 471);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(318, 55);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "  DELETE SELECTED";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(732, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(318, 59);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   ADD NEW ITEMS";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grid_peritem
            // 
            this.grid_peritem.AutoGenerateColumns = false;
            this.grid_peritem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_peritem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_peritem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_peritem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.loggedby,
            this.deliverydateDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.itembrandDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn1,
            this.purchasepriceDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.itemdescriptionDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn});
            this.grid_peritem.DataSource = this.invPeritemBindingSource;
            this.grid_peritem.EnableHeadersVisualStyles = false;
            this.grid_peritem.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_peritem.Location = new System.Drawing.Point(24, 46);
            this.grid_peritem.Name = "grid_peritem";
            this.grid_peritem.ReadOnly = true;
            this.grid_peritem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_peritem.RowTemplate.Height = 24;
            this.grid_peritem.Size = new System.Drawing.Size(690, 544);
            this.grid_peritem.TabIndex = 0;
            this.grid_peritem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_peritem_CellContentClick);
            this.grid_peritem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_peritem_KeyDown);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // loggedby
            // 
            this.loggedby.DataPropertyName = "loggedby";
            this.loggedby.HeaderText = "logged by";
            this.loggedby.Name = "loggedby";
            this.loggedby.ReadOnly = true;
            this.loggedby.Width = 150;
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "deliverydate";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "delivery date";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverydateDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierDataGridViewTextBoxColumn.Width = 200;
            // 
            // itembrandDataGridViewTextBoxColumn
            // 
            this.itembrandDataGridViewTextBoxColumn.DataPropertyName = "itembrand";
            this.itembrandDataGridViewTextBoxColumn.HeaderText = "item brand";
            this.itembrandDataGridViewTextBoxColumn.Name = "itembrandDataGridViewTextBoxColumn";
            this.itembrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.itembrandDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemnameDataGridViewTextBoxColumn1
            // 
            this.itemnameDataGridViewTextBoxColumn1.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn1.HeaderText = "item name";
            this.itemnameDataGridViewTextBoxColumn1.Name = "itemnameDataGridViewTextBoxColumn1";
            this.itemnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemnameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchaseprice";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            this.purchasepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdescriptionDataGridViewTextBoxColumn
            // 
            this.itemdescriptionDataGridViewTextBoxColumn.DataPropertyName = "itemdescription";
            this.itemdescriptionDataGridViewTextBoxColumn.HeaderText = "item description";
            this.itemdescriptionDataGridViewTextBoxColumn.Name = "itemdescriptionDataGridViewTextBoxColumn";
            this.itemdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Visible = false;
            // 
            // invPeritemBindingSource
            // 
            this.invPeritemBindingSource.DataMember = "Inv_Peritem";
            this.invPeritemBindingSource.DataSource = this.pOSDBDataSet1;
            // 
            // pOSDBDataSet1
            // 
            this.pOSDBDataSet1.DataSetName = "POSDBDataSet1";
            this.pOSDBDataSet1.Namespace = "http://tempuri.org/POSDBDataSet1.xsd";
            this.pOSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_rall);
            this.tabPage1.Controls.Add(this.btn_rsearch);
            this.tabPage1.Controls.Add(this.txtbox_rejects);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btn_deleteReject);
            this.tabPage1.Controls.Add(this.btn_removefrrej);
            this.tabPage1.Controls.Add(this.grid_reject);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 604);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "RETURNED / REJECTED";
            // 
            // btn_rall
            // 
            this.btn_rall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rall.Location = new System.Drawing.Point(745, 10);
            this.btn_rall.Name = "btn_rall";
            this.btn_rall.Size = new System.Drawing.Size(47, 23);
            this.btn_rall.TabIndex = 6;
            this.btn_rall.Text = "ALL";
            this.btn_rall.UseVisualStyleBackColor = false;
            this.btn_rall.Click += new System.EventHandler(this.btn_rall_Click);
            // 
            // btn_rsearch
            // 
            this.btn_rsearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rsearch.Location = new System.Drawing.Point(794, 10);
            this.btn_rsearch.Name = "btn_rsearch";
            this.btn_rsearch.Size = new System.Drawing.Size(75, 23);
            this.btn_rsearch.TabIndex = 5;
            this.btn_rsearch.Text = "SEARCH";
            this.btn_rsearch.UseVisualStyleBackColor = false;
            this.btn_rsearch.Click += new System.EventHandler(this.btn_rsearch_Click);
            // 
            // txtbox_rejects
            // 
            this.txtbox_rejects.Location = new System.Drawing.Point(875, 10);
            this.txtbox_rejects.Name = "txtbox_rejects";
            this.txtbox_rejects.Size = new System.Drawing.Size(152, 23);
            this.txtbox_rejects.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "All rejected items in inventory, not fit for sales.";
            // 
            // btn_deleteReject
            // 
            this.btn_deleteReject.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_deleteReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteReject.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteReject.Image")));
            this.btn_deleteReject.Location = new System.Drawing.Point(24, 534);
            this.btn_deleteReject.Name = "btn_deleteReject";
            this.btn_deleteReject.Size = new System.Drawing.Size(493, 59);
            this.btn_deleteReject.TabIndex = 2;
            this.btn_deleteReject.Text = "   DELETE ITEM FROM RECORDS";
            this.btn_deleteReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteReject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteReject.UseVisualStyleBackColor = false;
            this.btn_deleteReject.Click += new System.EventHandler(this.btn_deleteReject_Click);
            // 
            // btn_removefrrej
            // 
            this.btn_removefrrej.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_removefrrej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removefrrej.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_removefrrej.Image = ((System.Drawing.Image)(resources.GetObject("btn_removefrrej.Image")));
            this.btn_removefrrej.Location = new System.Drawing.Point(522, 534);
            this.btn_removefrrej.Name = "btn_removefrrej";
            this.btn_removefrrej.Size = new System.Drawing.Size(506, 59);
            this.btn_removefrrej.TabIndex = 1;
            this.btn_removefrrej.Text = "   RETURN ITEM TO INVENTORY";
            this.btn_removefrrej.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_removefrrej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_removefrrej.UseVisualStyleBackColor = false;
            this.btn_removefrrej.Click += new System.EventHandler(this.btn_removefrrej_Click);
            // 
            // grid_reject
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.grid_reject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_reject.AutoGenerateColumns = false;
            this.grid_reject.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_reject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_reject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.deliverydateDataGridViewTextBoxColumn1,
            this.supplierDataGridViewTextBoxColumn1,
            this.itembrandDataGridViewTextBoxColumn1,
            this.itemnameDataGridViewTextBoxColumn2,
            this.purchasepriceDataGridViewTextBoxColumn1,
            this.barcodeDataGridViewTextBoxColumn1,
            this.itemdescriptionDataGridViewTextBoxColumn1,
            this.conditionDataGridViewTextBoxColumn1});
            this.grid_reject.DataSource = this.invPeritemBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_reject.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_reject.EnableHeadersVisualStyles = false;
            this.grid_reject.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_reject.Location = new System.Drawing.Point(24, 48);
            this.grid_reject.Name = "grid_reject";
            this.grid_reject.ReadOnly = true;
            this.grid_reject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_reject.RowTemplate.Height = 24;
            this.grid_reject.Size = new System.Drawing.Size(1004, 481);
            this.grid_reject.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // deliverydateDataGridViewTextBoxColumn1
            // 
            this.deliverydateDataGridViewTextBoxColumn1.DataPropertyName = "deliverydate";
            this.deliverydateDataGridViewTextBoxColumn1.HeaderText = "delivery date";
            this.deliverydateDataGridViewTextBoxColumn1.Name = "deliverydateDataGridViewTextBoxColumn1";
            this.deliverydateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn1
            // 
            this.supplierDataGridViewTextBoxColumn1.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn1.HeaderText = "supplier";
            this.supplierDataGridViewTextBoxColumn1.Name = "supplierDataGridViewTextBoxColumn1";
            this.supplierDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itembrandDataGridViewTextBoxColumn1
            // 
            this.itembrandDataGridViewTextBoxColumn1.DataPropertyName = "itembrand";
            this.itembrandDataGridViewTextBoxColumn1.HeaderText = "item brand";
            this.itembrandDataGridViewTextBoxColumn1.Name = "itembrandDataGridViewTextBoxColumn1";
            this.itembrandDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemnameDataGridViewTextBoxColumn2
            // 
            this.itemnameDataGridViewTextBoxColumn2.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn2.HeaderText = "item name";
            this.itemnameDataGridViewTextBoxColumn2.Name = "itemnameDataGridViewTextBoxColumn2";
            this.itemnameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // purchasepriceDataGridViewTextBoxColumn1
            // 
            this.purchasepriceDataGridViewTextBoxColumn1.DataPropertyName = "purchaseprice";
            this.purchasepriceDataGridViewTextBoxColumn1.HeaderText = "purchase price";
            this.purchasepriceDataGridViewTextBoxColumn1.Name = "purchasepriceDataGridViewTextBoxColumn1";
            this.purchasepriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn1
            // 
            this.barcodeDataGridViewTextBoxColumn1.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn1.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn1.Name = "barcodeDataGridViewTextBoxColumn1";
            this.barcodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemdescriptionDataGridViewTextBoxColumn1
            // 
            this.itemdescriptionDataGridViewTextBoxColumn1.DataPropertyName = "itemdescription";
            this.itemdescriptionDataGridViewTextBoxColumn1.HeaderText = "item description";
            this.itemdescriptionDataGridViewTextBoxColumn1.Name = "itemdescriptionDataGridViewTextBoxColumn1";
            this.itemdescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn1
            // 
            this.conditionDataGridViewTextBoxColumn1.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn1.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn1.Name = "conditionDataGridViewTextBoxColumn1";
            this.conditionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lb_cuser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 76);
            this.panel1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Keep track of your stocks and inventory before sales.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(788, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "CURRENT USER: ";
            // 
            // lb_cuser
            // 
            this.lb_cuser.AutoSize = true;
            this.lb_cuser.Location = new System.Drawing.Point(898, 15);
            this.lb_cuser.MaximumSize = new System.Drawing.Size(88, 0);
            this.lb_cuser.Name = "lb_cuser";
            this.lb_cuser.Size = new System.Drawing.Size(87, 45);
            this.lb_cuser.TabIndex = 8;
            this.lb_cuser.Text = "lbjashdjsahdkjsahdkjsahdjashdjksahd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inv_PeritemTableAdapter
            // 
            this.inv_PeritemTableAdapter.ClearBeforeFill = true;
            // 
            // inv_SummaryTableAdapter
            // 
            this.inv_SummaryTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1036, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "INVENTORY";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.tabInv.ResumeLayout(false);
            this.tab_summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_SUMMARY_NEW)).EndInit();
            this.tab_peritem.ResumeLayout(false);
            this.tab_peritem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_purchaseprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invPeritemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabInv;
        private System.Windows.Forms.TabPage tab_summary;
        private System.Windows.Forms.TabPage tab_peritem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView grid_peritem;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_removefrrej;
        private System.Windows.Forms.DataGridView grid_reject;
        private POSDBDataSet1 pOSDBDataSet1;
        private System.Windows.Forms.BindingSource invPeritemBindingSource;
        private POSDBDataSet1TableAdapters.Inv_PeritemTableAdapter inv_PeritemTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_itemdescription;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.TextBox tb_itemname;
        private System.Windows.Forms.TextBox tb_itembrand;
        private System.Windows.Forms.TextBox tb_supplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_deleteReject;
        private System.Windows.Forms.DataGridView grid_summary;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.ComboBox cb_condition;
        private INVENTORY_SUMMARY_NEW iNVENTORY_SUMMARY_NEW;
        private System.Windows.Forms.BindingSource invSummaryBindingSource;
        private INVENTORY_SUMMARY_NEWTableAdapters.Inv_SummaryTableAdapter inv_SummaryTableAdapter;
        private System.Windows.Forms.NumericUpDown tb_purchaseprice;
        private System.Windows.Forms.NumericUpDown tb_price;
        private System.Windows.Forms.NumericUpDown tb_qty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembrandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_exp_peritem;
        private System.Windows.Forms.Button btn_exp_sum;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBarz;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsinstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsavailableforsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private TextBox txt_SearchName;
        private Button btn_search;
        private Button btn_allitems;
        private Button btn_rall;
        private Button btn_rsearch;
        private TextBox txtbox_rejects;
        private Label label16;
    }
}