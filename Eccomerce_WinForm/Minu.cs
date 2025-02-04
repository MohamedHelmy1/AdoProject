using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentation
{
    public partial class Minu : Form
    {
        Product_Services product = new Product_Services();
        int userId;
        string UserName;
        public Minu(int _userId, string _UserName)
        {
            InitializeComponent();
            userId = _userId;
            UserName = _UserName;

        }

        private void Minu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }
        int productid;
        private void dgv_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            productid = (int)dgv.SelectedRows[0].Cells["ProductId"].Value;
            var productData = product.getOneProduct(productid);
            Text_product.Text = productData.Rows[0]["ProductName"].ToString();
            Text_Category.Text = productData.Rows[0]["CategoryId"].ToString();

        }

        private void All_guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Fav_Click(object sender, EventArgs e)
        {
            FavouriteServices favouriteServices = new FavouriteServices();
            var productData = favouriteServices.AddProductFavourite(userId, productid);
            if (productData > 0)
            {
                MessageBox.Show("Product Added to Fav Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text_product.Text = "";
                Text_Category.Text = "";

                var Added = favouriteServices.getFavProduct(userId);
                dgv.DataSource = Added;

            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User(userId , UserName).Show();

        }
    }
}
