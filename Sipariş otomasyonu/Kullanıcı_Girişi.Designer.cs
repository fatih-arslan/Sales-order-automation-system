
namespace Sipariş_otomasyonu
{
    partial class Kullanıcı_Girişi
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
            this.textBoxKa = new System.Windows.Forms.TextBox();
            this.textBoxŞifre = new System.Windows.Forms.TextBox();
            this.buttonGiriş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // textBoxKa
            // 
            this.textBoxKa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKa.Location = new System.Drawing.Point(213, 184);
            this.textBoxKa.Name = "textBoxKa";
            this.textBoxKa.Size = new System.Drawing.Size(153, 24);
            this.textBoxKa.TabIndex = 3;
            // 
            // textBoxŞifre
            // 
            this.textBoxŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxŞifre.Location = new System.Drawing.Point(213, 251);
            this.textBoxŞifre.Name = "textBoxŞifre";
            this.textBoxŞifre.PasswordChar = '*';
            this.textBoxŞifre.Size = new System.Drawing.Size(153, 24);
            this.textBoxŞifre.TabIndex = 4;
            // 
            // buttonGiriş
            // 
            this.buttonGiriş.BackColor = System.Drawing.Color.Chocolate;
            this.buttonGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiriş.ForeColor = System.Drawing.Color.White;
            this.buttonGiriş.Location = new System.Drawing.Point(175, 369);
            this.buttonGiriş.Name = "buttonGiriş";
            this.buttonGiriş.Size = new System.Drawing.Size(161, 54);
            this.buttonGiriş.TabIndex = 5;
            this.buttonGiriş.Text = "Giriş Yap";
            this.buttonGiriş.UseVisualStyleBackColor = false;
            this.buttonGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanıcı_Girişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 575);
            this.Controls.Add(this.buttonGiriş);
            this.Controls.Add(this.textBoxŞifre);
            this.Controls.Add(this.textBoxKa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanıcı_Girişi";
            this.Text = "Kullanıcı_Girişi";
            this.Load += new System.EventHandler(this.Kullanıcı_Girişi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxŞifre;
        private System.Windows.Forms.Button buttonGiriş;
        public System.Windows.Forms.TextBox textBoxKa;
    }
}