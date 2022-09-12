
namespace Sipariş_otomasyonu
{
    partial class Form1
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
            this.buttonKayit = new System.Windows.Forms.Button();
            this.buttonKontrol = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKayit
            // 
            this.buttonKayit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayit.ForeColor = System.Drawing.Color.White;
            this.buttonKayit.Location = new System.Drawing.Point(148, 26);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(183, 62);
            this.buttonKayit.TabIndex = 0;
            this.buttonKayit.Text = "Kayıt Ol";
            this.buttonKayit.UseVisualStyleBackColor = false;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // buttonKontrol
            // 
            this.buttonKontrol.BackColor = System.Drawing.Color.Chocolate;
            this.buttonKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKontrol.ForeColor = System.Drawing.Color.White;
            this.buttonKontrol.Location = new System.Drawing.Point(807, 26);
            this.buttonKontrol.Name = "buttonKontrol";
            this.buttonKontrol.Size = new System.Drawing.Size(183, 62);
            this.buttonKontrol.TabIndex = 1;
            this.buttonKontrol.Text = "Kontrol Paneli";
            this.buttonKontrol.UseVisualStyleBackColor = false;
            this.buttonKontrol.Click += new System.EventHandler(this.buttonKontrol_Click);
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.Chocolate;
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.ForeColor = System.Drawing.Color.White;
            this.buttonGiris.Location = new System.Drawing.Point(476, 26);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(183, 62);
            this.buttonGiris.TabIndex = 2;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Chocolate;
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.White;
            this.buttonCikis.Location = new System.Drawing.Point(1138, 26);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(183, 62);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sipariş_otomasyonu.Properties.Resources.es2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 605);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.buttonKontrol);
            this.Controls.Add(this.buttonKayit);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Ana Menü ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.Button buttonKontrol;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonCikis;
    }
}

