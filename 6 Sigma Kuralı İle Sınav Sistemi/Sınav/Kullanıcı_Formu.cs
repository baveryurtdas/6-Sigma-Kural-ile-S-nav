using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sınav
{
    internal class Kullanıcı_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-19P5K9M;Initial Catalog=yazilimyapimi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand komut;
        SqlDataReader read;
        frmSınavaGiris Sinav = new frmSınavaGiris();
        public SqlDataReader kullanıcı(TextBox kullanıcıadı, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from dbo.tbl_kullanici where kullanıcıadı = '"+kullanıcıadı.Text+ "'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if(sifre.Text==read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    Sinav.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifreniz Hatalı", "HATA");
                }

            
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Uyarı2");

            }
            baglanti.Close();
            return read;

        }
        public void yeniKullanıcı(TextBox adsoyad, TextBox kullanıcıadı,TextBox sifre, TextBox şifretekrar, TextBox soru, TextBox cevap, GroupBox grup)
        {
            if(sifre.Text==şifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into dbo.tbl_kullanici values('"+adsoyad.Text+"','"+kullanıcıadı.Text+"','"+sifre.Text+"','"+soru.Text+"','"+cevap.Text+"')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı.");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şireler Uyuşmuyor","HATA");
            }
        }
        public void sifre(TextBox adsoyad, TextBox kullanıcıadı, TextBox sifre, TextBox sifretekrar, TextBox soru, TextBox cevap, GroupBox grup)
        {
            if (sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from dbo.tbl_kullanici where kullanıcıadı='" + kullanıcıadı.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    if (soru.Text == read["soru"].ToString() && cevap.Text == read["cevap"].ToString())
                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update dbo.tbl_kullanici set adsoyad='"+adsoyad.Text+"',sifre='"+sifre.Text+"' where kullanıcıadı='"+kullanıcıadı.Text+"'",baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem başarılı.");
                        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı haricinde diğer bilgileri kontrol ediniz.", "HATA1");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.", "HATA2");
                }
                baglanti.Close();
            }
            
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "HATA3");
            }
        }
    }
}
