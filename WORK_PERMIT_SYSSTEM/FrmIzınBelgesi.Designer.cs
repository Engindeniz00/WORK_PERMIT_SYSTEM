
namespace WORK_PERMIT_SYSSTEM
{
    partial class FrmIzınBelgesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucretsizIzınRadioButon = new System.Windows.Forms.RadioButton();
            this.yilIzınRadButon = new System.Windows.Forms.RadioButton();
            this.ücretliIzınRadButon = new System.Windows.Forms.RadioButton();
            this.gorevRadButon = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sicilText = new System.Windows.Forms.TextBox();
            this.bolumText = new System.Windows.Forms.TextBox();
            this.unvanText = new System.Windows.Forms.TextBox();
            this.izinNedenText = new System.Windows.Forms.TextBox();
            this.izinBaslamaTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.isBaslamaTarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.izinBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.kullaniciIzinKombox = new System.Windows.Forms.ComboBox();
            this.kaydetButon = new System.Windows.Forms.Button();
            this.iptalButon = new System.Windows.Forms.Button();
            this.kullaniciIzinListe = new System.Windows.Forms.ListView();
            this.personelId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izinTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baslamaSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitisSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topGun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isBaslamaSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izinSebep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izinDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durumButon = new System.Windows.Forms.Button();
            this.personelUnvanAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Talep Belgesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucretsizIzınRadioButon);
            this.groupBox1.Controls.Add(this.yilIzınRadButon);
            this.groupBox1.Controls.Add(this.ücretliIzınRadButon);
            this.groupBox1.Controls.Add(this.gorevRadButon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(55, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(682, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Türü";
            // 
            // ucretsizIzınRadioButon
            // 
            this.ucretsizIzınRadioButon.AutoSize = true;
            this.ucretsizIzınRadioButon.Location = new System.Drawing.Point(499, 31);
            this.ucretsizIzınRadioButon.Margin = new System.Windows.Forms.Padding(4);
            this.ucretsizIzınRadioButon.Name = "ucretsizIzınRadioButon";
            this.ucretsizIzınRadioButon.Size = new System.Drawing.Size(151, 29);
            this.ucretsizIzınRadioButon.TabIndex = 5;
            this.ucretsizIzınRadioButon.TabStop = true;
            this.ucretsizIzınRadioButon.Text = "Ücretsiz İzin";
            this.ucretsizIzınRadioButon.UseVisualStyleBackColor = true;
            // 
            // yilIzınRadButon
            // 
            this.yilIzınRadButon.AutoSize = true;
            this.yilIzınRadButon.Location = new System.Drawing.Point(174, 31);
            this.yilIzınRadButon.Margin = new System.Windows.Forms.Padding(4);
            this.yilIzınRadButon.Name = "yilIzınRadButon";
            this.yilIzınRadButon.Size = new System.Drawing.Size(118, 29);
            this.yilIzınRadButon.TabIndex = 3;
            this.yilIzınRadButon.TabStop = true;
            this.yilIzınRadButon.Text = "Yıllık İzin";
            this.yilIzınRadButon.UseVisualStyleBackColor = true;
            // 
            // ücretliIzınRadButon
            // 
            this.ücretliIzınRadButon.AutoSize = true;
            this.ücretliIzınRadButon.Location = new System.Drawing.Point(335, 31);
            this.ücretliIzınRadButon.Margin = new System.Windows.Forms.Padding(4);
            this.ücretliIzınRadButon.Name = "ücretliIzınRadButon";
            this.ücretliIzınRadButon.Size = new System.Drawing.Size(134, 29);
            this.ücretliIzınRadButon.TabIndex = 4;
            this.ücretliIzınRadButon.TabStop = true;
            this.ücretliIzınRadButon.Text = "Ücretli İzin";
            this.ücretliIzınRadButon.UseVisualStyleBackColor = true;
            // 
            // gorevRadButon
            // 
            this.gorevRadButon.AutoSize = true;
            this.gorevRadButon.Location = new System.Drawing.Point(27, 31);
            this.gorevRadButon.Margin = new System.Windows.Forms.Padding(4);
            this.gorevRadButon.Name = "gorevRadButon";
            this.gorevRadButon.Size = new System.Drawing.Size(91, 29);
            this.gorevRadButon.TabIndex = 2;
            this.gorevRadButon.TabStop = true;
            this.gorevRadButon.Text = "Görev";
            this.gorevRadButon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "İşyeri Sicil No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bölümü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ünvan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Görev İzin Nedeni";
            // 
            // sicilText
            // 
            this.sicilText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sicilText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicilText.Location = new System.Drawing.Point(275, 217);
            this.sicilText.Margin = new System.Windows.Forms.Padding(4);
            this.sicilText.Name = "sicilText";
            this.sicilText.ReadOnly = true;
            this.sicilText.Size = new System.Drawing.Size(462, 30);
            this.sicilText.TabIndex = 8;
            // 
            // bolumText
            // 
            this.bolumText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bolumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumText.Location = new System.Drawing.Point(275, 250);
            this.bolumText.Margin = new System.Windows.Forms.Padding(4);
            this.bolumText.Name = "bolumText";
            this.bolumText.ReadOnly = true;
            this.bolumText.Size = new System.Drawing.Size(462, 30);
            this.bolumText.TabIndex = 9;
            // 
            // unvanText
            // 
            this.unvanText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.unvanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanText.Location = new System.Drawing.Point(275, 284);
            this.unvanText.Margin = new System.Windows.Forms.Padding(4);
            this.unvanText.Name = "unvanText";
            this.unvanText.ReadOnly = true;
            this.unvanText.Size = new System.Drawing.Size(462, 30);
            this.unvanText.TabIndex = 10;
            // 
            // izinNedenText
            // 
            this.izinNedenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinNedenText.Location = new System.Drawing.Point(275, 319);
            this.izinNedenText.Margin = new System.Windows.Forms.Padding(4);
            this.izinNedenText.Multiline = true;
            this.izinNedenText.Name = "izinNedenText";
            this.izinNedenText.Size = new System.Drawing.Size(462, 98);
            this.izinNedenText.TabIndex = 11;
            // 
            // izinBaslamaTarih
            // 
            this.izinBaslamaTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            this.izinBaslamaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.izinBaslamaTarih.Location = new System.Drawing.Point(311, 435);
            this.izinBaslamaTarih.Margin = new System.Windows.Forms.Padding(4);
            this.izinBaslamaTarih.Name = "izinBaslamaTarih";
            this.izinBaslamaTarih.Size = new System.Drawing.Size(163, 22);
            this.izinBaslamaTarih.TabIndex = 23;
            this.izinBaslamaTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 435);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "İzne Başlama Tarih/Saat";
            // 
            // isBaslamaTarih
            // 
            this.isBaslamaTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            this.isBaslamaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.isBaslamaTarih.Location = new System.Drawing.Point(311, 489);
            this.isBaslamaTarih.Margin = new System.Windows.Forms.Padding(4);
            this.isBaslamaTarih.Name = "isBaslamaTarih";
            this.isBaslamaTarih.Size = new System.Drawing.Size(163, 22);
            this.isBaslamaTarih.TabIndex = 25;
            this.isBaslamaTarih.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(56, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "İzin Bitiş Tarihi";
            // 
            // izinBitisTarih
            // 
            this.izinBitisTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            this.izinBitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.izinBitisTarih.Location = new System.Drawing.Point(311, 463);
            this.izinBitisTarih.Margin = new System.Windows.Forms.Padding(4);
            this.izinBitisTarih.Name = "izinBitisTarih";
            this.izinBitisTarih.Size = new System.Drawing.Size(163, 22);
            this.izinBitisTarih.TabIndex = 24;
            this.izinBitisTarih.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(56, 489);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "İşe Başlama Tarihi";
            // 
            // kullaniciIzinKombox
            // 
            this.kullaniciIzinKombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciIzinKombox.FormattingEnabled = true;
            this.kullaniciIzinKombox.Location = new System.Drawing.Point(275, 190);
            this.kullaniciIzinKombox.Name = "kullaniciIzinKombox";
            this.kullaniciIzinKombox.Size = new System.Drawing.Size(462, 24);
            this.kullaniciIzinKombox.TabIndex = 22;
            this.kullaniciIzinKombox.SelectedIndexChanged += new System.EventHandler(this.kullaniciIzinKombox_SelectedIndexChanged);
            // 
            // kaydetButon
            // 
            this.kaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButon.Location = new System.Drawing.Point(487, 433);
            this.kaydetButon.Name = "kaydetButon";
            this.kaydetButon.Size = new System.Drawing.Size(122, 78);
            this.kaydetButon.TabIndex = 26;
            this.kaydetButon.Text = "Kaydet";
            this.kaydetButon.UseVisualStyleBackColor = true;
            this.kaydetButon.Click += new System.EventHandler(this.kaydetButon_Click);
            // 
            // iptalButon
            // 
            this.iptalButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalButon.Location = new System.Drawing.Point(615, 433);
            this.iptalButon.Name = "iptalButon";
            this.iptalButon.Size = new System.Drawing.Size(122, 78);
            this.iptalButon.TabIndex = 27;
            this.iptalButon.Text = "İptal";
            this.iptalButon.UseVisualStyleBackColor = true;
            this.iptalButon.Click += new System.EventHandler(this.iptalButon_Click);
            // 
            // kullaniciIzinListe
            // 
            this.kullaniciIzinListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personelId,
            this.personelAdSoyad,
            this.personelUnvanAdi,
            this.izinTürü,
            this.baslamaSaat,
            this.bitisSaat,
            this.topGun,
            this.topSaat,
            this.isBaslamaSaat,
            this.izinSebep,
            this.izinDurum});
            this.kullaniciIzinListe.HideSelection = false;
            this.kullaniciIzinListe.Location = new System.Drawing.Point(61, 535);
            this.kullaniciIzinListe.Name = "kullaniciIzinListe";
            this.kullaniciIzinListe.Size = new System.Drawing.Size(1090, 329);
            this.kullaniciIzinListe.TabIndex = 28;
            this.kullaniciIzinListe.UseCompatibleStateImageBehavior = false;
            this.kullaniciIzinListe.View = System.Windows.Forms.View.Details;
            // 
            // personelId
            // 
            this.personelId.Text = "";
            this.personelId.Width = 0;
            // 
            // personelAdSoyad
            // 
            this.personelAdSoyad.Text = "Personel Ad Soyad";
            this.personelAdSoyad.Width = 132;
            // 
            // izinTürü
            // 
            this.izinTürü.Text = "İzin Türü";
            this.izinTürü.Width = 81;
            // 
            // baslamaSaat
            // 
            this.baslamaSaat.Text = "İzin Başlama Tarih/Saat";
            this.baslamaSaat.Width = 157;
            // 
            // bitisSaat
            // 
            this.bitisSaat.Text = "İzin Bitiş Tarih/Saat";
            this.bitisSaat.Width = 125;
            // 
            // topGun
            // 
            this.topGun.Text = "Toplam Gün";
            this.topGun.Width = 90;
            // 
            // topSaat
            // 
            this.topSaat.Text = "Toplam Saat";
            this.topSaat.Width = 101;
            // 
            // isBaslamaSaat
            // 
            this.isBaslamaSaat.Text = "İşe Başlama Tarih/Saat";
            this.isBaslamaSaat.Width = 165;
            // 
            // izinSebep
            // 
            this.izinSebep.Text = "İzin Sebebi";
            this.izinSebep.Width = 109;
            // 
            // izinDurum
            // 
            this.izinDurum.Text = "İzin Durumu";
            this.izinDurum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.izinDurum.Width = 99;
            // 
            // durumButon
            // 
            this.durumButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumButon.Location = new System.Drawing.Point(743, 433);
            this.durumButon.Name = "durumButon";
            this.durumButon.Size = new System.Drawing.Size(123, 77);
            this.durumButon.TabIndex = 29;
            this.durumButon.Text = "Durum Değiştir";
            this.durumButon.UseVisualStyleBackColor = true;
            this.durumButon.Click += new System.EventHandler(this.durumButon_Click);
            // 
            // personelUnvanAdi
            // 
            this.personelUnvanAdi.Text = "Ünvan Adı";
            this.personelUnvanAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personelUnvanAdi.Width = 100;
            // 
            // FrmIzınBelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 886);
            this.Controls.Add(this.durumButon);
            this.Controls.Add(this.kullaniciIzinListe);
            this.Controls.Add(this.iptalButon);
            this.Controls.Add(this.kaydetButon);
            this.Controls.Add(this.izinBaslamaTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isBaslamaTarih);
            this.Controls.Add(this.kullaniciIzinKombox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.izinBitisTarih);
            this.Controls.Add(this.izinNedenText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.unvanText);
            this.Controls.Add(this.bolumText);
            this.Controls.Add(this.sicilText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIzınBelgesi";
            this.Text = "FrmIzınBelgesi";
            this.Load += new System.EventHandler(this.FrmIzınBelgesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ucretsizIzınRadioButon;
        private System.Windows.Forms.RadioButton yilIzınRadButon;
        private System.Windows.Forms.RadioButton ücretliIzınRadButon;
        private System.Windows.Forms.RadioButton gorevRadButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sicilText;
        private System.Windows.Forms.TextBox bolumText;
        private System.Windows.Forms.TextBox unvanText;
        private System.Windows.Forms.TextBox izinNedenText;
        private System.Windows.Forms.DateTimePicker izinBaslamaTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker isBaslamaTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker izinBitisTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox kullaniciIzinKombox;
        private System.Windows.Forms.Button kaydetButon;
        private System.Windows.Forms.Button iptalButon;
        private System.Windows.Forms.ListView kullaniciIzinListe;
        private System.Windows.Forms.ColumnHeader personelAdSoyad;
        private System.Windows.Forms.ColumnHeader izinTürü;
        private System.Windows.Forms.ColumnHeader baslamaSaat;
        private System.Windows.Forms.ColumnHeader bitisSaat;
        private System.Windows.Forms.ColumnHeader topGun;
        private System.Windows.Forms.ColumnHeader topSaat;
        private System.Windows.Forms.ColumnHeader isBaslamaSaat;
        private System.Windows.Forms.ColumnHeader izinSebep;
        private System.Windows.Forms.ColumnHeader personelId;
        private System.Windows.Forms.ColumnHeader izinDurum;
        private System.Windows.Forms.Button durumButon;
        private System.Windows.Forms.ColumnHeader personelUnvanAdi;
    }
}