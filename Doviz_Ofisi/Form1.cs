using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(today);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod= 'USD']/BanknoteBuying").InnerXml;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod= 'USD']/BanknoteSelling").InnerXml;
            string euralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod= 'EUR']/BanknoteBuying").InnerXml;
            string eursatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod= 'EUR']/BanknoteSelling").InnerXml;
            LblDolarAlis.Text = dolaralis;
            LblDolarSatis.Text = dolarsatis;
            LblEurAlis.Text = euralis;
            LblEurSatis.Text = eursatis;

        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = LblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = LblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = LblEurAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = LblEurSatis.Text;
        }
        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % tutar;
            txtKalan.Text = kalan.ToString();
        }
    }
}
