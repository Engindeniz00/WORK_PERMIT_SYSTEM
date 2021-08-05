using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WORK_PERMIT_SYSSTEM
{
    public partial class FrmIzınBelgesi : Form
    {
        private static int kont_degeri = 0;
        public FrmIzınBelgesi()
        {
            InitializeComponent();
        }

        private void FrmIzınBelgesi_Load(object sender, EventArgs e)
        {
            KomboBoxVeriGetir();
            VerileriGoster();
        }

        private void KomboBoxVeriGetir()
        {
            string sorgu = @"SELECT pr.*,pr.PersonelAdi + ' ' + pr.PersonelSoyadi as PersonelKullaniciAdi,du.UnvanAdi FROM dbPersonelKullanici as pr
                             INNER JOIN dbUnvan as du ON du.Id = pr.PersonelUnvanID
                             ORDER BY PersonelKullaniciAdi ASC";
            DataTable dtTable = new DataTable();
            dtTable = Utils.TabloGetir(sorgu);
            kullaniciIzinKombox.DisplayMember = "PersonelKullaniciAdi";
            kullaniciIzinKombox.ValueMember = "Id";
            kullaniciIzinKombox.DataSource = dtTable;
            kullaniciIzinKombox.SelectedIndex = Utils.izinIndex;
        }

        private void kullaniciIzinKombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kullaniciIzinKombox.SelectedIndex > -1)
            {
                sicilText.Text = ((DataTable)(kullaniciIzinKombox.DataSource)).Rows[kullaniciIzinKombox.SelectedIndex]["PersonelSicilNo"].ToString();
                bolumText.Text = ((DataTable)(kullaniciIzinKombox.DataSource)).Rows[kullaniciIzinKombox.SelectedIndex]["PersonelBolum"].ToString();
                unvanText.Text = ((DataTable)(kullaniciIzinKombox.DataSource)).Rows[kullaniciIzinKombox.SelectedIndex]["UnvanAdi"].ToString();
                Utils.izinKullaniciId = Convert.ToInt32(kullaniciIzinKombox.SelectedValue);
            }
            else
            {
                return;
            }
        }

        private void iptalButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            string sorgu = "";
            if (kullaniciIzinKombox.SelectedIndex > 0)
            {
                bool kont = false;
                string rdb_Text = "";
                

                foreach(RadioButton rdb in groupBox1.Controls.OfType<RadioButton>())
                {
                    if (rdb.Checked)
                    {
                        kont = true;
                        rdb_Text = rdb.Text;
                    }
                }

                if (kont)
                {
                    if(izinNedenText.Text != "")
                    {
                        if (kont_degeri > 2)
                        {
                            if(izinBaslamaTarih.Value.Date<izinBitisTarih.Value.Date && izinBaslamaTarih.Value.Date< isBaslamaTarih.Value.Date && izinBitisTarih.Value.Date < isBaslamaTarih.Value.Date)
                            {
                                int toplam_saat = Utils.HesaplaSaat(izinBaslamaTarih.Value, izinBitisTarih.Value);
                                int toplam_gun = Utils.HesaplaGun(izinBaslamaTarih.Value.Date, izinBitisTarih.Value.Date);
                                //MessageBox.Show(Utils.HesaplaGun(izinBaslamaTarih.Value, izinBitisTarih.Value).ToString());
                                sorgu = string.Format(@"INSERT INTO dbIzinler (PersonelId,IzinTuru,BaslamaTarihSaat,BitisTarihSaat,GunToplam,SaatToplam,IseBaslamaTarihSaat,IzinSebep,DurumId) VALUES ({0},'{1}','{2}','{3}',{4},{5},'{6}','{7}',{8})", Utils.izinKullaniciId, rdb_Text, izinBaslamaTarih.Value.ToString("yyyy-MM-dd HH:mm"), izinBitisTarih.Value.ToString("yyyy-MM-dd HH:mm"), toplam_gun,toplam_saat, isBaslamaTarih.Value.ToString("yyyy-MM-dd HH:mm"), izinNedenText.Text,4);
                            }
                            else if(izinBaslamaTarih.Value.Date == izinBitisTarih.Value.Date && izinBaslamaTarih.Value.Date == isBaslamaTarih.Value.Date && izinBitisTarih.Value.Date == isBaslamaTarih.Value.Date)
                            {
                                int toplam_saat = Utils.HesaplaSaat(izinBaslamaTarih.Value, izinBitisTarih.Value);
                                int toplam_gun = 0;

                                sorgu = string.Format(@"INSERT INTO dbIzinler (PersonelId,IzinTuru,BaslamaTarihSaat,BitisTarihSaat,GunToplam,SaatToplam,IseBaslamaTarihSaat,IzinSebep,DurumId) VALUES ({0},'{1}','{2}','{3}',{4},{5},'{6}','{7}',{8})", Utils.izinKullaniciId, rdb_Text, izinBaslamaTarih.Value.ToString("yyyy-MM-dd HH:mm"), izinBitisTarih.Value.ToString("yyyy-MM-dd HH:mm"), toplam_gun, toplam_saat, isBaslamaTarih.Value.ToString("yyyy-MM-dd HH:mm"), izinNedenText.Text,4);
                            }
                            else
                            {
                                MessageBox.Show("Lütfen Tarihleri Doğru Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (Utils.SorguCalistir(sorgu))
                            {
                                MessageBox.Show("İzin başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearBoxes();
                            }
                            else
                            {
                                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ClearBoxes();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Lütfen Tarihleri Doğru Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen İzin Nedenini Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İzin Türünü Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
            else
            {
                MessageBox.Show("Lütfen Bir Personel Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VerileriGoster();
        }

        private void ClearBoxes()
        {
            kullaniciIzinKombox.SelectedIndex = -1;
            sicilText.Clear();
            bolumText.Clear();
            unvanText.Clear();
            izinNedenText.Clear();
            izinBaslamaTarih.Value = DateTime.Now;
            izinBitisTarih.Value = DateTime.Now;
            isBaslamaTarih.Value = DateTime.Now;
            Utils.izinKullaniciId = 0 ;
        }

        private void VerileriGoster()
        {
            string sorgu = @"SELECT pr.PersonelAdi + ' ' + pr.PersonelSoyadi as AdiSoyadi,iz.*,dr.DurumAdi,dr.DurumKodu,du.UnvanAdi FROM dbPersonelKullanici as pr 
                             INNER JOIN dbIzinler as iz ON pr.Id = iz.PersonelId
                             INNER JOIN dbDurum as dr ON dr.Id = iz.DurumId   
                             INNER JOIN dbUnvan as du ON du.Id = pr.PersonelUnvanID ";
            DataTable dtTable = new DataTable();
            dtTable = Utils.TabloGetir(sorgu);

            if(dtTable != null && dtTable.Rows.Count > 0)
            {
                kullaniciIzinListe.Items.Clear();
                for (int i = 0; i < dtTable.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dtTable.Rows[i]["PersonelId"].ToString();
                    item.SubItems.Add(dtTable.Rows[i]["AdiSoyadi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["UnvanAdi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["IzinTuru"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["BaslamaTarihSaat"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["BitisTarihSaat"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["GunToplam"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["SaatToplam"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["IseBaslamaTarihSaat"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["IzinSebep"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["DurumAdi"].ToString());
                    kullaniciIzinListe.Items.Add(item);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            kont_degeri++;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            kont_degeri++;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            kont_degeri++;
        }

        private void durumButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDurumDegistir frmDurumDegistir = new FrmDurumDegistir();
            frmDurumDegistir.ShowDialog();
            this.Show();

        }
    }
}
