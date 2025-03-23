using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_WindowsFormsApp
{
    public partial class FormKitaplar : Form
    {
        private SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=KutuphaneOtomasyon; Integrated Security=True; TrustServerCertificate=True;");
        private object dateGridViewKitaplar;

        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand Sqlcmd = new SqlCommand("INSERT INTO Table_Kitaplar" +
                    "(KitapAdi , YazarAdi , YazarSoyadi , ISBN , Durum , KitapTurKodu)" +
                    " VALUES (@p1 , @p2 , @p3 , @p4 , @p5 , @p6)", baglanti);
                Sqlcmd.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                Sqlcmd.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                Sqlcmd.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                Sqlcmd.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                Sqlcmd.Parameters.AddWithValue("@p5", "True");
                Sqlcmd.Parameters.AddWithValue("@p6", textBoxKitapTurKodu.Text);

                Sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken Hata Oluştu!" , ex.Message);
            }
            finally 
            {
                baglanti.Close();
            }
            verileriGoster();

            textBoxKitapAdi.Clear();
            textBoxYazarAdi.Clear();
            textBoxYazarSoyadi.Clear();
            textBoxISBN.Clear();
            textBoxKitapTurKodu.Clear();
        }
        

        private void verileriGoster()
        {
            string q = "SELECT * FROM Table_Kitaplar";
            SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();     // Veriler DataTable da tutulacak
            da.Fill(dt);                // DataAdapter DataTable ile dolduruldu
            // DataAdapter query(q) sonucunda DataTable dolduracak
            // Querydeki verileri DataAdaptır seçer
            // DataGrid DataTable sayesinde veri çeker
            if (dt.Rows.Count > 0)
            {
                dataGridViewKitaplar.DataSource = dt;
                // DataGrid DataTable bağlandı
            }
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeliTL.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            // RowIndex hangi satırı seçtiğini döndürüyor
            labelKitapID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
            {
                dateTimePickerAlmaTarih.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
            }
        }

        private void buttonKitapGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand Sqlcmd = new SqlCommand("UPDATE Table_Kitaplar SET KitapAdi = @p1 , YazarAdi = @p2 , YazarSoyadi = @p3 , ISBN = @p4  , KitapTurKodu = @p6"
                                                   + " WHERE ID = @p7", baglanti);
                Sqlcmd.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                Sqlcmd.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                Sqlcmd.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                Sqlcmd.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                Sqlcmd.Parameters.AddWithValue("@p6", textBoxKitapTurKodu.Text);
                Sqlcmd.Parameters.AddWithValue("@p7", int.Parse(labelKitapID.Text));

                Sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Bilgileri Güncellenirken Hata Oluştu!", ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verileriGoster();
        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelKitapID != null)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand Sqlcmd = new SqlCommand("UPDATE Table_Kitaplar SET OduncAlanID = @p1 , OduncAlmaTarihi = @p2 , Durum = @p3 WHERE ID = @p4", baglanti);
                    Sqlcmd.Parameters.AddWithValue("@p1", textBoxOduncAlan.Text);
                    Sqlcmd.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePickerAlmaTarih.Value.Date;
                    Sqlcmd.Parameters.AddWithValue("@p3", "False");
                    Sqlcmd.Parameters.AddWithValue("@p4", labelKitapID.Text);
                    Sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap Ödünç Verme İşlemi Sırasında Hata Oluştu", ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
            }

            else
            {
                MessageBox.Show("lÜTFEN BİR KİTAP SEÇİNİZ!");
            }
          
        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelKitapID != null)
            {
                try 
                {
                    baglanti.Open();
                    DateTime datetime = DateTime.Now;
                    // Arada kaç gün fark olduğunu verecek kod :
                    int gunFarkı = (int)(datetime - dateTimePickerAlmaTarih.Value.Date).TotalDays;
                    if (gunFarkı > 15) 
                    {
                        labelGecikmeBedeliTL.Text = ((gunFarkı-15) * 10).ToString();
                    }
                    else
                    {
                        MessageBox.Show("GECİKME BEDELİ BULUNMAMAKTADIR");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap İade Etme Gecikme Bedeli Hesaplama Sırasında Hata Oluştu", ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
               
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR KİTAP SEÇİNİZ!");
            }
            
        }

        private void buttonKitapIade_Click(object sender, EventArgs e)
        {
            if (labelKitapID != null) 
            {
                try
                {
                    baglanti.Open();
                    SqlCommand Sqlcmd = new SqlCommand("UPDATE Table_Kitaplar SET OduncAlanID = @p1 , OduncAlmaTarihi = @p2 , Durum = @p3 WHERE ID = @p4", baglanti);
                    Sqlcmd.Parameters.AddWithValue("@p1", " " );
                    Sqlcmd.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value;
                    Sqlcmd.Parameters.AddWithValue("@p3", "True");
                    Sqlcmd.Parameters.AddWithValue("@p4", labelKitapID.Text);
                    Sqlcmd.ExecuteNonQuery();

                    // BU İŞLEMLER BAŞARILI OLDUKTAN SONRA ÖDÜNÇ ALAN BİLGİLERİNİ BOŞALTALIM
                    textBoxOduncAlan.Text = " " ;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap İade İşlemi Sırasında Hata Oluştu", ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();

            }
        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            aramaSonuclarınıGoster();
        }
        private void aramaSonuclarınıGoster()
        {
            try
            {
                string q = "SELECT * FROM Table_Kitaplar WHERE 1=1"; // Başlangıçta geçerli sorgu

                if (!string.IsNullOrWhiteSpace(textBoxKitapAdi.Text))
                    q += " AND KitapAdi LIKE @KitapAdi";

                if (!string.IsNullOrWhiteSpace(textBoxYazarAdi.Text))
                    q += " AND YazarAdi LIKE @YazarAdi";

                if (!string.IsNullOrWhiteSpace(textBoxYazarSoyadi.Text))
                    q += " AND YazarSoyadi LIKE @YazarSoyadi";

                if (!string.IsNullOrWhiteSpace(textBoxISBN.Text))
                    q += " AND ISBN LIKE @ISBN";

                if (!string.IsNullOrWhiteSpace(textBoxKitapTurKodu.Text))
                    q += " AND KitapTurKodu = @KitapTurKodu";  // INT türü olduğu için = kullanıyoruz

                if (!string.IsNullOrWhiteSpace(textBoxOduncAlan.Text))
                    q += " AND OduncAlanID = @OduncAlanID";   // INT türü olduğu için = kullanıyoruz

                SqlCommand cmd = new SqlCommand(q, baglanti);

                // Kitap Adı (LIKE kullanıyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxKitapAdi.Text))
                    cmd.Parameters.AddWithValue("@KitapAdi", "%" + textBoxKitapAdi.Text.Trim() + "%");

                // Yazar Adı (LIKE kullanıyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxYazarAdi.Text))
                    cmd.Parameters.AddWithValue("@YazarAdi", "%" + textBoxYazarAdi.Text.Trim() + "%");

                // Yazar Soyadı (LIKE kullanıyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxYazarSoyadi.Text))
                    cmd.Parameters.AddWithValue("@YazarSoyadi", "%" + textBoxYazarSoyadi.Text.Trim() + "%");

                // ISBN (Bazı veritabanlarında INTEGER olabilir, ama string olarak eşleşme yapıyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxISBN.Text))
                    cmd.Parameters.AddWithValue("@ISBN", "%" + textBoxISBN.Text.Trim() + "%");

                // Kitap Tür Kodu (INT türüne çeviriyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxKitapTurKodu.Text))
                {
                    if (int.TryParse(textBoxKitapTurKodu.Text, out int kitapTurKodu))
                        cmd.Parameters.AddWithValue("@KitapTurKodu", kitapTurKodu);
                    else
                        MessageBox.Show("Geçersiz Kitap Tür Kodu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Ödünç Alan ID (INT türüne çeviriyoruz)
                if (!string.IsNullOrWhiteSpace(textBoxOduncAlan.Text))
                {
                    if (int.TryParse(textBoxOduncAlan.Text, out int oduncAlanID))
                        cmd.Parameters.AddWithValue("@OduncAlanID", oduncAlanID);
                    else
                        MessageBox.Show("Geçersiz Ödünç Alan ID!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Aradığınız kriterlere uygun veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutulariniTemizle();
        }

        public void metinKutulariniTemizle()
        {
            labelKitapID.Text = " " ;
            textBoxKitapAdi.Text = " " ;
            textBoxYazarAdi.Text = " " ;
            textBoxYazarSoyadi.Text = " " ;
            textBoxISBN.Text = " " ;
            textBoxKitapTurKodu.Text = " " ;
            textBoxOduncAlan.Text = " " ;
        }

        private void buttonKayitlariGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            if ((labelKitapID.Text == " ") || (labelKitapID.Text == "-"))
            {
                MessageBox.Show("LÜTFEN SİLMEK İSTEDİĞİNİZ KİTABI SEÇİNİZ!");
            }
            else

            {
                try
                {
                    baglanti.Open();
                    SqlCommand Sqlcmd = new SqlCommand("DELETE FROM Table_Kitaplar WHERE ID = @p1", baglanti);
                    Sqlcmd.Parameters.AddWithValue("@p1", int.Parse(labelKitapID.Text));

                    Sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap Silerken Hata Oluştu!", ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
                metinKutulariniTemizle();
            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();     // Uygulama Kapanır
        }
    }
}

