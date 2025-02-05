namespace Presentation
{
    partial class Favourite
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            dgv = new DataGridView();
            Button_Fav = new Guna.UI2.WinForms.Guna2GradientTileButton();
            label7 = new Label();
            Text_product = new Guna.UI2.WinForms.Guna2TextBox();
            guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientTileButton1
            // 
            guna2GradientTileButton1.BackColor = Color.DarkRed;
            guna2GradientTileButton1.CustomizableEdges = customizableEdges1;
            guna2GradientTileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton1.FillColor = Color.DarkRed;
            guna2GradientTileButton1.FillColor2 = Color.Brown;
            guna2GradientTileButton1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientTileButton1.ForeColor = Color.White;
            guna2GradientTileButton1.Location = new Point(12, 255);
            guna2GradientTileButton1.Margin = new Padding(3, 2, 3, 2);
            guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            guna2GradientTileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton1.Size = new Size(91, 81);
            guna2GradientTileButton1.TabIndex = 25;
            guna2GradientTileButton1.Text = "Logout";
            guna2GradientTileButton1.Click += guna2GradientTileButton1_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(109, 132);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(333, 204);
            dgv.TabIndex = 24;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // Button_Fav
            // 
            Button_Fav.CustomizableEdges = customizableEdges3;
            Button_Fav.DisabledState.BorderColor = Color.DarkGray;
            Button_Fav.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Fav.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Fav.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Button_Fav.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Fav.FillColor = Color.Gainsboro;
            Button_Fav.FillColor2 = Color.Silver;
            Button_Fav.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Fav.ForeColor = Color.DarkRed;
            Button_Fav.Location = new Point(183, 372);
            Button_Fav.Margin = new Padding(3, 2, 3, 2);
            Button_Fav.Name = "Button_Fav";
            Button_Fav.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Fav.Size = new Size(202, 81);
            Button_Fav.TabIndex = 23;
            Button_Fav.Text = "Remove From Favourite";
            Button_Fav.Click += Button_Fav_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(32, 86);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 21;
            label7.Text = "Product";
            // 
            // Text_product
            // 
            Text_product.CustomizableEdges = customizableEdges5;
            Text_product.DefaultText = "";
            Text_product.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Text_product.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Text_product.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Text_product.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Text_product.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_product.Font = new Font("Segoe UI", 9F);
            Text_product.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Text_product.Location = new Point(109, 86);
            Text_product.Name = "Text_product";
            Text_product.PasswordChar = '\0';
            Text_product.PlaceholderText = "";
            Text_product.SelectedText = "";
            Text_product.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Text_product.Size = new Size(333, 32);
            Text_product.TabIndex = 19;
            // 
            // guna2GradientTileButton2
            // 
            guna2GradientTileButton2.BackColor = Color.DarkRed;
            guna2GradientTileButton2.CustomizableEdges = customizableEdges7;
            guna2GradientTileButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton2.FillColor = Color.Silver;
            guna2GradientTileButton2.FillColor2 = Color.DarkGray;
            guna2GradientTileButton2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientTileButton2.ForeColor = Color.DarkRed;
            guna2GradientTileButton2.Location = new Point(390, 17);
            guna2GradientTileButton2.Margin = new Padding(3, 2, 3, 2);
            guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientTileButton2.Size = new Size(73, 32);
            guna2GradientTileButton2.TabIndex = 27;
            guna2GradientTileButton2.Text = ">";
            guna2GradientTileButton2.Click += guna2GradientTileButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(310, 33);
            label1.TabIndex = 26;
            label1.Text = "My Favourites Product";
            // 
            // Favourite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 492);
            Controls.Add(guna2GradientTileButton2);
            Controls.Add(label1);
            Controls.Add(guna2GradientTileButton1);
            Controls.Add(dgv);
            Controls.Add(Button_Fav);
            Controls.Add(label7);
            Controls.Add(Text_product);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Favourite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favourites";
            Load += Favourite_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private DataGridView dgv;
        private Guna.UI2.WinForms.Guna2GradientTileButton Button_Fav;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Text_product;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Label label1;
    }
}