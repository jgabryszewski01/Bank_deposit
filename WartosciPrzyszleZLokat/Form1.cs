using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WartosciPrzyszleZLokat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            double wpłacone = Convert.ToDouble(tbKwotaWpłacana.Text);
            double oprocentowanie = Convert.ToDouble(tbOprocentowanie.Text);
            double inflacja = Convert.ToDouble(tbInflacja.Text);
            double podatek = Convert.ToDouble(tbPodatek.Text);
            double utrzymanie = Convert.ToDouble(tbUtrzymanie.Text);
            double stan_konta = wpłacone;
            int rok = 2021;

            while (stan_konta > 0)
            {
                rok++;
                stan_konta = ((stan_konta *(1 + (oprocentowanie)/100)) * ((100-inflacja)/100) - utrzymanie) * ((100-podatek)/100);
                if (stan_konta < 0) { stan_konta = 0; }
                lblWynik.Text = lblWynik.Text + "W roku " + Convert.ToString(rok) + ": " + Convert.ToString(stan_konta) + "\n";
            }
        }

        private void btnOblicz2_Click(object sender, EventArgs e)
        {
            double wpłacone = Convert.ToDouble(tbKwotaWpłacana2.Text);
            double oprocentowanie = Convert.ToDouble(tbOprocentowanie2.Text);
            double inflacja = Convert.ToDouble(tbInflacja2.Text);
            double podatek = Convert.ToDouble(tbPodatek2.Text);
            double liczba_lat = Convert.ToDouble(tbLata2.Text);

            lblWynik2.Text = "Wartość końcowa wyniesie: " + Convert.ToString((wpłacone * Math.Pow(((double)oprocentowanie)/100+1, liczba_lat) - ((wpłacone * Math.Pow(((double)oprocentowanie) / 100 + 1, liczba_lat) - wpłacone) * (podatek/100)))*(1-(inflacja/100)));
            
        }
    }
}
