
namespace Sipariş_otomasyonu
{
    partial class ÜrünGüncelleme
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
            this.comboBoxÜrünler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxAğırlık = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxÜrünler
            // 
            this.comboBoxÜrünler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxÜrünler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxÜrünler.FormattingEnabled = true;
            this.comboBoxÜrünler.Location = new System.Drawing.Point(218, 53);
            this.comboBoxÜrünler.Name = "comboBoxÜrünler";
            this.comboBoxÜrünler.Size = new System.Drawing.Size(190, 28);
            this.comboBoxÜrünler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Güncellenecek ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeni Ağırlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeni Stok:";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFiyat.Location = new System.Drawing.Point(218, 155);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(190, 27);
            this.textBoxFiyat.TabIndex = 5;
            // 
            // textBoxAğırlık
            // 
            this.textBoxAğırlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAğırlık.Location = new System.Drawing.Point(218, 211);
            this.textBoxAğırlık.Name = "textBoxAğırlık";
            this.textBoxAğırlık.Size = new System.Drawing.Size(190, 27);
            this.textBoxAğırlık.TabIndex = 6;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxStok.Location = new System.Drawing.Point(218, 275);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(190, 27);
            this.textBoxStok.TabIndex = 7;
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGüncelle.Location = new System.Drawing.Point(317, 386);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(181, 61);
            this.buttonGüncelle.TabIndex = 8;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonBilgi
            // 
            this.buttonBilgi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBilgi.ForeColor = System.Drawing.Color.White;
            this.buttonBilgi.Location = new System.Drawing.Point(84, 386);
            this.buttonBilgi.Name = "buttonBilgi";
            this.buttonBilgi.Size = new System.Drawing.Size(181, 61);
            this.buttonBilgi.TabIndex = 9;
            this.buttonBilgi.Text = "Bilgileri getir";
            this.buttonBilgi.UseVisualStyleBackColor = false;
            this.buttonBilgi.Click += new System.EventHandler(this.buttonBilgi_Click);
            // 
            // ÜrünGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(584, 533);
            this.Controls.Add(this.buttonBilgi);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.textBoxAğırlık);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxÜrünler);
            this.Name = "ÜrünGüncelleme";
            this.Text = "ÜrünGüncelleme";
            this.Load += new System.EventHandler(this.ÜrünGüncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxÜrünler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxAğırlık;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonBilgi;
    }
}