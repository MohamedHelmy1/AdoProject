namespace Presentation
{
    partial class User
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
            label1 = new Label();
            btn_Minu = new Button();
            btn_Fav = new Button();
            guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(158, 33);
            label1.TabIndex = 20;
            label1.Text = "Welcome,  ";
            // 
            // btn_Minu
            // 
            btn_Minu.BackColor = Color.DarkRed;
            btn_Minu.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Minu.ForeColor = Color.White;
            btn_Minu.Location = new Point(125, 184);
            btn_Minu.Margin = new Padding(3, 2, 3, 2);
            btn_Minu.Name = "btn_Minu";
            btn_Minu.Size = new Size(232, 32);
            btn_Minu.TabIndex = 21;
            btn_Minu.Text = "Menu";
            btn_Minu.UseVisualStyleBackColor = false;
            btn_Minu.Click += btn_Minu_Click;
            // 
            // btn_Fav
            // 
            btn_Fav.BackColor = Color.DarkRed;
            btn_Fav.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Fav.ForeColor = Color.White;
            btn_Fav.Location = new Point(125, 336);
            btn_Fav.Margin = new Padding(3, 2, 3, 2);
            btn_Fav.Name = "btn_Fav";
            btn_Fav.Size = new Size(232, 32);
            btn_Fav.TabIndex = 22;
            btn_Fav.Text = "Favourite";
            btn_Fav.UseVisualStyleBackColor = false;
            btn_Fav.Click += btn_Fav_Click;
            // 
            // guna2GradientTileButton2
            // 
            guna2GradientTileButton2.BackColor = Color.DarkRed;
            guna2GradientTileButton2.CustomizableEdges = customizableEdges1;
            guna2GradientTileButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton2.FillColor = Color.Silver;
            guna2GradientTileButton2.FillColor2 = Color.DarkGray;
            guna2GradientTileButton2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientTileButton2.ForeColor = Color.DarkRed;
            guna2GradientTileButton2.Location = new Point(398, 31);
            guna2GradientTileButton2.Margin = new Padding(3, 2, 3, 2);
            guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton2.Size = new Size(69, 32);
            guna2GradientTileButton2.TabIndex = 24;
            guna2GradientTileButton2.Text = ">";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(507, 562);
            Controls.Add(guna2GradientTileButton2);
            Controls.Add(btn_Fav);
            Controls.Add(btn_Minu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Minu;
        private Button btn_Fav;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
    }
}