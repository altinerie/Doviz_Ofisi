namespace Doviz_Ofisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.LblEurAlis = new System.Windows.Forms.Label();
            this.LblEurSatis = new System.Windows.Forms.Label();
            this.btnDolarAl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.btnDolarSat = new System.Windows.Forms.Button();
            this.btnEuroAl = new System.Windows.Forms.Button();
            this.btnEuroSat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD Alış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "USD Satış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "EUR Alış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "EUR Satış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.Location = new System.Drawing.Point(491, 50);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(18, 18);
            this.LblDolarAlis.TabIndex = 4;
            this.LblDolarAlis.Text = "0";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.Location = new System.Drawing.Point(491, 82);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(18, 18);
            this.LblDolarSatis.TabIndex = 5;
            this.LblDolarSatis.Text = "0";
            // 
            // LblEurAlis
            // 
            this.LblEurAlis.AutoSize = true;
            this.LblEurAlis.Location = new System.Drawing.Point(491, 110);
            this.LblEurAlis.Name = "LblEurAlis";
            this.LblEurAlis.Size = new System.Drawing.Size(18, 18);
            this.LblEurAlis.TabIndex = 6;
            this.LblEurAlis.Text = "0";
            // 
            // LblEurSatis
            // 
            this.LblEurSatis.AutoSize = true;
            this.LblEurSatis.Location = new System.Drawing.Point(491, 138);
            this.LblEurSatis.Name = "LblEurSatis";
            this.LblEurSatis.Size = new System.Drawing.Size(18, 18);
            this.LblEurSatis.TabIndex = 7;
            this.LblEurSatis.Text = "0";
            // 
            // btnDolarAl
            // 
            this.btnDolarAl.Location = new System.Drawing.Point(340, 48);
            this.btnDolarAl.Name = "btnDolarAl";
            this.btnDolarAl.Size = new System.Drawing.Size(45, 23);
            this.btnDolarAl.TabIndex = 8;
            this.btnDolarAl.Text = "...";
            this.btnDolarAl.UseVisualStyleBackColor = true;
            this.btnDolarAl.Click += new System.EventHandler(this.btnDolarAl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(291, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 189);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "İşlem 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(71, 116);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(165, 26);
            this.txtKalan.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(71, 83);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(165, 26);
            this.txtTutar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(71, 51);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(165, 26);
            this.txtMiktar.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(71, 19);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(165, 26);
            this.txtKur.TabIndex = 10;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // btnDolarSat
            // 
            this.btnDolarSat.Location = new System.Drawing.Point(340, 80);
            this.btnDolarSat.Name = "btnDolarSat";
            this.btnDolarSat.Size = new System.Drawing.Size(45, 23);
            this.btnDolarSat.TabIndex = 11;
            this.btnDolarSat.Text = "...";
            this.btnDolarSat.UseVisualStyleBackColor = true;
            this.btnDolarSat.Click += new System.EventHandler(this.btnDolarSat_Click);
            // 
            // btnEuroAl
            // 
            this.btnEuroAl.Location = new System.Drawing.Point(340, 109);
            this.btnEuroAl.Name = "btnEuroAl";
            this.btnEuroAl.Size = new System.Drawing.Size(45, 23);
            this.btnEuroAl.TabIndex = 12;
            this.btnEuroAl.Text = "...";
            this.btnEuroAl.UseVisualStyleBackColor = true;
            this.btnEuroAl.Click += new System.EventHandler(this.btnEuroAl_Click);
            // 
            // btnEuroSat
            // 
            this.btnEuroSat.Location = new System.Drawing.Point(340, 138);
            this.btnEuroSat.Name = "btnEuroSat";
            this.btnEuroSat.Size = new System.Drawing.Size(45, 23);
            this.btnEuroSat.TabIndex = 13;
            this.btnEuroSat.Text = "...";
            this.btnEuroSat.UseVisualStyleBackColor = true;
            this.btnEuroSat.Click += new System.EventHandler(this.btnEuroSat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "İşlem 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 523);
            this.Controls.Add(this.btnEuroSat);
            this.Controls.Add(this.btnEuroAl);
            this.Controls.Add(this.btnDolarSat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDolarAl);
            this.Controls.Add(this.LblEurSatis);
            this.Controls.Add(this.LblEurAlis);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label LblEurAlis;
        private System.Windows.Forms.Label LblEurSatis;
        private System.Windows.Forms.Button btnDolarAl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDolarSat;
        private System.Windows.Forms.Button btnEuroAl;
        private System.Windows.Forms.Button btnEuroSat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

