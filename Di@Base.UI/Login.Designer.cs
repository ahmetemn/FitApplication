namespace Di_Base.UI
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
            button_AnketeGit = new Button();
            button_Login = new Button();
            textBox_LoginEmail = new TextBox();
            textBox_LoginPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_AnketeGit
            // 
            button_AnketeGit.BackColor = Color.Green;
            button_AnketeGit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button_AnketeGit.ForeColor = SystemColors.ButtonHighlight;
            button_AnketeGit.Location = new Point(86, 374);
            button_AnketeGit.Name = "button_AnketeGit";
            button_AnketeGit.Size = new Size(82, 30);
            button_AnketeGit.TabIndex = 0;
            button_AnketeGit.Text = "Ankete Git";
            button_AnketeGit.UseVisualStyleBackColor = false;
            button_AnketeGit.Click += button_AnketeGit_Click;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.Navy;
            button_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Login.ForeColor = SystemColors.ButtonHighlight;
            button_Login.Location = new Point(186, 374);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(79, 30);
            button_Login.TabIndex = 1;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_LoginEmail
            // 
            textBox_LoginEmail.Location = new Point(86, 280);
            textBox_LoginEmail.Name = "textBox_LoginEmail";
            textBox_LoginEmail.Size = new Size(179, 23);
            textBox_LoginEmail.TabIndex = 3;
            // 
            // textBox_LoginPassword
            // 
            textBox_LoginPassword.Location = new Point(86, 333);
            textBox_LoginPassword.Name = "textBox_LoginPassword";
            textBox_LoginPassword.PasswordChar = '*';
            textBox_LoginPassword.Size = new Size(179, 23);
            textBox_LoginPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(85, 263);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(85, 315);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(84, 359);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 8;
            label3.Text = "Hesabınız Yokmu ?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Adsız_tasarım__3_;
            ClientSize = new Size(342, 437);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_LoginPassword);
            Controls.Add(textBox_LoginEmail);
            Controls.Add(button_Login);
            Controls.Add(button_AnketeGit);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_AnketeGit;
        private Button button_Login;
        private TextBox textBox_LoginEmail;
        private TextBox textBox_LoginPassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}