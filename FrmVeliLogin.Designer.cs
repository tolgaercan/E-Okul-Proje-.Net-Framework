
namespace E_Okul_Proje
{
    partial class FrmVeliLogin
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.msktxtTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(482, 218);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(259, 22);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.Text = "123456";
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // msktxtTc
            // 
            this.msktxtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtTc.Location = new System.Drawing.Point(482, 152);
            this.msktxtTc.Mask = "00000000000";
            this.msktxtTc.Name = "msktxtTc";
            this.msktxtTc.Size = new System.Drawing.Size(259, 27);
            this.msktxtTc.TabIndex = 16;
            this.msktxtTc.Text = "44444444444";
            this.msktxtTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(397, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(297, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Veli TC No:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(533, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Okul_Proje.Properties.Resources.veli;
            this.pictureBox1.Location = new System.Drawing.Point(59, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVeliLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.msktxtTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmVeliLogin";
            this.Text = "FrmVeliLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox msktxtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}