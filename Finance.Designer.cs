namespace BMC2021
{
    partial class FinanceMonitoring
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceMonitoring));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_stockvalue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_profit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_revenue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cost = new System.Windows.Forms.Label();
            this.lb_selectedmonthyear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_loadmonth = new System.Windows.Forms.Button();
            this.chart_visual_month = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_annual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_monthyear = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_LoadAnnual = new System.Windows.Forms.Button();
            this.dtp_selectYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_annual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_visual_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 541);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_visual_month);
            this.tabPage1.Controls.Add(this.lb_stockvalue);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lb_profit);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lb_revenue);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lb_cost);
            this.tabPage1.Controls.Add(this.lb_selectedmonthyear);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_loadmonth);
            this.tabPage1.Controls.Add(this.dtp_monthyear);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MONTHLY VISUALIZATION";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_stockvalue
            // 
            this.lb_stockvalue.AutoSize = true;
            this.lb_stockvalue.Location = new System.Drawing.Point(959, 341);
            this.lb_stockvalue.Name = "lb_stockvalue";
            this.lb_stockvalue.Size = new System.Drawing.Size(46, 17);
            this.lb_stockvalue.TabIndex = 28;
            this.lb_stockvalue.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 317);
            this.label7.MaximumSize = new System.Drawing.Size(175, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 51);
            this.label7.TabIndex = 27;
            this.label7.Text = "STOCK VALUE OF REMAINING ITEMS IN INVENTORY:";
            // 
            // lb_profit
            // 
            this.lb_profit.AutoSize = true;
            this.lb_profit.Location = new System.Drawing.Point(959, 290);
            this.lb_profit.Name = "lb_profit";
            this.lb_profit.Size = new System.Drawing.Size(54, 17);
            this.lb_profit.TabIndex = 26;
            this.lb_profit.Text = "label14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(766, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "COST OF ITEMS SOLD:";
            // 
            // lb_revenue
            // 
            this.lb_revenue.AutoSize = true;
            this.lb_revenue.Location = new System.Drawing.Point(959, 264);
            this.lb_revenue.Name = "lb_revenue";
            this.lb_revenue.Size = new System.Drawing.Size(46, 17);
            this.lb_revenue.TabIndex = 24;
            this.lb_revenue.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "PROFIT FROM SALES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "REVENUE FROM SALES:";
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Location = new System.Drawing.Point(959, 239);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(46, 17);
            this.lb_cost.TabIndex = 21;
            this.lb_cost.Text = "label4";
            // 
            // chart_visual_month
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_visual_month.ChartAreas.Add(chartArea1);
            this.chart_visual_month.Location = new System.Drawing.Point(3, 6);
            this.chart_visual_month.Name = "chart_visual_month";
            this.chart_visual_month.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Name = "AMOUNT in PHP";
            this.chart_visual_month.Series.Add(series1);
            this.chart_visual_month.Size = new System.Drawing.Size(750, 500);
            this.chart_visual_month.TabIndex = 5;
            this.chart_visual_month.Text = "VISUALIZATION";
            // 
            // lb_selectedmonthyear
            // 
            this.lb_selectedmonthyear.AutoSize = true;
            this.lb_selectedmonthyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_selectedmonthyear.Location = new System.Drawing.Point(766, 179);
            this.lb_selectedmonthyear.Name = "lb_selectedmonthyear";
            this.lb_selectedmonthyear.Size = new System.Drawing.Size(64, 25);
            this.lb_selectedmonthyear.TabIndex = 19;
            this.lb_selectedmonthyear.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(766, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "FOR THE MONTH OF:";
            // 
            // btn_loadmonth
            // 
            this.btn_loadmonth.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_loadmonth.FlatAppearance.BorderSize = 0;
            this.btn_loadmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadmonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loadmonth.Location = new System.Drawing.Point(766, 75);
            this.btn_loadmonth.Name = "btn_loadmonth";
            this.btn_loadmonth.Size = new System.Drawing.Size(279, 48);
            this.btn_loadmonth.TabIndex = 17;
            this.btn_loadmonth.Text = "LOAD DATA";
            this.btn_loadmonth.UseVisualStyleBackColor = false;
            this.btn_loadmonth.Click += new System.EventHandler(this.btn_loadmonth_Click_1);
            // 
            // dtp_monthyear
            // 
            this.dtp_monthyear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_monthyear.Location = new System.Drawing.Point(766, 41);
            this.dtp_monthyear.Name = "dtp_monthyear";
            this.dtp_monthyear.ShowUpDown = true;
            this.dtp_monthyear.Size = new System.Drawing.Size(280, 23);
            this.dtp_monthyear.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Select MONTH and YEAR";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_LoadAnnual);
            this.tabPage3.Controls.Add(this.dtp_selectYear);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lb_year);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.chart_annual);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(800, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ANNUAL VISUALIZATION";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_LoadAnnual
            // 
            this.btn_LoadAnnual.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_LoadAnnual.FlatAppearance.BorderSize = 0;
            this.btn_LoadAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadAnnual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LoadAnnual.Location = new System.Drawing.Point(852, 396);
            this.btn_LoadAnnual.Name = "btn_LoadAnnual";
            this.btn_LoadAnnual.Size = new System.Drawing.Size(194, 54);
            this.btn_LoadAnnual.TabIndex = 23;
            this.btn_LoadAnnual.Text = "LOAD GRAPHS";
            this.btn_LoadAnnual.UseVisualStyleBackColor = false;
            this.btn_LoadAnnual.Click += new System.EventHandler(this.btn_LoadAnnual_Click);
            // 
            // dtp_selectYear
            // 
            this.dtp_selectYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_selectYear.Location = new System.Drawing.Point(852, 366);
            this.dtp_selectYear.Name = "dtp_selectYear";
            this.dtp_selectYear.ShowUpDown = true;
            this.dtp_selectYear.Size = new System.Drawing.Size(195, 23);
            this.dtp_selectYear.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select YEAR";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_year.Location = new System.Drawing.Point(209, 23);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(64, 25);
            this.lb_year.TabIndex = 20;
            this.lb_year.Text = "YYYY";
            // 
            // chart_annual
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_annual.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart_annual.Legends.Add(legend1);
            this.chart_annual.Location = new System.Drawing.Point(0, 51);
            this.chart_annual.Name = "chart_annual";
            this.chart_annual.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "COST OF ITEMS";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SALES REVENUE";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "SALES PROFIT";
            this.chart_annual.Series.Add(series2);
            this.chart_annual.Series.Add(series3);
            this.chart_annual.Series.Add(series4);
            this.chart_annual.Size = new System.Drawing.Size(700, 486);
            this.chart_annual.TabIndex = 2;
            this.chart_annual.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "FOR THE YEAR:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(94, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "FINANCE MONITORING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 76);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Monitor your monthly revenue, stock value and profits.";
            // 
            // FinanceMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = false;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinanceMonitoring";
            this.Text = "FINANCE MONITORING";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_annual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_visual_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_visual_month;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_annual;
        private System.Windows.Forms.Button btn_loadmonth;
        private System.Windows.Forms.DateTimePicker dtp_monthyear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_profit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_revenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.Label lb_selectedmonthyear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_selectYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LoadAnnual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_stockvalue;
        private System.Windows.Forms.Label label9;
    }
}