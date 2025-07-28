namespace BMC2021
{
    partial class SalesMonitoring
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMonitoring));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            salesperitemBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            salespendingordersBindingSource1 = new System.Windows.Forms.BindingSource(components);
            tab_CURRENTORDER = new System.Windows.Forms.TabPage();
            btn_printreceipt = new System.Windows.Forms.Button();
            grid_customerlist = new System.Windows.Forms.DataGridView();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            btn_removeorder = new System.Windows.Forms.Button();
            grid_orders = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            btn_placeorder = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tabControl2 = new System.Windows.Forms.TabControl();
            tab_PLACEORDER = new System.Windows.Forms.TabPage();
            tb_qty = new System.Windows.Forms.NumericUpDown();
            tb_diskawnt = new System.Windows.Forms.NumericUpDown();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lb_price = new System.Windows.Forms.Label();
            btn_addtolist = new System.Windows.Forms.Button();
            label18 = new System.Windows.Forms.Label();
            cb_item = new System.Windows.Forms.ComboBox();
            cb_brand = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            tab_NEWITEMS = new System.Windows.Forms.TabPage();
            tb_price = new System.Windows.Forms.NumericUpDown();
            tb_qty2 = new System.Windows.Forms.NumericUpDown();
            tb_disc = new System.Windows.Forms.NumericUpDown();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            tb_item = new System.Windows.Forms.TextBox();
            tb_brand = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            btn_addtolist_new = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tb_address = new System.Windows.Forms.RichTextBox();
            label4 = new System.Windows.Forms.Label();
            tb_contact = new System.Windows.Forms.TextBox();
            tb_cname = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            tb_notes = new System.Windows.Forms.RichTextBox();
            label6 = new System.Windows.Forms.Label();
            delivery_picker = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lb_subtotal = new System.Windows.Forms.Label();
            lb_subt = new System.Windows.Forms.Label();
            btn_remove = new System.Windows.Forms.Button();
            grid_orderlist = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            panel1 = new System.Windows.Forms.Panel();
            label21 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lb_cuser = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            salespendingordersBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)salesperitemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salespendingordersBindingSource1).BeginInit();
            tab_CURRENTORDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_customerlist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_orders).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl2.SuspendLayout();
            tab_PLACEORDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_qty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_diskawnt).BeginInit();
            tab_NEWITEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_qty2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_disc).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_orderlist).BeginInit();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salespendingordersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // salesperitemBindingSource
            // 
            salesperitemBindingSource.DataMember = "sales_peritem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(86, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 24);
            label1.TabIndex = 1;
            label1.Text = "ORDERS MANAGEMENT";
            // 
            // salespendingordersBindingSource1
            // 
            salespendingordersBindingSource1.DataMember = "sales_pending_orders";
            // 
            // tab_CURRENTORDER
            // 
            tab_CURRENTORDER.Controls.Add(btn_printreceipt);
            tab_CURRENTORDER.Controls.Add(grid_customerlist);
            tab_CURRENTORDER.Controls.Add(label17);
            tab_CURRENTORDER.Controls.Add(label16);
            tab_CURRENTORDER.Controls.Add(btn_removeorder);
            tab_CURRENTORDER.Controls.Add(grid_orders);
            tab_CURRENTORDER.Location = new System.Drawing.Point(4, 29);
            tab_CURRENTORDER.Name = "tab_CURRENTORDER";
            tab_CURRENTORDER.Padding = new System.Windows.Forms.Padding(3);
            tab_CURRENTORDER.Size = new System.Drawing.Size(1055, 635);
            tab_CURRENTORDER.TabIndex = 4;
            tab_CURRENTORDER.Text = "CURRENT ORDERS";
            tab_CURRENTORDER.UseVisualStyleBackColor = true;
            // 
            // btn_printreceipt
            // 
            btn_printreceipt.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_printreceipt.FlatAppearance.BorderSize = 0;
            btn_printreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_printreceipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_printreceipt.Image = (System.Drawing.Image)resources.GetObject("btn_printreceipt.Image");
            btn_printreceipt.Location = new System.Drawing.Point(732, 542);
            btn_printreceipt.Name = "btn_printreceipt";
            btn_printreceipt.Size = new System.Drawing.Size(293, 50);
            btn_printreceipt.TabIndex = 5;
            btn_printreceipt.Text = "   PRINT DELIVERY RECEIPT";
            btn_printreceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_printreceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_printreceipt.UseVisualStyleBackColor = false;
            btn_printreceipt.Click += btn_printreceipt_Click;
            // 
            // grid_customerlist
            // 
            grid_customerlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            grid_customerlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_customerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_customerlist.EnableHeadersVisualStyles = false;
            grid_customerlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            grid_customerlist.Location = new System.Drawing.Point(17, 88);
            grid_customerlist.Name = "grid_customerlist";
            grid_customerlist.ReadOnly = true;
            grid_customerlist.RowTemplate.Height = 24;
            grid_customerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid_customerlist.Size = new System.Drawing.Size(426, 503);
            grid_customerlist.TabIndex = 4;
            grid_customerlist.CellClick += grid_customerlist_CellClick;
            grid_customerlist.CellContentClick += grid_customerlist_CellContentClick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(12, 19);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(315, 25);
            label17.TabIndex = 3;
            label17.Text = "CURRENT CUSTOMER ORDERS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(14, 54);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(490, 17);
            label16.TabIndex = 2;
            label16.Text = "Please use the POS feature when checking out an order to tally to inventory.";
            // 
            // btn_removeorder
            // 
            btn_removeorder.BackColor = System.Drawing.Color.RosyBrown;
            btn_removeorder.FlatAppearance.BorderSize = 0;
            btn_removeorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_removeorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_removeorder.Image = (System.Drawing.Image)resources.GetObject("btn_removeorder.Image");
            btn_removeorder.Location = new System.Drawing.Point(448, 542);
            btn_removeorder.Name = "btn_removeorder";
            btn_removeorder.Size = new System.Drawing.Size(278, 51);
            btn_removeorder.TabIndex = 1;
            btn_removeorder.Text = "   REMOVE ORDER";
            btn_removeorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_removeorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_removeorder.UseVisualStyleBackColor = false;
            btn_removeorder.Click += btn_removeorder_Click;
            // 
            // grid_orders
            // 
            grid_orders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            grid_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_orders.EnableHeadersVisualStyles = false;
            grid_orders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            grid_orders.Location = new System.Drawing.Point(448, 88);
            grid_orders.Name = "grid_orders";
            grid_orders.ReadOnly = true;
            grid_orders.RowTemplate.Height = 24;
            grid_orders.Size = new System.Drawing.Size(577, 448);
            grid_orders.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_placeorder);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1055, 635);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PLACE ORDER";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // btn_placeorder
            // 
            btn_placeorder.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_placeorder.FlatAppearance.BorderSize = 0;
            btn_placeorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_placeorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_placeorder.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_placeorder.Location = new System.Drawing.Point(778, 494);
            btn_placeorder.Name = "btn_placeorder";
            btn_placeorder.Size = new System.Drawing.Size(257, 100);
            btn_placeorder.TabIndex = 24;
            btn_placeorder.Text = "PLACE ORDER";
            btn_placeorder.UseVisualStyleBackColor = false;
            btn_placeorder.Click += btn_placeorder_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(11, 19);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(204, 25);
            label9.TabIndex = 8;
            label9.Text = "PLACE NEW ORDER";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl2);
            groupBox3.Location = new System.Drawing.Point(16, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(280, 352);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "ADD ITEMS";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tab_PLACEORDER);
            tabControl2.Controls.Add(tab_NEWITEMS);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(3, 19);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(274, 330);
            tabControl2.TabIndex = 7;
            // 
            // tab_PLACEORDER
            // 
            tab_PLACEORDER.Controls.Add(tb_qty);
            tab_PLACEORDER.Controls.Add(tb_diskawnt);
            tab_PLACEORDER.Controls.Add(label13);
            tab_PLACEORDER.Controls.Add(label12);
            tab_PLACEORDER.Controls.Add(lb_price);
            tab_PLACEORDER.Controls.Add(btn_addtolist);
            tab_PLACEORDER.Controls.Add(label18);
            tab_PLACEORDER.Controls.Add(cb_item);
            tab_PLACEORDER.Controls.Add(cb_brand);
            tab_PLACEORDER.Controls.Add(label11);
            tab_PLACEORDER.Controls.Add(label10);
            tab_PLACEORDER.Location = new System.Drawing.Point(4, 25);
            tab_PLACEORDER.Name = "tab_PLACEORDER";
            tab_PLACEORDER.Padding = new System.Windows.Forms.Padding(3);
            tab_PLACEORDER.Size = new System.Drawing.Size(266, 301);
            tab_PLACEORDER.TabIndex = 0;
            tab_PLACEORDER.Text = "INVENTORY";
            tab_PLACEORDER.UseVisualStyleBackColor = true;
            // 
            // tb_qty
            // 
            tb_qty.Location = new System.Drawing.Point(186, 158);
            tb_qty.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            tb_qty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tb_qty.Name = "tb_qty";
            tb_qty.Size = new System.Drawing.Size(63, 23);
            tb_qty.TabIndex = 18;
            tb_qty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_diskawnt
            // 
            tb_diskawnt.Location = new System.Drawing.Point(10, 154);
            tb_diskawnt.Name = "tb_diskawnt";
            tb_diskawnt.Size = new System.Drawing.Size(106, 23);
            tb_diskawnt.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(5, 129);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(105, 17);
            label13.TabIndex = 13;
            label13.Text = "DISCOUNT (%)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(130, 159);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(49, 17);
            label12.TabIndex = 12;
            label12.Text = "UNITS";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new System.Drawing.Point(68, 194);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(16, 17);
            lb_price.TabIndex = 7;
            lb_price.Text = "0";
            // 
            // btn_addtolist
            // 
            btn_addtolist.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_addtolist.FlatAppearance.BorderSize = 0;
            btn_addtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addtolist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_addtolist.Image = (System.Drawing.Image)resources.GetObject("btn_addtolist.Image");
            btn_addtolist.Location = new System.Drawing.Point(26, 230);
            btn_addtolist.Name = "btn_addtolist";
            btn_addtolist.Size = new System.Drawing.Size(217, 52);
            btn_addtolist.TabIndex = 6;
            btn_addtolist.Text = "   ADD TO LIST";
            btn_addtolist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_addtolist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_addtolist.UseVisualStyleBackColor = false;
            btn_addtolist.Click += btn_addtolist_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(11, 194);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(48, 17);
            label18.TabIndex = 6;
            label18.Text = "PRICE";
            // 
            // cb_item
            // 
            cb_item.FormattingEnabled = true;
            cb_item.Location = new System.Drawing.Point(8, 96);
            cb_item.Name = "cb_item";
            cb_item.Size = new System.Drawing.Size(242, 24);
            cb_item.TabIndex = 5;
            // 
            // cb_brand
            // 
            cb_brand.FormattingEnabled = true;
            cb_brand.Location = new System.Drawing.Point(9, 38);
            cb_brand.Name = "cb_brand";
            cb_brand.Size = new System.Drawing.Size(241, 24);
            cb_brand.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 71);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(40, 17);
            label11.TabIndex = 1;
            label11.Text = "ITEM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 17);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 17);
            label10.TabIndex = 0;
            label10.Text = "BRAND";
            // 
            // tab_NEWITEMS
            // 
            tab_NEWITEMS.Controls.Add(tb_price);
            tab_NEWITEMS.Controls.Add(tb_qty2);
            tab_NEWITEMS.Controls.Add(tb_disc);
            tab_NEWITEMS.Controls.Add(label19);
            tab_NEWITEMS.Controls.Add(label20);
            tab_NEWITEMS.Controls.Add(label8);
            tab_NEWITEMS.Controls.Add(tb_item);
            tab_NEWITEMS.Controls.Add(tb_brand);
            tab_NEWITEMS.Controls.Add(label14);
            tab_NEWITEMS.Controls.Add(label15);
            tab_NEWITEMS.Controls.Add(btn_addtolist_new);
            tab_NEWITEMS.Location = new System.Drawing.Point(4, 24);
            tab_NEWITEMS.Name = "tab_NEWITEMS";
            tab_NEWITEMS.Padding = new System.Windows.Forms.Padding(3);
            tab_NEWITEMS.Size = new System.Drawing.Size(266, 302);
            tab_NEWITEMS.TabIndex = 1;
            tab_NEWITEMS.Text = "NEW ITEMS";
            tab_NEWITEMS.UseVisualStyleBackColor = true;
            // 
            // tb_price
            // 
            tb_price.DecimalPlaces = 2;
            tb_price.Location = new System.Drawing.Point(68, 194);
            tb_price.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            tb_price.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tb_price.Name = "tb_price";
            tb_price.Size = new System.Drawing.Size(105, 23);
            tb_price.TabIndex = 26;
            tb_price.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_qty2
            // 
            tb_qty2.Location = new System.Drawing.Point(199, 151);
            tb_qty2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            tb_qty2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tb_qty2.Name = "tb_qty2";
            tb_qty2.Size = new System.Drawing.Size(51, 23);
            tb_qty2.TabIndex = 25;
            tb_qty2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_disc
            // 
            tb_disc.Location = new System.Drawing.Point(9, 151);
            tb_disc.Name = "tb_disc";
            tb_disc.Size = new System.Drawing.Size(105, 23);
            tb_disc.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(5, 129);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(105, 17);
            label19.TabIndex = 23;
            label19.Text = "DISCOUNT (%)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(144, 153);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(49, 17);
            label20.TabIndex = 22;
            label20.Text = "UNITS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(11, 194);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(48, 17);
            label8.TabIndex = 6;
            label8.Text = "PRICE";
            // 
            // tb_item
            // 
            tb_item.Location = new System.Drawing.Point(9, 96);
            tb_item.Name = "tb_item";
            tb_item.Size = new System.Drawing.Size(241, 23);
            tb_item.TabIndex = 5;
            // 
            // tb_brand
            // 
            tb_brand.Location = new System.Drawing.Point(9, 38);
            tb_brand.Name = "tb_brand";
            tb_brand.Size = new System.Drawing.Size(241, 23);
            tb_brand.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(8, 71);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(40, 17);
            label14.TabIndex = 3;
            label14.Text = "ITEM";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(7, 17);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(56, 17);
            label15.TabIndex = 2;
            label15.Text = "BRAND";
            // 
            // btn_addtolist_new
            // 
            btn_addtolist_new.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_addtolist_new.FlatAppearance.BorderSize = 0;
            btn_addtolist_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addtolist_new.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_addtolist_new.Image = (System.Drawing.Image)resources.GetObject("btn_addtolist_new.Image");
            btn_addtolist_new.Location = new System.Drawing.Point(26, 230);
            btn_addtolist_new.Name = "btn_addtolist_new";
            btn_addtolist_new.Size = new System.Drawing.Size(217, 52);
            btn_addtolist_new.TabIndex = 19;
            btn_addtolist_new.Text = "   ADD TO LIST";
            btn_addtolist_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_addtolist_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_addtolist_new.UseVisualStyleBackColor = false;
            btn_addtolist_new.Click += btn_addtolist_new_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_address);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tb_contact);
            groupBox2.Controls.Add(tb_cname);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(16, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(281, 185);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "INSERT CUSTOMER DETAILS";
            // 
            // tb_address
            // 
            tb_address.Location = new System.Drawing.Point(91, 64);
            tb_address.Name = "tb_address";
            tb_address.Size = new System.Drawing.Size(182, 81);
            tb_address.TabIndex = 6;
            tb_address.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 17);
            label4.TabIndex = 5;
            label4.Text = "CONTACT";
            // 
            // tb_contact
            // 
            tb_contact.Location = new System.Drawing.Point(92, 148);
            tb_contact.Name = "tb_contact";
            tb_contact.Size = new System.Drawing.Size(181, 23);
            tb_contact.TabIndex = 4;
            // 
            // tb_cname
            // 
            tb_cname.Location = new System.Drawing.Point(91, 34);
            tb_cname.Name = "tb_cname";
            tb_cname.Size = new System.Drawing.Size(182, 23);
            tb_cname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 17);
            label3.TabIndex = 1;
            label3.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 17);
            label2.TabIndex = 0;
            label2.Text = "NAME";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_notes);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(delivery_picker);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new System.Drawing.Point(778, 59);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(257, 429);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "PAYMENT AND DELIVERY DETAILS";
            // 
            // tb_notes
            // 
            tb_notes.Location = new System.Drawing.Point(15, 169);
            tb_notes.Name = "tb_notes";
            tb_notes.Size = new System.Drawing.Size(229, 235);
            tb_notes.TabIndex = 7;
            tb_notes.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 17);
            label6.TabIndex = 20;
            label6.Text = "NOTES";
            // 
            // delivery_picker
            // 
            delivery_picker.Location = new System.Drawing.Point(15, 90);
            delivery_picker.Name = "delivery_picker";
            delivery_picker.Size = new System.Drawing.Size(229, 23);
            delivery_picker.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 65);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 17);
            label5.TabIndex = 10;
            label5.Text = "DELIVERY DATE:";
            label5.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_subtotal);
            groupBox1.Controls.Add(lb_subt);
            groupBox1.Controls.Add(btn_remove);
            groupBox1.Controls.Add(grid_orderlist);
            groupBox1.Location = new System.Drawing.Point(302, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(471, 539);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ORDER LIST";
            // 
            // lb_subtotal
            // 
            lb_subtotal.AutoSize = true;
            lb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_subtotal.Location = new System.Drawing.Point(354, 477);
            lb_subtotal.Name = "lb_subtotal";
            lb_subtotal.Size = new System.Drawing.Size(23, 25);
            lb_subtotal.TabIndex = 5;
            lb_subtotal.Text = "0";
            // 
            // lb_subt
            // 
            lb_subt.AutoSize = true;
            lb_subt.Location = new System.Drawing.Point(269, 482);
            lb_subt.Name = "lb_subt";
            lb_subt.Size = new System.Drawing.Size(58, 17);
            lb_subt.TabIndex = 4;
            lb_subt.Text = "TOTAL:";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = System.Drawing.Color.RosyBrown;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_remove.Image = (System.Drawing.Image)resources.GetObject("btn_remove.Image");
            btn_remove.Location = new System.Drawing.Point(6, 466);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(236, 56);
            btn_remove.TabIndex = 3;
            btn_remove.Text = "REMOVE FROM LIST";
            btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // grid_orderlist
            // 
            grid_orderlist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            grid_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_orderlist.GridColor = System.Drawing.Color.Silver;
            grid_orderlist.Location = new System.Drawing.Point(6, 21);
            grid_orderlist.Name = "grid_orderlist";
            grid_orderlist.ReadOnly = true;
            grid_orderlist.RowTemplate.Height = 24;
            grid_orderlist.Size = new System.Drawing.Size(458, 433);
            grid_orderlist.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tab_CURRENTORDER);
            tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(0, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new System.Drawing.Point(10, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1063, 668);
            tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lb_cuser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1063, 76);
            panel1.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(91, 44);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(335, 15);
            label21.TabIndex = 14;
            label21.Text = "Keep track of orders, delivery dates and customer information.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(779, 15);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 15);
            label7.TabIndex = 13;
            label7.Text = "CURRENT USER: ";
            // 
            // lb_cuser
            // 
            lb_cuser.AutoSize = true;
            lb_cuser.Location = new System.Drawing.Point(882, 13);
            lb_cuser.MaximumSize = new System.Drawing.Size(88, 0);
            lb_cuser.Name = "lb_cuser";
            lb_cuser.Size = new System.Drawing.Size(87, 45);
            lb_cuser.TabIndex = 12;
            lb_cuser.Text = "lbjashdjsahdkjsahdkjsahdjashdjksahd";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(55, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // SalesMonitoring
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(1063, 758);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SalesMonitoring";
            Text = "ORDERS MANAGEMENT";
            Load += SalesMonitoring_Load;
            ((System.ComponentModel.ISupportInitialize)salesperitemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)salespendingordersBindingSource1).EndInit();
            tab_CURRENTORDER.ResumeLayout(false);
            tab_CURRENTORDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_customerlist).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_orders).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tab_PLACEORDER.ResumeLayout(false);
            tab_PLACEORDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_qty).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_diskawnt).EndInit();
            tab_NEWITEMS.ResumeLayout(false);
            tab_NEWITEMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_qty2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_disc).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_orderlist).EndInit();
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salespendingordersBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private POSDBDataSet2 pOSDBDataSet2;
        private System.Windows.Forms.BindingSource salesperitemBindingSource;
        private POSDBDataSet2TableAdapters.sales_peritemTableAdapter sales_peritemTableAdapter;
        private System.Windows.Forms.Label label1;
        private POSDBDataSet3 pOSDBDataSet3;
        private System.Windows.Forms.BindingSource salespendingordersBindingSource;
        private POSDBDataSet5TableAdapters.sales_pending_ordersTableAdapter sales_pending_ordersTableAdapter;
        private System.Windows.Forms.BindingSource salespendingordersBindingSource1;
        private POSDBDataSet5 pOSDBDataSet5;
        private System.Windows.Forms.TabPage tab_CURRENTORDER;
        private System.Windows.Forms.DataGridView grid_customerlist;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_removeorder;
        private System.Windows.Forms.DataGridView grid_orders;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_PLACEORDER;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tab_NEWITEMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.TextBox tb_brand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_addtolist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tb_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_cname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_orderlist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_addtolist_new;
        private System.Windows.Forms.Label lb_subtotal;
        private System.Windows.Forms.Label lb_subt;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_placeorder;
        private System.Windows.Forms.DateTimePicker delivery_picker;
        private System.Windows.Forms.Button btn_printreceipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox tb_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.NumericUpDown tb_diskawnt;
        private System.Windows.Forms.NumericUpDown tb_qty;
        private System.Windows.Forms.NumericUpDown tb_disc;
        private System.Windows.Forms.NumericUpDown tb_price;
        private System.Windows.Forms.NumericUpDown tb_qty2;
        private System.Windows.Forms.Label label21;
    }
}