using COMPLETE_ADO_PROject.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace COMPLETE_ADO_Project.Presentation
{
    public partial class Form4 : Form
    {
        CategriesServies categries;
        ProductsService products;
        UsersService users;
        private string currentMode = "";
        


        public Form4()
        {
            categries = new CategriesServies();
            products = new ProductsService();
            users = new UsersService();
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            HideProductControls();
            HideCategoryControls();
            btn_delete.Visible = false;
            btn_modify.Visible = false;
        }

        private void HideProductControls()
        {
            lbl_productName.Visible = false;
            txt_product.Visible = false;
            lbl_category.Visible = false;
            cmb_Categories.Visible = false;
            lbl_price.Visible = false;
            nUD_price.Visible = false;
            DGV_products.Visible = false;
        }

        private void HideCategoryControls()
        {
            lbl_CategoryName.Visible = false;
            txt_CategoryName.Visible = false;
            DGV_Categories.Visible = false;
        }
        private void ShowCategoryControls()
        {
            lbl_CategoryName.Visible = true;
            txt_CategoryName.Visible = true;
            DGV_Categories.Visible = true;
        }
        private void ShowProductControls()
        {
            lbl_productName.Visible = true;
            txt_product.Visible = true;
            lbl_category.Visible = true;
            cmb_Categories.Visible = true;
            lbl_price.Visible = true;
            nUD_price.Visible = true;
            DGV_products.Visible = true;
        }
        private void LoadCategories()
        {
            DataTable allCategories = categries.Get_Categories();
            cmb_Categories.DataSource = allCategories;
            cmb_Categories.DisplayMember = "CategoryName";
            cmb_Categories.ValueMember = "CategoryId";

            btn_delete.Visible = false;
            btn_modify.Visible = false;
            btn_Add.Visible = true;
        }

        private void GetAllProducts()
        {
            DataTable allProducts = products.GetAllProducts();
            DGV_products.DataSource = allProducts;
        }

        public void GetAllCategories()
        {
            DataTable categories = categries.Get_Categories();
            DGV_Categories.DataSource = categories;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (currentMode == "products")
            {
                if (string.IsNullOrEmpty(txt_product.Text) || nUD_price.Value == 0 || cmb_Categories.SelectedValue == null)
                {
                    MessageBox.Show("Sorry, you should fill all fields to add a new Product");
                    return;
                }
                int affectedRows = products.AddNewProduct(txt_product.Text, nUD_price.Value, (int)cmb_Categories.SelectedValue);
                if (affectedRows > 0)
                {
                    MessageBox.Show("A New Product Added Successfully !");
                    GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Failed to add new product !");
                }
            }
            else if (currentMode == "categories")
            {
                if (string.IsNullOrEmpty(txt_CategoryName.Text))
                {
                    MessageBox.Show("please enter a category name !");
                    return;
                }
                int affectedRows = categries.AddCategory(txt_CategoryName.Text);
                if (affectedRows > 0)
                {
                    MessageBox.Show("A New Category Added Successfully !");
                    GetAllCategories();

                }
                else
                {
                    MessageBox.Show("Failed to add new Category!");
                }

            }
        }

        int selected_ProdId = -1;
        int selected_CatgryId = -1;


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (currentMode == "products")
            {
                int affectedRows = products.DeleteProduct(selected_ProdId);
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product deleted Successfully !");
                    GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Failed to delete Product !");
                }
            }
            else if (currentMode == "categories")
            {
                int affectedrows = categries.DeleteCategories(selected_CatgryId);
                if (affectedrows > 0)
                {
                    MessageBox.Show("Category deleted Successfully !");
                    GetAllCategories();
                }
                else
                {
                    MessageBox.Show("Failed to delete Category !");
                }

            }


        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (currentMode == "products")
            {
                int affectedRows = products.ModifyProduct(selected_ProdId, txt_product.Text, nUD_price.Value, (int)cmb_Categories.SelectedValue);
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product Modified Successfully !");
                    GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Failed to Modify Product !");
                }
            }
            else if (currentMode == "categories")
            {

                int affectedRows = categries.updateCategories(selected_CatgryId, txt_CategoryName.Text);
                if (affectedRows > 0)
                {
                    MessageBox.Show("Category Modified Successfully !");
                    GetAllCategories();
                }
                else
                {
                    MessageBox.Show("Failed to Modify Category !");
                }

            }

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {

            currentMode = "products";
            btn_modify.Visible = false;
            btn_delete.Visible = false;

            //MessageBox.Show("current mode " + currentMode);
            HideCategoryControls();
            ShowProductControls();
            btn_Add.Text = "Add Product";
            LoadCategories();
            GetAllProducts();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {

            currentMode = "categories";
            btn_modify.Visible = false;
            btn_delete.Visible = false;

            //MessageBox.Show("current mode " + currentMode);
            HideProductControls();
            ShowCategoryControls();
            btn_Add.Text = "Add Category";
            GetAllCategories();
        }


        private void DGV_Categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selected = DGV_Categories.SelectedRows[0];
            txt_CategoryName.Text = selected.Cells["CategoryName"].Value.ToString();
            btn_delete.Visible = true;
            btn_modify.Visible = true;
            selected_CatgryId = (int)selected.Cells["CategoryId"].Value;
        }

        private void DGV_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_delete.Visible = true;
            btn_modify.Visible = true;
            DataGridViewRow selectedRow = DGV_products.SelectedRows[0];
            txt_product.Text = selectedRow.Cells["ProductName"].Value.ToString();
            nUD_price.Value = (decimal)selectedRow.Cells["Price"].Value;
            cmb_Categories.SelectedValue = (int)selectedRow.Cells["CategoryId"].Value;
            selected_ProdId = (int)selectedRow.Cells["ProductId"].Value;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (currentMode == "products")
            {
                txt_product.Text = "";
                cmb_Categories.SelectedIndex = 0;
                nUD_price.Value = nUD_price.Minimum;
            }
            else if (currentMode == "categories")
            {
                txt_CategoryName.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_returnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void GetAllUsers()
        {
            DataTable UsersInfo = users.GetUsersInfo();
         DGV_products.DataSource = UsersInfo;
        }
        private void btn_Users_Click(object sender, EventArgs e)
        {
             
              HideCategoryControls();
              HideProductControls();
            DGV_products.Visible = true;

            GetAllUsers();
        }
    }
}