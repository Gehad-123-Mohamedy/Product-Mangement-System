using COMPLETE_ADO_PROject.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_ADO_Project.Presentation
{
    public partial class Form3 : Form
    {
        int userId;
        ProductsService productsService;
        FavouriteService favouriteService;

        public Form3(int userId)
        {

            InitializeComponent();
            productsService = new ProductsService();
            favouriteService = new FavouriteService();
            this.userId = userId;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadProducts();
            Load_InfoOf_FavProduct();
            //LoadUserFavourites();
        }

        private void LoadProducts()
        {
            DataTable allProducts = productsService.GetProdId_ProdName();
            DataTable favourites = favouriteService.Get_USers_FavProducts(userId);
            HashSet<int> FavProductsId = new HashSet<int>();
            foreach (DataRow row in favourites.Rows)
            {
                FavProductsId.Add((int)row["ProductId"]);
            }
            DataTable available = allProducts.Clone();
            foreach (DataRow row in allProducts.Rows)
            {
                int prodId = (int)row["ProductId"];
                if (!FavProductsId.Contains(prodId))
                {
                    available.ImportRow(row);
                }
            }
            cmbx_Products.DataSource = available;
            cmbx_Products.DisplayMember = "ProductName";
            cmbx_Products.ValueMember = "ProductId";

        }
        private void LoadUserFavourites()
        {
            DataTable favourites = favouriteService.Get_USers_FavProducts(userId);
            Gdv_favoutites.DataSource = favourites;
            Gdv_favoutites.Columns["ProductId"].Visible = false;
        }

        private void Load_InfoOf_FavProduct()
        {
            DataTable InfoFavProd = favouriteService.Get_InfoOfFavProd(userId);
            Gdv_favoutites.DataSource = InfoFavProd;

        }
        private void btn_addToFav_Click(object sender, EventArgs e)
        {
            int prodId = (int)cmbx_Products.SelectedValue;
            int affected = favouriteService.AddFavourite(userId, prodId);
            if (affected > 0)
            {

                MessageBox.Show("Favourited added Successfully");
                LoadProducts();
                Load_InfoOf_FavProduct();
                //LoadUserFavourites();

            }
            else
            {
                MessageBox.Show("Cann't add to FaV");
                return;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_returnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        int selected_ProdId = -1;
        private void Gdv_favoutites_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = Gdv_favoutites.SelectedRows[0];
            selected_ProdId = (int)selectedRow.Cells["ProductId"].Value;
        }

        private void btn_DeleteFav_Click(object sender, EventArgs e)
        {
            int affectedRows= favouriteService.Delete_Fav_Products(userId, selected_ProdId);
            if (affectedRows > 0)
            {
                MessageBox.Show("Product deleted from Favourites Successfully !");
                LoadProducts();
                Load_InfoOf_FavProduct();

            }
            else
            {
                MessageBox.Show("Failed to delete Product from Favourite !");
            }
        }
    }
}
