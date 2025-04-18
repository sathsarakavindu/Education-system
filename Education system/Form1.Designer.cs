namespace Education_system
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            pb_login = new PictureBox();
            lbl_exit = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btn_login = new Button();
            lbl_clear = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pb_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pb_login
            // 
            pb_login.Image = (Image)resources.GetObject("pb_login.Image");
            pb_login.Location = new Point(95, 77);
            pb_login.Name = "pb_login";
            pb_login.Size = new Size(87, 78);
            pb_login.SizeMode = PictureBoxSizeMode.Zoom;
            pb_login.TabIndex = 0;
            pb_login.TabStop = false;
            // 
            // lbl_exit
            // 
            lbl_exit.AutoSize = true;
            lbl_exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_exit.Location = new Point(118, 399);
            lbl_exit.Name = "lbl_exit";
            lbl_exit.Size = new Size(40, 23);
            lbl_exit.TabIndex = 1;
            lbl_exit.Text = "Exit";
            lbl_exit.Click += lbl_exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(26, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(26, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(26, 346);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(236, 34);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_clear
            // 
            lbl_clear.AutoSize = true;
            lbl_clear.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_clear.Location = new Point(187, 326);
            lbl_clear.Name = "lbl_clear";
            lbl_clear.Size = new Size(76, 17);
            lbl_clear.TabIndex = 1;
            lbl_clear.Text = "Clear Fields";
            lbl_clear.Click += lbl_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(70, 208);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(190, 22);
            txt_username.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(70, 273);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(190, 21);
            txt_password.TabIndex = 5;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 439);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_clear);
            Controls.Add(label1);
            Controls.Add(lbl_exit);
            Controls.Add(pb_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_form_Load;
            ((System.ComponentModel.ISupportInitialize)pb_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_login;
        private Label lbl_exit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btn_login;
        private Label lbl_clear;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
    }
}
