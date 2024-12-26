namespace finalProject.Tampilan
{
    partial class Home
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
            this.panelUtama = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_donasi = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUtama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUtama
            // 
            this.panelUtama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelUtama.Controls.Add(this.btn_donasi);
            this.panelUtama.Controls.Add(this.label2);
            this.panelUtama.Controls.Add(this.guna2PictureBox2);
            this.panelUtama.Controls.Add(this.label1);
            this.panelUtama.Location = new System.Drawing.Point(0, 0);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(1145, 749);
            this.panelUtama.TabIndex = 2;
            // 
            // btn_donasi
            // 
            this.btn_donasi.BorderRadius = 20;
            this.btn_donasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_donasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_donasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_donasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_donasi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(38)))), ((int)(((byte)(137)))));
            this.btn_donasi.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donasi.ForeColor = System.Drawing.Color.White;
            this.btn_donasi.Location = new System.Drawing.Point(25, 401);
            this.btn_donasi.Name = "btn_donasi";
            this.btn_donasi.Size = new System.Drawing.Size(132, 45);
            this.btn_donasi.TabIndex = 8;
            this.btn_donasi.Text = "Donasi Disini!";
            this.btn_donasi.Click += new System.EventHandler(this.btn_donasi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(189)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(21, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mari membantu mereka yang membutuhkan di luar sana, \r\nbersama Domikom Langkah Kec" +
    "il Berarti";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::finalProject.Properties.Resources.volunteer_holding_box_containing_donations_charity_Recovered;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(563, 164);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(582, 585);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(38)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 183);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"Langkah kecil Anda hari ini dapat mengubah \r\nmasa depan mereka\r\nselamanya\"";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUtama);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1145, 749);
            this.panelUtama.ResumeLayout(false);
            this.panelUtama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelUtama;
        private Guna.UI2.WinForms.Guna2Button btn_donasi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
