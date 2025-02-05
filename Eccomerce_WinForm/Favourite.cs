using BLL;
using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Favourite : Form
    {
        Product_Services product = new Product_Services();
        FavouriteServices FavouriteServices = new FavouriteServices();


        int userId;
        string UserName;
        public Favourite(int _userId, string _UserName)
        {
            userId = _userId;
            UserName = _UserName;
            InitializeComponent();
        }

        private void Favourite_Load(object sender, EventArgs e)
        {
            var data = FavouriteServices.getFavProduct(userId);
            dgv.DataSource = data;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User(userId, UserName).Show();

        }

        private void Button_Fav_Click(object sender, EventArgs e)
        {
                var data = FavouriteServices.DeleteProductFavourite(userId, productid);
                if (data > 0)
                {
                    MessageBox.Show("Product Deleted from Fav Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Text_product.Text = "";


                    var DeletedFat = FavouriteServices.getFavProduct(userId);
                    dgv.DataSource = data;

                }
                else
                {
                    MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        int productid;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            productid = (int)dgv.SelectedRows[0].Cells["ProductId"].Value;
           
            Text_product.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();

        }
    }
}
