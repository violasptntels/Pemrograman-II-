namespace P9_714230001
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxNPM = new System.Windows.Forms.TextBox();
            this.textboxNama = new System.Windows.Forms.TextBox();
            this.textboxAlamat = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxNohp = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data mahasiswa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxAngkatan);
            this.groupBox2.Controls.Add(this.textboxNohp);
            this.groupBox2.Controls.Add(this.textboxEmail);
            this.groupBox2.Controls.Add(this.textboxAlamat);
            this.groupBox2.Controls.Add(this.textboxNama);
            this.groupBox2.Controls.Add(this.textboxNPM);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(553, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 179);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angkatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "No HP";
            // 
            // textboxNPM
            // 
            this.textboxNPM.Location = new System.Drawing.Point(80, 22);
            this.textboxNPM.Name = "textboxNPM";
            this.textboxNPM.Size = new System.Drawing.Size(342, 23);
            this.textboxNPM.TabIndex = 6;
            // 
            // textboxNama
            // 
            this.textboxNama.Location = new System.Drawing.Point(80, 57);
            this.textboxNama.Name = "textboxNama";
            this.textboxNama.Size = new System.Drawing.Size(342, 23);
            this.textboxNama.TabIndex = 7;
            // 
            // textboxAlamat
            // 
            this.textboxAlamat.Location = new System.Drawing.Point(80, 120);
            this.textboxAlamat.Name = "textboxAlamat";
            this.textboxAlamat.Size = new System.Drawing.Size(342, 23);
            this.textboxAlamat.TabIndex = 8;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(80, 153);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(342, 23);
            this.textboxEmail.TabIndex = 9;
            // 
            // textboxNohp
            // 
            this.textboxNohp.Location = new System.Drawing.Point(80, 187);
            this.textboxNohp.Name = "textboxNohp";
            this.textboxNohp.Size = new System.Drawing.Size(342, 23);
            this.textboxNohp.TabIndex = 10;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Location = new System.Drawing.Point(80, 88);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(342, 26);
            this.comboBoxAngkatan.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(290, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(16, 71);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(290, 26);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(16, 107);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(290, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(16, 137);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(290, 27);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(6, 17);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Size = new System.Drawing.Size(841, 172);
            this.DataMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ULBI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textboxNPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNohp;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxAlamat;
        private System.Windows.Forms.TextBox textboxNama;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
    }
}

