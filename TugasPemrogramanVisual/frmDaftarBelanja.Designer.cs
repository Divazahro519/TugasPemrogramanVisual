namespace TugasPemrogramanVisual
{
    partial class frmDaftarBelanja
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
            label1 = new Label();
            txtBarang = new TextBox();
            btnTambah = new Button();
            lstBelanja = new ListBox();
            btnHapus = new Button();
            btnBersihkan = new Button();
            lblTotalItem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Barang";
            // 
            // txtBarang
            // 
            txtBarang.Location = new Point(118, 18);
            txtBarang.Name = "txtBarang";
            txtBarang.Size = new Size(125, 27);
            txtBarang.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(249, 18);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // lstBelanja
            // 
            lstBelanja.FormattingEnabled = true;
            lstBelanja.Location = new Point(125, 53);
            lstBelanja.Name = "lstBelanja";
            lstBelanja.Size = new Size(225, 104);
            lstBelanja.TabIndex = 4;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(125, 163);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus Item";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(225, 163);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(125, 29);
            btnBersihkan.TabIndex = 6;
            btnBersihkan.Text = "Hapus Semua";
            btnBersihkan.UseVisualStyleBackColor = true;
            btnBersihkan.Click += btnBersihkan_Click;
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.Location = new Point(12, 209);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(91, 20);
            lblTotalItem.TabIndex = 7;
            lblTotalItem.Text = "Total Item: 0";
            // 
            // frmDaftarBelanja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalItem);
            Controls.Add(btnBersihkan);
            Controls.Add(btnHapus);
            Controls.Add(lstBelanja);
            Controls.Add(btnTambah);
            Controls.Add(txtBarang);
            Controls.Add(label1);
            Name = "frmDaftarBelanja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Daftar Belanja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBarang;
        private Button btnTambah;
        private ListBox lstBelanja;
        private Button btnHapus;
        private Button btnBersihkan;
        private Label lblTotalItem;
    }
}