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
        }

        private void KomboboxVeriYukle()
        {
            string sorgu = "SELECT * FROM dbDurum AS durum  WHERE durum.Id=2 OR DURUM.Id = 3 OR durum.Id = 1002 OR durum.Id = 1003";
            DataTable dtTable = new DataTable();
            dtTable = Utils.TabloGetir(sorgu);
            onayKombox.SelectedIndex = -1;
            onayKombox.DisplayMember = "DurumKodu";
            onayKombox.ValueMember = "Id";
            onayKombox.DataSource = dtTable;
        }

        private void iptaButon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
