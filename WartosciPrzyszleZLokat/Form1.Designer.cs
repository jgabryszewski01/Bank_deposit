namespace WartosciPrzyszleZLokat
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWynik2 = new System.Windows.Forms.RichTextBox();
            this.btnOblicz2 = new System.Windows.Forms.Button();
            this.lblLiczbaLat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPodatek2 = new System.Windows.Forms.TextBox();
            this.tbOprocentowanie2 = new System.Windows.Forms.TextBox();
            this.tbLata2 = new System.Windows.Forms.TextBox();
            this.tbInflacja2 = new System.Windows.Forms.TextBox();
            this.tbKwotaWpłacana2 = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.RichTextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.lblUtrzymanie = new System.Windows.Forms.Label();
            this.lblPodatek = new System.Windows.Forms.Label();
            this.lblInflacja = new System.Windows.Forms.Label();
            this.lblOprocentowanie = new System.Windows.Forms.Label();
            this.lblKwotaWpłacana = new System.Windows.Forms.Label();
            this.lblPodajDane = new System.Windows.Forms.Label();
            this.tbPodatek = new System.Windows.Forms.TextBox();
            this.tbOprocentowanie = new System.Windows.Forms.TextBox();
            this.tbUtrzymanie = new System.Windows.Forms.TextBox();
            this.tbInflacja = new System.Windows.Forms.TextBox();
            this.tbKwotaWpłacana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 34);
            this.label7.TabIndex = 109;
            this.label7.Text = "Aplikacja jako rezultat ma podawać kwotę, \r\nktóra zostanie osiągnięta dla lokaty " +
    "dla podanej liczby lat.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 51);
            this.label1.TabIndex = 108;
            this.label1.Text = "Aplikacja ma wypisywać ile pozostało jeszcze kwoty w danym roku \r\ni zatrzymać się" +
    " (czyt. przestać wypisywać) w momencie, \r\nw którym skończą się środki (czyt. war" +
    "tość <=0).\r\n";
            // 
            // lblWynik2
            // 
            this.lblWynik2.Location = new System.Drawing.Point(711, 511);
            this.lblWynik2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblWynik2.Name = "lblWynik2";
            this.lblWynik2.Size = new System.Drawing.Size(431, 221);
            this.lblWynik2.TabIndex = 107;
            this.lblWynik2.Text = "";
            // 
            // btnOblicz2
            // 
            this.btnOblicz2.Location = new System.Drawing.Point(711, 418);
            this.btnOblicz2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOblicz2.Name = "btnOblicz2";
            this.btnOblicz2.Size = new System.Drawing.Size(432, 57);
            this.btnOblicz2.TabIndex = 106;
            this.btnOblicz2.Text = "Oblicz wartość przyszłą";
            this.btnOblicz2.UseVisualStyleBackColor = true;
            this.btnOblicz2.Click += new System.EventHandler(this.btnOblicz2_Click);
            // 
            // lblLiczbaLat
            // 
            this.lblLiczbaLat.AutoSize = true;
            this.lblLiczbaLat.Location = new System.Drawing.Point(707, 364);
            this.lblLiczbaLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiczbaLat.Name = "lblLiczbaLat";
            this.lblLiczbaLat.Size = new System.Drawing.Size(68, 17);
            this.lblLiczbaLat.TabIndex = 105;
            this.lblLiczbaLat.Text = "Liczba lat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Stawka podatku (w %)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Inflacja ( w %)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Oprocentowanie lokaty w skali roku (w %)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Kwota wpłacana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(707, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "Podaj dane";
            // 
            // tbPodatek2
            // 
            this.tbPodatek2.Location = new System.Drawing.Point(1009, 314);
            this.tbPodatek2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPodatek2.Name = "tbPodatek2";
            this.tbPodatek2.Size = new System.Drawing.Size(132, 22);
            this.tbPodatek2.TabIndex = 99;
            // 
            // tbOprocentowanie2
            // 
            this.tbOprocentowanie2.Location = new System.Drawing.Point(1009, 220);
            this.tbOprocentowanie2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOprocentowanie2.Name = "tbOprocentowanie2";
            this.tbOprocentowanie2.Size = new System.Drawing.Size(132, 22);
            this.tbOprocentowanie2.TabIndex = 98;
            // 
            // tbLata2
            // 
            this.tbLata2.Location = new System.Drawing.Point(1009, 361);
            this.tbLata2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLata2.Name = "tbLata2";
            this.tbLata2.Size = new System.Drawing.Size(132, 22);
            this.tbLata2.TabIndex = 97;
            // 
            // tbInflacja2
            // 
            this.tbInflacja2.Location = new System.Drawing.Point(1009, 267);
            this.tbInflacja2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInflacja2.Name = "tbInflacja2";
            this.tbInflacja2.Size = new System.Drawing.Size(132, 22);
            this.tbInflacja2.TabIndex = 96;
            // 
            // tbKwotaWpłacana2
            // 
            this.tbKwotaWpłacana2.Location = new System.Drawing.Point(1009, 175);
            this.tbKwotaWpłacana2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKwotaWpłacana2.Name = "tbKwotaWpłacana2";
            this.tbKwotaWpłacana2.Size = new System.Drawing.Size(132, 22);
            this.tbKwotaWpłacana2.TabIndex = 95;
            // 
            // lblWynik
            // 
            this.lblWynik.Location = new System.Drawing.Point(93, 511);
            this.lblWynik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(431, 221);
            this.lblWynik.TabIndex = 94;
            this.lblWynik.Text = "";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(93, 418);
            this.btnOblicz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(432, 57);
            this.btnOblicz.TabIndex = 93;
            this.btnOblicz.Text = "Oblicz ile pozostało jeszcze kwoty w kolejnych latach ";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // lblUtrzymanie
            // 
            this.lblUtrzymanie.AutoSize = true;
            this.lblUtrzymanie.Location = new System.Drawing.Point(89, 364);
            this.lblUtrzymanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtrzymanie.Name = "lblUtrzymanie";
            this.lblUtrzymanie.Size = new System.Drawing.Size(273, 17);
            this.lblUtrzymanie.TabIndex = 92;
            this.lblUtrzymanie.Text = "Kwota pozwalająca utrzymać się przez rok";
            // 
            // lblPodatek
            // 
            this.lblPodatek.AutoSize = true;
            this.lblPodatek.Location = new System.Drawing.Point(89, 318);
            this.lblPodatek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodatek.Name = "lblPodatek";
            this.lblPodatek.Size = new System.Drawing.Size(147, 17);
            this.lblPodatek.TabIndex = 91;
            this.lblPodatek.Text = "Stawka podatku (w %)";
            // 
            // lblInflacja
            // 
            this.lblInflacja.AutoSize = true;
            this.lblInflacja.Location = new System.Drawing.Point(89, 271);
            this.lblInflacja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInflacja.Name = "lblInflacja";
            this.lblInflacja.Size = new System.Drawing.Size(95, 17);
            this.lblInflacja.TabIndex = 90;
            this.lblInflacja.Text = "Inflacja ( w %)";
            // 
            // lblOprocentowanie
            // 
            this.lblOprocentowanie.AutoSize = true;
            this.lblOprocentowanie.Location = new System.Drawing.Point(89, 224);
            this.lblOprocentowanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOprocentowanie.Name = "lblOprocentowanie";
            this.lblOprocentowanie.Size = new System.Drawing.Size(268, 17);
            this.lblOprocentowanie.TabIndex = 89;
            this.lblOprocentowanie.Text = "Oprocentowanie lokaty w skali roku (w %)";
            // 
            // lblKwotaWpłacana
            // 
            this.lblKwotaWpłacana.AutoSize = true;
            this.lblKwotaWpłacana.Location = new System.Drawing.Point(89, 178);
            this.lblKwotaWpłacana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKwotaWpłacana.Name = "lblKwotaWpłacana";
            this.lblKwotaWpłacana.Size = new System.Drawing.Size(109, 17);
            this.lblKwotaWpłacana.TabIndex = 88;
            this.lblKwotaWpłacana.Text = "Kwota wpłacana";
            // 
            // lblPodajDane
            // 
            this.lblPodajDane.AutoSize = true;
            this.lblPodajDane.Location = new System.Drawing.Point(89, 112);
            this.lblPodajDane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodajDane.Name = "lblPodajDane";
            this.lblPodajDane.Size = new System.Drawing.Size(80, 17);
            this.lblPodajDane.TabIndex = 87;
            this.lblPodajDane.Text = "Podaj dane";
            // 
            // tbPodatek
            // 
            this.tbPodatek.Location = new System.Drawing.Point(392, 314);
            this.tbPodatek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPodatek.Name = "tbPodatek";
            this.tbPodatek.Size = new System.Drawing.Size(132, 22);
            this.tbPodatek.TabIndex = 86;
            // 
            // tbOprocentowanie
            // 
            this.tbOprocentowanie.Location = new System.Drawing.Point(392, 220);
            this.tbOprocentowanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOprocentowanie.Name = "tbOprocentowanie";
            this.tbOprocentowanie.Size = new System.Drawing.Size(132, 22);
            this.tbOprocentowanie.TabIndex = 85;
            // 
            // tbUtrzymanie
            // 
            this.tbUtrzymanie.Location = new System.Drawing.Point(392, 361);
            this.tbUtrzymanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUtrzymanie.Name = "tbUtrzymanie";
            this.tbUtrzymanie.Size = new System.Drawing.Size(132, 22);
            this.tbUtrzymanie.TabIndex = 84;
            // 
            // tbInflacja
            // 
            this.tbInflacja.Location = new System.Drawing.Point(392, 267);
            this.tbInflacja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInflacja.Name = "tbInflacja";
            this.tbInflacja.Size = new System.Drawing.Size(132, 22);
            this.tbInflacja.TabIndex = 83;
            // 
            // tbKwotaWpłacana
            // 
            this.tbKwotaWpłacana.Location = new System.Drawing.Point(392, 175);
            this.tbKwotaWpłacana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKwotaWpłacana.Name = "tbKwotaWpłacana";
            this.tbKwotaWpłacana.Size = new System.Drawing.Size(132, 22);
            this.tbKwotaWpłacana.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 826);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWynik2);
            this.Controls.Add(this.btnOblicz2);
            this.Controls.Add(this.lblLiczbaLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPodatek2);
            this.Controls.Add(this.tbOprocentowanie2);
            this.Controls.Add(this.tbLata2);
            this.Controls.Add(this.tbInflacja2);
            this.Controls.Add(this.tbKwotaWpłacana2);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.lblUtrzymanie);
            this.Controls.Add(this.lblPodatek);
            this.Controls.Add(this.lblInflacja);
            this.Controls.Add(this.lblOprocentowanie);
            this.Controls.Add(this.lblKwotaWpłacana);
            this.Controls.Add(this.lblPodajDane);
            this.Controls.Add(this.tbPodatek);
            this.Controls.Add(this.tbOprocentowanie);
            this.Controls.Add(this.tbUtrzymanie);
            this.Controls.Add(this.tbInflacja);
            this.Controls.Add(this.tbKwotaWpłacana);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lblWynik2;
        private System.Windows.Forms.Button btnOblicz2;
        private System.Windows.Forms.Label lblLiczbaLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPodatek2;
        private System.Windows.Forms.TextBox tbOprocentowanie2;
        private System.Windows.Forms.TextBox tbLata2;
        private System.Windows.Forms.TextBox tbInflacja2;
        private System.Windows.Forms.TextBox tbKwotaWpłacana2;
        private System.Windows.Forms.RichTextBox lblWynik;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label lblUtrzymanie;
        private System.Windows.Forms.Label lblPodatek;
        private System.Windows.Forms.Label lblInflacja;
        private System.Windows.Forms.Label lblOprocentowanie;
        private System.Windows.Forms.Label lblKwotaWpłacana;
        private System.Windows.Forms.Label lblPodajDane;
        private System.Windows.Forms.TextBox tbPodatek;
        private System.Windows.Forms.TextBox tbOprocentowanie;
        private System.Windows.Forms.TextBox tbUtrzymanie;
        private System.Windows.Forms.TextBox tbInflacja;
        private System.Windows.Forms.TextBox tbKwotaWpłacana;
    }
}

