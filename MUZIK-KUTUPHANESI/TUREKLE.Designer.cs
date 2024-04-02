namespace MUZIK_KUTUPHANESI
{
    partial class TUREKLE
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tür Adı";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tür  Ekle";
            // 
            // TUREKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TUREKLE";
            this.Text = "Tür Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}