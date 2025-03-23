namespace deneme_WindowsFormsApp
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            this.groupBoxKitapÖdünc = new System.Windows.Forms.GroupBox();
            this.buttonKitapOduncVer = new System.Windows.Forms.Button();
            this.dateTimePickerAlmaTarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelOduncAlan = new System.Windows.Forms.Label();
            this.groupBoxKitapIade = new System.Windows.Forms.GroupBox();
            this.labelGecikmeBedeliBilgilendirme = new System.Windows.Forms.Label();
            this.buttonKitapIade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGecikmeBedeliTL = new System.Windows.Forms.Label();
            this.buttonGecikmeBedeliHesapla = new System.Windows.Forms.Button();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.label_KitapID = new System.Windows.Forms.Label();
            this.labelKitapID = new System.Windows.Forms.Label();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.labelKitapTurKodu = new System.Windows.Forms.Label();
            this.labelYazarAdi = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.groupBoxKitapKayıt = new System.Windows.Forms.GroupBox();
            this.groupBoxAraama = new System.Windows.Forms.GroupBox();
            this.buttonKayitlariGoster = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.labelYazarSoyadi = new System.Windows.Forms.Label();
            this.gorupBoxKitapListesi = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.buttonKitapGüncelle = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapSil = new System.Windows.Forms.Button();
            this.groupBoxButonlar = new System.Windows.Forms.GroupBox();
            this.groupBoxKitapÖdünc.SuspendLayout();
            this.groupBoxKitapIade.SuspendLayout();
            this.groupBoxKitapKayıt.SuspendLayout();
            this.groupBoxAraama.SuspendLayout();
            this.gorupBoxKitapListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.groupBoxButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKitapÖdünc
            // 
            this.groupBoxKitapÖdünc.Controls.Add(this.buttonKitapOduncVer);
            this.groupBoxKitapÖdünc.Controls.Add(this.dateTimePickerAlmaTarih);
            this.groupBoxKitapÖdünc.Controls.Add(this.textBoxOduncAlan);
            this.groupBoxKitapÖdünc.Controls.Add(this.labelTarih);
            this.groupBoxKitapÖdünc.Controls.Add(this.labelOduncAlan);
            this.groupBoxKitapÖdünc.Location = new System.Drawing.Point(561, 12);
            this.groupBoxKitapÖdünc.Name = "groupBoxKitapÖdünc";
            this.groupBoxKitapÖdünc.Size = new System.Drawing.Size(364, 328);
            this.groupBoxKitapÖdünc.TabIndex = 1;
            this.groupBoxKitapÖdünc.TabStop = false;
            this.groupBoxKitapÖdünc.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            this.buttonKitapOduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKitapOduncVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapOduncVer.Location = new System.Drawing.Point(101, 130);
            this.buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            this.buttonKitapOduncVer.Size = new System.Drawing.Size(120, 90);
            this.buttonKitapOduncVer.TabIndex = 13;
            this.buttonKitapOduncVer.Text = "Kitap Ödünç Ver";
            this.buttonKitapOduncVer.UseVisualStyleBackColor = false;
            this.buttonKitapOduncVer.Click += new System.EventHandler(this.buttonKitapOduncVer_Click);
            // 
            // dateTimePickerAlmaTarih
            // 
            this.dateTimePickerAlmaTarih.Location = new System.Drawing.Point(167, 80);
            this.dateTimePickerAlmaTarih.Name = "dateTimePickerAlmaTarih";
            this.dateTimePickerAlmaTarih.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerAlmaTarih.TabIndex = 9;
            this.dateTimePickerAlmaTarih.Value = new System.DateTime(2025, 3, 21, 17, 28, 30, 0);
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Location = new System.Drawing.Point(167, 42);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(149, 22);
            this.textBoxOduncAlan.TabIndex = 8;
            // 
            // labelTarih
            // 
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(22, 72);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(113, 40);
            this.labelTarih.TabIndex = 4;
            this.labelTarih.Text = "Tarih : ";
            this.labelTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOduncAlan
            // 
            this.labelOduncAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOduncAlan.Location = new System.Drawing.Point(22, 32);
            this.labelOduncAlan.Name = "labelOduncAlan";
            this.labelOduncAlan.Size = new System.Drawing.Size(113, 40);
            this.labelOduncAlan.TabIndex = 3;
            this.labelOduncAlan.Text = "Ödünç Alan :";
            this.labelOduncAlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxKitapIade
            // 
            this.groupBoxKitapIade.Controls.Add(this.labelGecikmeBedeliBilgilendirme);
            this.groupBoxKitapIade.Controls.Add(this.buttonKitapIade);
            this.groupBoxKitapIade.Controls.Add(this.label1);
            this.groupBoxKitapIade.Controls.Add(this.labelGecikmeBedeliTL);
            this.groupBoxKitapIade.Controls.Add(this.buttonGecikmeBedeliHesapla);
            this.groupBoxKitapIade.Controls.Add(this.labelGecikmeBedeli);
            this.groupBoxKitapIade.Location = new System.Drawing.Point(945, 12);
            this.groupBoxKitapIade.Name = "groupBoxKitapIade";
            this.groupBoxKitapIade.Size = new System.Drawing.Size(364, 328);
            this.groupBoxKitapIade.TabIndex = 2;
            this.groupBoxKitapIade.TabStop = false;
            this.groupBoxKitapIade.Text = "Kitap İade";
            // 
            // labelGecikmeBedeliBilgilendirme
            // 
            this.labelGecikmeBedeliBilgilendirme.AutoSize = true;
            this.labelGecikmeBedeliBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGecikmeBedeliBilgilendirme.Location = new System.Drawing.Point(6, 309);
            this.labelGecikmeBedeliBilgilendirme.Name = "labelGecikmeBedeliBilgilendirme";
            this.labelGecikmeBedeliBilgilendirme.Size = new System.Drawing.Size(334, 16);
            this.labelGecikmeBedeliBilgilendirme.TabIndex = 18;
            this.labelGecikmeBedeliBilgilendirme.Text = "Gecikme Bedeli : Geciken gün başına 10 TL\'dir.";
            // 
            // buttonKitapIade
            // 
            this.buttonKitapIade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKitapIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapIade.Location = new System.Drawing.Point(55, 130);
            this.buttonKitapIade.Name = "buttonKitapIade";
            this.buttonKitapIade.Size = new System.Drawing.Size(120, 90);
            this.buttonKitapIade.TabIndex = 17;
            this.buttonKitapIade.Text = "Kitap İade";
            this.buttonKitapIade.UseVisualStyleBackColor = false;
            this.buttonKitapIade.Click += new System.EventHandler(this.buttonKitapIade_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGecikmeBedeliTL
            // 
            this.labelGecikmeBedeliTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGecikmeBedeliTL.Location = new System.Drawing.Point(168, 24);
            this.labelGecikmeBedeliTL.Name = "labelGecikmeBedeliTL";
            this.labelGecikmeBedeliTL.Size = new System.Drawing.Size(100, 40);
            this.labelGecikmeBedeliTL.TabIndex = 15;
            this.labelGecikmeBedeliTL.Text = "0 ";
            this.labelGecikmeBedeliTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGecikmeBedeliHesapla
            // 
            this.buttonGecikmeBedeliHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGecikmeBedeliHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGecikmeBedeliHesapla.Location = new System.Drawing.Point(197, 130);
            this.buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            this.buttonGecikmeBedeliHesapla.Size = new System.Drawing.Size(120, 90);
            this.buttonGecikmeBedeliHesapla.TabIndex = 14;
            this.buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            this.buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = false;
            this.buttonGecikmeBedeliHesapla.Click += new System.EventHandler(this.buttonGecikmeBedeliHesapla_Click);
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(6, 32);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(169, 40);
            this.labelGecikmeBedeli.TabIndex = 4;
            this.labelGecikmeBedeli.Text = "Gecikme Bedeli :";
            this.labelGecikmeBedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_KitapID
            // 
            this.label_KitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_KitapID.Location = new System.Drawing.Point(6, 50);
            this.label_KitapID.Name = "label_KitapID";
            this.label_KitapID.Size = new System.Drawing.Size(170, 40);
            this.label_KitapID.TabIndex = 0;
            this.label_KitapID.Text = "Kitap ID : ";
            this.label_KitapID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKitapID
            // 
            this.labelKitapID.BackColor = System.Drawing.SystemColors.Control;
            this.labelKitapID.Location = new System.Drawing.Point(194, 50);
            this.labelKitapID.Name = "labelKitapID";
            this.labelKitapID.Size = new System.Drawing.Size(100, 40);
            this.labelKitapID.TabIndex = 1;
            this.labelKitapID.Text = "...";
            this.labelKitapID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAdi.Location = new System.Drawing.Point(6, 90);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(170, 40);
            this.labelKitapAdi.TabIndex = 2;
            this.labelKitapAdi.Text = "Kitap Adı : ";
            this.labelKitapAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKitapTurKodu
            // 
            this.labelKitapTurKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapTurKodu.Location = new System.Drawing.Point(-2, 276);
            this.labelKitapTurKodu.Name = "labelKitapTurKodu";
            this.labelKitapTurKodu.Size = new System.Drawing.Size(170, 40);
            this.labelKitapTurKodu.TabIndex = 3;
            this.labelKitapTurKodu.Text = "Kitap Tür Kodu : ";
            this.labelKitapTurKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYazarAdi
            // 
            this.labelYazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazarAdi.Location = new System.Drawing.Point(6, 130);
            this.labelYazarAdi.Name = "labelYazarAdi";
            this.labelYazarAdi.Size = new System.Drawing.Size(170, 40);
            this.labelYazarAdi.TabIndex = 4;
            this.labelYazarAdi.Text = "Yazar Adı : ";
            this.labelYazarAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelISBN
            // 
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelISBN.Location = new System.Drawing.Point(6, 232);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(170, 40);
            this.labelISBN.TabIndex = 5;
            this.labelISBN.Text = "ISBN : ";
            this.labelISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxKitapKayıt
            // 
            this.groupBoxKitapKayıt.Controls.Add(this.groupBoxAraama);
            this.groupBoxKitapKayıt.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBoxKitapKayıt.Controls.Add(this.textBoxISBN);
            this.groupBoxKitapKayıt.Controls.Add(this.textBoxYazarSoyadi);
            this.groupBoxKitapKayıt.Controls.Add(this.textBoxYazarAdi);
            this.groupBoxKitapKayıt.Controls.Add(this.textBoxKitapAdi);
            this.groupBoxKitapKayıt.Controls.Add(this.labelYazarSoyadi);
            this.groupBoxKitapKayıt.Controls.Add(this.labelISBN);
            this.groupBoxKitapKayıt.Controls.Add(this.labelYazarAdi);
            this.groupBoxKitapKayıt.Controls.Add(this.labelKitapTurKodu);
            this.groupBoxKitapKayıt.Controls.Add(this.labelKitapAdi);
            this.groupBoxKitapKayıt.Controls.Add(this.labelKitapID);
            this.groupBoxKitapKayıt.Controls.Add(this.label_KitapID);
            this.groupBoxKitapKayıt.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKitapKayıt.Name = "groupBoxKitapKayıt";
            this.groupBoxKitapKayıt.Size = new System.Drawing.Size(532, 328);
            this.groupBoxKitapKayıt.TabIndex = 0;
            this.groupBoxKitapKayıt.TabStop = false;
            this.groupBoxKitapKayıt.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // groupBoxAraama
            // 
            this.groupBoxAraama.Controls.Add(this.buttonKayitlariGoster);
            this.groupBoxAraama.Controls.Add(this.buttonAra);
            this.groupBoxAraama.Controls.Add(this.buttonTemizle);
            this.groupBoxAraama.Location = new System.Drawing.Point(372, 168);
            this.groupBoxAraama.Name = "groupBoxAraama";
            this.groupBoxAraama.Size = new System.Drawing.Size(160, 170);
            this.groupBoxAraama.TabIndex = 0;
            this.groupBoxAraama.TabStop = false;
            this.groupBoxAraama.Text = "Arana";
            // 
            // buttonKayitlariGoster
            // 
            this.buttonKayitlariGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKayitlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitlariGoster.Location = new System.Drawing.Point(17, 18);
            this.buttonKayitlariGoster.Name = "buttonKayitlariGoster";
            this.buttonKayitlariGoster.Size = new System.Drawing.Size(125, 45);
            this.buttonKayitlariGoster.TabIndex = 16;
            this.buttonKayitlariGoster.Text = "Tüm Kayıtları Göster";
            this.buttonKayitlariGoster.UseVisualStyleBackColor = false;
            this.buttonKayitlariGoster.Click += new System.EventHandler(this.buttonKayitlariGoster_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAra.Location = new System.Drawing.Point(17, 112);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(125, 45);
            this.buttonAra.TabIndex = 14;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(17, 63);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(125, 45);
            this.buttonTemizle.TabIndex = 15;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(186, 286);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(185, 22);
            this.textBoxKitapTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(186, 242);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(185, 22);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyadi
            // 
            this.textBoxYazarSoyadi.Location = new System.Drawing.Point(186, 190);
            this.textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            this.textBoxYazarSoyadi.Size = new System.Drawing.Size(185, 22);
            this.textBoxYazarSoyadi.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Location = new System.Drawing.Point(186, 140);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(185, 22);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(186, 100);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(185, 22);
            this.textBoxKitapAdi.TabIndex = 7;
            // 
            // labelYazarSoyadi
            // 
            this.labelYazarSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazarSoyadi.Location = new System.Drawing.Point(6, 180);
            this.labelYazarSoyadi.Name = "labelYazarSoyadi";
            this.labelYazarSoyadi.Size = new System.Drawing.Size(170, 40);
            this.labelYazarSoyadi.TabIndex = 6;
            this.labelYazarSoyadi.Text = "Yazar Soyadı : ";
            this.labelYazarSoyadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gorupBoxKitapListesi
            // 
            this.gorupBoxKitapListesi.Controls.Add(this.dataGridViewKitaplar);
            this.gorupBoxKitapListesi.Location = new System.Drawing.Point(12, 346);
            this.gorupBoxKitapListesi.Name = "gorupBoxKitapListesi";
            this.gorupBoxKitapListesi.Size = new System.Drawing.Size(1300, 180);
            this.gorupBoxKitapListesi.TabIndex = 3;
            this.gorupBoxKitapListesi.TabStop = false;
            this.gorupBoxKitapListesi.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.RowTemplate.Height = 24;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(1294, 159);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // buttonKitapGüncelle
            // 
            this.buttonKitapGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKitapGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapGüncelle.Location = new System.Drawing.Point(17, 72);
            this.buttonKitapGüncelle.Name = "buttonKitapGüncelle";
            this.buttonKitapGüncelle.Size = new System.Drawing.Size(125, 45);
            this.buttonKitapGüncelle.TabIndex = 13;
            this.buttonKitapGüncelle.Text = "Kitap Bilgileri Güncelle";
            this.buttonKitapGüncelle.UseVisualStyleBackColor = false;
            this.buttonKitapGüncelle.Click += new System.EventHandler(this.buttonKitapGüncelle_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapEkle.Location = new System.Drawing.Point(17, 21);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(125, 45);
            this.buttonKitapEkle.TabIndex = 12;
            this.buttonKitapEkle.Text = "Yeni Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = false;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonKitapSil
            // 
            this.buttonKitapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapSil.Location = new System.Drawing.Point(17, 119);
            this.buttonKitapSil.Name = "buttonKitapSil";
            this.buttonKitapSil.Size = new System.Drawing.Size(125, 45);
            this.buttonKitapSil.TabIndex = 14;
            this.buttonKitapSil.Text = "Kitap Sil";
            this.buttonKitapSil.UseVisualStyleBackColor = false;
            this.buttonKitapSil.Click += new System.EventHandler(this.buttonKayitSil_Click);
            // 
            // groupBoxButonlar
            // 
            this.groupBoxButonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxButonlar.Controls.Add(this.buttonKitapEkle);
            this.groupBoxButonlar.Controls.Add(this.buttonKitapSil);
            this.groupBoxButonlar.Controls.Add(this.buttonKitapGüncelle);
            this.groupBoxButonlar.Location = new System.Drawing.Point(384, 4);
            this.groupBoxButonlar.Name = "groupBoxButonlar";
            this.groupBoxButonlar.Size = new System.Drawing.Size(160, 170);
            this.groupBoxButonlar.TabIndex = 17;
            this.groupBoxButonlar.TabStop = false;
            this.groupBoxButonlar.Text = "Kayıt Düzenleme";
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1324, 538);
            this.Controls.Add(this.groupBoxButonlar);
            this.Controls.Add(this.gorupBoxKitapListesi);
            this.Controls.Add(this.groupBoxKitapIade);
            this.Controls.Add(this.groupBoxKitapÖdünc);
            this.Controls.Add(this.groupBoxKitapKayıt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitaplar";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBoxKitapÖdünc.ResumeLayout(false);
            this.groupBoxKitapÖdünc.PerformLayout();
            this.groupBoxKitapIade.ResumeLayout(false);
            this.groupBoxKitapIade.PerformLayout();
            this.groupBoxKitapKayıt.ResumeLayout(false);
            this.groupBoxKitapKayıt.PerformLayout();
            this.groupBoxAraama.ResumeLayout(false);
            this.gorupBoxKitapListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.groupBoxButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxKitapÖdünc;
        private System.Windows.Forms.GroupBox groupBoxKitapIade;
        private System.Windows.Forms.Label label_KitapID;
        private System.Windows.Forms.Label labelKitapID;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label labelKitapTurKodu;
        private System.Windows.Forms.Label labelYazarAdi;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.GroupBox groupBoxKitapKayıt;
        private System.Windows.Forms.Label labelYazarSoyadi;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxYazarSoyadi;
        private System.Windows.Forms.TextBox textBoxYazarAdi;
        private System.Windows.Forms.TextBox textBoxKitapTurKodu;
        private System.Windows.Forms.GroupBox gorupBoxKitapListesi;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.TextBox textBoxOduncAlan;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelOduncAlan;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlmaTarih;
        private System.Windows.Forms.Button buttonKitapIade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGecikmeBedeliTL;
        private System.Windows.Forms.Button buttonGecikmeBedeliHesapla;
        private System.Windows.Forms.Label labelGecikmeBedeli;
        private System.Windows.Forms.Button buttonKitapOduncVer;
        private System.Windows.Forms.Label labelGecikmeBedeliBilgilendirme;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonKitapGüncelle;
        private System.Windows.Forms.Button buttonKayitlariGoster;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Button buttonKitapSil;
        private System.Windows.Forms.GroupBox groupBoxButonlar;
        private System.Windows.Forms.GroupBox groupBoxAraama;
    }
}