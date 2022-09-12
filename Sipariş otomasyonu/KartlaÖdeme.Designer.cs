
namespace Sipariş_otomasyonu
{
    partial class KartlaÖdeme
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxKartNumara = new System.Windows.Forms.TextBox();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.buttonÖde = new System.Windows.Forms.Button();
            this.comboBoxAy = new System.Windows.Forms.ComboBox();
            this.comboBoxYıl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(88, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Güvenik kodu (CVC):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(44, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Son kullanma tarihi:";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(239, 100);
            this.textBoxAdSoyad.Multiline = true;
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(223, 27);
            this.textBoxAdSoyad.TabIndex = 4;
            // 
            // textBoxKartNumara
            // 
            this.textBoxKartNumara.Location = new System.Drawing.Point(239, 166);
            this.textBoxKartNumara.Multiline = true;
            this.textBoxKartNumara.Name = "textBoxKartNumara";
            this.textBoxKartNumara.Size = new System.Drawing.Size(223, 27);
            this.textBoxKartNumara.TabIndex = 5;
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Location = new System.Drawing.Point(239, 228);
            this.textBoxCVC.Multiline = true;
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(223, 27);
            this.textBoxCVC.TabIndex = 6;
            // 
            // buttonÖde
            // 
            this.buttonÖde.BackColor = System.Drawing.Color.Chocolate;
            this.buttonÖde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÖde.ForeColor = System.Drawing.Color.White;
            this.buttonÖde.Location = new System.Drawing.Point(182, 390);
            this.buttonÖde.Name = "buttonÖde";
            this.buttonÖde.Size = new System.Drawing.Size(193, 66);
            this.buttonÖde.TabIndex = 8;
            this.buttonÖde.Text = "Ödemeyi Tamamla";
            this.buttonÖde.UseVisualStyleBackColor = false;
            this.buttonÖde.Click += new System.EventHandler(this.buttonÖde_Click);
            // 
            // comboBoxAy
            // 
            this.comboBoxAy.FormattingEnabled = true;
            this.comboBoxAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxAy.Location = new System.Drawing.Point(239, 291);
            this.comboBoxAy.Name = "comboBoxAy";
            this.comboBoxAy.Size = new System.Drawing.Size(76, 24);
            this.comboBoxAy.TabIndex = 9;
            // 
            // comboBoxYıl
            // 
            this.comboBoxYıl.FormattingEnabled = true;
            this.comboBoxYıl.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.comboBoxYıl.Location = new System.Drawing.Point(345, 291);
            this.comboBoxYıl.Name = "comboBoxYıl";
            this.comboBoxYıl.Size = new System.Drawing.Size(76, 24);
            this.comboBoxYıl.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(321, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            // 
            // KartlaÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxYıl);
            this.Controls.Add(this.comboBoxAy);
            this.Controls.Add(this.buttonÖde);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBoxKartNumara);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KartlaÖdeme";
            this.Text = "KartlaÖdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxKartNumara;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.Button buttonÖde;
        private System.Windows.Forms.ComboBox comboBoxAy;
        private System.Windows.Forms.ComboBox comboBoxYıl;
        private System.Windows.Forms.Label label5;
    }
}