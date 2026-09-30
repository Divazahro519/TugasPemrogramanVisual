namespace TugasPemrogramanVisual
{
    partial class frmpendaftaran
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNIM = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNamaMhs = new System.Windows.Forms.TextBox();
            this.lblProdi = new System.Windows.Forms.Label();
            this.cboProdi = new System.Windows.Forms.ComboBox();
            this.grpMinat = new System.Windows.Forms.GroupBox();
            this.chkCoding = new System.Windows.Forms.CheckBox();
            this.chkDesain = new System.Windows.Forms.CheckBox();
            this.chkJaringan = new System.Windows.Forms.CheckBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpMinat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(30, 30);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(33, 15);
            this.lblNIM.TabIndex = 0;
            this.lblNIM.Text = "NIM:";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(140, 27);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(200, 23);
            this.txtNIM.TabIndex = 1;
            this.txtNIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIM_KeyPress);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(30, 70);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(103, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Mahasiswa:";
            // 
            // txtNamaMhs
            // 
            this.txtNamaMhs.Location = new System.Drawing.Point(140, 67);
            this.txtNamaMhs.Name = "txtNamaMhs";
            this.txtNamaMhs.Size = new System.Drawing.Size(200, 23);
            this.txtNamaMhs.TabIndex = 3;
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(30, 110);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(86, 15);
            this.lblProdi.TabIndex = 4;
            this.lblProdi.Text = "Program Studi:";
            // 
            // cboProdi
            // 
            this.cboProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdi.FormattingEnabled = true;
            this.cboProdi.Items.AddRange(new object[] {
            "Informatika",
            "Sistem Informasi",
            "Teknik Komputer"});
            this.cboProdi.Location = new System.Drawing.Point(140, 107);
            this.cboProdi.Name = "cboProdi";
            this.cboProdi.Size = new System.Drawing.Size(200, 23);
            this.cboProdi.TabIndex = 5;
            // 
            // grpMinat
            // 
            this.grpMinat.Controls.Add(this.chkCoding);
            this.grpMinat.Controls.Add(this.chkDesain);
            this.grpMinat.Controls.Add(this.chkJaringan);
            this.grpMinat.Location = new System.Drawing.Point(30, 150);
            this.grpMinat.Name = "grpMinat";
            this.grpMinat.Size = new System.Drawing.Size(310, 80);
            this.grpMinat.TabIndex = 6;
            this.grpMinat.TabStop = false;
            this.grpMinat.Text = "Minat";
            // 
            // chkCoding
            // 
            this.chkCoding.AutoSize = true;
            this.chkCoding.Location = new System.Drawing.Point(15, 30);
            this.chkCoding.Name = "chkCoding";
            this.chkCoding.Size = new System.Drawing.Size(65, 19);
            this.chkCoding.TabIndex = 0;
            this.chkCoding.Text = "Coding";
            this.chkCoding.UseVisualStyleBackColor = true;
            // 
            // chkDesain
            // 
            this.chkDesain.AutoSize = true;
            this.chkDesain.Location = new System.Drawing.Point(100, 30);
            this.chkDesain.Name = "chkDesain";
            this.chkDesain.Size = new System.Drawing.Size(61, 19);
            this.chkDesain.TabIndex = 1;
            this.chkDesain.Text = "Desain";
            this.chkDesain.UseVisualStyleBackColor = true;
            // 
            // chkJaringan
            // 
            this.chkJaringan.AutoSize = true;
            this.chkJaringan.Location = new System.Drawing.Point(180, 30);
            this.chkJaringan.Name = "chkJaringan";
            this.chkJaringan.Size = new System.Drawing.Size(70, 19);
            this.chkJaringan.TabIndex = 2;
            this.chkJaringan.Text = "Jaringan";
            this.chkJaringan.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(140, 250);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(95, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(245, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmpendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.grpMinat);
            this.Controls.Add(this.cboProdi);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.txtNamaMhs);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.lblNIM);
            this.Name = "frmpendaftaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pendaftaran Mahasiswa";
            this.grpMinat.ResumeLayout(false);
            this.grpMinat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNamaMhs;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.ComboBox cboProdi;
        private System.Windows.Forms.GroupBox grpMinat;
        private System.Windows.Forms.CheckBox chkCoding;
        private System.Windows.Forms.CheckBox chkDesain;
        private System.Windows.Forms.CheckBox chkJaringan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
    }
}