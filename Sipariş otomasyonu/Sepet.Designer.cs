
namespace Sipariş_otomasyonu
{
    partial class Sepet
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
            this.buttonSiparişTamamla = new System.Windows.Forms.Button();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonÜrünÇıkar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSiparişTamamla
            // 
            this.buttonSiparişTamamla.BackColor = System.Drawing.Color.Chocolate;
            this.buttonSiparişTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSiparişTamamla.ForeColor = System.Drawing.Color.White;
            this.buttonSiparişTamamla.Location = new System.Drawing.Point(268, 376);
            this.buttonSiparişTamamla.Name = "buttonSiparişTamamla";
            this.buttonSiparişTamamla.Size = new System.Drawing.Size(179, 66);
            this.buttonSiparişTamamla.TabIndex = 1;
            this.buttonSiparişTamamla.Text = "Siparişi tamamla";
            this.buttonSiparişTamamla.UseVisualStyleBackColor = false;
            this.buttonSiparişTamamla.Click += new System.EventHandler(this.buttonSiparişTamamla_Click);
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxToplamTutar.Location = new System.Drawing.Point(635, 399);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.ReadOnly = true;
            this.textBoxToplamTutar.Size = new System.Drawing.Size(143, 27);
            this.textBoxToplamTutar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam tutar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(832, 325);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // buttonÜrünÇıkar
            // 
            this.buttonÜrünÇıkar.BackColor = System.Drawing.Color.Chocolate;
            this.buttonÜrünÇıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÜrünÇıkar.ForeColor = System.Drawing.Color.White;
            this.buttonÜrünÇıkar.Location = new System.Drawing.Point(37, 379);
            this.buttonÜrünÇıkar.Name = "buttonÜrünÇıkar";
            this.buttonÜrünÇıkar.Size = new System.Drawing.Size(179, 66);
            this.buttonÜrünÇıkar.TabIndex = 5;
            this.buttonÜrünÇıkar.Text = "Ürünü çıkar";
            this.buttonÜrünÇıkar.UseVisualStyleBackColor = false;
            this.buttonÜrünÇıkar.Click += new System.EventHandler(this.buttonÜrünÇıkar_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 492);
            this.Controls.Add(this.buttonÜrünÇıkar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxToplamTutar);
            this.Controls.Add(this.buttonSiparişTamamla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSiparişTamamla;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonÜrünÇıkar;
    }
}