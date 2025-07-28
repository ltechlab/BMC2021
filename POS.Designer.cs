namespace BMC2021
{
    partial class PointOfSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSales));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_removecart = new System.Windows.Forms.Button();
            lb_totalprice = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            grid_cart = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            tb_cname = new System.Windows.Forms.TextBox();
            btn_checkout = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tb_qty = new System.Windows.Forms.NumericUpDown();
            tb_discount = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tb_barcode = new System.Windows.Forms.TextBox();
            tabPage4 = new System.Windows.Forms.TabPage();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cb_item = new System.Windows.Forms.ComboBox();
            cb_brand = new System.Windows.Forms.ComboBox();
            btn_addtocart = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label22 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lb_cuser = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_cart).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_qty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_discount).BeginInit();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btn_removecart);
            groupBox1.Controls.Add(lb_totalprice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(grid_cart);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_cname);
            groupBox1.Controls.Add(btn_checkout);
            groupBox1.Location = new System.Drawing.Point(33, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(533, 653);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHECKOUT";
            // 
            // btn_removecart
            // 
            btn_removecart.BackColor = System.Drawing.Color.Salmon;
            btn_removecart.FlatAppearance.BorderSize = 0;
            btn_removecart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_removecart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_removecart.Image = (System.Drawing.Image)resources.GetObject("btn_removecart.Image");
            btn_removecart.Location = new System.Drawing.Point(27, 538);
            btn_removecart.Name = "btn_removecart";
            btn_removecart.Size = new System.Drawing.Size(258, 41);
            btn_removecart.TabIndex = 11;
            btn_removecart.Text = "   REMOVE ITEM FROM CART";
            btn_removecart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_removecart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_removecart.UseVisualStyleBackColor = false;
            btn_removecart.Click += btn_removecart_Click;
            // 
            // lb_totalprice
            // 
            lb_totalprice.AutoSize = true;
            lb_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_totalprice.Location = new System.Drawing.Point(408, 546);
            lb_totalprice.Name = "lb_totalprice";
            lb_totalprice.Size = new System.Drawing.Size(18, 20);
            lb_totalprice.TabIndex = 10;
            lb_totalprice.Text = "0";
            lb_totalprice.Click += lb_totalprice_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(290, 549);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(106, 17);
            label4.TabIndex = 9;
            label4.Text = "TOTAL PRICE: ";
            // 
            // grid_cart
            // 
            grid_cart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            grid_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_cart.Location = new System.Drawing.Point(27, 71);
            grid_cart.Name = "grid_cart";
            grid_cart.ReadOnly = true;
            grid_cart.RowTemplate.Height = 24;
            grid_cart.Size = new System.Drawing.Size(473, 458);
            grid_cart.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(24, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 17);
            label3.TabIndex = 7;
            label3.Text = "Customer NAME";
            // 
            // tb_cname
            // 
            tb_cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_cname.Location = new System.Drawing.Point(160, 30);
            tb_cname.Name = "tb_cname";
            tb_cname.Size = new System.Drawing.Size(341, 23);
            tb_cname.TabIndex = 2;
            // 
            // btn_checkout
            // 
            btn_checkout.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_checkout.FlatAppearance.BorderSize = 0;
            btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_checkout.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_checkout.Image = (System.Drawing.Image)resources.GetObject("btn_checkout.Image");
            btn_checkout.Location = new System.Drawing.Point(29, 587);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new System.Drawing.Size(473, 54);
            btn_checkout.TabIndex = 1;
            btn_checkout.Text = "   CHECKOUT";
            btn_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_checkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_checkout.UseVisualStyleBackColor = false;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox2.Controls.Add(tb_qty);
            groupBox2.Controls.Add(tb_discount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tabControl2);
            groupBox2.Controls.Add(btn_addtocart);
            groupBox2.Location = new System.Drawing.Point(602, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(433, 341);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CUSTOMER CART";
            // 
            // tb_qty
            // 
            tb_qty.Location = new System.Drawing.Point(143, 217);
            tb_qty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tb_qty.Name = "tb_qty";
            tb_qty.Size = new System.Drawing.Size(248, 23);
            tb_qty.TabIndex = 26;
            tb_qty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_discount
            // 
            tb_discount.Location = new System.Drawing.Point(143, 189);
            tb_discount.Name = "tb_discount";
            tb_discount.Size = new System.Drawing.Size(248, 23);
            tb_discount.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(17, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 17);
            label5.TabIndex = 22;
            label5.Text = "DISCOUNT (%)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 216);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 17);
            label2.TabIndex = 21;
            label2.Text = "UNITS (pcs/kilos)";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new System.Drawing.Point(19, 22);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(396, 142);
            tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(tb_barcode);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(388, 114);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "BARCODE INPUT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(5, 8);
            label9.MaximumSize = new System.Drawing.Size(280, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(270, 30);
            label9.TabIndex = 5;
            label9.Text = "Please connect the barcode scanner OR manually input the barcode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 17);
            label1.TabIndex = 4;
            label1.Text = "BARCODE";
            // 
            // tb_barcode
            // 
            tb_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_barcode.Location = new System.Drawing.Point(120, 61);
            tb_barcode.Name = "tb_barcode";
            tb_barcode.Size = new System.Drawing.Size(244, 23);
            tb_barcode.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(cb_item);
            tabPage4.Controls.Add(cb_brand);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(388, 114);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "MANUAL INPUT";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(5, 8);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(232, 15);
            label10.TabIndex = 20;
            label10.Text = "Please select item BRAND and item NAME.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(10, 68);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 17);
            label7.TabIndex = 19;
            label7.Text = "ITEM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(10, 42);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 17);
            label6.TabIndex = 18;
            label6.Text = "BRAND";
            // 
            // cb_item
            // 
            cb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_item.FormattingEnabled = true;
            cb_item.Location = new System.Drawing.Point(83, 68);
            cb_item.Name = "cb_item";
            cb_item.Size = new System.Drawing.Size(283, 24);
            cb_item.TabIndex = 14;
            // 
            // cb_brand
            // 
            cb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_brand.FormattingEnabled = true;
            cb_brand.Location = new System.Drawing.Point(83, 39);
            cb_brand.Name = "cb_brand";
            cb_brand.Size = new System.Drawing.Size(283, 24);
            cb_brand.TabIndex = 13;
            // 
            // btn_addtocart
            // 
            btn_addtocart.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_addtocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_addtocart.FlatAppearance.BorderSize = 0;
            btn_addtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_addtocart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_addtocart.ForeColor = System.Drawing.Color.Ivory;
            btn_addtocart.Image = (System.Drawing.Image)resources.GetObject("btn_addtocart.Image");
            btn_addtocart.Location = new System.Drawing.Point(73, 260);
            btn_addtocart.Name = "btn_addtocart";
            btn_addtocart.Size = new System.Drawing.Size(297, 53);
            btn_addtocart.TabIndex = 0;
            btn_addtocart.Text = "   ADD TO LIST";
            btn_addtocart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_addtocart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_addtocart.UseVisualStyleBackColor = false;
            btn_addtocart.Click += btn_addtocart_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl1);
            groupBox3.Location = new System.Drawing.Point(602, 454);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(433, 290);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "REMINDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(3, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(427, 268);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(419, 240);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GENERAL";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.Location = new System.Drawing.Point(10, 194);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(392, 32);
            label22.TabIndex = 4;
            label22.Text = "Don't forget to issue an official receipt (if applicable).";
            // 
            // label21
            // 
            label21.Location = new System.Drawing.Point(10, 140);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(392, 54);
            label21.TabIndex = 3;
            label21.Text = "If you want to void a transaction, go to \"Sales Monitoring\" feature and delete the transaction row. Then, re-add the item in the inventory if applicable.";
            // 
            // label20
            // 
            label20.Location = new System.Drawing.Point(13, 100);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(392, 44);
            label20.TabIndex = 2;
            label20.Text = "Don't forget to include applicable taxes in your transactions! Check your country's tax laws!";
            // 
            // label14
            // 
            label14.Location = new System.Drawing.Point(12, 58);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(392, 44);
            label14.TabIndex = 1;
            label14.Text = "What supporting documentation are needed to be presented to avail of discount?";
            // 
            // label13
            // 
            label13.Location = new System.Drawing.Point(12, 12);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(392, 44);
            label13.TabIndex = 0;
            label13.Text = "Issue discounts as mandated by law. Use the discount function to automatically deduct % discount from the unit price.";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(419, 240);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DISCOUNTS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.Location = new System.Drawing.Point(12, 111);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(381, 23);
            label19.TabIndex = 6;
            label19.Text = "Vouchers";
            // 
            // label18
            // 
            label18.Location = new System.Drawing.Point(13, 88);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(381, 23);
            label18.TabIndex = 5;
            label18.Text = "Membership / Promo Card Holders";
            // 
            // label17
            // 
            label17.Location = new System.Drawing.Point(12, 65);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(381, 23);
            label17.TabIndex = 4;
            label17.Text = "Persons With Disability (PWD) Discount";
            // 
            // label16
            // 
            label16.Location = new System.Drawing.Point(12, 42);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(381, 23);
            label16.TabIndex = 3;
            label16.Text = "Senior Citizen Discount";
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(12, 18);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(392, 24);
            label15.TabIndex = 2;
            label15.Text = "Example discounts:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(86, 14);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(164, 24);
            label8.TabIndex = 1;
            label8.Text = "POINT OF SALES";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lb_cuser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1057, 76);
            panel1.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(89, 40);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(297, 15);
            label12.TabIndex = 12;
            label12.Text = "Point of Sales : Properly LOG and check-out sold items.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(765, 9);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(100, 15);
            label11.TabIndex = 11;
            label11.Text = "CURRENT USER: ";
            // 
            // lb_cuser
            // 
            lb_cuser.AutoSize = true;
            lb_cuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_cuser.Location = new System.Drawing.Point(886, 9);
            lb_cuser.MaximumSize = new System.Drawing.Size(88, 0);
            lb_cuser.Name = "lb_cuser";
            lb_cuser.Size = new System.Drawing.Size(87, 45);
            lb_cuser.TabIndex = 10;
            lb_cuser.Text = "lbjashdjsahdkjsahdkjsahdjashdjksahd";
            lb_cuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // PointOfSales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(1057, 755);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "PointOfSales";
            Text = "POINT OF SALES";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_cart).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_qty).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_discount).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_cname;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_cart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_totalprice;
        private System.Windows.Forms.Button btn_removecart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.NumericUpDown tb_discount;
        private System.Windows.Forms.NumericUpDown tb_qty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}