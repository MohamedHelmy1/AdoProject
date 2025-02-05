namespace Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            link_SignUp = new LinkLabel();
            linkLabel2 = new LinkLabel();
            btn_login = new Button();
            text_Passowrd = new TextBox();
            text_email = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(guna2ImageButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(link_SignUp);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(text_Passowrd);
            panel1.Controls.Add(text_email);
            panel1.Location = new Point(110, 104);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 364);
            panel1.TabIndex = 0;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(70, 2);
            guna2ImageButton1.Margin = new Padding(3, 2, 3, 2);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(158, 65);
            guna2ImageButton1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 253);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 9;
            label5.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 246);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = " ________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 246);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = " ________________";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 307);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 6;
            label2.Text = "Don't have an account?";
            // 
            // link_SignUp
            // 
            link_SignUp.AutoSize = true;
            link_SignUp.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_SignUp.LinkBehavior = LinkBehavior.HoverUnderline;
            link_SignUp.LinkColor = Color.DarkRed;
            link_SignUp.Location = new Point(180, 305);
            link_SignUp.Name = "link_SignUp";
            link_SignUp.Size = new Size(55, 16);
            link_SignUp.TabIndex = 5;
            link_SignUp.TabStop = true;
            link_SignUp.Text = "Sign up";
            link_SignUp.LinkClicked += link_SignUp_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.DarkRed;
            linkLabel2.Location = new Point(79, 218);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(122, 16);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forget Password?";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkRed;
            btn_login.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(66, 172);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(147, 32);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // text_Passowrd
            // 
            text_Passowrd.Location = new Point(44, 128);
            text_Passowrd.Margin = new Padding(3, 2, 3, 2);
            text_Passowrd.Name = "text_Passowrd";
            text_Passowrd.PlaceholderText = "Enter password";
            text_Passowrd.Size = new Size(194, 23);
            text_Passowrd.TabIndex = 1;
            text_Passowrd.UseSystemPasswordChar = true;
            // 
            // text_email
            // 
            text_email.Cursor = Cursors.IBeam;
            text_email.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_email.Location = new Point(44, 79);
            text_email.Margin = new Padding(3, 2, 3, 2);
            text_email.Name = "text_email";
            text_email.PlaceholderText = "Enter email";
            text_email.Size = new Size(194, 26);
            text_email.TabIndex = 0;
            text_email.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(180, 16);
            label1.Name = "label1";
            label1.Size = new Size(153, 56);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(507, 562);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_login;
        private TextBox text_Passowrd;
        private TextBox text_email;
        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel link_SignUp;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}