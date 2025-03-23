using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_WindowsFormsApp
{
    public partial class FormLoginEkran : Form
    {
        FormKitaplar formkitaplar;
        public FormLoginEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=KutuphaneOtomasyon; Integrated Security=True; TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre boş mu kontrol et
            if (string.IsNullOrWhiteSpace(textBoxNickname.Text) || string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                labelKontrol.Text = "KULLANICI ADI VE ŞİFRE BOŞ BIRAKILAMAZ!";
                textBoxNickname.Clear();
                textBoxSifre.Clear();
                return; // Geri dön, veritabanı işlemlerine devam etme
                
            }
            string sifre = null ; 
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select sifre from Table_Kutuphane_Yoneticileri where kullaniciAdi = @p1" , baglanti);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@p1" , textBoxNickname.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    sifre = reader[0].ToString().Trim();  // sadece şifre bilgisini çekeceğimiz için [0]
                    // MessageBox.Show("Veritabanından gelen şifre: " + sifre);
                    // MessageBox.Show("Veritabanından gelen şifre: '" + sifre + "'\nGirdiğiniz şifre: '" + textBoxSifre.Text + "'");

                }
                reader.Close();
                if (sifre == textBoxSifre.Text.Trim() && sifre != null)
                {
                    labelKontrol.Text = "ŞİFRE DOĞRU";
                    formkitaplar = new FormKitaplar();
                    this.Hide();   // Form Kapanır
                    formkitaplar.Show();

                }
                else
                {
                    labelKontrol.Text = ("KULLANICI ADI VEYA ŞİFRE HATALI!");
                    textBoxNickname.Clear();
                    textBoxSifre.Clear();
                }
     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası" +  ex.Message );
            }
            finally 
            {
                baglanti.Close();
            }
        }
    }  
}
