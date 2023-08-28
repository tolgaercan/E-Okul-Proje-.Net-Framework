
namespace E_Okul_Proje
{
    partial class FrmOgrenciBilgiGuncelle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOgrenciİd = new System.Windows.Forms.TextBox();
            this.msktxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktxtogrenciTc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "ÖĞRENCİ BİLGİ GÜNCELLEME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(115, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "İd:";
            this.label8.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = " Şifre:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(177, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 42);
            this.button3.TabIndex = 57;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOgrenciİd
            // 
            this.txtOgrenciİd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciİd.Location = new System.Drawing.Point(151, 84);
            this.txtOgrenciİd.Name = "txtOgrenciİd";
            this.txtOgrenciİd.Size = new System.Drawing.Size(181, 27);
            this.txtOgrenciİd.TabIndex = 49;
            this.txtOgrenciİd.Visible = false;
            // 
            // msktxtSifre
            // 
            this.msktxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtSifre.Location = new System.Drawing.Point(151, 177);
            this.msktxtSifre.Mask = "000000";
            this.msktxtSifre.Name = "msktxtSifre";
            this.msktxtSifre.Size = new System.Drawing.Size(181, 27);
            this.msktxtSifre.TabIndex = 46;
            this.msktxtSifre.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(151, 115);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(181, 27);
            this.txtAdSoyad.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(106, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "TC:";
            // 
            // msktxtogrenciTc
            // 
            this.msktxtogrenciTc.Enabled = false;
            this.msktxtogrenciTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtogrenciTc.Location = new System.Drawing.Point(151, 146);
            this.msktxtogrenciTc.Mask = "00000000000";
            this.msktxtogrenciTc.Name = "msktxtogrenciTc";
            this.msktxtogrenciTc.Size = new System.Drawing.Size(181, 27);
            this.msktxtogrenciTc.TabIndex = 45;
            this.msktxtogrenciTc.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ad Soyad:";
            // 
            // FrmOgrenciBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(436, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtOgrenciİd);
            this.Controls.Add(this.msktxtSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msktxtogrenciTc);
            this.Controls.Add(this.label6);
            this.Name = "FrmOgrenciBilgiGuncelle";
            this.Text = "FrmOgrenciBilgiGuncelle";
            this.Load += new System.EventHandler(this.FrmOgrenciBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOgrenciİd;
        private System.Windows.Forms.MaskedTextBox msktxtSifre;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktxtogrenciTc;
        private System.Windows.Forms.Label label6;
    }
}