using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijital_projemiz.veritabani
{
    public class veritabani
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
                // (Hata Yönetimi)
                System.Windows.Forms.MessageBox.Show("Bağlantı Hatası: " + ex.Message);
                return null;
            }
        }
    }
}
    }
}
