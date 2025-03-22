namespace Aplikasi_Menggambar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJajarGenjang = new System.Windows.Forms.Button();
            this.btnLingkaran = new System.Windows.Forms.Button();
            this.btnSegitiga = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPersegi = new System.Windows.Forms.Button();
            this.btnPersegiPanjang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(146, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 400);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnJajarGenjang
            // 
            this.btnJajarGenjang.Location = new System.Drawing.Point(739, 420);
            this.btnJajarGenjang.Name = "btnJajarGenjang";
            this.btnJajarGenjang.Size = new System.Drawing.Size(100, 25);
            this.btnJajarGenjang.TabIndex = 0;
            this.btnJajarGenjang.Text = "Jajar Genjang";
            this.btnJajarGenjang.UseVisualStyleBackColor = true;
            this.btnJajarGenjang.Click += new System.EventHandler(this.btnJajarGenjang_Click);
            // 
            // btnLingkaran
            // 
            this.btnLingkaran.Location = new System.Drawing.Point(300, 420);
            this.btnLingkaran.Name = "btnLingkaran";
            this.btnLingkaran.Size = new System.Drawing.Size(100, 25);
            this.btnLingkaran.TabIndex = 1;
            this.btnLingkaran.Text = "Lingkaran";
            this.btnLingkaran.UseVisualStyleBackColor = true;
            this.btnLingkaran.Click += new System.EventHandler(this.btnLingkaran_Click);
            // 
            // btnSegitiga
            // 
            this.btnSegitiga.Location = new System.Drawing.Point(400, 420);
            this.btnSegitiga.Name = "btnSegitiga";
            this.btnSegitiga.Size = new System.Drawing.Size(100, 25);
            this.btnSegitiga.TabIndex = 2;
            this.btnSegitiga.Text = "Segitiga";
            this.btnSegitiga.UseVisualStyleBackColor = true;
            this.btnSegitiga.Click += new System.EventHandler(this.btnSegitiga_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(470, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 100);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Canvas";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPersegi
            // 
            this.btnPersegi.Location = new System.Drawing.Point(500, 420);
            this.btnPersegi.Name = "btnPersegi";
            this.btnPersegi.Size = new System.Drawing.Size(100, 25);
            this.btnPersegi.TabIndex = 6;
            this.btnPersegi.Text = "Persegi";
            this.btnPersegi.UseVisualStyleBackColor = true;
            this.btnPersegi.Click += new System.EventHandler(this.btnPersegi_Click);
            // 
            // btnPersegiPanjang
            // 
            this.btnPersegiPanjang.Location = new System.Drawing.Point(600, 420);
            this.btnPersegiPanjang.Name = "btnPersegiPanjang";
            this.btnPersegiPanjang.Size = new System.Drawing.Size(138, 25);
            this.btnPersegiPanjang.TabIndex = 7;
            this.btnPersegiPanjang.Text = "Persegi Panjang";
            this.btnPersegiPanjang.UseVisualStyleBackColor = true;
            this.btnPersegiPanjang.Click += new System.EventHandler(this.btnPersegiPanjang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 558);
            this.Controls.Add(this.btnPersegiPanjang);
            this.Controls.Add(this.btnPersegi);
            this.Controls.Add(this.btnJajarGenjang);
            this.Controls.Add(this.btnLingkaran);
            this.Controls.Add(this.btnSegitiga);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJajarGenjang;
        private System.Windows.Forms.Button btnLingkaran;
        private System.Windows.Forms.Button btnSegitiga;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPersegi;
        private System.Windows.Forms.Button btnPersegiPanjang;
    }
}

