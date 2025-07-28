namespace BMC2021
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.tb_oldpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_newpass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_cuser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_desc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.lb_notice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_oldpass
            // 
            this.tb_oldpass.Location = new System.Drawing.Point(256, 172);
            this.tb_oldpass.Name = "tb_oldpass";
            this.tb_oldpass.Size = new System.Drawing.Size(275, 23);
            this.tb_oldpass.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "OLD PASSWORD: ";
            // 
            // tb_newpass
            // 
            this.tb_newpass.Location = new System.Drawing.Point(256, 199);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(275, 23);
            this.tb_newpass.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "NEW PASSWORD: ";
            // 
            // tb_newpass2
            // 
            this.tb_newpass2.Location = new System.Drawing.Point(256, 226);
            this.tb_newpass2.Name = "tb_newpass2";
            this.tb_newpass2.Size = new System.Drawing.Size(275, 23);
            this.tb_newpass2.TabIndex = 12;
            this.tb_newpass2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "RETYPE NEW PASSWORD: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "CURRENT USER:";
            // 
            // lb_cuser
            // 
            this.lb_cuser.AutoSize = true;
            this.lb_cuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cuser.Location = new System.Drawing.Point(190, 53);
            this.lb_cuser.Name = "lb_cuser";
            this.lb_cuser.Size = new System.Drawing.Size(46, 17);
            this.lb_cuser.TabIndex = 16;
            this.lb_cuser.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(50, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "DESIGNATION:";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_desc.Location = new System.Drawing.Point(190, 80);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(46, 17);
            this.lb_desc.TabIndex = 18;
            this.lb_desc.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "TIP: Set a password with AT LEAST six (6) characters, with at least one uppercase" +
    " letter.";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_changePassword.FlatAppearance.BorderSize = 0;
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_changePassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_changePassword.Image")));
            this.btn_changePassword.Location = new System.Drawing.Point(106, 270);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(349, 61);
            this.btn_changePassword.TabIndex = 13;
            this.btn_changePassword.Text = "   SAVE NEW PASSWORD";
            this.btn_changePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_changePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changePassword.UseVisualStyleBackColor = false;
            this.btn_changePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_notice
            // 
            this.lb_notice.AutoSize = true;
            this.lb_notice.Location = new System.Drawing.Point(162, 356);
            this.lb_notice.Name = "lb_notice";
            this.lb_notice.Size = new System.Drawing.Size(248, 15);
            this.lb_notice.TabIndex = 20;
            this.lb_notice.Text = "TIP: Change your password every 3-6 months.";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(560, 414);
            this.Controls.Add(this.lb_notice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_cuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.tb_newpass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_oldpass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_oldpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_newpass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_notice;
    }
}