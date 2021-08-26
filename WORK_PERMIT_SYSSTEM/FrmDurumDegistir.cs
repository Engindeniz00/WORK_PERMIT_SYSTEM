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
    public partial class FrmDurumDegistir : Form
    {
        public FrmDurumDegistir()
        {
            InitializeComponent();
        }

        private void FrmDurumDegistir_Load(object sender, EventArgs e)
        {
            KomboboxVeriYukle();
            GenelVerileriGoster();
        }

        private void KomboboxVeriYukle()
        {
            string sorgu = "SELECT * FROM dbDurum AS durum  WHERE durum.Id=2 OR durum.Id = 3 OR durum.Id = 1002 OR durum.Id = 1003";
            DataTable dtTable = new DataTable();
            dtTable = SQLiteUtils.TabloGetir(sorgu);
            onayKombox.DisplayMember = "DurumKodu";
            onayKombox.ValueMember = "Id";
            onayKombox.SelectedIndex = -1;
            onayKombox.DataSource = dtTable;
        }

        private void iptaButon_Click(object sender, EventArgs e)
        {
            FrmIzınBelgesi frmIzınBelgesi = new FrmIzınBelgesi();
            frmIzınBelgesi.FrmIzınBelgesi_Load(sender,e);
            this.Hide();

        }

        private void GenelVerileriGoster()
        {
            iptNedenText.Enabled = false;
        }
        private void onaylaButon_Click(object sender, EventArgs e)
        {
            string sorgu = "";
            bool kont = false;
            if (Utils.personelUnvanId == 1)
            {
                if (Convert.ToInt32(onayKombox.SelectedValue) == 1003)
                {
                    if (iptNedenText.Text.Length > 5)
                    {
                        if (Utils.izinBelgeSelectedDurumID == 4)
                        {
                            sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 1003 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                            kont = true;                           
                        }
                        else
                        {
                            MessageBox.Show("İzin durumu : 'Onay Bekliyor' olması gerek", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptNedenText.Focus();
                        iptNedenText.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Yetki yetersiz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 2)
            {
                if (Convert.ToInt32(onayKombox.SelectedValue) == 1003)
                {
                    if (iptNedenText.Text.Length > 5)
                    {
                        if (Utils.izinBelgeSelectedDurumID == 4 || Utils.izinBelgeSelectedDurumID == 2)
                        {
                            sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1003 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                            kont = true;
                        }
                        else
                        {
                            MessageBox.Show("İzin durumu : 'Onay Bekliyor' ya da 'Şef Onayında' olması gerek", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptNedenText.Focus();
                        iptNedenText.SelectAll();
                    }
                }
                else if (Convert.ToInt32(onayKombox.SelectedValue) == 2)
                {
                    if (Utils.izinBelgeSelectedDurumID == 4)
                    {
                        sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 2 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                        kont = true;
                    }
                    else
                    {
                        MessageBox.Show("İzin durumu : 'Onay Bekliyor' olması gerek", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Yetki yetersiz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 3)
            {
                if (Convert.ToInt32(onayKombox.SelectedValue) == 1003)
                {
                    if (iptNedenText.Text.Length > 5)
                    {
                        sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 1003 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                        kont = true;
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptNedenText.Focus();
                        iptNedenText.SelectAll();
                    }
                }
                else if(Convert.ToInt32(onayKombox.SelectedValue) == 3)
                {
                    sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 3 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                    kont = true;
                }

                else
                {
                    MessageBox.Show("Lütfen kendi yetkinizdeki onay işlemini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 4)
            {
                if (Convert.ToInt32(onayKombox.SelectedValue) == 1003)
                {
                    if (iptNedenText.Text.Length > 5)
                    {
                        sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 1003 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                        kont = true; 
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptNedenText.Focus();
                        iptNedenText.SelectAll();
                    }
                }
                else if (Convert.ToInt32(onayKombox.SelectedValue) == 1002)
                {
                    sorgu = string.Format(@"UPDATE dbIzinler SET DurumId = 1 WHERE Id = {0}", Utils.izinBelgeSelectedIzinID);
                    kont = true;
                }

                else
                {
                    MessageBox.Show("Lütfen kendi yetkinizdeki onay işlemini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (kont)
            {
                if (SQLiteUtils.SorguCalistir(sorgu))
                {
                    MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Herhangi Bir Değişim Yapılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Temizle();
            
        }

        private void onayKombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(onayKombox.SelectedValue) != 1003)
            {
                iptNedenText.Enabled = false;
                iptNedenText.Clear();
            }
            else
            {
                iptNedenText.Enabled = true;
                iptNedenText.Focus();

            }
        }
        
        private void Temizle()
        {
            onayKombox.SelectedIndex = -1;
            iptNedenText.Clear();
        }
    }
}
