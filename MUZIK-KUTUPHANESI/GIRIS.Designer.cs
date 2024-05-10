namespace MUZIK_KUTUPHANESI
{
    partial class GIRIS
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btGirisYap = new System.Windows.Forms.Button();
            this.btKayitOl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soundtopia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-Posta";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEMAIL.Location = new System.Drawing.Point(25, 126);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(190, 26);
            this.txtEMAIL.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Parola";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPASSWORD.Location = new System.Drawing.Point(25, 181);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(190, 26);
            this.txtPASSWORD.TabIndex = 8;
            // 
            // btGirisYap
            // 
            this.btGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGirisYap.Location = new System.Drawing.Point(25, 223);
            this.btGirisYap.Name = "btGirisYap";
            this.btGirisYap.Size = new System.Drawing.Size(190, 39);
            this.btGirisYap.TabIndex = 10;
            this.btGirisYap.Text = "Giriş Yap";
            this.btGirisYap.UseVisualStyleBackColor = true;
            this.btGirisYap.Click += new System.EventHandler(this.btGirisYap_Click);
            // 
            // btKayitOl
            // 
            this.btKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKayitOl.Location = new System.Drawing.Point(237, 296);
            this.btKayitOl.Name = "btKayitOl";
            this.btKayitOl.Size = new System.Drawing.Size(240, 39);
            this.btKayitOl.TabIndex = 17;
            this.btKayitOl.Text = "Hemen Kayıt Ol";
            this.btKayitOl.UseVisualStyleBackColor = true;
            this.btKayitOl.Click += new System.EventHandler(this.btKayitOl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "İster Yükle, İster Dinle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(233, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = " Müzik ve Podcast Platformu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(233, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hesabın yok mu?";
            // 
            // GIRIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btKayitOl);
            this.Controls.Add(this.btGirisYap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.label1);
            this.Name = "GIRIS";
            this.Text = "Soundtopia";
            this.Load += new System.EventHandler(this.GIRIS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Button btGirisYap;
        private System.Windows.Forms.Button btKayitOl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

