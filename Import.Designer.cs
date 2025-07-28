
namespace BMC2021
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Location = new System.Drawing.Point(12, 386);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(416, 53);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "LOAD CSV";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 100);
            this.panel1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(503, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "If you are working with two or more BMC software, you may import external records" +
    " thru CSV.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "IMPORT ITEMS TO INVENTORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make sure that your CSV file have the correct column names.";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(12, 445);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(416, 53);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "ADD ROWS TO DATABASE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.ColumnHeadersHeight = 47;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.deliverydate,
            this.supplier,
            this.itembrand,
            this.itemname,
            this.purchaseprice,
            this.barcode,
            this.itemdescription,
            this.condition,
            this.saleprice,
            this.loggedby});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgItems.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgItems.Location = new System.Drawing.Point(461, 100);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgItems.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.Size = new System.Drawing.Size(463, 427);
            this.dgItems.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // deliverydate
            // 
            this.deliverydate.DataPropertyName = "deliverydate";
            this.deliverydate.HeaderText = "deliverydate";
            this.deliverydate.Name = "deliverydate";
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "supplier";
            this.supplier.HeaderText = "supplier";
            this.supplier.Name = "supplier";
            // 
            // itembrand
            // 
            this.itembrand.DataPropertyName = "itembrand";
            this.itembrand.HeaderText = "itembrand";
            this.itembrand.Name = "itembrand";
            // 
            // itemname
            // 
            this.itemname.DataPropertyName = "itemname";
            this.itemname.HeaderText = "itemname";
            this.itemname.Name = "itemname";
            // 
            // purchaseprice
            // 
            this.purchaseprice.DataPropertyName = "purchaseprice";
            this.purchaseprice.HeaderText = "purchaseprice";
            this.purchaseprice.Name = "purchaseprice";
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "barcode";
            this.barcode.Name = "barcode";
            // 
            // itemdescription
            // 
            this.itemdescription.DataPropertyName = "itemdescription";
            this.itemdescription.HeaderText = "itemdescription";
            this.itemdescription.Name = "itemdescription";
            // 
            // condition
            // 
            this.condition.DataPropertyName = "condition";
            this.condition.HeaderText = "condition";
            this.condition.Name = "condition";
            // 
            // saleprice
            // 
            this.saleprice.DataPropertyName = "saleprice";
            this.saleprice.HeaderText = "saleprice";
            this.saleprice.Name = "saleprice";
            // 
            // loggedby
            // 
            this.loggedby.DataPropertyName = "loggedby";
            this.loggedby.HeaderText = "loggedby";
            this.loggedby.Name = "loggedby";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(461, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "Import items from CSV to your Inventory";
            // 
            // txtFile
            // 
            this.txtFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFile.Location = new System.Drawing.Point(15, 356);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(413, 16);
            this.txtFile.TabIndex = 8;
            this.txtFile.Text = "FILENAME OF CSV DISPLAYED HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "All imported rows will be ADDED to existing database.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "The correct column names and order is shown on the left panel.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Invalid values will be highlighted in the panel on the left.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Follow the export document\'s date format: dd-mm-yyyy";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Import";
            this.Text = "IMPORT TO INVENTORY";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label txtFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggedby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}