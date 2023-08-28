
namespace E_Okul_Proje
{
    partial class FrmVeliGirisPaneli
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
            this.DTGRDWLİSTE = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdSOYAD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tndersprog = new System.Windows.Forms.Button();
            this.btnsınavtakvim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnnot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRDWLİSTE)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGRDWLİSTE
            // 
            this.DTGRDWLİSTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRDWLİSTE.Location = new System.Drawing.Point(264, 140);
            this.DTGRDWLİSTE.Name = "DTGRDWLİSTE";
            this.DTGRDWLİSTE.RowHeadersWidth = 51;
            this.DTGRDWLİSTE.RowTemplate.Height = 24;
            this.DTGRDWLİSTE.Size = new System.Drawing.Size(516, 289);
            this.DTGRDWLİSTE.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTC);
            this.panel1.Controls.Add(this.lblAdSOYAD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(264, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 102);
            this.panel1.TabIndex = 14;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTC.Location = new System.Drawing.Point(168, 56);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(0, 17);
            this.lblTC.TabIndex = 3;
            // 
            // lblAdSOYAD
            // 
            this.lblAdSOYAD.AutoSize = true;
            this.lblAdSOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAdSOYAD.Location = new System.Drawing.Point(168, 19);
            this.lblAdSOYAD.Name = "lblAdSOYAD";
            this.lblAdSOYAD.Size = new System.Drawing.Size(0, 17);
            this.lblAdSOYAD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(69, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad Soyad:";
            // 
            // tndersprog
            // 
            this.tndersprog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tndersprog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tndersprog.Location = new System.Drawing.Point(20, 123);
            this.tndersprog.Name = "tndersprog";
            this.tndersprog.Size = new System.Drawing.Size(220, 102);
            this.tndersprog.TabIndex = 13;
            this.tndersprog.Text = "Ders Programı Görüntüle";
            this.tndersprog.UseVisualStyleBackColor = false;
            this.tndersprog.Click += new System.EventHandler(this.tndersprog_Click);
            // 
            // btnsınavtakvim
            // 
            this.btnsınavtakvim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsınavtakvim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsınavtakvim.Location = new System.Drawing.Point(20, 225);
            this.btnsınavtakvim.Name = "btnsınavtakvim";
            this.btnsınavtakvim.Size = new System.Drawing.Size(220, 102);
            this.btnsınavtakvim.TabIndex = 12;
            this.btnsınavtakvim.Text = "Sınav Takvimi Görüntüle";
            this.btnsınavtakvim.UseVisualStyleBackColor = false;
            this.btnsınavtakvim.Click += new System.EventHandler(this.btnsınavtakvim_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(20, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 102);
            this.button2.TabIndex = 11;
            this.button2.Text = "Bilgi Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnot
            // 
            this.btnnot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnot.Location = new System.Drawing.Point(20, 21);
            this.btnnot.Name = "btnnot";
            this.btnnot.Size = new System.Drawing.Size(220, 102);
            this.btnnot.TabIndex = 10;
            this.btnnot.Text = "Not Görüntüle";
            this.btnnot.UseVisualStyleBackColor = false;
            this.btnnot.Click += new System.EventHandler(this.btnnot_Click);
            // 
            // FrmVeliGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTGRDWLİSTE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tndersprog);
            this.Controls.Add(this.btnsınavtakvim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnot);
            this.Name = "FrmVeliGirisPaneli";
            this.Text = "FrmVeliGirisPaneli";
            this.Load += new System.EventHandler(this.FrmVeliGirisPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGRDWLİSTE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGRDWLİSTE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdSOYAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tndersprog;
        private System.Windows.Forms.Button btnsınavtakvim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnnot;
    }
}