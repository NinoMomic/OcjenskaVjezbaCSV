namespace OcjenskaVjezbaKolekcije
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxGodiste = new System.Windows.Forms.TextBox();
            this.comboBoxSpol = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spol:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(32, 46);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIme.TabIndex = 4;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(32, 85);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrezime.TabIndex = 5;
            // 
            // txtBoxGodiste
            // 
            this.txtBoxGodiste.Location = new System.Drawing.Point(32, 124);
            this.txtBoxGodiste.Name = "txtBoxGodiste";
            this.txtBoxGodiste.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGodiste.TabIndex = 6;
            // 
            // comboBoxSpol
            // 
            this.comboBoxSpol.FormattingEnabled = true;
            this.comboBoxSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.comboBoxSpol.Location = new System.Drawing.Point(32, 163);
            this.comboBoxSpol.Name = "comboBoxSpol";
            this.comboBoxSpol.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSpol.TabIndex = 7;
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnUnesi.Location = new System.Drawing.Point(164, 46);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(132, 138);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnObradi.Location = new System.Drawing.Point(323, 46);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(122, 138);
            this.btnObradi.TabIndex = 9;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = false;
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIspisi.Location = new System.Drawing.Point(484, 46);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(122, 138);
            this.btnIspisi.TabIndex = 10;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(724, 132);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(633, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 138);
            this.button1.TabIndex = 12;
            this.button1.Text = "SaveFileDialog";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.comboBoxSpol);
            this.Controls.Add(this.txtBoxGodiste);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxGodiste;
        private System.Windows.Forms.ComboBox comboBoxSpol;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

