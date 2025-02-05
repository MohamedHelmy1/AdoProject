namespace Presentation
{
    partial class Intro
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
            label1 = new Label();
            label2 = new Label();
            btn_getStarted = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 115);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 1;
            label1.Text = "welcom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(146, 237);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 2;
            label2.Text = "In Eccomerce";
            label2.Click += label2_Click;
            // 
            // btn_getStarted
            // 
            btn_getStarted.BackColor = Color.White;
            btn_getStarted.FlatAppearance.BorderSize = 30;
            btn_getStarted.FlatStyle = FlatStyle.Popup;
            btn_getStarted.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_getStarted.ForeColor = Color.DarkRed;
            btn_getStarted.Location = new Point(165, 465);
            btn_getStarted.Margin = new Padding(3, 2, 3, 2);
            btn_getStarted.Name = "btn_getStarted";
            btn_getStarted.Size = new Size(162, 28);
            btn_getStarted.TabIndex = 3;
            btn_getStarted.Text = "Get Started";
            btn_getStarted.UseVisualStyleBackColor = false;
            btn_getStarted.Click += btn_getStarted_Click;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(507, 562);
            Controls.Add(btn_getStarted);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Intro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intro";
            Load += Intro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btn_getStarted;
    }
}