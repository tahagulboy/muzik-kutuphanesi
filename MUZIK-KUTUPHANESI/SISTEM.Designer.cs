namespace MUZIK_KUTUPHANESI
{
    partial class SISTEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SISTEM));
            this.dtSarkiListesi = new System.Windows.Forms.DataGridView();
            this.aramaKutusu = new System.Windows.Forms.TextBox();
            this.btAra = new System.Windows.Forms.Button();
            this.btSarkiYukle = new System.Windows.Forms.Button();
            this.lbKullaniciAdi = new System.Windows.Forms.Label();
            this.btAlbumEkle = new System.Windows.Forms.Button();
            this.btTurEkle = new System.Windows.Forms.Button();
            this.btCikisYap = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.btDuzenle = new System.Windows.Forms.Button();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dtSarkiListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSarkiListesi
            // 
            this.dtSarkiListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSarkiListesi.Location = new System.Drawing.Point(12, 47);
            this.dtSarkiListesi.Name = "dtSarkiListesi";
            this.dtSarkiListesi.Size = new System.Drawing.Size(573, 353);
            this.dtSarkiListesi.TabIndex = 0;
            // 
            // aramaKutusu
            // 
            this.aramaKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaKutusu.Location = new System.Drawing.Point(12, 10);
            this.aramaKutusu.Name = "aramaKutusu";
            this.aramaKutusu.Size = new System.Drawing.Size(474, 31);
            this.aramaKutusu.TabIndex = 1;
            // 
            // btAra
            // 
            this.btAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAra.Location = new System.Drawing.Point(493, 10);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(92, 31);
            this.btAra.TabIndex = 2;
            this.btAra.Text = "Ara";
            this.btAra.UseVisualStyleBackColor = true;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // btSarkiYukle
            // 
            this.btSarkiYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSarkiYukle.Location = new System.Drawing.Point(597, 47);
            this.btSarkiYukle.Name = "btSarkiYukle";
            this.btSarkiYukle.Size = new System.Drawing.Size(197, 39);
            this.btSarkiYukle.TabIndex = 3;
            this.btSarkiYukle.Text = "Şarkı Yükle";
            this.btSarkiYukle.UseVisualStyleBackColor = true;
            this.btSarkiYukle.Click += new System.EventHandler(this.btSarkiYukle_Click);
            // 
            // lbKullaniciAdi
            // 
            this.lbKullaniciAdi.AutoSize = true;
            this.lbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKullaniciAdi.Location = new System.Drawing.Point(593, 10);
            this.lbKullaniciAdi.Name = "lbKullaniciAdi";
            this.lbKullaniciAdi.Size = new System.Drawing.Size(113, 24);
            this.lbKullaniciAdi.TabIndex = 10;
            this.lbKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btAlbumEkle
            // 
            this.btAlbumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAlbumEkle.Location = new System.Drawing.Point(597, 92);
            this.btAlbumEkle.Name = "btAlbumEkle";
            this.btAlbumEkle.Size = new System.Drawing.Size(197, 39);
            this.btAlbumEkle.TabIndex = 12;
            this.btAlbumEkle.Text = "Albüm Ekle";
            this.btAlbumEkle.UseVisualStyleBackColor = true;
            this.btAlbumEkle.Click += new System.EventHandler(this.btAlbumEkle_Click);
            // 
            // btTurEkle
            // 
            this.btTurEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTurEkle.Location = new System.Drawing.Point(597, 137);
            this.btTurEkle.Name = "btTurEkle";
            this.btTurEkle.Size = new System.Drawing.Size(197, 39);
            this.btTurEkle.TabIndex = 13;
            this.btTurEkle.Text = "Tür Ekle";
            this.btTurEkle.UseVisualStyleBackColor = true;
            this.btTurEkle.Click += new System.EventHandler(this.btTurEkle_Click);
            // 
            // btCikisYap
            // 
            this.btCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCikisYap.Location = new System.Drawing.Point(597, 392);
            this.btCikisYap.Name = "btCikisYap";
            this.btCikisYap.Size = new System.Drawing.Size(197, 46);
            this.btCikisYap.TabIndex = 14;
            this.btCikisYap.Text = "Çıkış Yap";
            this.btCikisYap.UseVisualStyleBackColor = true;
            this.btCikisYap.Click += new System.EventHandler(this.btCikisYap_Click);
            // 
            // btSil
            // 
            this.btSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSil.Location = new System.Drawing.Point(597, 335);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(197, 51);
            this.btSil.TabIndex = 16;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // btDuzenle
            // 
            this.btDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDuzenle.Location = new System.Drawing.Point(597, 278);
            this.btDuzenle.Name = "btDuzenle";
            this.btDuzenle.Size = new System.Drawing.Size(197, 51);
            this.btDuzenle.TabIndex = 17;
            this.btDuzenle.Text = "Düzenle";
            this.btDuzenle.UseVisualStyleBackColor = true;
            this.btDuzenle.Click += new System.EventHandler(this.btDuzenle_Click);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(12, 392);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(573, 46);
            this.musicPlayer.TabIndex = 11;
            this.musicPlayer.Enter += new System.EventHandler(this.musicPlayer_Enter);
            // 
            // SISTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDuzenle);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btCikisYap);
            this.Controls.Add(this.btTurEkle);
            this.Controls.Add(this.btAlbumEkle);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.lbKullaniciAdi);
            this.Controls.Add(this.btSarkiYukle);
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.aramaKutusu);
            this.Controls.Add(this.dtSarkiListesi);
            this.Name = "SISTEM";
            this.Text = "Soundtopia: Ana Sayfa";
            this.Load += new System.EventHandler(this.SISTEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSarkiListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSarkiListesi;
        private System.Windows.Forms.TextBox aramaKutusu;
        private System.Windows.Forms.Button btAra;
        private System.Windows.Forms.Button btSarkiYukle;
        private System.Windows.Forms.Label lbKullaniciAdi;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Button btAlbumEkle;
        private System.Windows.Forms.Button btTurEkle;
        private System.Windows.Forms.Button btCikisYap;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btDuzenle;
    }
}