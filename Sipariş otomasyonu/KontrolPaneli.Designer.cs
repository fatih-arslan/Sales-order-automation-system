
namespace Sipariş_otomasyonu
{
    partial class KontrolPaneli
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
            this.buttonMusteri = new System.Windows.Forms.Button();
            this.buttonYonetici = new System.Windows.Forms.Button();
            this.buttonYöneticiEkle = new System.Windows.Forms.Button();
            this.buttonÜrünler = new System.Windows.Forms.Button();
            this.buttonSiparişler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusteri
            // 
            this.buttonMusteri.BackColor = System.Drawing.Color.Chocolate;
            this.buttonMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteri.ForeColor = System.Drawing.Color.White;
            this.buttonMusteri.Location = new System.Drawing.Point(210, 169);
            this.buttonMusteri.Name = "buttonMusteri";
            this.buttonMusteri.Size = new System.Drawing.Size(221, 77);
            this.buttonMusteri.TabIndex = 0;
            this.buttonMusteri.Text = "Müşteriler";
            this.buttonMusteri.UseVisualStyleBackColor = false;
            this.buttonMusteri.Click += new System.EventHandler(this.buttonMusteri_Click);
            // 
            // buttonYonetici
            // 
            this.buttonYonetici.BackColor = System.Drawing.Color.Chocolate;
            this.buttonYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYonetici.ForeColor = System.Drawing.Color.White;
            this.buttonYonetici.Location = new System.Drawing.Point(210, 402);
            this.buttonYonetici.Name = "buttonYonetici";
            this.buttonYonetici.Size = new System.Drawing.Size(221, 77);
            this.buttonYonetici.TabIndex = 1;
            this.buttonYonetici.Text = "Yöneticiler";
            this.buttonYonetici.UseVisualStyleBackColor = false;
            this.buttonYonetici.Click += new System.EventHandler(this.buttonYonetici_Click);
            // 
            // buttonYöneticiEkle
            // 
            this.buttonYöneticiEkle.BackColor = System.Drawing.Color.Chocolate;
            this.buttonYöneticiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYöneticiEkle.ForeColor = System.Drawing.Color.White;
            this.buttonYöneticiEkle.Location = new System.Drawing.Point(210, 540);
            this.buttonYöneticiEkle.Name = "buttonYöneticiEkle";
            this.buttonYöneticiEkle.Size = new System.Drawing.Size(221, 77);
            this.buttonYöneticiEkle.TabIndex = 2;
            this.buttonYöneticiEkle.Text = "Yönetici Hesabı Ekle";
            this.buttonYöneticiEkle.UseVisualStyleBackColor = false;
            this.buttonYöneticiEkle.Click += new System.EventHandler(this.buttonYöneticiEkle_Click);
            // 
            // buttonÜrünler
            // 
            this.buttonÜrünler.BackColor = System.Drawing.Color.Chocolate;
            this.buttonÜrünler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÜrünler.ForeColor = System.Drawing.Color.White;
            this.buttonÜrünler.Location = new System.Drawing.Point(210, 48);
            this.buttonÜrünler.Name = "buttonÜrünler";
            this.buttonÜrünler.Size = new System.Drawing.Size(221, 77);
            this.buttonÜrünler.TabIndex = 3;
            this.buttonÜrünler.Text = "Ürünler";
            this.buttonÜrünler.UseVisualStyleBackColor = false;
            this.buttonÜrünler.Click += new System.EventHandler(this.buttonÜrünler_Click);
            // 
            // buttonSiparişler
            // 
            this.buttonSiparişler.BackColor = System.Drawing.Color.Chocolate;
            this.buttonSiparişler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSiparişler.ForeColor = System.Drawing.Color.White;
            this.buttonSiparişler.Location = new System.Drawing.Point(210, 286);
            this.buttonSiparişler.Name = "buttonSiparişler";
            this.buttonSiparişler.Size = new System.Drawing.Size(221, 77);
            this.buttonSiparişler.TabIndex = 4;
            this.buttonSiparişler.Text = "Siparişler";
            this.buttonSiparişler.UseVisualStyleBackColor = false;
            this.buttonSiparişler.Click += new System.EventHandler(this.buttonSiparişler_Click);
            // 
            // KontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 656);
            this.Controls.Add(this.buttonSiparişler);
            this.Controls.Add(this.buttonÜrünler);
            this.Controls.Add(this.buttonYöneticiEkle);
            this.Controls.Add(this.buttonYonetici);
            this.Controls.Add(this.buttonMusteri);
            this.Name = "KontrolPaneli";
            this.Text = "KontrolPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusteri;
        private System.Windows.Forms.Button buttonYonetici;
        private System.Windows.Forms.Button buttonYöneticiEkle;
        private System.Windows.Forms.Button buttonÜrünler;
        private System.Windows.Forms.Button buttonSiparişler;
    }
}