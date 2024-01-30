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
            button2 = new Button();
            SuspendLayout();
            // 
            // button_AnketeGit
            // 
            button_AnketeGit.BackColor = Color.Green;
            button_AnketeGit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button_AnketeGit.ForeColor = SystemColors.ButtonHighlight;
            button_AnketeGit.Location = new Point(79, 304);
            button_AnketeGit.Name = "button_AnketeGit";
            button_AnketeGit.Size = new Size(194, 30);
            button_AnketeGit.TabIndex = 0;
            button_AnketeGit.Text = "Ankete Git";
            button_AnketeGit.UseVisualStyleBackColor = false;
            button_AnketeGit.Click += button_AnketeGit_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(79, 350);
            button2.Name = "button2";
            button2.Size = new Size(194, 30);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Adsız_tasarım__3_;
            ClientSize = new Size(342, 450);
            Controls.Add(button2);
            Controls.Add(button_AnketeGit);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button button_AnketeGit;
        private Button button2;
    }
}