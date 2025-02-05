namespace Presentation
{
    partial class Admin_Category
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
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            label1 = new Label();
            textBox_name = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gray;
            splitContainer1.Panel2.Controls.Add(btn_Delete);
            splitContainer1.Panel2.Controls.Add(btn_Edit);
            splitContainer1.Panel2.Controls.Add(btn_Add);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBox_name);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_1;
            splitContainer1.Size = new Size(504, 562);
            splitContainer1.SplitterDistance = 104;
            splitContainer1.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_logout.ForeColor = Color.DarkRed;
            btn_logout.Location = new Point(10, 426);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 86);
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
            btn_Catigory.ForeColor = Color.Red;
            btn_Catigory.Location = new Point(10, 115);
            btn_Catigory.Margin = new Padding(3, 2, 3, 2);
            btn_Catigory.Name = "btn_Catigory";
            btn_Catigory.Size = new Size(82, 56);
            btn_Catigory.TabIndex = 1;
            btn_Catigory.Text = "Catigory";
            btn_Catigory.UseVisualStyleBackColor = true;
            // 
            // btn_Products
            // 
            btn_Products.FlatAppearance.BorderSize = 0;
            btn_Products.FlatStyle = FlatStyle.Flat;
            btn_Products.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Products.ForeColor = Color.DarkRed;
            btn_Products.Location = new Point(10, 48);
            btn_Products.Margin = new Padding(3, 2, 3, 2);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(82, 50);
            btn_Products.TabIndex = 0;
            btn_Products.Text = "Products";
            btn_Products.UseVisualStyleBackColor = true;
            btn_Products.Click += btn_Products_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.White;
            btn_Delete.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Delete.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.DarkRed;
            btn_Delete.Location = new Point(253, 234);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(88, 22);
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
            btn_Edit.Location = new Point(45, 234);
            btn_Edit.Margin = new Padding(3, 2, 3, 2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(88, 22);
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
            btn_Add.Location = new Point(149, 234);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(85, 22);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 114);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(148, 115);
            textBox_name.Margin = new Padding(3, 2, 3, 2);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "Category Name";
            textBox_name.Size = new Size(198, 16);
            textBox_name.TabIndex = 3;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 308);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(299, 204);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // Admin_Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 562);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Category";
            Load += Admin_Category_Load;
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
        private Button btn_logout;
        private Button btn_Catigory;
        private Button btn_Products;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private TextBox textBox_name;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox textBox_Descreption;
        private PaintEventHandler splitContainer1_Panel2_Paint;
    }
}