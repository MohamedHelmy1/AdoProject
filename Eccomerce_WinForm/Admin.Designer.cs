namespace Presentation
{
    partial class Admin
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitContainer1 = new SplitContainer();
            btn_logout = new Button();
            btn_Catigory = new Button();
            btn_Products = new Button();
            numericUpDown_price = new TextBox();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_Category = new ComboBox();
            textBox_name = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_logout);
            splitContainer1.Panel1.Controls.Add(btn_Catigory);
            splitContainer1.Panel1.Controls.Add(btn_Products);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gray;
            splitContainer1.Panel2.Controls.Add(numericUpDown_price);
            splitContainer1.Panel2.Controls.Add(btn_Delete);
            splitContainer1.Panel2.Controls.Add(btn_Edit);
            splitContainer1.Panel2.Controls.Add(btn_Add);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(comboBox_Category);
            splitContainer1.Panel2.Controls.Add(textBox_name);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(507, 562);
            splitContainer1.SplitterDistance = 95;
            splitContainer1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_logout.ForeColor = Color.DarkRed;
            btn_logout.Location = new Point(10, 464);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 53);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_Catigory
            // 
            btn_Catigory.FlatAppearance.BorderSize = 0;
            btn_Catigory.FlatStyle = FlatStyle.Flat;
            btn_Catigory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Catigory.ForeColor = Color.DarkRed;
            btn_Catigory.Location = new Point(10, 142);
            btn_Catigory.Margin = new Padding(3, 2, 3, 2);
            btn_Catigory.Name = "btn_Catigory";
            btn_Catigory.Size = new Size(82, 47);
            btn_Catigory.TabIndex = 1;
            btn_Catigory.Text = "Catigory";
            btn_Catigory.UseVisualStyleBackColor = true;
            btn_Catigory.Click += btn_Catigory_Click;
            // 
            // btn_Products
            // 
            btn_Products.FlatAppearance.BorderSize = 0;
            btn_Products.FlatStyle = FlatStyle.Flat;
            btn_Products.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Products.ForeColor = Color.Red;
            btn_Products.Location = new Point(10, 73);
            btn_Products.Margin = new Padding(3, 2, 3, 2);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(82, 37);
            btn_Products.TabIndex = 0;
            btn_Products.Text = "Products";
            btn_Products.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.BorderStyle = BorderStyle.None;
            numericUpDown_price.Location = new Point(173, 112);
            numericUpDown_price.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.PlaceholderText = "Price";
            numericUpDown_price.Size = new Size(208, 16);
            numericUpDown_price.TabIndex = 12;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.White;
            btn_Delete.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Delete.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.DarkRed;
            btn_Delete.Location = new Point(265, 237);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(76, 22);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.White;
            btn_Edit.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Edit.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Edit.ForeColor = Color.DarkRed;
            btn_Edit.Location = new Point(73, 237);
            btn_Edit.Margin = new Padding(3, 2, 3, 2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(76, 22);
            btn_Edit.TabIndex = 10;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Add.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Add.ForeColor = Color.DarkRed;
            btn_Add.Location = new Point(173, 237);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(76, 22);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 173);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 8;
            label3.Text = "Category ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 16);
            label1.TabIndex = 6;
            label1.Text = "Product Name";
            // 
            // comboBox_Category
            // 
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(173, 166);
            comboBox_Category.Margin = new Padding(3, 2, 3, 2);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(208, 23);
            comboBox_Category.TabIndex = 5;
            comboBox_Category.SelectedIndexChanged += comboBox_Category_SelectedIndexChanged;
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(173, 52);
            textBox_name.Margin = new Padding(3, 2, 3, 2);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "Product Name";
            textBox_name.Size = new Size(208, 16);
            textBox_name.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 310);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(350, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 562);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button btn_logout;
        private Button btn_Catigory;
        private Button btn_Products;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_Category;
        private TextBox textBox_name;
        private TextBox numericUpDown_price;
    }
}