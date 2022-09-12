
namespace Sipariş_otomasyonu
{
    partial class ÜrünListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonÇıkar = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Chocolate;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.Location = new System.Drawing.Point(81, 406);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(161, 54);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ürün Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonÇıkar
            // 
            this.buttonÇıkar.BackColor = System.Drawing.Color.Chocolate;
            this.buttonÇıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÇıkar.ForeColor = System.Drawing.Color.White;
            this.buttonÇıkar.Location = new System.Drawing.Point(379, 406);
            this.buttonÇıkar.Name = "buttonÇıkar";
            this.buttonÇıkar.Size = new System.Drawing.Size(161, 54);
            this.buttonÇıkar.TabIndex = 8;
            this.buttonÇıkar.Text = "Ürün Çıkar";
            this.buttonÇıkar.UseVisualStyleBackColor = false;
            this.buttonÇıkar.Click += new System.EventHandler(this.buttonÇıkar_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.Chocolate;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGüncelle.Location = new System.Drawing.Point(666, 406);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(161, 54);
            this.buttonGüncelle.TabIndex = 9;
            this.buttonGüncelle.Text = "Ürün Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // ÜrünListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 534);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonÇıkar);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜrünListesi";
            this.Text = "ÜrünListesi";
            this.Load += new System.EventHandler(this.ÜrünListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonÇıkar;
        private System.Windows.Forms.Button buttonGüncelle;
    }
}