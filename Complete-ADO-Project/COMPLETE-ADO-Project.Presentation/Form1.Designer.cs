namespace COMPLETE_ADO_Project.Presentation
{
    partial class Form1
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
            lbl_UserName = new Label();
            lbl_password = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            btn_login = new Button();
            btn_signup = new Button();
            lbl_signup = new Label();
            chkbx_password = new CheckBox();
            btn_Clear = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserName.ForeColor = SystemColors.ControlText;
            lbl_UserName.Location = new Point(553, 216);
            lbl_UserName.Margin = new Padding(4, 0, 4, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(108, 22);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "User Name :";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.ControlText;
            lbl_password.Location = new Point(553, 319);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(96, 22);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password :";
            // 
            // txt_UserName
            // 
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_UserName.Font = new Font("Tahoma", 10.8F);
            txt_UserName.ForeColor = Color.FromArgb(75, 8, 138);
            txt_UserName.Location = new Point(539, 252);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Multiline = true;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(354, 30);
            txt_UserName.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Tahoma", 10.8F);
            txt_Password.ForeColor = Color.FromArgb(75, 8, 138);
            txt_Password.Location = new Point(539, 353);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(354, 30);
            txt_Password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(75, 8, 138);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(528, 534);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(154, 42);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(33, 11, 97);
            btn_signup.Cursor = Cursors.Hand;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_signup.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(12, 583);
            btn_signup.Margin = new Padding(4, 3, 4, 3);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(423, 51);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "Sign UP";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_CreateAcc_Click;
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_signup.ForeColor = Color.White;
            lbl_signup.Location = new Point(55, 522);
            lbl_signup.Margin = new Padding(4, 0, 4, 0);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(289, 34);
            lbl_signup.TabIndex = 6;
            lbl_signup.Text = "Register Your Account";
            // 
            // chkbx_password
            // 
            chkbx_password.AutoSize = true;
            chkbx_password.Cursor = Cursors.Hand;
            chkbx_password.FlatStyle = FlatStyle.Flat;
            chkbx_password.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbx_password.ForeColor = SystemColors.ControlText;
            chkbx_password.Location = new Point(749, 402);
            chkbx_password.Margin = new Padding(4, 3, 4, 3);
            chkbx_password.Name = "chkbx_password";
            chkbx_password.Size = new Size(144, 25);
            chkbx_password.TabIndex = 8;
            chkbx_password.Text = "Show Password";
            chkbx_password.UseVisualStyleBackColor = true;
            chkbx_password.CheckedChanged += chkbx_password_CheckedChanged;
            // 
            // btn_Clear
            // 
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.MouseDownBackColor = SystemColors.Menu;
            btn_Clear.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btn_Clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_Clear.Location = new Point(739, 534);
            btn_Clear.Margin = new Padding(4, 3, 4, 3);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(154, 42);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_signup);
            panel1.Controls.Add(btn_signup);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 674);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_ICon2;
            pictureBox1.Location = new Point(119, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 299);
            label3.Name = "label3";
            label3.Size = new Size(339, 28);
            label3.TabIndex = 7;
            label3.Text = "Products Mangment System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(1104, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 22);
            label1.TabIndex = 12;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(528, 92);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 13;
            label2.Text = "Login Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ControlText;
            exit.Location = new Point(916, 9);
            exit.Name = "exit";
            exit.Size = new Size(23, 28);
            exit.TabIndex = 14;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(951, 674);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_Clear);
            Controls.Add(chkbx_password);
            Controls.Add(btn_login);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_password);
            Controls.Add(lbl_UserName);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserName;
        private Label lbl_password;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Button btn_login;
        private Button btn_signup;
        private Label lbl_signup;
        private CheckBox chkbx_password;
        private Button btn_Clear;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label exit;
    }
}
