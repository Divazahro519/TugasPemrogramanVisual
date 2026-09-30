using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasPemrogramanVisual
{
    public partial class frmDaftarBelanja : Form
    {
        public frmDaftarBelanja()
        {
            InitializeComponent();
        }

        // Method bantuan untuk meng-update jumlah item di label
        private void UpdateTotalItem()
        {
            lblTotalItem.Text = $"Total Item: {lstBelanja.Items.Count}";
        }

        // Tombol Tambah Barang
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarang.Text))
            {
                MessageBox.Show("Ketikkan nama barang terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarang.Focus();
                return;
            }

            // Tambahkan barang ke ListBox
            lstBelanja.Items.Add(txtBarang.Text.Trim());

            // Hitung ulang total item
            UpdateTotalItem();

            // Reset inputan
            txtBarang.Clear();
            txtBarang.Focus();
        }

        // Tombol Hapus Item yang Dipilih
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstBelanja.SelectedIndex != -1)
            {
                lstBelanja.Items.RemoveAt(lstBelanja.SelectedIndex);

                // Hitung ulang total item setelah dihapus
                UpdateTotalItem();
            }
            else
            {
                MessageBox.Show("Pilih barang yang ingin dihapus dari daftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Tombol Hapus Semua
        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            if (lstBelanja.Items.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Yakin ingin menghapus semua daftar belanja?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lstBelanja.Items.Clear();

                    // Hitung ulang total item setelah dibersihkan
                    UpdateTotalItem();
                }
            }
        }
    }
}