namespace MUZIK_KUTUPHANESI
{
    partial class ALBUMEKLE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAlbumAdi = new System.Windows.Forms.TextBox();
            this.btAlbumEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albüm Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Albüm Adı";
            // 
            // lbAlbumAdi
            // 
            this.lbAlbumAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAlbumAdi.Location = new System.Drawing.Point(12, 73);
            this.lbAlbumAdi.Name = "lbAlbumAdi";
            this.lbAlbumAdi.Size = new System.Drawing.Size(190, 26);
            this.lbAlbumAdi.TabIndex = 8;
            // 
            // btAlbumEkle
            // 
            this.btAlbumEkle.Location = new System.Drawing.Point(12, 111);
            this.btAlbumEkle.Name = "btAlbumEkle";
            this.btAlbumEkle.Size = new System.Drawing.Size(190, 32);
            this.btAlbumEkle.TabIndex = 10;
            this.btAlbumEkle.Text = "Ekle";
            this.btAlbumEkle.UseVisualStyleBackColor = true;
            this.btAlbumEkle.Click += new System.EventHandler(this.btAlbumEkle_Click);
            // 
            // ALBUMEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 155);
            this.Controls.Add(this.btAlbumEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAlbumAdi);
            this.Controls.Add(this.label1);
            this.Name = "ALBUMEKLE";
            this.Text = "Albüm Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbAlbumAdi;
        private System.Windows.Forms.Button btAlbumEkle;
    }
}