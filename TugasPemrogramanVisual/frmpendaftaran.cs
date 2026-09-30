using System;
using System.Windows.Forms;

namespace TugasPemrogramanVisual
{
    public partial class frmpendaftaran : Form
    {
        public frmpendaftaran()
        {
            InitializeComponent();
        }

        private void txtNIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNIM.Text) || string.IsNullOrWhiteSpace(txtNamaMhs.Text))
            {
                MessageBox.Show("NIM dan Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboProdi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Program Studi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string minat = "";
            if (chkCoding.Checked) minat += "Coding ";
            if (chkDesain.Checked) minat += "Desain ";
            if (chkJaringan.Checked) minat += "Jaringan ";

            string info = $"NIM: {txtNIM.Text}\nNama: {txtNamaMhs.Text}\nProdi: {cboProdi.SelectedItem}\nMinat: {(minat == "" ? "-" : minat)}";
            MessageBox.Show(info, "Data Pendaftaran Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNamaMhs.Clear();
            cboProdi.SelectedIndex = -1;
            chkCoding.Checked = false;
            chkDesain.Checked = false;
            chkJaringan.Checked = false;
        }
    }
}