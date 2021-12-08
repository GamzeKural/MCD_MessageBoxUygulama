using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri()
            { id=Guid.NewGuid(),
                isim=txtisim.Text,
                soyisim=txtsoyisim.Text,
                emailAdres=txtemail.Text,
                telefonNumarasi=txttelefonNo.Text 
            });

            if (islemSonuc>0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı, yeni müşteri kaydı eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res==DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt adedi : " + SanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }
                else if (res==DialogResult.No)
                {

                }
                EkranTemizle();
                EkranListele();
            }
            else
            {
                MessageBox.Show("Hata: Kayıt ekleme işlemi yapılamadı.");
            }
        }

        private void EkranListele()
        {
            lstMusteriler.DataSource = SanalDatabase.musteriler;
        }

        private void EkranTemizle()
        {
            txtisim.Text = string.Empty;
            txtsoyisim.Text = string.Empty;
            txtemail.Text = string.Empty;
            txttelefonNo.Text = string.Empty;
        }

        private int yeniMusteriEkle(Musteri data)
        {
            SanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
