namespace TugasPemrogramanVisual
{
    public partial class frmPerkenalan : Form
    {
        public frmPerkenalan()
        {
            InitializeComponent();
        }

        private void btnSapa_Click(object sender, EventArgs e)
        {
            string nama = txtName.Text;
            string panggilan = "";

            if (rdoLaki.Checked)
            {
                panggilan = "Bapak/Mas";
            }
            else if (rdoPerempuan.Checked)
            {
                panggilan = "Ibu/Mbak";
            }

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Silakan masukkan nama Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblSapaan.Text = $"Halo, selamat datang {panggilan} {nama}!";
        }

        private void rdoLaki_CheckedChanged(object sender, EventArgs e)
        {
            // Dibiarkan kosong agar tidak error jika terlanjur ditautkan di designer
        }
    }
}