namespace COMPLETE_ADO_Project.Presentation
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbl_products = new Label();
            cmbx_Products = new ComboBox();
            btn_addToFav = new Button();
            Gdv_favoutites = new DataGridView();
            lbl_FaVProducts = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_DeleteFav = new Button();
            btn_returnToLogin = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Gdv_favoutites).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_products
            // 
            lbl_products.AutoSize = true;
            lbl_products.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_products.ForeColor = Color.White;
            lbl_products.Location = new Point(131, 327);
            lbl_products.Name = "lbl_products";
            lbl_products.Size = new Size(86, 24);
            lbl_products.TabIndex = 0;
            lbl_products.Text = "Products";
            // 
            // cmbx_Products
            // 
            cmbx_Products.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbx_Products.ForeColor = Color.FromArgb(75, 8, 138);
            cmbx_Products.FormattingEnabled = true;
            cmbx_Products.Location = new Point(26, 373);
            cmbx_Products.Name = "cmbx_Products";
            cmbx_Products.Size = new Size(323, 39);
            cmbx_Products.TabIndex = 1;
            // 
            // btn_addToFav
            // 
            btn_addToFav.BackColor = Color.FromArgb(33, 11, 97);
            btn_addToFav.Cursor = Cursors.Hand;
            btn_addToFav.FlatAppearance.BorderSize = 0;
            btn_addToFav.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_addToFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_addToFav.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addToFav.ForeColor = Color.White;
            btn_addToFav.Location = new Point(26, 434);
            btn_addToFav.Name = "btn_addToFav";
            btn_addToFav.Size = new Size(323, 65);
            btn_addToFav.TabIndex = 2;
            btn_addToFav.Text = "Add To Favourite";
            btn_addToFav.UseVisualStyleBackColor = false;
            btn_addToFav.Click += btn_addToFav_Click;
            // 
            // Gdv_favoutites
            // 
            Gdv_favoutites.AllowUserToResizeColumns = false;
            Gdv_favoutites.AllowUserToResizeRows = false;
            Gdv_favoutites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Gdv_favoutites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Gdv_favoutites.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Gdv_favoutites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Gdv_favoutites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(164, 165, 169);
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Gdv_favoutites.DefaultCellStyle = dataGridViewCellStyle2;
            Gdv_favoutites.Dock = DockStyle.Bottom;
            Gdv_favoutites.GridColor = Color.FromArgb(33, 11, 97);
            Gdv_favoutites.Location = new Point(0, 234);
            Gdv_favoutites.MinimumSize = new Size(150, 50);
            Gdv_favoutites.Name = "Gdv_favoutites";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Gdv_favoutites.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Gdv_favoutites.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Gdv_favoutites.RowsDefaultCellStyle = dataGridViewCellStyle4;
            Gdv_favoutites.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gdv_favoutites.RowTemplate.Height = 33;
            Gdv_favoutites.Size = new Size(929, 406);
            Gdv_favoutites.TabIndex = 3;
            Gdv_favoutites.RowHeaderMouseDoubleClick += Gdv_favoutites_RowHeaderMouseDoubleClick;
            // 
            // lbl_FaVProducts
            // 
            lbl_FaVProducts.AutoSize = true;
            lbl_FaVProducts.BackColor = Color.White;
            lbl_FaVProducts.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FaVProducts.ForeColor = Color.FromArgb(33, 11, 97);
            lbl_FaVProducts.Location = new Point(304, 128);
            lbl_FaVProducts.Name = "lbl_FaVProducts";
            lbl_FaVProducts.Size = new Size(222, 28);
            lbl_FaVProducts.TabIndex = 4;
            lbl_FaVProducts.Text = "Your Fav Products";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1321, 44);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(278, 22);
            label2.TabIndex = 1;
            label2.Text = "Users Admins Mangement System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1284, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(btn_DeleteFav);
            panel2.Controls.Add(btn_returnToLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_addToFav);
            panel2.Controls.Add(cmbx_Products);
            panel2.Controls.Add(lbl_products);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 666);
            panel2.TabIndex = 6;
            // 
            // btn_DeleteFav
            // 
            btn_DeleteFav.BackColor = Color.FromArgb(33, 11, 97);
            btn_DeleteFav.Cursor = Cursors.Hand;
            btn_DeleteFav.FlatAppearance.BorderSize = 0;
            btn_DeleteFav.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_DeleteFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_DeleteFav.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeleteFav.ForeColor = Color.White;
            btn_DeleteFav.Location = new Point(26, 521);
            btn_DeleteFav.Name = "btn_DeleteFav";
            btn_DeleteFav.Size = new Size(323, 65);
            btn_DeleteFav.TabIndex = 20;
            btn_DeleteFav.Text = "Delete From Favourite";
            btn_DeleteFav.UseVisualStyleBackColor = false;
            btn_DeleteFav.Click += btn_DeleteFav_Click;
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
            btn_returnToLogin.Location = new Point(48, 615);
            btn_returnToLogin.Margin = new Padding(4, 3, 4, 3);
            btn_returnToLogin.Name = "btn_returnToLogin";
            btn_returnToLogin.Size = new Size(260, 39);
            btn_returnToLogin.TabIndex = 19;
            btn_returnToLogin.Text = "Return To Login";
            btn_returnToLogin.UseVisualStyleBackColor = false;
            btn_returnToLogin.Click += btn_returnToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 224);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 10;
            label3.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_ICon2;
            pictureBox1.Location = new Point(90, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(Gdv_favoutites);
            panel3.Controls.Add(lbl_FaVProducts);
            panel3.Location = new Point(392, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(929, 640);
            panel3.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 710);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Users Page";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)Gdv_favoutites).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_products;
        private ComboBox cmbx_Products;
        private Button btn_addToFav;
        private DataGridView Gdv_favoutites;
        private Label lbl_FaVProducts;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_returnToLogin;
        private Button btn_DeleteFav;
    }
}