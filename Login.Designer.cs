namespace BMC2021
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tb_userinput = new System.Windows.Forms.TextBox();
            tb_passinput = new System.Windows.Forms.TextBox();
            btn_login = new System.Windows.Forms.Button();
            lb_note = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_exit = new System.Windows.Forms.Button();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(86, 203);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(82, 241);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 17);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            // 
            // tb_userinput
            // 
            tb_userinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_userinput.Location = new System.Drawing.Point(197, 201);
            tb_userinput.Name = "tb_userinput";
            tb_userinput.Size = new System.Drawing.Size(310, 23);
            tb_userinput.TabIndex = 4;
            // 
            // tb_passinput
            // 
            tb_passinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_passinput.Location = new System.Drawing.Point(197, 239);
            tb_passinput.Name = "tb_passinput";
            tb_passinput.Size = new System.Drawing.Size(310, 23);
            tb_passinput.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_login.Location = new System.Drawing.Point(66, 285);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(229, 67);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOGIN";
            btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // lb_note
            // 
            lb_note.AutoSize = true;
            lb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_note.Location = new System.Drawing.Point(179, 161);
            lb_note.Name = "lb_note";
            lb_note.Size = new System.Drawing.Size(264, 15);
            lb_note.TabIndex = 6;
            lb_note.Text = "Please log-in with your user credentials.";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(587, 133);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = System.Drawing.Color.RosyBrown;
            btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_exit.Location = new System.Drawing.Point(301, 285);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(233, 67);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "EXIT";
            btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 379);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(587, 22);
            statusStrip1.TabIndex = 49;
            statusStrip1.Text = "statusStrip1";
            // 
            // Login
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(587, 401);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(btn_exit);
            Controls.Add(pictureBox1);
            Controls.Add(lb_note);
            Controls.Add(tb_passinput);
            Controls.Add(tb_userinput);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "LOG-IN TO BMC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_userinput;
        private System.Windows.Forms.TextBox tb_passinput;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

