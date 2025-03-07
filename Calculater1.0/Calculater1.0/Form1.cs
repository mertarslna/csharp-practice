using System;
using System.Windows.Forms;

namespace Calculater1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 + sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc.ToString();
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {

            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 - sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc.ToString();
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {

            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 * sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc.ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {

            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            if (sayi2 != 0)
            {
                double sonuc = sayi1 / sayi2;
                lblSonuc.Text = "Sonuç: " + sonuc.ToString();
            }
            else
            {
                lblSonuc.Text = "Hata: Sıfıra bölme hatası!";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
