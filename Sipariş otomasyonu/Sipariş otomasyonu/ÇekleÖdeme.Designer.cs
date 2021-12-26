
namespace Sipariş_otomasyonu
{
    partial class ÇekleÖdeme
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
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxBanka = new System.Windows.Forms.TextBox();
            this.textBoxBankaID = new System.Windows.Forms.TextBox();
            this.buttonÖde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Banka ID:";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(204, 124);
            this.textBoxAdSoyad.Multiline = true;
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(223, 27);
            this.textBoxAdSoyad.TabIndex = 5;
            // 
            // textBoxBanka
            // 
            this.textBoxBanka.Location = new System.Drawing.Point(204, 186);
            this.textBoxBanka.Multiline = true;
            this.textBoxBanka.Name = "textBoxBanka";
            this.textBoxBanka.Size = new System.Drawing.Size(223, 27);
            this.textBoxBanka.TabIndex = 6;
            // 
            // textBoxBankaID
            // 
            this.textBoxBankaID.Location = new System.Drawing.Point(204, 245);
            this.textBoxBankaID.Multiline = true;
            this.textBoxBankaID.Name = "textBoxBankaID";
            this.textBoxBankaID.Size = new System.Drawing.Size(223, 27);
            this.textBoxBankaID.TabIndex = 7;
            // 
            // buttonÖde
            // 
            this.buttonÖde.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonÖde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÖde.ForeColor = System.Drawing.Color.White;
            this.buttonÖde.Location = new System.Drawing.Point(169, 365);
            this.buttonÖde.Name = "buttonÖde";
            this.buttonÖde.Size = new System.Drawing.Size(193, 66);
            this.buttonÖde.TabIndex = 9;
            this.buttonÖde.Text = "Ödemeyi Tamamla";
            this.buttonÖde.UseVisualStyleBackColor = false;
            this.buttonÖde.Click += new System.EventHandler(this.buttonÖde_Click);
            // 
            // ÇekleÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(568, 540);
            this.Controls.Add(this.buttonÖde);
            this.Controls.Add(this.textBoxBankaID);
            this.Controls.Add(this.textBoxBanka);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÇekleÖdeme";
            this.Text = "ÇekleÖdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxBanka;
        private System.Windows.Forms.TextBox textBoxBankaID;
        private System.Windows.Forms.Button buttonÖde;
    }
}