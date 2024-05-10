namespace MUZIK_KUTUPHANESI
{
    partial class SARKIYUKLE
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
            this.btYukle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSarkiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtYil = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btDosyaYolu = new System.Windows.Forms.Button();
            this.dosyaSecDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbDosyaYolu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btYukle
            // 
            this.btYukle.Location = new System.Drawing.Point(12, 345);
            this.btYukle.Name = "btYukle";
            this.btYukle.Size = new System.Drawing.Size(190, 32);
            this.btYukle.TabIndex = 14;
            this.btYukle.Text = "Yükle";
            this.btYukle.UseVisualStyleBackColor = true;
            this.btYukle.Click += new System.EventHandler(this.btYukle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şarkı Adı";
            // 
            // lbSarkiAdi
            // 
            this.lbSarkiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSarkiAdi.Location = new System.Drawing.Point(12, 71);
            this.lbSarkiAdi.Name = "lbSarkiAdi";
            this.lbSarkiAdi.Size = new System.Drawing.Size(190, 26);
            this.lbSarkiAdi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şarkı Yükle";
            // 
            // cbAlbum
            // 
            this.cbAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(12, 125);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(190, 28);
            this.cbAlbum.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Albüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tür";
            // 
            // cbTur
            // 
            this.cbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(12, 185);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(190, 28);
            this.cbTur.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dosya Yolu";
            // 
            // dtYil
            // 
            this.dtYil.Location = new System.Drawing.Point(15, 308);
            this.dtYil.Name = "dtYil";
            this.dtYil.Size = new System.Drawing.Size(190, 20);
            this.dtYil.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yılı";
            // 
            // btDosyaYolu
            // 
            this.btDosyaYolu.Location = new System.Drawing.Point(12, 247);
            this.btDosyaYolu.Name = "btDosyaYolu";
            this.btDosyaYolu.Size = new System.Drawing.Size(190, 25);
            this.btDosyaYolu.TabIndex = 23;
            this.btDosyaYolu.Text = "Dosya Seç";
            this.btDosyaYolu.UseVisualStyleBackColor = true;
            this.btDosyaYolu.Click += new System.EventHandler(this.btDosyaYolu_Click);
            // 
            // dosyaSecDialog
            // 
            this.dosyaSecDialog.FileName = "dosya";
            // 
            // lbDosyaYolu
            // 
            this.lbDosyaYolu.AutoSize = true;
            this.lbDosyaYolu.Location = new System.Drawing.Point(12, 273);
            this.lbDosyaYolu.Name = "lbDosyaYolu";
            this.lbDosyaYolu.Size = new System.Drawing.Size(91, 13);
            this.lbDosyaYolu.TabIndex = 24;
            this.lbDosyaYolu.Text = "dosya yüklenmedi";
            // 
            // SARKIYUKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 388);
            this.Controls.Add(this.lbDosyaYolu);
            this.Controls.Add(this.btDosyaYolu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtYil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.btYukle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSarkiAdi);
            this.Controls.Add(this.label1);
            this.Name = "SARKIYUKLE";
            this.Text = "Şarkı Yükle";
            this.Load += new System.EventHandler(this.SARKIYUKLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYukle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbSarkiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtYil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDosyaYolu;
        private System.Windows.Forms.OpenFileDialog dosyaSecDialog;
        private System.Windows.Forms.Label lbDosyaYolu;
    }
}