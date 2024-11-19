namespace P6_3_714230001
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelHuruf = new System.Windows.Forms.Label();
            this.LabelAngka = new System.Windows.Forms.Label();
            this.LabelEmai = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabelAngka1 = new System.Windows.Forms.Label();
            this.LabelAngka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textAngka1 = new System.Windows.Forms.TextBox();
            this.textAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHuruf
            // 
            this.LabelHuruf.AutoSize = true;
            this.LabelHuruf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHuruf.Location = new System.Drawing.Point(57, 43);
            this.LabelHuruf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHuruf.Name = "LabelHuruf";
            this.LabelHuruf.Size = new System.Drawing.Size(62, 26);
            this.LabelHuruf.TabIndex = 0;
            this.LabelHuruf.Text = "Huruf";
            this.LabelHuruf.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelAngka
            // 
            this.LabelAngka.AutoSize = true;
            this.LabelAngka.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAngka.Location = new System.Drawing.Point(57, 103);
            this.LabelAngka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAngka.Name = "LabelAngka";
            this.LabelAngka.Size = new System.Drawing.Size(66, 26);
            this.LabelAngka.TabIndex = 1;
            this.LabelAngka.Text = "Angka";
            // 
            // LabelEmai
            // 
            this.LabelEmai.AutoSize = true;
            this.LabelEmai.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmai.Location = new System.Drawing.Point(57, 163);
            this.LabelEmai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmai.Name = "LabelEmai";
            this.LabelEmai.Size = new System.Drawing.Size(63, 26);
            this.LabelEmai.TabIndex = 2;
            this.LabelEmai.Text = "Email";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Red;
            this.Label4.Location = new System.Drawing.Point(57, 208);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(185, 26);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "* Angka 1 > Angka 2";
            // 
            // LabelAngka1
            // 
            this.LabelAngka1.AutoSize = true;
            this.LabelAngka1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAngka1.Location = new System.Drawing.Point(57, 249);
            this.LabelAngka1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAngka1.Name = "LabelAngka1";
            this.LabelAngka1.Size = new System.Drawing.Size(82, 26);
            this.LabelAngka1.TabIndex = 4;
            this.LabelAngka1.Text = "Angka 1";
            // 
            // LabelAngka2
            // 
            this.LabelAngka2.AutoSize = true;
            this.LabelAngka2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAngka2.Location = new System.Drawing.Point(57, 311);
            this.LabelAngka2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAngka2.Name = "LabelAngka2";
            this.LabelAngka2.Size = new System.Drawing.Size(82, 26);
            this.LabelAngka2.TabIndex = 5;
            this.LabelAngka2.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuruf.Location = new System.Drawing.Point(282, 35);
            this.txtHuruf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(148, 30);
            this.txtHuruf.TabIndex = 6;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka.Location = new System.Drawing.Point(282, 95);
            this.txtAngka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(148, 30);
            this.txtAngka.TabIndex = 7;
            this.txtAngka.TextChanged += new System.EventHandler(this.txtAngka_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(282, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 30);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // textAngka1
            // 
            this.textAngka1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka1.Location = new System.Drawing.Point(282, 242);
            this.textAngka1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(148, 30);
            this.textAngka1.TabIndex = 9;
            this.textAngka1.TextChanged += new System.EventHandler(this.textAngka1_TextChanged);
            this.textAngka1.Leave += new System.EventHandler(this.textAngka1_Leave);
            // 
            // textAngka2
            // 
            this.textAngka2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAngka2.Location = new System.Drawing.Point(282, 303);
            this.textAngka2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(148, 30);
            this.textAngka2.TabIndex = 10;
            this.textAngka2.TextChanged += new System.EventHandler(this.textAngka2_TextChanged);
            this.textAngka2.Leave += new System.EventHandler(this.textAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(536, 449);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.textAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.LabelAngka2);
            this.Controls.Add(this.LabelAngka1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LabelEmai);
            this.Controls.Add(this.LabelAngka);
            this.Controls.Add(this.LabelHuruf);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHuruf;
        private System.Windows.Forms.Label LabelAngka;
        private System.Windows.Forms.Label LabelEmai;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label LabelAngka1;
        private System.Windows.Forms.Label LabelAngka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textAngka1;
        private System.Windows.Forms.TextBox textAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

