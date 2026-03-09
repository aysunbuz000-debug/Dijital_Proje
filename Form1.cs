using System;
using dijital_projemiz.veritabani;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace dijital_projemiz
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

        private void GirişButonu_Click(object sender, EventArgs e)
        {

            // Veritabanı sınıfından nesne oluşturacak.
            veritabani_islemleri db = new veritabani_islemleri();

            // textbox'lardan kullanıcı adı ve şifre alınacak.
            string KullaniciAdi = KullanıcıAdıBox.Text;
            string Sifre = ŞifreBox.Text;

            var sonuc = db.GirisYap(KullaniciAdi, Sifre);

            if (sonuc != null)
            {
                HataMesajı.Visible = false; // varsa hatayı gizle
                MenüPanel.Visible = true;   // menü görünür olacak.

                // giriş kontrol metodu çağırılacak.
                MessageBox.Show("Hoş Geldin " +sonuc.AdSoyad+"!");

                KullanıcıAdıBox.Visible = false;
                ŞifreBox.Visible = false;
                GirişButonu.Visible = false;
            }
            else
            {
                
                HataMesajı.Visible = true;  // hata varsa kırmızı label gösterilecek.
                MenüPanel.Visible = false;  // hata varsa menü gizli kalmaya devam edecek
            }
        }
        
        
        
        private void ŞifreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KullanıcıAdıBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ÜyeOlButonu_Click(object sender, EventArgs e)
        {

        }
    }
}
