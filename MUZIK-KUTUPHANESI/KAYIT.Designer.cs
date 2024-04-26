namespace MUZIK_KUTUPHANESI
{
    partial class KAYIT
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.btREGISTER = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "E-Posta";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEMAIL.Location = new System.Drawing.Point(12, 130);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(190, 26);
            this.txtEMAIL.TabIndex = 31;
            // 
            // btREGISTER
            // 
            this.btREGISTER.Location = new System.Drawing.Point(12, 229);
            this.btREGISTER.Name = "btREGISTER";
            this.btREGISTER.Size = new System.Drawing.Size(190, 32);
            this.btREGISTER.TabIndex = 26;
            this.btREGISTER.Text = "Kayıt Ol";
            this.btREGISTER.UseVisualStyleBackColor = true;
            this.btREGISTER.Click += new System.EventHandler(this.btREGISTER_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUSERNAME.Location = new System.Drawing.Point(12, 73);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(190, 26);
            this.txtUSERNAME.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kayıt Ol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Şifre";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPASSWORD.Location = new System.Drawing.Point(12, 187);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(190, 26);
            this.txtPASSWORD.TabIndex = 33;
            // 
            // KAYIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.btREGISTER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.label1);
            this.Name = "KAYIT";
            this.Text = "KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button btREGISTER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPASSWORD;
    }
}