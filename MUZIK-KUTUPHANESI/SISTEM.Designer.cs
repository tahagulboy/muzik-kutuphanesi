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
            this.sarkiListesi = new System.Windows.Forms.DataGridView();
            this.aramaKutusu = new System.Windows.Forms.TextBox();
            this.araButonu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sarkiListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // sarkiListesi
            // 
            this.sarkiListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sarkiListesi.Location = new System.Drawing.Point(12, 47);
            this.sarkiListesi.Name = "sarkiListesi";
            this.sarkiListesi.Size = new System.Drawing.Size(573, 352);
            this.sarkiListesi.TabIndex = 0;
            // 
            // aramaKutusu
            // 
            this.aramaKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaKutusu.Location = new System.Drawing.Point(12, 10);
            this.aramaKutusu.Name = "aramaKutusu";
            this.aramaKutusu.Size = new System.Drawing.Size(474, 31);
            this.aramaKutusu.TabIndex = 1;
            // 
            // araButonu
            // 
            this.araButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButonu.Location = new System.Drawing.Point(493, 10);
            this.araButonu.Name = "araButonu";
            this.araButonu.Size = new System.Drawing.Size(92, 31);
            this.araButonu.TabIndex = 2;
            this.araButonu.Text = "Ara";
            this.araButonu.UseVisualStyleBackColor = true;
            this.araButonu.Click += new System.EventHandler(this.araButonu_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(597, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Şarkı Yükle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(597, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Albüm Ekle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(597, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tür Ekle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(597, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "Çıkış Yap";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(597, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 51);
            this.button7.TabIndex = 16;
            this.button7.Text = "Sil";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 392);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(573, 46);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(592, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Standart Kullanıcı";
            // 
            // SISTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.araButonu);
            this.Controls.Add(this.aramaKutusu);
            this.Controls.Add(this.sarkiListesi);
            this.Name = "SISTEM";
            this.Text = "Soundtopia: Ana Sayfa";
            this.Load += new System.EventHandler(this.SISTEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sarkiListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sarkiListesi;
        private System.Windows.Forms.TextBox aramaKutusu;
        private System.Windows.Forms.Button araButonu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
    }
}