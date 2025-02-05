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
    public partial class Admin : Form
    {
        public Admin(Product_Services productService,CatogeryServices categoryService)
        {
            InitializeComponent();
            this.productService = productService;
            this.categoryService = categoryService;
        }

      

        private void Admin_Load(object sender, EventArgs e)
        {

            GetAllProducts();
           
            var categoryData = categoryService.getCategory();
            comboBox_Category.DataSource = categoryData;
            comboBox_Category.ValueMember = "CategoryId";
            comboBox_Category.DisplayMember = "CategoryName";
            btn_Edit.Visible = false;
            btn_Delete.Visible = false;
            btn_Add.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this Product", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (productService.DeleteProduct(id) > 0)
                {

                    MessageBox.Show("Product Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_name.Text = "";
                    numericUpDown_price.Text = "";
                    GetAllProducts();
                    btn_Edit.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Add.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {



        }
        public void GetAllProducts()
        {
            var productData = productService.getProducts();
            dataGridView1.DataSource = productData;
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ProductVM productVM = new ProductVM();
            productVM.Name = textBox_name.Text;
            productVM.Price = numericUpDown_price.Text;
            productVM.Ctg_Id = (int)comboBox_Category.SelectedValue;


            if (productService.AddProduct(productVM) > 0)
            {
                MessageBox.Show("Product Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                numericUpDown_price.Text = "";
                GetAllProducts();
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ProductVM productVM = new ProductVM();
            productVM.ID = id;
            productVM.Name = textBox_name.Text;
            productVM.Price = numericUpDown_price.Text;
            productVM.Ctg_Id = (int)(comboBox_Category.SelectedValue);
            if (productService.UpdateProduct(productVM) > 0)
            {
                MessageBox.Show("Product Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                numericUpDown_price.Text = "";
                GetAllProducts();
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                btn_Add.Visible = true;
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id;
        private readonly Product_Services productService;
        private readonly CatogeryServices categoryService;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            textBox_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown_price.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox_Category.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            btn_Edit.Visible = true;
            btn_Delete.Visible = true;
            btn_Add.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btn_Catigory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Category(categoryService).Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
