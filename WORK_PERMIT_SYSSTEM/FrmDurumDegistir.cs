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
            string sorgu = "SELECT * FROM dbDurum AS durum  WHERE durum.Id=2 OR DURUM.Id = 3 OR durum.Id = 1002 OR durum.Id = 1003";
            DataTable dtTable = new DataTable();
            dtTable = Utils.TabloGetir(sorgu);
            onayKombox.DisplayMember = "DurumKodu";
            onayKombox.ValueMember = "Id";
            onayKombox.DataSource = dtTable;
            onayKombox.SelectedIndex = -1;
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
            if (Utils.personelUnvanId == 1)
            {
                if (Convert.ToInt32(onayKombox.SelectedValue) == 1003)
                {
                    if (iptNedenText.Text.Length > 5)
                    {
                        if (Utils.izinBelgeSelectedDurumID == 4)
                        {
                            sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1003 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                            MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            /***Burada böyle mi olması gerekiyor bir sorarsın ***/

                            //if(Utils.KullaniciId == Utils.izinBelgeSelectedPersonelID)
                            //{
                            //    sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1003 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Sadece izin isteyen kişi iptal edebilir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //}
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
                            MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 2 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
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
                        sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1003 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                        MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 3 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
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
                        sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1003 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                        MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    sorgu = string.Format(@"UPDATE dbIzinler SET dbIzinler.DurumId = 1 WHERE dbIzinler.Id = {0}", Utils.izinBelgeSelectedIzinID);
                }

                else
                {
                    MessageBox.Show("Lütfen kendi yetkinizdeki onay işlemini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Utils.SorguCalistir(sorgu);
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
