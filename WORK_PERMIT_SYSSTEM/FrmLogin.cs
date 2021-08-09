using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WORK_PERMIT_SYSSTEM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            KomboBoxBilgiGonder();
            RememberCheckYazdir();
        }

        private void KomboBoxBilgiGonder()
        {
            string sorgu = @"SELECT dbPersonelKullanici.*,(dbPersonelKullanici.PersonelAdi || ' ' || dbPersonelKullanici.PersonelSoyadi) as PersonelKullaniciAdi FROM dbPersonelKullanici ORDER BY PersonelKullaniciAdi ASC";
            DataTable dtTable = new DataTable();
            dtTable = SQLiteUtils.TabloGetir(sorgu);
            kullaniciKombox.DisplayMember = "PersonelKullaniciAdi";
            kullaniciKombox.ValueMember = "Id";           
            kullaniciKombox.DataSource = dtTable;

            Utils.personelUnvanId = Convert.ToInt32(((DataTable)kullaniciKombox.DataSource).Rows[kullaniciKombox.SelectedIndex]["PersonelUnvanID"].ToString());
        }

        private void RememberCheckBoxKayit()
        {
            if (sifremiHatirlacheckBox.Checked)
            {
                Properties.Settings.Default.UserName = kullaniciKombox.Text;
                Properties.Settings.Default.Password = sifreText.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void RememberCheckYazdir()
        {
            if(Properties.Settings.Default.UserName != "")
            {
                if (Properties.Settings.Default.Remember)
                {
                    kullaniciKombox.Text = Properties.Settings.Default.UserName;
                    sifreText.Text = Properties.Settings.Default.Password;
                    sifremiHatirlacheckBox.Checked = true;
                }
                else
                {
                    kullaniciKombox.SelectedIndex = -1;
                }
            }
            else
            {
                kullaniciKombox.SelectedIndex = -1;
            }
        }


        private void butonIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butonGiris_Click(object sender, EventArgs e)
        {
            if (kullaniciKombox.SelectedIndex < 0)
            {
                MessageBox.Show("Kullanıcı seçmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kullaniciKombox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sifreText.Text))
            {
                MessageBox.Show("Şifreyi girmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sifreText.Focus();
                sifreText.SelectAll();
                return;
            }

            string secilenKullanicininSifresi = ((DataTable)kullaniciKombox.DataSource).Rows[kullaniciKombox.SelectedIndex]["PersonelSifre"].ToString();

            if(sifreText.Text == secilenKullanicininSifresi)
            {
                RememberCheckBoxKayit();
                Utils.KullaniciId = Convert.ToInt32(kullaniciKombox.SelectedValue);
                Utils.KullaniciAdi = kullaniciKombox.Text;
                Utils.izinIndex = kullaniciKombox.SelectedIndex;
                FrmIzınBelgesi frmIzınBelgesi = new FrmIzınBelgesi();
                this.Hide();
                frmIzınBelgesi.ShowDialog();
                this.Show();
            }
            else
            {

                MessageBox.Show("Hatalı şifre girişi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sifreText.Focus();
                sifreText.SelectAll();
                return;
            }


        }

        private void kullaniciKombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(kullaniciKombox.SelectedIndex > 0)
            {
                sifreText.Focus();

                Utils.personelUnvanId = Convert.ToInt32(((DataTable)kullaniciKombox.DataSource).Rows[kullaniciKombox.SelectedIndex]["PersonelUnvanID"].ToString());
            }
            else
            {
                kullaniciKombox.Focus();
            }
        }
    }
}
