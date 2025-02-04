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
    public partial class Admin_Category : Form
    {
        public Admin_Category(CatogeryServices categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin(new Product_Services(), categoryService).Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new Login().Show();
        }

        private void Admin_Category_Load(object sender, EventArgs e)
        {
            GetAllCategory();
        }
        public void GetAllCategory()
        {

            var categoryData = categoryService.getCategory();
            dataGridView1.DataSource = categoryData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int id;
        private readonly CatogeryServices categoryService;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
            textBox_name.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Descreption.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CategoryVM CategoryVM = new CategoryVM();
            CategoryVM.Name = textBox_name.Text;
            CategoryVM.Description = textBox_Descreption.Text;


            if (categoryService.AddCategory(CategoryVM) > 0)
            {
                MessageBox.Show("category Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                textBox_Descreption.Text = "";
                GetAllCategory();
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            CategoryVM CategoryVM = new CategoryVM();
            CategoryVM.ID = id;
            CategoryVM.Name = textBox_name.Text;
            CategoryVM.Description = textBox_Descreption.Text;

            if (categoryService.UpdateCategory(CategoryVM) > 0)
            {
                MessageBox.Show("Category Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                textBox_Descreption.Text = "";
                GetAllCategory();

            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               

                if (categoryService.DeleteCategory(id) > 0)
                {

                    MessageBox.Show("Category Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_name.Text = "";
                    textBox_Descreption.Text = "";
                    GetAllCategory();
                }
                else
                {
                    MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
