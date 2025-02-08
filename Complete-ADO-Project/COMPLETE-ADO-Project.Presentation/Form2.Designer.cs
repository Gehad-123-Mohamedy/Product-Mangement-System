namespace COMPLETE_ADO_Project.Presentation
{
    partial class Form2
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
            lbl_name = new Label();
            lbl_age = new Label();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txt_name = new TextBox();
            txt_Email = new TextBox();
            txt_password = new TextBox();
            btn_register = new Button();
            nUD_age = new NumericUpDown();
            lbl_address = new Label();
            txt_address = new TextBox();
            cmb_Role = new ComboBox();
            lbl_role = new Label();
            btn_returnToLogin = new Button();
            chkbx_password = new CheckBox();
            label2 = new Label();
            txt_confirmPass = new TextBox();
            panel1 = new Panel();
            lbl_signup = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Clear = new Button();
            exit = new Label();
            ((System.ComponentModel.ISupportInitialize)nUD_age).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = SystemColors.ButtonHighlight;
            lbl_name.Font = new Font("Tahoma", 10.8F);
            lbl_name.ForeColor = SystemColors.ControlText;
            lbl_name.Location = new Point(548, 118);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(67, 22);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name :";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.BackColor = SystemColors.ButtonHighlight;
            lbl_age.Font = new Font("Tahoma", 10.8F);
            lbl_age.ForeColor = SystemColors.ControlText;
            lbl_age.Location = new Point(546, 350);
            lbl_age.Margin = new Padding(4, 0, 4, 0);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(52, 22);
            lbl_age.TabIndex = 1;
            lbl_age.Text = "Age :";
            lbl_age.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = SystemColors.ButtonHighlight;
            lbl_Email.Font = new Font("Tahoma", 10.8F);
            lbl_Email.ForeColor = SystemColors.ControlText;
            lbl_Email.Location = new Point(546, 199);
            lbl_Email.Margin = new Padding(4, 0, 4, 0);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(64, 22);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Email :";
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = SystemColors.ButtonHighlight;
            lbl_Password.Font = new Font("Tahoma", 10.8F);
            lbl_Password.ForeColor = SystemColors.ControlText;
            lbl_Password.Location = new Point(546, 422);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(96, 22);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password :";
            lbl_Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Window;
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Font = new Font("Tahoma", 10.8F);
            txt_name.ForeColor = Color.FromArgb(75, 8, 138);
            txt_name.Location = new Point(524, 156);
            txt_name.Margin = new Padding(4, 3, 4, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(354, 30);
            txt_name.TabIndex = 4;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = SystemColors.Window;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Tahoma", 10.8F);
            txt_Email.ForeColor = Color.FromArgb(75, 8, 138);
            txt_Email.Location = new Point(524, 233);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Multiline = true;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(354, 30);
            txt_Email.TabIndex = 6;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.Window;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Tahoma", 10.8F);
            txt_password.ForeColor = Color.FromArgb(75, 8, 138);
            txt_password.Location = new Point(524, 456);
            txt_password.Margin = new Padding(4, 3, 4, 3);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(354, 30);
            txt_password.TabIndex = 7;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(75, 8, 138);
            btn_register.Cursor = Cursors.Hand;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(524, 694);
            btn_register.Margin = new Padding(4, 3, 4, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(154, 42);
            btn_register.TabIndex = 8;
            btn_register.Text = "SIGN UP";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // nUD_age
            // 
            nUD_age.BackColor = SystemColors.Window;
            nUD_age.BorderStyle = BorderStyle.FixedSingle;
            nUD_age.Font = new Font("Tahoma", 10.8F);
            nUD_age.ForeColor = Color.FromArgb(75, 8, 138);
            nUD_age.Location = new Point(524, 375);
            nUD_age.Margin = new Padding(8, 3, 8, 3);
            nUD_age.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            nUD_age.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nUD_age.Name = "nUD_age";
            nUD_age.Size = new Size(354, 29);
            nUD_age.TabIndex = 9;
            nUD_age.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.BackColor = SystemColors.ButtonHighlight;
            lbl_address.Font = new Font("Tahoma", 10.8F);
            lbl_address.ForeColor = SystemColors.ControlText;
            lbl_address.Location = new Point(546, 281);
            lbl_address.Margin = new Padding(4, 0, 4, 0);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(84, 22);
            lbl_address.TabIndex = 10;
            lbl_address.Text = "Address :";
            lbl_address.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_address
            // 
            txt_address.BackColor = SystemColors.Window;
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            txt_address.Font = new Font("Tahoma", 10.8F);
            txt_address.ForeColor = Color.FromArgb(75, 8, 138);
            txt_address.Location = new Point(524, 306);
            txt_address.Margin = new Padding(4, 3, 4, 3);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(354, 30);
            txt_address.TabIndex = 11;
            // 
            // cmb_Role
            // 
            cmb_Role.BackColor = SystemColors.Window;
            cmb_Role.Font = new Font("Tahoma", 10.8F);
            cmb_Role.ForeColor = Color.FromArgb(75, 8, 138);
            cmb_Role.FormattingEnabled = true;
            cmb_Role.Location = new Point(524, 608);
            cmb_Role.Margin = new Padding(4, 3, 4, 3);
            cmb_Role.Name = "cmb_Role";
            cmb_Role.Size = new Size(354, 30);
            cmb_Role.TabIndex = 14;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.BackColor = SystemColors.ButtonHighlight;
            lbl_role.Font = new Font("Tahoma", 10.8F);
            lbl_role.ForeColor = SystemColors.ControlText;
            lbl_role.Location = new Point(548, 583);
            lbl_role.Margin = new Padding(4, 0, 4, 0);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(50, 22);
            lbl_role.TabIndex = 15;
            lbl_role.Text = "Role ";
            // 
            // btn_returnToLogin
            // 
            btn_returnToLogin.BackColor = Color.FromArgb(33, 11, 97);
            btn_returnToLogin.Cursor = Cursors.Hand;
            btn_returnToLogin.FlatAppearance.BorderSize = 0;
            btn_returnToLogin.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_returnToLogin.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_returnToLogin.FlatStyle = FlatStyle.Flat;
            btn_returnToLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_returnToLogin.ForeColor = Color.White;
            btn_returnToLogin.Location = new Point(12, 672);
            btn_returnToLogin.Margin = new Padding(4, 3, 4, 3);
            btn_returnToLogin.Name = "btn_returnToLogin";
            btn_returnToLogin.Size = new Size(423, 51);
            btn_returnToLogin.TabIndex = 18;
            btn_returnToLogin.Text = "SIGN IN";
            btn_returnToLogin.UseVisualStyleBackColor = false;
            btn_returnToLogin.Click += btn_returnToLogin_Click;
            // 
            // chkbx_password
            // 
            chkbx_password.AutoSize = true;
            chkbx_password.Cursor = Cursors.Hand;
            chkbx_password.FlatStyle = FlatStyle.Flat;
            chkbx_password.Font = new Font("Tahoma", 10.2F);
            chkbx_password.ForeColor = SystemColors.ControlText;
            chkbx_password.Location = new Point(767, 573);
            chkbx_password.Margin = new Padding(4, 3, 4, 3);
            chkbx_password.Name = "chkbx_password";
            chkbx_password.Size = new Size(144, 25);
            chkbx_password.TabIndex = 19;
            chkbx_password.Text = "Show Password";
            chkbx_password.UseVisualStyleBackColor = true;
            chkbx_password.CheckedChanged += chkbx_password_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Tahoma", 10.8F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(546, 503);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 20;
            label2.Text = " Confirm Password :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_confirmPass
            // 
            txt_confirmPass.BackColor = SystemColors.Window;
            txt_confirmPass.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmPass.Font = new Font("Tahoma", 10.8F);
            txt_confirmPass.ForeColor = Color.FromArgb(75, 8, 138);
            txt_confirmPass.Location = new Point(524, 537);
            txt_confirmPass.Margin = new Padding(4, 3, 4, 3);
            txt_confirmPass.Multiline = true;
            txt_confirmPass.Name = "txt_confirmPass";
            txt_confirmPass.PasswordChar = '*';
            txt_confirmPass.Size = new Size(354, 30);
            txt_confirmPass.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.Controls.Add(lbl_signup);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_returnToLogin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 768);
            panel1.TabIndex = 22;
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_signup.ForeColor = Color.White;
            lbl_signup.Location = new Point(84, 608);
            lbl_signup.Margin = new Padding(4, 0, 4, 0);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(255, 34);
            lbl_signup.TabIndex = 11;
            lbl_signup.Text = "Login Your Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 281);
            label3.Name = "label3";
            label3.Size = new Size(395, 28);
            label3.TabIndex = 10;
            label3.Text = "Users Admins Mangment System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_ICon2;
            pictureBox1.Location = new Point(114, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(509, 44);
            label1.Name = "label1";
            label1.Size = new Size(245, 33);
            label1.TabIndex = 23;
            label1.Text = "Register Account";
            // 
            // btn_Clear
            // 
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.MouseDownBackColor = SystemColors.Menu;
            btn_Clear.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btn_Clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_Clear.Location = new Point(724, 694);
            btn_Clear.Margin = new Padding(4, 3, 4, 3);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(154, 42);
            btn_Clear.TabIndex = 24;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ControlText;
            exit.Location = new Point(911, 9);
            exit.Name = "exit";
            exit.Size = new Size(23, 28);
            exit.TabIndex = 25;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 768);
            Controls.Add(exit);
            Controls.Add(btn_Clear);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txt_confirmPass);
            Controls.Add(label2);
            Controls.Add(chkbx_password);
            Controls.Add(lbl_role);
            Controls.Add(cmb_Role);
            Controls.Add(txt_address);
            Controls.Add(lbl_address);
            Controls.Add(nUD_age);
            Controls.Add(btn_register);
            Controls.Add(txt_password);
            Controls.Add(txt_Email);
            Controls.Add(txt_name);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_age);
            Controls.Add(lbl_name);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)nUD_age).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_age;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txt_name;
        private TextBox txt_Email;
        private TextBox txt_password;
        private Button btn_register;
        private NumericUpDown nUD_age;
        private Label lbl_address;
        private TextBox txt_address;
        private ComboBox cmb_Role;
        private Label lbl_role;
        private Button btn_returnToLogin;
        private CheckBox chkbx_password;
        private Label label2;
        private TextBox txt_confirmPass;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Label lbl_signup;
        private Button btn_Clear;
        private Label exit;
    }
}