using System;
using System.Windows.Forms;
using dijital_projemiz.model; // kullanici sınıfına ulaşmak için gerekli
using MySqlConnector;


namespace dijital_projemiz.veritabani
{
	public class veritabani_islemleri
	{
		private string baglantiYolu = "Server=localhost;Database=dijital_sql;Uid=root;Pwd=;";

		public MySqlConnection BaglantiAl()
		{
			MySqlConnection baglanti = new MySqlConnection(baglantiYolu);
			try
			{
				if (baglanti.State == System.Data.ConnectionState.Closed)
				{
					baglanti.Open();
				}
				return baglanti;
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Bağlantı Hatası: " + ex.Message);
				return null;
			}
		}

		// GirisYap metodu sınıfın içinde
		public kullanici GirisYap(string KullaniciAdi, string Sifre)
		{
            
            using (MySqlConnection baglanti = BaglantiAl())
			{
				if (baglanti == null) return null;

				string sorgu = "SELECT * FROM kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
				MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@p1", KullaniciAdi);
				komut.Parameters.AddWithValue("@p2", Sifre);

				try
				{
					using (MySqlDataReader oku = komut.ExecuteReader())
					{
						if (oku.Read())
						{
                            kullanici k = new kullanici();
                            k.KullaniciID = Convert.ToInt32(oku["KullaniciID"]);
                            k.AdSoyad = oku["AdSoyad"].ToString();
                            var adminValue = oku["Admin"];
                            k.Admin = adminValue != DBNull.Value && (adminValue.ToString() == "1" || adminValue.ToString().ToLower() == "true");

                            return k;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Giriş sırasında teknik hata: " + ex.Message);
                }
                return null;
            }
        }
                            
		}
	} 
 



