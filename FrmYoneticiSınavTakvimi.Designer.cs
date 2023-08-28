
namespace E_Okul_Proje
{
    partial class FrmYoneticiSınavTakvimi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktxtsınavsaat = new System.Windows.Forms.MaskedTextBox();
            this.msktxtsınavtarih = new System.Windows.Forms.MaskedTextBox();
            this.txtdersad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(197, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ders Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sınav Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sınav Tarihi";
            // 
            // msktxtsınavsaat
            // 
            this.msktxtsınavsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtsınavsaat.Location = new System.Drawing.Point(148, 156);
            this.msktxtsınavsaat.Mask = "90:00";
            this.msktxtsınavsaat.Name = "msktxtsınavsaat";
            this.msktxtsınavsaat.Size = new System.Drawing.Size(214, 28);
            this.msktxtsınavsaat.TabIndex = 7;
            this.msktxtsınavsaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtsınavtarih
            // 
            this.msktxtsınavtarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtsınavtarih.Location = new System.Drawing.Point(148, 105);
            this.msktxtsınavtarih.Mask = "00/00/0000";
            this.msktxtsınavtarih.Name = "msktxtsınavtarih";
            this.msktxtsınavtarih.Size = new System.Drawing.Size(214, 28);
            this.msktxtsınavtarih.TabIndex = 8;
            this.msktxtsınavtarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtdersad
            // 
            this.txtdersad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdersad.Location = new System.Drawing.Point(148, 47);
            this.txtdersad.Name = "txtdersad";
            this.txtdersad.Size = new System.Drawing.Size(214, 28);
            this.txtdersad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sınav İd:";
            this.label4.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(148, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(214, 22);
            this.txtid.TabIndex = 12;
            this.txtid.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(197, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 71);
            this.button4.TabIndex = 13;
            this.button4.Text = "YENİLE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmYoneticiSınavTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdersad);
            this.Controls.Add(this.msktxtsınavtarih);
            this.Controls.Add(this.msktxtsınavsaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "FrmYoneticiSınavTakvimi";
            this.Text = "FrmYoneticiSınavTakvimi";
            this.Load += new System.EventHandler(this.FrmYoneticiSınavTakvimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxtsınavsaat;
        private System.Windows.Forms.MaskedTextBox msktxtsınavtarih;
        private System.Windows.Forms.TextBox txtdersad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button4;
    }
}