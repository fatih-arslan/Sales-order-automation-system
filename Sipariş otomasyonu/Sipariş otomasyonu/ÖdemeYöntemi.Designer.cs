
namespace Sipariş_otomasyonu
{
    partial class ÖdemeYöntemi
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
            this.buttonKart = new System.Windows.Forms.Button();
            this.buttonÇek = new System.Windows.Forms.Button();
            this.buttonNakit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKart
            // 
            this.buttonKart.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKart.ForeColor = System.Drawing.Color.White;
            this.buttonKart.Location = new System.Drawing.Point(205, 186);
            this.buttonKart.Name = "buttonKart";
            this.buttonKart.Size = new System.Drawing.Size(156, 56);
            this.buttonKart.TabIndex = 0;
            this.buttonKart.Text = "Kartla ödeme";
            this.buttonKart.UseVisualStyleBackColor = false;
            this.buttonKart.Click += new System.EventHandler(this.buttonKart_Click);
            // 
            // buttonÇek
            // 
            this.buttonÇek.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonÇek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÇek.ForeColor = System.Drawing.Color.White;
            this.buttonÇek.Location = new System.Drawing.Point(205, 263);
            this.buttonÇek.Name = "buttonÇek";
            this.buttonÇek.Size = new System.Drawing.Size(156, 56);
            this.buttonÇek.TabIndex = 1;
            this.buttonÇek.Text = "Çek";
            this.buttonÇek.UseVisualStyleBackColor = false;
            this.buttonÇek.Click += new System.EventHandler(this.buttonÇek_Click);
            // 
            // buttonNakit
            // 
            this.buttonNakit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNakit.ForeColor = System.Drawing.Color.White;
            this.buttonNakit.Location = new System.Drawing.Point(205, 346);
            this.buttonNakit.Name = "buttonNakit";
            this.buttonNakit.Size = new System.Drawing.Size(156, 56);
            this.buttonNakit.TabIndex = 2;
            this.buttonNakit.Text = "Kapıda ödeme";
            this.buttonNakit.UseVisualStyleBackColor = false;
            this.buttonNakit.Click += new System.EventHandler(this.buttonNakit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödeme yöntemi seçin";
            // 
            // ÖdemeYöntemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNakit);
            this.Controls.Add(this.buttonÇek);
            this.Controls.Add(this.buttonKart);
            this.Name = "ÖdemeYöntemi";
            this.Text = "ÖdemeYöntemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKart;
        private System.Windows.Forms.Button buttonÇek;
        private System.Windows.Forms.Button buttonNakit;
        private System.Windows.Forms.Label label1;
    }
}