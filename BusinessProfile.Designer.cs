

namespace BMC2021
{
    partial class BusinessProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessProfile));
            BPROFILE_TABS = new System.Windows.Forms.TabControl();
            TAB_SCHEDULER = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btn_deletesched = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cb_repeating = new System.Windows.Forms.CheckBox();
            btn_savereminder = new System.Windows.Forms.Button();
            tb_remind = new System.Windows.Forms.RichTextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            TAB_EDITPROFILE = new System.Windows.Forms.TabPage();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            btn_updateprofile = new System.Windows.Forms.Button();
            blicense = new System.Windows.Forms.TextBox();
            dticert = new System.Windows.Forms.TextBox();
            bnature = new System.Windows.Forms.TextBox();
            baddress = new System.Windows.Forms.TextBox();
            tb_tin = new System.Windows.Forms.TextBox();
            bname = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox5 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            monthlytable = new System.Windows.Forms.TableLayoutPanel();
            groupBox6 = new System.Windows.Forms.GroupBox();
            panel3 = new System.Windows.Forms.Panel();
            tb_today = new System.Windows.Forms.TableLayoutPanel();
            lb_char = new System.Windows.Forms.Label();
            calendar = new System.Windows.Forms.MonthCalendar();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            blic = new System.Windows.Forms.Label();
            dtic = new System.Windows.Forms.Label();
            bnat = new System.Windows.Forms.Label();
            badd = new System.Windows.Forms.Label();
            txt_tin = new System.Windows.Forms.Label();
            txt_bname = new System.Windows.Forms.Label();
            pOSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(components);
            pOSDBDataSet = new POSDBDataSet();
            remindersTableAdapter = new BMC2021.POSDBDataSetTableAdapters.RemindersTableAdapter();
            label7 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label18 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lb_cuser = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            remindersBindingSource1 = new System.Windows.Forms.BindingSource(components);
            remindersBindingSource = new System.Windows.Forms.BindingSource(components);
            BPROFILE_TABS.SuspendLayout();
            TAB_SCHEDULER.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            TAB_EDITPROFILE.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            groupBox6.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pOSDBDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pOSDBDataSet).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)remindersBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)remindersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BPROFILE_TABS
            // 
            BPROFILE_TABS.Controls.Add(TAB_SCHEDULER);
            BPROFILE_TABS.Controls.Add(TAB_EDITPROFILE);
            BPROFILE_TABS.Controls.Add(tabPage1);
            BPROFILE_TABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BPROFILE_TABS.ItemSize = new System.Drawing.Size(152, 29);
            BPROFILE_TABS.Location = new System.Drawing.Point(209, 82);
            BPROFILE_TABS.Name = "BPROFILE_TABS";
            BPROFILE_TABS.Padding = new System.Drawing.Point(10, 5);
            BPROFILE_TABS.SelectedIndex = 0;
            BPROFILE_TABS.Size = new System.Drawing.Size(913, 547);
            BPROFILE_TABS.TabIndex = 0;
            // 
            // TAB_SCHEDULER
            // 
            TAB_SCHEDULER.Controls.Add(groupBox3);
            TAB_SCHEDULER.Controls.Add(groupBox2);
            TAB_SCHEDULER.Location = new System.Drawing.Point(4, 33);
            TAB_SCHEDULER.Name = "TAB_SCHEDULER";
            TAB_SCHEDULER.Padding = new System.Windows.Forms.Padding(3);
            TAB_SCHEDULER.Size = new System.Drawing.Size(905, 510);
            TAB_SCHEDULER.TabIndex = 0;
            TAB_SCHEDULER.Text = "MY SCHEDULER";
            TAB_SCHEDULER.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBox3.Controls.Add(btn_deletesched);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new System.Drawing.Point(465, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(424, 469);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "DELETE SCHEDULE";
            // 
            // btn_deletesched
            // 
            btn_deletesched.BackColor = System.Drawing.Color.RosyBrown;
            btn_deletesched.FlatAppearance.BorderSize = 0;
            btn_deletesched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_deletesched.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_deletesched.Image = (System.Drawing.Image)resources.GetObject("btn_deletesched.Image");
            btn_deletesched.Location = new System.Drawing.Point(16, 412);
            btn_deletesched.Name = "btn_deletesched";
            btn_deletesched.Size = new System.Drawing.Size(392, 45);
            btn_deletesched.TabIndex = 1;
            btn_deletesched.Text = "DELETE SELECTED";
            btn_deletesched.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_deletesched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_deletesched.UseVisualStyleBackColor = false;
            btn_deletesched.Click += btn_deletesched_Click;
            // 
            // listBox1
            // 
            listBox1.DisplayMember = "id";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new System.Drawing.Point(16, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(392, 356);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "id";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBox2.Controls.Add(cb_repeating);
            groupBox2.Controls.Add(btn_savereminder);
            groupBox2.Controls.Add(tb_remind);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new System.Drawing.Point(16, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(434, 471);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD SCHEDULE";
            // 
            // cb_repeating
            // 
            cb_repeating.AutoSize = true;
            cb_repeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_repeating.Location = new System.Drawing.Point(323, 37);
            cb_repeating.Name = "cb_repeating";
            cb_repeating.Size = new System.Drawing.Size(85, 17);
            cb_repeating.TabIndex = 3;
            cb_repeating.Text = "MONTHLY?";
            cb_repeating.UseVisualStyleBackColor = true;
            // 
            // btn_savereminder
            // 
            btn_savereminder.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_savereminder.FlatAppearance.BorderSize = 0;
            btn_savereminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_savereminder.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_savereminder.Image = (System.Drawing.Image)resources.GetObject("btn_savereminder.Image");
            btn_savereminder.Location = new System.Drawing.Point(15, 414);
            btn_savereminder.Name = "btn_savereminder";
            btn_savereminder.Size = new System.Drawing.Size(401, 44);
            btn_savereminder.TabIndex = 2;
            btn_savereminder.Text = " SAVE";
            btn_savereminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_savereminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_savereminder.UseVisualStyleBackColor = false;
            btn_savereminder.Click += btn_savereminder_Click;
            // 
            // tb_remind
            // 
            tb_remind.Location = new System.Drawing.Point(15, 62);
            tb_remind.Name = "tb_remind";
            tb_remind.Size = new System.Drawing.Size(401, 342);
            tb_remind.TabIndex = 1;
            tb_remind.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(15, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(260, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // TAB_EDITPROFILE
            // 
            TAB_EDITPROFILE.Controls.Add(label17);
            TAB_EDITPROFILE.Controls.Add(label16);
            TAB_EDITPROFILE.Controls.Add(label15);
            TAB_EDITPROFILE.Controls.Add(btn_updateprofile);
            TAB_EDITPROFILE.Controls.Add(blicense);
            TAB_EDITPROFILE.Controls.Add(dticert);
            TAB_EDITPROFILE.Controls.Add(bnature);
            TAB_EDITPROFILE.Controls.Add(baddress);
            TAB_EDITPROFILE.Controls.Add(tb_tin);
            TAB_EDITPROFILE.Controls.Add(bname);
            TAB_EDITPROFILE.Controls.Add(label6);
            TAB_EDITPROFILE.Controls.Add(label5);
            TAB_EDITPROFILE.Controls.Add(label4);
            TAB_EDITPROFILE.Controls.Add(label3);
            TAB_EDITPROFILE.Controls.Add(label2);
            TAB_EDITPROFILE.Controls.Add(label1);
            TAB_EDITPROFILE.Location = new System.Drawing.Point(4, 33);
            TAB_EDITPROFILE.Name = "TAB_EDITPROFILE";
            TAB_EDITPROFILE.Padding = new System.Windows.Forms.Padding(3);
            TAB_EDITPROFILE.Size = new System.Drawing.Size(905, 510);
            TAB_EDITPROFILE.TabIndex = 1;
            TAB_EDITPROFILE.Text = "EDIT PROFILE";
            TAB_EDITPROFILE.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(587, 188);
            label17.MaximumSize = new System.Drawing.Size(262, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(230, 34);
            label17.TabIndex = 15;
            label17.Text = "For security purposes, only ADMIN accounts can edit this section.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(587, 31);
            label16.MaximumSize = new System.Drawing.Size(262, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(262, 102);
            label16.TabIndex = 14;
            label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(39, 30);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(450, 25);
            label15.TabIndex = 13;
            label15.Text = "KEEP YOUR BUSINESS DETAILS UP-TO-DATE";
            // 
            // btn_updateprofile
            // 
            btn_updateprofile.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_updateprofile.FlatAppearance.BorderSize = 0;
            btn_updateprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_updateprofile.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_updateprofile.Image = (System.Drawing.Image)resources.GetObject("btn_updateprofile.Image");
            btn_updateprofile.Location = new System.Drawing.Point(44, 288);
            btn_updateprofile.Name = "btn_updateprofile";
            btn_updateprofile.Size = new System.Drawing.Size(462, 54);
            btn_updateprofile.TabIndex = 12;
            btn_updateprofile.Text = "UPDATE BUSINESS PROFILE";
            btn_updateprofile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_updateprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_updateprofile.UseVisualStyleBackColor = false;
            btn_updateprofile.Click += btn_updateprofile_Click;
            // 
            // blicense
            // 
            blicense.Location = new System.Drawing.Point(274, 234);
            blicense.Name = "blicense";
            blicense.Size = new System.Drawing.Size(238, 23);
            blicense.TabIndex = 11;
            // 
            // dticert
            // 
            dticert.Location = new System.Drawing.Point(274, 202);
            dticert.Name = "dticert";
            dticert.Size = new System.Drawing.Size(238, 23);
            dticert.TabIndex = 10;
            // 
            // bnature
            // 
            bnature.Location = new System.Drawing.Point(274, 172);
            bnature.Name = "bnature";
            bnature.Size = new System.Drawing.Size(238, 23);
            bnature.TabIndex = 9;
            // 
            // baddress
            // 
            baddress.Location = new System.Drawing.Point(274, 141);
            baddress.Name = "baddress";
            baddress.Size = new System.Drawing.Size(238, 23);
            baddress.TabIndex = 8;
            // 
            // tb_tin
            // 
            tb_tin.Location = new System.Drawing.Point(274, 110);
            tb_tin.Name = "tb_tin";
            tb_tin.Size = new System.Drawing.Size(238, 23);
            tb_tin.TabIndex = 7;
            // 
            // bname
            // 
            bname.Location = new System.Drawing.Point(274, 78);
            bname.Name = "bname";
            bname.Size = new System.Drawing.Size(238, 23);
            bname.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(38, 240);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(200, 17);
            label6.TabIndex = 5;
            label6.Text = "BUSINESS LICENSE NUMBER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 206);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(199, 17);
            label5.TabIndex = 4;
            label5.Text = "DTI CERTIFICATION NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 178);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 17);
            label4.TabIndex = 3;
            label4.Text = "BUSINESS NATURE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 17);
            label3.TabIndex = 2;
            label3.Text = "BUSINESS ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(208, 17);
            label2.TabIndex = 1;
            label2.Text = "TAX IDENTIFICATION NUMBER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "BUSINESS NAME";
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(calendar);
            tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabPage1.Location = new System.Drawing.Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(905, 510);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "MY CALENDAR";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(panel1);
            groupBox5.Location = new System.Drawing.Point(592, 21);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(307, 470);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "MONTHLY REMINDERS";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(monthlytable);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 17);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(301, 450);
            panel1.TabIndex = 0;
            // 
            // monthlytable
            // 
            monthlytable.AutoScroll = true;
            monthlytable.AutoSize = true;
            monthlytable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            monthlytable.ColumnCount = 2;
            monthlytable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            monthlytable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            monthlytable.Location = new System.Drawing.Point(9, 12);
            monthlytable.Name = "monthlytable";
            monthlytable.Padding = new System.Windows.Forms.Padding(5);
            monthlytable.RowCount = 2;
            monthlytable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            monthlytable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            monthlytable.Size = new System.Drawing.Size(376, 94);
            monthlytable.TabIndex = 0;
            monthlytable.Paint += monthlytable_Paint;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(panel3);
            groupBox6.Location = new System.Drawing.Point(280, 21);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(306, 469);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "ON THIS DAY:";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(tb_today);
            panel3.Controls.Add(lb_char);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(3, 17);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(300, 449);
            panel3.TabIndex = 0;
            // 
            // tb_today
            // 
            tb_today.AutoScroll = true;
            tb_today.AutoSize = true;
            tb_today.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            tb_today.ColumnCount = 2;
            tb_today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            tb_today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            tb_today.Location = new System.Drawing.Point(8, 35);
            tb_today.Name = "tb_today";
            tb_today.Padding = new System.Windows.Forms.Padding(5);
            tb_today.RowCount = 2;
            tb_today.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tb_today.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tb_today.Size = new System.Drawing.Size(376, 94);
            tb_today.TabIndex = 3;
            // 
            // lb_char
            // 
            lb_char.AutoSize = true;
            lb_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_char.Location = new System.Drawing.Point(12, 12);
            lb_char.Name = "lb_char";
            lb_char.Size = new System.Drawing.Size(97, 17);
            lb_char.TabIndex = 2;
            lb_char.Text = "Date Selected";
            // 
            // calendar
            // 
            calendar.BackColor = System.Drawing.SystemColors.HighlightText;
            calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            calendar.Location = new System.Drawing.Point(7, 8);
            calendar.Margin = new System.Windows.Forms.Padding(8);
            calendar.MaxSelectionCount = 1;
            calendar.Name = "calendar";
            calendar.TabIndex = 6;
            calendar.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            calendar.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            calendar.TrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(blic);
            groupBox1.Controls.Add(dtic);
            groupBox1.Controls.Add(bnat);
            groupBox1.Controls.Add(badd);
            groupBox1.Controls.Add(txt_tin);
            groupBox1.Controls.Add(txt_bname);
            groupBox1.Location = new System.Drawing.Point(11, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(192, 436);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSINESS DETAILS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label14.Location = new System.Drawing.Point(6, 367);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(132, 15);
            label14.TabIndex = 11;
            label14.Text = "BUS. LICENSE NUMBER:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label13.Location = new System.Drawing.Point(5, 312);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(109, 15);
            label13.TabIndex = 10;
            label13.Text = "DTI CERTIFICATION:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label12.Location = new System.Drawing.Point(5, 260);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(107, 15);
            label12.TabIndex = 9;
            label12.Text = "BUSINESS NATURE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label11.Location = new System.Drawing.Point(5, 172);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(113, 15);
            label11.TabIndex = 8;
            label11.Text = "BUSINESS ADDRESS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label10.Location = new System.Drawing.Point(7, 122);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(79, 15);
            label10.TabIndex = 7;
            label10.Text = "TIN NUMBER:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            label9.Location = new System.Drawing.Point(6, 31);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(98, 15);
            label9.TabIndex = 6;
            label9.Text = "BUSINESS NAME:";
            // 
            // blic
            // 
            blic.AutoSize = true;
            blic.Location = new System.Drawing.Point(7, 392);
            blic.MaximumSize = new System.Drawing.Size(175, 0);
            blic.Name = "blic";
            blic.Size = new System.Drawing.Size(38, 15);
            blic.TabIndex = 5;
            blic.Text = "label1";
            // 
            // dtic
            // 
            dtic.AutoSize = true;
            dtic.Location = new System.Drawing.Point(6, 338);
            dtic.MaximumSize = new System.Drawing.Size(175, 0);
            dtic.Name = "dtic";
            dtic.Size = new System.Drawing.Size(38, 15);
            dtic.TabIndex = 4;
            dtic.Text = "label5";
            // 
            // bnat
            // 
            bnat.AutoSize = true;
            bnat.Location = new System.Drawing.Point(10, 280);
            bnat.MaximumSize = new System.Drawing.Size(175, 0);
            bnat.Name = "bnat";
            bnat.Size = new System.Drawing.Size(38, 15);
            bnat.TabIndex = 3;
            bnat.Text = "label4";
            // 
            // badd
            // 
            badd.AutoSize = true;
            badd.Location = new System.Drawing.Point(8, 188);
            badd.MaximumSize = new System.Drawing.Size(175, 0);
            badd.Name = "badd";
            badd.Size = new System.Drawing.Size(171, 60);
            badd.TabIndex = 2;
            badd.Text = "adashdjksadjkashdklashdjklsahdjksahdjksahdsakjhdkjsahdsjakhdlsajkhdsakdhsakldhsakjdhasjdhsjak";
            // 
            // txt_tin
            // 
            txt_tin.AutoSize = true;
            txt_tin.Location = new System.Drawing.Point(10, 138);
            txt_tin.MaximumSize = new System.Drawing.Size(175, 0);
            txt_tin.Name = "txt_tin";
            txt_tin.Size = new System.Drawing.Size(40, 15);
            txt_tin.TabIndex = 1;
            txt_tin.Text = "txt_tin";
            // 
            // txt_bname
            // 
            txt_bname.AutoSize = true;
            txt_bname.Location = new System.Drawing.Point(5, 51);
            txt_bname.MaximumSize = new System.Drawing.Size(175, 0);
            txt_bname.Name = "txt_bname";
            txt_bname.Size = new System.Drawing.Size(174, 60);
            txt_bname.TabIndex = 0;
            txt_bname.Text = "ksadjlsakjdkslajdklsajdklsajdklsajdklsajdkljsalkdjsakldjsaldjaslkjdklsajdklsajdksajdklsajdklsajdklasjd";
            // 
            // pOSDBDataSet
            // 
            pOSDBDataSet.DataSetName = "POSDBDataSet";
            pOSDBDataSet.Namespace = "http://tempuri.org/POSDBDataSet.xsd";
            pOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remindersTableAdapter
            // 
            remindersTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(95, 17);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(383, 24);
            label7.TabIndex = 1;
            label7.Text = "MY BUSINESS PROFILE AND SCHEDULER";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lb_cuser);
            panel2.Controls.Add(label7);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1144, 76);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(58, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(99, 41);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(242, 15);
            label18.TabIndex = 8;
            label18.Text = "Manage business information and schedules";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(853, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 15);
            label8.TabIndex = 7;
            label8.Text = "CURRENT USER: ";
            // 
            // lb_cuser
            // 
            lb_cuser.AutoSize = true;
            lb_cuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_cuser.Location = new System.Drawing.Point(974, 12);
            lb_cuser.MaximumSize = new System.Drawing.Size(96, 0);
            lb_cuser.Name = "lb_cuser";
            lb_cuser.Size = new System.Drawing.Size(94, 45);
            lb_cuser.TabIndex = 6;
            lb_cuser.Text = "YOURNAMEHEREYOURNAMEHERE";
            lb_cuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_cuser.Click += lb_cuser_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Location = new System.Drawing.Point(0, 631);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            statusStrip1.Size = new System.Drawing.Size(1144, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // remindersBindingSource1
            // 
            remindersBindingSource1.DataMember = "Reminders";
            remindersBindingSource1.DataSource = pOSDBDataSet;
            // 
            // remindersBindingSource
            // 
            remindersBindingSource.DataMember = "Reminders";
            remindersBindingSource.DataSource = pOSDBDataSet;
            // 
            // BusinessProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(1144, 653);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(BPROFILE_TABS);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "BusinessProfile";
            Text = "MY BUSINESS PROFILE";
            Load += BusinessProfile_Load;
            BPROFILE_TABS.ResumeLayout(false);
            TAB_SCHEDULER.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TAB_EDITPROFILE.ResumeLayout(false);
            TAB_EDITPROFILE.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pOSDBDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pOSDBDataSet).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)remindersBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)remindersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl BPROFILE_TABS;
        private System.Windows.Forms.TabPage TAB_SCHEDULER;
        private System.Windows.Forms.TabPage TAB_EDITPROFILE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dtic;
        private System.Windows.Forms.Label bnat;
        private System.Windows.Forms.Label badd;
        private System.Windows.Forms.Label txt_tin;
        private System.Windows.Forms.Label txt_bname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_deletesched;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cb_repeating;
        private System.Windows.Forms.Button btn_savereminder;
        private System.Windows.Forms.RichTextBox tb_remind;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label blic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blicense;
        private System.Windows.Forms.TextBox dticert;
        private System.Windows.Forms.TextBox bnature;
        private System.Windows.Forms.TextBox baddress;
        private System.Windows.Forms.TextBox tb_tin;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.Button btn_updateprofile;
        private System.Windows.Forms.BindingSource pOSDBDataSetBindingSource;
        private POSDBDataSet pOSDBDataSet;
        private POSDBDataSetTableAdapters.RemindersTableAdapter remindersTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lb_char;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel monthlytable;
        private System.Windows.Forms.TableLayoutPanel tb_today;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource remindersBindingSource1;
        private System.Windows.Forms.BindingSource remindersBindingSource;
    }
}