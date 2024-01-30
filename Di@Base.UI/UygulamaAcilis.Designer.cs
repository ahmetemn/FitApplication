namespace Di_Base.UI
{
    partial class UygulamaAcilis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UygulamaAcilis));
            label1 = new Label();
            dateTimePicker_DogumTarihi = new DateTimePicker();
            radioButton_Erkek = new RadioButton();
            radioButton_Kadın = new RadioButton();
            label2 = new Label();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            button_DevamEt = new Button();
            textBox_Meslek = new TextBox();
            textBox_Sehir = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDown_Boy = new NumericUpDown();
            label4 = new Label();
            numericUpDown_Kilo = new NumericUpDown();
            label3 = new Label();
            bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Boy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Kilo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Doğum Tarihi";
            // 
            // dateTimePicker_DogumTarihi
            // 
            dateTimePicker_DogumTarihi.Location = new Point(13, 89);
            dateTimePicker_DogumTarihi.Name = "dateTimePicker_DogumTarihi";
            dateTimePicker_DogumTarihi.Size = new Size(273, 23);
            dateTimePicker_DogumTarihi.TabIndex = 2;
            // 
            // radioButton_Erkek
            // 
            radioButton_Erkek.AutoSize = true;
            radioButton_Erkek.BackColor = Color.Transparent;
            radioButton_Erkek.Location = new Point(13, 38);
            radioButton_Erkek.Name = "radioButton_Erkek";
            radioButton_Erkek.Size = new Size(53, 19);
            radioButton_Erkek.TabIndex = 3;
            radioButton_Erkek.TabStop = true;
            radioButton_Erkek.Text = "Erkek";
            radioButton_Erkek.UseVisualStyleBackColor = false;
            // 
            // radioButton_Kadın
            // 
            radioButton_Kadın.AutoSize = true;
            radioButton_Kadın.BackColor = Color.Transparent;
            radioButton_Kadın.Location = new Point(82, 38);
            radioButton_Kadın.Name = "radioButton_Kadın";
            radioButton_Kadın.Size = new Size(55, 19);
            radioButton_Kadın.TabIndex = 4;
            radioButton_Kadın.TabStop = true;
            radioButton_Kadın.Text = "Kadın";
            radioButton_Kadın.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(13, 20);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Cinsiyet";
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 50;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Tomato;
            bunifuCards1.Controls.Add(button_DevamEt);
            bunifuCards1.Controls.Add(textBox_Meslek);
            bunifuCards1.Controls.Add(textBox_Sehir);
            bunifuCards1.Controls.Add(label10);
            bunifuCards1.Controls.Add(label11);
            bunifuCards1.Controls.Add(label9);
            bunifuCards1.Controls.Add(label8);
            bunifuCards1.Controls.Add(label7);
            bunifuCards1.Controls.Add(label6);
            bunifuCards1.Controls.Add(label5);
            bunifuCards1.Controls.Add(numericUpDown_Boy);
            bunifuCards1.Controls.Add(label4);
            bunifuCards1.Controls.Add(numericUpDown_Kilo);
            bunifuCards1.Controls.Add(label3);
            bunifuCards1.Controls.Add(dateTimePicker_DogumTarihi);
            bunifuCards1.Controls.Add(radioButton_Kadın);
            bunifuCards1.Controls.Add(label1);
            bunifuCards1.Controls.Add(label2);
            bunifuCards1.Controls.Add(radioButton_Erkek);
            bunifuCards1.IndicatorColor = Color.Tomato;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(99, 360);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(311, 397);
            bunifuCards1.TabIndex = 6;
            // 
            // button_DevamEt
            // 
            button_DevamEt.BackColor = Color.FromArgb(0, 0, 192);
            button_DevamEt.ForeColor = Color.White;
            button_DevamEt.Location = new Point(11, 355);
            button_DevamEt.Name = "button_DevamEt";
            button_DevamEt.Size = new Size(276, 27);
            button_DevamEt.TabIndex = 19;
            button_DevamEt.Text = "Devam Et";
            button_DevamEt.UseVisualStyleBackColor = false;
            button_DevamEt.Click += button_DevamEt_Click;
            // 
            // textBox_Meslek
            // 
            textBox_Meslek.Location = new Point(13, 316);
            textBox_Meslek.Name = "textBox_Meslek";
            textBox_Meslek.Size = new Size(273, 23);
            textBox_Meslek.TabIndex = 18;
            // 
            // textBox_Sehir
            // 
            textBox_Sehir.Location = new Point(13, 259);
            textBox_Sehir.Name = "textBox_Sehir";
            textBox_Sehir.Size = new Size(273, 23);
            textBox_Sehir.TabIndex = 17;
            // 
            // label10
            // 
            label10.BackColor = Color.IndianRed;
            label10.Location = new Point(11, 288);
            label10.Name = "label10";
            label10.Size = new Size(275, 1);
            label10.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(11, 298);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 15;
            label11.Text = "Meslek";
            // 
            // label9
            // 
            label9.BackColor = Color.IndianRed;
            label9.Location = new Point(12, 231);
            label9.Name = "label9";
            label9.Size = new Size(275, 1);
            label9.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(12, 241);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Şehir";
            // 
            // label7
            // 
            label7.BackColor = Color.IndianRed;
            label7.Location = new Point(11, 174);
            label7.Name = "label7";
            label7.Size = new Size(275, 1);
            label7.TabIndex = 12;
            // 
            // label6
            // 
            label6.BackColor = Color.IndianRed;
            label6.Location = new Point(11, 122);
            label6.Name = "label6";
            label6.Size = new Size(275, 1);
            label6.TabIndex = 11;
            // 
            // label5
            // 
            label5.BackColor = Color.IndianRed;
            label5.Location = new Point(12, 64);
            label5.Name = "label5";
            label5.Size = new Size(275, 1);
            label5.TabIndex = 10;
            // 
            // numericUpDown_Boy
            // 
            numericUpDown_Boy.Location = new Point(13, 201);
            numericUpDown_Boy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDown_Boy.Name = "numericUpDown_Boy";
            numericUpDown_Boy.Size = new Size(273, 23);
            numericUpDown_Boy.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(13, 183);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "Boy";
            // 
            // numericUpDown_Kilo
            // 
            numericUpDown_Kilo.Location = new Point(13, 144);
            numericUpDown_Kilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDown_Kilo.Name = "numericUpDown_Kilo";
            numericUpDown_Kilo.Size = new Size(274, 23);
            numericUpDown_Kilo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(13, 126);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Kilo";
            // 
            // UygulamaAcilis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(529, 829);
            Controls.Add(bunifuCards1);
            Name = "UygulamaAcilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketKullanıcıDetay";
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Boy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Kilo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePicker_DogumTarihi;
        private RadioButton radioButton_Erkek;
        private RadioButton radioButton_Kadın;
        private Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown_Boy;
        private Label label4;
        private NumericUpDown numericUpDown_Kilo;
        private Label label3;
        private Button button_DevamEt;
        private TextBox textBox_Meslek;
        private TextBox textBox_Sehir;
        private Label label10;
        private Label label11;
    }
}