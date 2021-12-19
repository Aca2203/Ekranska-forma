
namespace Ekranska_forma
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
            this.TXT_brojRacuna = new System.Windows.Forms.TextBox();
            this.TXT_kupac = new System.Windows.Forms.TextBox();
            this.TXT_datum = new System.Windows.Forms.TextBox();
            this.TXT_vrednost = new System.Windows.Forms.TextBox();
            this.TXT_brojStavki = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.napred = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.nazadMAX = new System.Windows.Forms.Button();
            this.napredMAX = new System.Windows.Forms.Button();
            this.promeni = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Број рачуна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Купац:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Датум:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вредност:";
            // 
            // TXT_brojRacuna
            // 
            this.TXT_brojRacuna.Location = new System.Drawing.Point(182, 30);
            this.TXT_brojRacuna.Name = "TXT_brojRacuna";
            this.TXT_brojRacuna.Size = new System.Drawing.Size(185, 22);
            this.TXT_brojRacuna.TabIndex = 4;
            // 
            // TXT_kupac
            // 
            this.TXT_kupac.Location = new System.Drawing.Point(182, 71);
            this.TXT_kupac.Name = "TXT_kupac";
            this.TXT_kupac.Size = new System.Drawing.Size(185, 22);
            this.TXT_kupac.TabIndex = 5;
            // 
            // TXT_datum
            // 
            this.TXT_datum.Location = new System.Drawing.Point(182, 113);
            this.TXT_datum.Name = "TXT_datum";
            this.TXT_datum.Size = new System.Drawing.Size(185, 22);
            this.TXT_datum.TabIndex = 6;
            // 
            // TXT_vrednost
            // 
            this.TXT_vrednost.Location = new System.Drawing.Point(182, 157);
            this.TXT_vrednost.Name = "TXT_vrednost";
            this.TXT_vrednost.Size = new System.Drawing.Size(185, 22);
            this.TXT_vrednost.TabIndex = 7;
            // 
            // TXT_brojStavki
            // 
            this.TXT_brojStavki.Location = new System.Drawing.Point(182, 200);
            this.TXT_brojStavki.Name = "TXT_brojStavki";
            this.TXT_brojStavki.Size = new System.Drawing.Size(185, 22);
            this.TXT_brojStavki.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Број ставки:";
            // 
            // napred
            // 
            this.napred.Location = new System.Drawing.Point(241, 316);
            this.napred.Name = "napred";
            this.napred.Size = new System.Drawing.Size(75, 23);
            this.napred.TabIndex = 10;
            this.napred.Text = ">";
            this.napred.UseVisualStyleBackColor = true;
            this.napred.Click += new System.EventHandler(this.napred_Click);
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(142, 316);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 11;
            this.nazad.Text = "<";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // nazadMAX
            // 
            this.nazadMAX.Location = new System.Drawing.Point(51, 316);
            this.nazadMAX.Name = "nazadMAX";
            this.nazadMAX.Size = new System.Drawing.Size(75, 23);
            this.nazadMAX.TabIndex = 12;
            this.nazadMAX.Text = "<<<";
            this.nazadMAX.UseVisualStyleBackColor = true;
            this.nazadMAX.Click += new System.EventHandler(this.nazadMAX_Click);
            // 
            // napredMAX
            // 
            this.napredMAX.Location = new System.Drawing.Point(335, 316);
            this.napredMAX.Name = "napredMAX";
            this.napredMAX.Size = new System.Drawing.Size(75, 23);
            this.napredMAX.TabIndex = 13;
            this.napredMAX.Text = ">>>";
            this.napredMAX.UseVisualStyleBackColor = true;
            this.napredMAX.Click += new System.EventHandler(this.napredMAX_Click);
            // 
            // promeni
            // 
            this.promeni.Location = new System.Drawing.Point(161, 264);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(145, 33);
            this.promeni.TabIndex = 15;
            this.promeni.Text = "Промени";
            this.promeni.UseVisualStyleBackColor = true;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(316, 264);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(125, 33);
            this.obrisi.TabIndex = 16;
            this.obrisi.Text = "Обриши";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(19, 264);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(124, 33);
            this.dodaj.TabIndex = 14;
            this.dodaj.Text = "Додај";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 374);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.napredMAX);
            this.Controls.Add(this.nazadMAX);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.napred);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_brojStavki);
            this.Controls.Add(this.TXT_vrednost);
            this.Controls.Add(this.TXT_datum);
            this.Controls.Add(this.TXT_kupac);
            this.Controls.Add(this.TXT_brojRacuna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_brojRacuna;
        private System.Windows.Forms.TextBox TXT_kupac;
        private System.Windows.Forms.TextBox TXT_datum;
        private System.Windows.Forms.TextBox TXT_vrednost;
        private System.Windows.Forms.TextBox TXT_brojStavki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button napred;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button nazadMAX;
        private System.Windows.Forms.Button napredMAX;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Button dodaj;
    }
}

