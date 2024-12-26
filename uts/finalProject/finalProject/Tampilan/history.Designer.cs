namespace finalProject.Tampilan
{
    partial class history
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwHistory = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.DonasiID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kampanye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JumlahDonasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MetodePembayaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwHistory
            // 
            this.lvwHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DonasiID,
            this.Username,
            this.Kampanye,
            this.JumlahDonasi,
            this.MetodePembayaran,
            this.Tanggal,
            this.Pesan});
            this.lvwHistory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHistory.HideSelection = false;
            this.lvwHistory.Location = new System.Drawing.Point(39, 105);
            this.lvwHistory.Name = "lvwHistory";
            this.lvwHistory.Size = new System.Drawing.Size(1065, 605);
            this.lvwHistory.TabIndex = 0;
            this.lvwHistory.UseCompatibleStateImageBehavior = false;
            this.lvwHistory.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(38)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Berikut Informasi Akun Anda";
            // 
            // DonasiID
            // 
            this.DonasiID.Text = "Donasi ID";
            this.DonasiID.Width = 73;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Width = 117;
            // 
            // Kampanye
            // 
            this.Kampanye.Text = "Kampanye";
            this.Kampanye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kampanye.Width = 198;
            // 
            // JumlahDonasi
            // 
            this.JumlahDonasi.Text = "Jumlah Donasi";
            this.JumlahDonasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JumlahDonasi.Width = 114;
            // 
            // MetodePembayaran
            // 
            this.MetodePembayaran.Text = "Metode Pembayaran";
            this.MetodePembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MetodePembayaran.Width = 139;
            // 
            // Tanggal
            // 
            this.Tanggal.Text = "Tanggal";
            this.Tanggal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tanggal.Width = 133;
            // 
            // Pesan
            // 
            this.Pesan.Text = "Pesan";
            this.Pesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pesan.Width = 286;
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwHistory);
            this.Name = "history";
            this.Size = new System.Drawing.Size(1145, 749);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwHistory;
        private System.Windows.Forms.ColumnHeader DonasiID;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Kampanye;
        private System.Windows.Forms.ColumnHeader JumlahDonasi;
        private System.Windows.Forms.ColumnHeader MetodePembayaran;
        private System.Windows.Forms.ColumnHeader Tanggal;
        private System.Windows.Forms.ColumnHeader Pesan;
        private System.Windows.Forms.Label label1;
    }
}
