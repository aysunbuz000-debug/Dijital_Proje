namespace dijital_projemiz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenüPanel = new System.Windows.Forms.Panel();
            this.İletişimButonu = new System.Windows.Forms.Button();
            this.PaylaşımButonu = new System.Windows.Forms.Button();
            this.MirasButonu = new System.Windows.Forms.Button();
            this.HakkımızdaButonu = new System.Windows.Forms.Button();
            this.AnasayfaButonu = new System.Windows.Forms.Button();
            this.HoşgeldinizText = new System.Windows.Forms.Label();
            this.KullanıcıAdıText = new System.Windows.Forms.Label();
            this.ŞifreText = new System.Windows.Forms.Label();
            this.KullanıcıAdıBox = new System.Windows.Forms.TextBox();
            this.ŞifreBox = new System.Windows.Forms.TextBox();
            this.GirişButonu = new System.Windows.Forms.Button();
            this.ÜyeOlButonu = new System.Windows.Forms.Button();
            this.HataMesajı = new System.Windows.Forms.Label();
            this.GirişResim = new System.Windows.Forms.PictureBox();
            this.AnahtarResim = new System.Windows.Forms.PictureBox();
            this.MenüPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirişResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnahtarResim)).BeginInit();
            this.SuspendLayout();
            // 
            // MenüPanel
            // 
            this.MenüPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.MenüPanel.Controls.Add(this.İletişimButonu);
            this.MenüPanel.Controls.Add(this.PaylaşımButonu);
            this.MenüPanel.Controls.Add(this.MirasButonu);
            this.MenüPanel.Controls.Add(this.HakkımızdaButonu);
            this.MenüPanel.Controls.Add(this.AnasayfaButonu);
            this.MenüPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenüPanel.Location = new System.Drawing.Point(0, 0);
            this.MenüPanel.Name = "MenüPanel";
            this.MenüPanel.Size = new System.Drawing.Size(141, 450);
            this.MenüPanel.TabIndex = 0;
            this.MenüPanel.Visible = false;
            // 
            // İletişimButonu
            // 
            this.İletişimButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İletişimButonu.Location = new System.Drawing.Point(12, 376);
            this.İletişimButonu.Name = "İletişimButonu";
            this.İletişimButonu.Size = new System.Drawing.Size(112, 40);
            this.İletişimButonu.TabIndex = 4;
            this.İletişimButonu.Text = "İletişim";
            this.İletişimButonu.UseVisualStyleBackColor = true;
            // 
            // PaylaşımButonu
            // 
            this.PaylaşımButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaylaşımButonu.Location = new System.Drawing.Point(12, 291);
            this.PaylaşımButonu.Name = "PaylaşımButonu";
            this.PaylaşımButonu.Size = new System.Drawing.Size(112, 40);
            this.PaylaşımButonu.TabIndex = 3;
            this.PaylaşımButonu.Text = "Paylaşım";
            this.PaylaşımButonu.UseVisualStyleBackColor = true;
            // 
            // MirasButonu
            // 
            this.MirasButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MirasButonu.Location = new System.Drawing.Point(12, 203);
            this.MirasButonu.Name = "MirasButonu";
            this.MirasButonu.Size = new System.Drawing.Size(112, 40);
            this.MirasButonu.TabIndex = 2;
            this.MirasButonu.Text = "Miras";
            this.MirasButonu.UseVisualStyleBackColor = true;
            // 
            // HakkımızdaButonu
            // 
            this.HakkımızdaButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HakkımızdaButonu.Location = new System.Drawing.Point(12, 122);
            this.HakkımızdaButonu.Name = "HakkımızdaButonu";
            this.HakkımızdaButonu.Size = new System.Drawing.Size(112, 40);
            this.HakkımızdaButonu.TabIndex = 1;
            this.HakkımızdaButonu.Text = "Hakkımızda";
            this.HakkımızdaButonu.UseVisualStyleBackColor = true;
            // 
            // AnasayfaButonu
            // 
            this.AnasayfaButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnasayfaButonu.Location = new System.Drawing.Point(12, 38);
            this.AnasayfaButonu.Name = "AnasayfaButonu";
            this.AnasayfaButonu.Size = new System.Drawing.Size(112, 40);
            this.AnasayfaButonu.TabIndex = 0;
            this.AnasayfaButonu.Text = "Anasayfa";
            this.AnasayfaButonu.UseVisualStyleBackColor = true;
            // 
            // HoşgeldinizText
            // 
            this.HoşgeldinizText.AutoSize = true;
            this.HoşgeldinizText.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HoşgeldinizText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HoşgeldinizText.Location = new System.Drawing.Point(140, 38);
            this.HoşgeldinizText.Name = "HoşgeldinizText";
            this.HoşgeldinizText.Size = new System.Drawing.Size(527, 38);
            this.HoşgeldinizText.TabIndex = 1;
            this.HoşgeldinizText.Text = "Dijital Miras Sistemine Hoşgeldiniz";
            // 
            // KullanıcıAdıText
            // 
            this.KullanıcıAdıText.AutoSize = true;
            this.KullanıcıAdıText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıAdıText.Location = new System.Drawing.Point(199, 136);
            this.KullanıcıAdıText.Name = "KullanıcıAdıText";
            this.KullanıcıAdıText.Size = new System.Drawing.Size(141, 26);
            this.KullanıcıAdıText.TabIndex = 2;
            this.KullanıcıAdıText.Text = "Kullanıcı Adı:";
            // 
            // ŞifreText
            // 
            this.ŞifreText.AutoSize = true;
            this.ŞifreText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ŞifreText.Location = new System.Drawing.Point(199, 194);
            this.ŞifreText.Name = "ŞifreText";
            this.ŞifreText.Size = new System.Drawing.Size(63, 26);
            this.ŞifreText.TabIndex = 3;
            this.ŞifreText.Text = "Şifre:";
            // 
            // KullanıcıAdıBox
            // 
            this.KullanıcıAdıBox.Location = new System.Drawing.Point(377, 136);
            this.KullanıcıAdıBox.Name = "KullanıcıAdıBox";
            this.KullanıcıAdıBox.Size = new System.Drawing.Size(225, 22);
            this.KullanıcıAdıBox.TabIndex = 4;
            this.KullanıcıAdıBox.TextChanged += new System.EventHandler(this.KullanıcıAdıBox_TextChanged);
            // 
            // ŞifreBox
            // 
            this.ŞifreBox.Location = new System.Drawing.Point(377, 194);
            this.ŞifreBox.Name = "ŞifreBox";
            this.ŞifreBox.PasswordChar = '*';
            this.ŞifreBox.Size = new System.Drawing.Size(225, 22);
            this.ŞifreBox.TabIndex = 5;
            this.ŞifreBox.TextChanged += new System.EventHandler(this.ŞifreBox_TextChanged);
            // 
            // GirişButonu
            // 
            this.GirişButonu.BackColor = System.Drawing.SystemColors.Window;
            this.GirişButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirişButonu.Location = new System.Drawing.Point(413, 291);
            this.GirişButonu.Name = "GirişButonu";
            this.GirişButonu.Size = new System.Drawing.Size(126, 34);
            this.GirişButonu.TabIndex = 6;
            this.GirişButonu.Text = "Giriş";
            this.GirişButonu.UseVisualStyleBackColor = false;
            this.GirişButonu.Click += new System.EventHandler(this.GirişButonu_Click);
            // 
            // ÜyeOlButonu
            // 
            this.ÜyeOlButonu.BackColor = System.Drawing.SystemColors.Window;
            this.ÜyeOlButonu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜyeOlButonu.Location = new System.Drawing.Point(551, 291);
            this.ÜyeOlButonu.Name = "ÜyeOlButonu";
            this.ÜyeOlButonu.Size = new System.Drawing.Size(123, 34);
            this.ÜyeOlButonu.TabIndex = 7;
            this.ÜyeOlButonu.Text = "Üye Ol";
            this.ÜyeOlButonu.UseVisualStyleBackColor = false;
            this.ÜyeOlButonu.Click += new System.EventHandler(this.ÜyeOlButonu_Click);
            // 
            // HataMesajı
            // 
            this.HataMesajı.AutoSize = true;
            this.HataMesajı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HataMesajı.ForeColor = System.Drawing.Color.Red;
            this.HataMesajı.Location = new System.Drawing.Point(449, 248);
            this.HataMesajı.Name = "HataMesajı";
            this.HataMesajı.Size = new System.Drawing.Size(225, 18);
            this.HataMesajı.TabIndex = 8;
            this.HataMesajı.Text = "Hatalı kullanıcı adı veya şifre!";
            this.HataMesajı.Visible = false;
            // 
            // GirişResim
            // 
            this.GirişResim.Image = global::dijital_projemiz.Properties.Resources.giriş;
            this.GirişResim.Location = new System.Drawing.Point(147, 129);
            this.GirişResim.Name = "GirişResim";
            this.GirişResim.Size = new System.Drawing.Size(46, 33);
            this.GirişResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GirişResim.TabIndex = 9;
            this.GirişResim.TabStop = false;
            // 
            // AnahtarResim
            // 
            this.AnahtarResim.Image = global::dijital_projemiz.Properties.Resources.anahtar;
            this.AnahtarResim.Location = new System.Drawing.Point(147, 186);
            this.AnahtarResim.Name = "AnahtarResim";
            this.AnahtarResim.Size = new System.Drawing.Size(46, 36);
            this.AnahtarResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnahtarResim.TabIndex = 10;
            this.AnahtarResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.MenüPanel);
            this.Controls.Add(this.AnahtarResim);
            this.Controls.Add(this.GirişResim);
            this.Controls.Add(this.HataMesajı);
            this.Controls.Add(this.ÜyeOlButonu);
            this.Controls.Add(this.GirişButonu);
            this.Controls.Add(this.ŞifreBox);
            this.Controls.Add(this.KullanıcıAdıBox);
            this.Controls.Add(this.ŞifreText);
            this.Controls.Add(this.KullanıcıAdıText);
            this.Controls.Add(this.HoşgeldinizText);
            this.Name = "Form1";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenüPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GirişResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnahtarResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel MenüPanel;
		private System.Windows.Forms.Button AnasayfaButonu;
		private System.Windows.Forms.Button İletişimButonu;
		private System.Windows.Forms.Button PaylaşımButonu;
		private System.Windows.Forms.Button MirasButonu;
		private System.Windows.Forms.Button HakkımızdaButonu;
		private System.Windows.Forms.Label HoşgeldinizText;
		private System.Windows.Forms.Label KullanıcıAdıText;
		private System.Windows.Forms.Label ŞifreText;
		private System.Windows.Forms.TextBox KullanıcıAdıBox;
		private System.Windows.Forms.TextBox ŞifreBox;
		private System.Windows.Forms.Button GirişButonu;
		private System.Windows.Forms.Button ÜyeOlButonu;
		private System.Windows.Forms.Label HataMesajı;
		private System.Windows.Forms.PictureBox GirişResim;
		private System.Windows.Forms.PictureBox AnahtarResim;
	}
}

