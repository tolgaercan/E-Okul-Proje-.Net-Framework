
namespace E_Okul_Proje
{
    partial class FrmOgrenciGirisPaneli
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
            this.tndersprog = new System.Windows.Forms.Button();
            this.btnsınavtakvim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnnot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTGRDWLİSTE = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdSOYAD = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRDWLİSTE)).BeginInit();
            this.SuspendLayout();
            // 
            // tndersprog
            // 
            this.tndersprog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tndersprog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tndersprog.Location = new System.Drawing.Point(23, 224);
            this.tndersprog.Name = "tndersprog";
            this.tndersprog.Size = new System.Drawing.Size(220, 102);
            this.tndersprog.TabIndex = 7;
            this.tndersprog.Text = "Ders Programı Görüntüle";
            this.tndersprog.UseVisualStyleBackColor = false;
            this.tndersprog.Click += new System.EventHandler(this.tndersprog_Click);
            // 
            // btnsınavtakvim
            // 
            this.btnsınavtakvim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsınavtakvim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsınavtakvim.Location = new System.Drawing.Point(23, 326);
            this.btnsınavtakvim.Name = "btnsınavtakvim";
            this.btnsınavtakvim.Size = new System.Drawing.Size(220, 102);
            this.btnsınavtakvim.TabIndex = 6;
            this.btnsınavtakvim.Text = "Sınav Takvimi Görüntüle";
            this.btnsınavtakvim.UseVisualStyleBackColor = false;
            this.btnsınavtakvim.Click += new System.EventHandler(this.btnsınavtakvim_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(23, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 102);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bilgi Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnot
            // 
            this.btnnot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnot.Location = new System.Drawing.Point(23, 122);
            this.btnnot.Name = "btnnot";
            this.btnnot.Size = new System.Drawing.Size(220, 102);
            this.btnnot.TabIndex = 4;
            this.btnnot.Text = "Not Görüntüle";
            this.btnnot.UseVisualStyleBackColor = false;
            this.btnnot.Click += new System.EventHandler(this.btnnot_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTC);
            this.panel1.Controls.Add(this.lblAdSOYAD);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 102);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DTGRDWLİSTE
            // 
            this.DTGRDWLİSTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRDWLİSTE.Location = new System.Drawing.Point(261, 12);
            this.DTGRDWLİSTE.Name = "DTGRDWLİSTE";
            this.DTGRDWLİSTE.RowHeadersWidth = 51;
            this.DTGRDWLİSTE.RowTemplate.Height = 24;
            this.DTGRDWLİSTE.Size = new System.Drawing.Size(527, 416);
            this.DTGRDWLİSTE.TabIndex = 9;
            this.DTGRDWLİSTE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGRDWLİSTE_CellContentClick);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTC.Location = new System.Drawing.Point(29, 52);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(0, 17);
            this.lblTC.TabIndex = 3;
            // 
            // lblAdSOYAD
            // 
            this.lblAdSOYAD.AutoSize = true;
            this.lblAdSOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAdSOYAD.Location = new System.Drawing.Point(29, 15);
            this.lblAdSOYAD.Name = "lblAdSOYAD";
            this.lblAdSOYAD.Size = new System.Drawing.Size(0, 17);
            this.lblAdSOYAD.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(374, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 102);
            this.button1.TabIndex = 10;
            this.button1.Text = "OYUN OYNA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrenciGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTGRDWLİSTE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tndersprog);
            this.Controls.Add(this.btnsınavtakvim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnot);
            this.Name = "FrmOgrenciGirisPaneli";
            this.Text = "FrmOgrenciGirisPaneli";
            this.Load += new System.EventHandler(this.FrmOgrenciGirisPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRDWLİSTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tndersprog;
        private System.Windows.Forms.Button btnsınavtakvim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnnot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DTGRDWLİSTE;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdSOYAD;
        private System.Windows.Forms.Button button1;
    }
}