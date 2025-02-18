namespace COMPLETE_ADO_Project.Presentation
{
    partial class Form4
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lbl_productName = new Label();
            txt_product = new TextBox();
            lbl_category = new Label();
            btn_modify = new Button();
            btn_delete = new Button();
            btn_Add = new Button();
            DGV_products = new DataGridView();
            lbl_price = new Label();
            nUD_price = new NumericUpDown();
            cmb_Categories = new ComboBox();
            btn_Products = new Button();
            btn_Categories = new Button();
            lbl_CategoryName = new Label();
            txt_CategoryName = new TextBox();
            DGV_Categories = new DataGridView();
            btn_Clear = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_Users = new Button();
            btn_returnToLogin = new Button();
            label3 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Categories).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_productName
            // 
            lbl_productName.AutoSize = true;
            lbl_productName.BackColor = Color.White;
            lbl_productName.FlatStyle = FlatStyle.Flat;
            lbl_productName.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_productName.ForeColor = Color.FromArgb(33, 11, 97);
            lbl_productName.Location = new Point(468, 533);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(177, 28);
            lbl_productName.TabIndex = 0;
            lbl_productName.Text = "Product Name";
            // 
            // txt_product
            // 
            txt_product.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txt_product.ForeColor = Color.FromArgb(33, 11, 97);
            txt_product.Location = new Point(468, 578);
            txt_product.Name = "txt_product";
            txt_product.Size = new Size(197, 38);
            txt_product.TabIndex = 1;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_category.ForeColor = Color.FromArgb(33, 11, 97);
            lbl_category.Location = new Point(1075, 533);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(210, 28);
            lbl_category.TabIndex = 2;
            lbl_category.Text = "Product category";
            // 
            // btn_modify
            // 
            btn_modify.BackColor = Color.FromArgb(33, 11, 97);
            btn_modify.Cursor = Cursors.Hand;
            btn_modify.FlatAppearance.BorderSize = 0;
            btn_modify.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_modify.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_modify.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modify.ForeColor = Color.White;
            btn_modify.Location = new Point(966, 676);
            btn_modify.Name = "btn_modify";
            btn_modify.Size = new Size(230, 44);
            btn_modify.TabIndex = 4;
            btn_modify.Text = "Modify";
            btn_modify.UseVisualStyleBackColor = false;
            btn_modify.Click += btn_modify_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(33, 11, 97);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_delete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(690, 676);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(230, 44);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete ";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(33, 11, 97);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_Add.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_Add.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(401, 676);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(230, 44);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // DGV_products
            // 
            DGV_products.AllowUserToResizeColumns = false;
            DGV_products.AllowUserToResizeRows = false;
            DGV_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_products.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(164, 165, 169);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_products.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_products.Dock = DockStyle.Fill;
            DGV_products.GridColor = Color.FromArgb(33, 11, 97);
            DGV_products.Location = new Point(0, 0);
            DGV_products.MinimumSize = new Size(150, 50);
            DGV_products.Name = "DGV_products";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_products.RowHeadersWidth = 21;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(75, 8, 138);
            DGV_products.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGV_products.Size = new Size(1075, 467);
            DGV_products.TabIndex = 7;
            DGV_products.RowHeaderMouseDoubleClick += DGV_products_RowHeaderMouseDoubleClick;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_price.ForeColor = Color.FromArgb(33, 11, 97);
            lbl_price.Location = new Point(737, 533);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(174, 28);
            lbl_price.TabIndex = 8;
            lbl_price.Text = " Product Price";
            // 
            // nUD_price
            // 
            nUD_price.DecimalPlaces = 2;
            nUD_price.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            nUD_price.ForeColor = Color.FromArgb(33, 11, 97);
            nUD_price.Location = new Point(753, 577);
            nUD_price.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_price.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            nUD_price.Name = "nUD_price";
            nUD_price.Size = new Size(210, 38);
            nUD_price.TabIndex = 9;
            nUD_price.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // cmb_Categories
            // 
            cmb_Categories.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            cmb_Categories.ForeColor = Color.FromArgb(33, 11, 97);
            cmb_Categories.FormattingEnabled = true;
            cmb_Categories.Location = new Point(1062, 577);
            cmb_Categories.Name = "cmb_Categories";
            cmb_Categories.Size = new Size(241, 39);
            cmb_Categories.TabIndex = 10;
            // 
            // btn_Products
            // 
            btn_Products.BackColor = Color.FromArgb(33, 11, 97);
            btn_Products.Cursor = Cursors.Hand;
            btn_Products.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Products.ForeColor = Color.White;
            btn_Products.Location = new Point(32, 386);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(323, 65);
            btn_Products.TabIndex = 11;
            btn_Products.Text = "Products";
            btn_Products.UseVisualStyleBackColor = false;
            btn_Products.Click += btn_Products_Click;
            // 
            // btn_Categories
            // 
            btn_Categories.BackColor = Color.FromArgb(33, 11, 97);
            btn_Categories.Cursor = Cursors.Hand;
            btn_Categories.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Categories.ForeColor = Color.White;
            btn_Categories.Location = new Point(32, 470);
            btn_Categories.Name = "btn_Categories";
            btn_Categories.Size = new Size(323, 65);
            btn_Categories.TabIndex = 12;
            btn_Categories.Text = "Categories";
            btn_Categories.UseVisualStyleBackColor = false;
            btn_Categories.Click += btn_Categories_Click;
            // 
            // lbl_CategoryName
            // 
            lbl_CategoryName.AutoSize = true;
            lbl_CategoryName.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CategoryName.ForeColor = Color.FromArgb(33, 11, 97);
            lbl_CategoryName.Location = new Point(753, 533);
            lbl_CategoryName.Name = "lbl_CategoryName";
            lbl_CategoryName.Size = new Size(191, 28);
            lbl_CategoryName.TabIndex = 13;
            lbl_CategoryName.Text = "Category Name";
            // 
            // txt_CategoryName
            // 
            txt_CategoryName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txt_CategoryName.ForeColor = Color.FromArgb(33, 11, 97);
            txt_CategoryName.Location = new Point(725, 578);
            txt_CategoryName.Name = "txt_CategoryName";
            txt_CategoryName.Size = new Size(289, 38);
            txt_CategoryName.TabIndex = 14;
            // 
            // DGV_Categories
            // 
            DGV_Categories.AllowUserToResizeColumns = false;
            DGV_Categories.AllowUserToResizeRows = false;
            DGV_Categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Categories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Categories.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_Categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(164, 165, 169);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGV_Categories.DefaultCellStyle = dataGridViewCellStyle6;
            DGV_Categories.Dock = DockStyle.Top;
            DGV_Categories.GridColor = Color.FromArgb(33, 11, 97);
            DGV_Categories.Location = new Point(0, 0);
            DGV_Categories.MinimumSize = new Size(150, 50);
            DGV_Categories.Name = "DGV_Categories";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(75, 8, 138);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGV_Categories.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGV_Categories.RowHeadersWidth = 21;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(75, 8, 138);
            DGV_Categories.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DGV_Categories.Size = new Size(1075, 354);
            DGV_Categories.TabIndex = 15;
            DGV_Categories.RowHeaderMouseDoubleClick += DGV_Categories_RowHeaderMouseDoubleClick;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(33, 11, 97);
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_Clear.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_Clear.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(1230, 676);
            btn_Clear.Margin = new Padding(4, 3, 4, 3);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(230, 42);
            btn_Clear.TabIndex = 16;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1467, 44);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1434, 8);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 8);
            label2.Name = "label2";
            label2.Size = new Size(239, 22);
            label2.TabIndex = 2;
            label2.Text = "Products Mangement System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_ICon2;
            pictureBox1.Location = new Point(90, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(btn_Users);
            panel2.Controls.Add(btn_returnToLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_Products);
            panel2.Controls.Add(btn_Categories);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 699);
            panel2.TabIndex = 18;
            // 
            // btn_Users
            // 
            btn_Users.BackColor = Color.FromArgb(33, 11, 97);
            btn_Users.Cursor = Cursors.Hand;
            btn_Users.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Users.ForeColor = Color.White;
            btn_Users.Location = new Point(32, 553);
            btn_Users.Name = "btn_Users";
            btn_Users.Size = new Size(323, 65);
            btn_Users.TabIndex = 21;
            btn_Users.Text = "Users";
            btn_Users.UseVisualStyleBackColor = false;
            btn_Users.Click += btn_Users_Click;
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
            btn_returnToLogin.Location = new Point(63, 638);
            btn_returnToLogin.Margin = new Padding(4, 3, 4, 3);
            btn_returnToLogin.Name = "btn_returnToLogin";
            btn_returnToLogin.Size = new Size(260, 39);
            btn_returnToLogin.TabIndex = 20;
            btn_returnToLogin.Text = "Return To Login";
            btn_returnToLogin.UseVisualStyleBackColor = false;
            btn_returnToLogin.Click += btn_returnToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 246);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 10;
            label3.Text = "Welcome, Admin";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(DGV_Categories);
            panel3.Controls.Add(DGV_products);
            panel3.Location = new Point(392, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(1075, 467);
            panel3.TabIndex = 19;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1467, 743);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Clear);
            Controls.Add(txt_CategoryName);
            Controls.Add(lbl_CategoryName);
            Controls.Add(cmb_Categories);
            Controls.Add(nUD_price);
            Controls.Add(lbl_price);
            Controls.Add(btn_Add);
            Controls.Add(btn_delete);
            Controls.Add(btn_modify);
            Controls.Add(lbl_category);
            Controls.Add(txt_product);
            Controls.Add(lbl_productName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Admin Page";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Categories).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_productName;
        private TextBox txt_product;
        private Label lbl_category;
        private Button btn_modify;
        private Button btn_delete;
        private Button btn_Add;
        private DataGridView DGV_products;
        private Label lbl_price;
        private NumericUpDown nUD_price;
        private ComboBox cmb_Categories;
        private Button btn_Products;
        private Button btn_Categories;
        private Label lbl_CategoryName;
        private TextBox txt_CategoryName;
        private DataGridView DGV_Categories;
        private Button btn_Clear;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Button btn_returnToLogin;
        private Button btn_Users;
    }
}