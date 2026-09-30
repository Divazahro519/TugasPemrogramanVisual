namespace TugasPemrogramanVisual
{
    partial class frmPerkenalan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInputNama = new Label();
            lblSapaan = new Label();
            txtName = new TextBox();
            rdoLaki = new RadioButton();
            rdoPerempuan = new RadioButton();
            btnSapa = new Button();
            SuspendLayout();
            // 
            // lblInputNama
            // 
            lblInputNama.AutoSize = true;
            lblInputNama.Location = new Point(25, 26);
            lblInputNama.Name = "lblInputNama";
            lblInputNama.Size = new Size(114, 20);
            lblInputNama.TabIndex = 0;
            lblInputNama.Text = "Masukan Nama:";
            // 
            // lblSapaan
            // 
            lblSapaan.AutoSize = true;
            lblSapaan.Location = new Point(36, 149);
            lblSapaan.Name = "lblSapaan";
            lblSapaan.Size = new Size(0, 20);
            lblSapaan.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // rdoLaki
            // 
            rdoLaki.AutoSize = true;
            rdoLaki.Location = new Point(25, 49);
            rdoLaki.Name = "rdoLaki";
            rdoLaki.Size = new Size(88, 24);
            rdoLaki.TabIndex = 3;
            rdoLaki.TabStop = true;
            rdoLaki.Text = "Laki-Laki";
            rdoLaki.UseVisualStyleBackColor = true;
            // 
            // rdoPerempuan
            // 
            rdoPerempuan.AutoSize = true;
            rdoPerempuan.Location = new Point(25, 79);
            rdoPerempuan.Name = "rdoPerempuan";
            rdoPerempuan.Size = new Size(104, 24);
            rdoPerempuan.TabIndex = 4;
            rdoPerempuan.TabStop = true;
            rdoPerempuan.Text = "Perempuan";
            rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnSapa
            // 
            btnSapa.Location = new Point(25, 117);
            btnSapa.Name = "btnSapa";
            btnSapa.Size = new Size(94, 29);
            btnSapa.TabIndex = 5;
            btnSapa.Text = "Sapa Saya";
            btnSapa.UseVisualStyleBackColor = true;
            btnSapa.Click += btnSapa_Click;
            // 
            // frmPerkenalan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSapa);
            Controls.Add(rdoPerempuan);
            Controls.Add(rdoLaki);
            Controls.Add(txtName);
            Controls.Add(lblSapaan);
            Controls.Add(lblInputNama);
            Name = "frmPerkenalan";
            Text = "Form Perkenalan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputNama;
        private Label lblSapaan;
        private TextBox txtName;
        private RadioButton rdoLaki;
        private RadioButton rdoPerempuan;
        private Button btnSapa;
    }
}
