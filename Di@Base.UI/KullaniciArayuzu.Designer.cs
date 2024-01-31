namespace Di_Base.UI
{
    partial class KullaniciArayuzu
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
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            label1 = new Label();
            label_KarsilamaLabel = new Label();
            SuspendLayout();
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 5;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(32, 120);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(206, 292);
            bunifuCards1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Hoşgeldiniz Sayın: ";
            // 
            // label_KarsilamaLabel
            // 
            label_KarsilamaLabel.AutoSize = true;
            label_KarsilamaLabel.Location = new Point(144, 22);
            label_KarsilamaLabel.Name = "label_KarsilamaLabel";
            label_KarsilamaLabel.Size = new Size(0, 15);
            label_KarsilamaLabel.TabIndex = 2;
            // 
            // KullaniciArayuzu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 583);
            Controls.Add(label_KarsilamaLabel);
            Controls.Add(label1);
            Controls.Add(bunifuCards1);
            Name = "KullaniciArayuzu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciArayuzu";
            Load += KullaniciArayuzu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Label label1;
        private Label label_KarsilamaLabel;
    }
}