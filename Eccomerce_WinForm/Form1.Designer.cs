﻿namespace Eccomerce_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgv = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(547, 166);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 43;
            label6.Text = "Burger";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(346, 166);
            label5.Name = "label5";
            label5.Size = new Size(36, 17);
            label5.TabIndex = 42;
            label5.Text = "Pizza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(439, 166);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 41;
            label4.Text = "Dessert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(232, 166);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 40;
            label3.Text = "All";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(209, 18);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 39;
            label1.Text = "Favourites";
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(276, 292);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(264, 141);
            dgv.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(209, 254);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 37;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(209, 204);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 36;
            label7.Text = "Product";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgv);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgv;
        private Label label8;
        private Label label7;
    }
}
