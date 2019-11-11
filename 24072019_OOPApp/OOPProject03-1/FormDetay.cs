using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject03_1
{
    public partial class FormDetay : Form
    {
        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        public FormDetay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(lblYasadiniz.Visible)
            //{
            //    lblYasadiniz.Visible = false;
            //}
            //else
            //{
            //    lblYasadiniz.Visible = true;
            //}

            // Ternary Operator ile tek satırda yazma
            var res = lblYasadiniz.Visible ? lblYasadiniz.Visible = false : lblYasadiniz.Visible = true;
        }

        private void FormDetay_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            this.txtId.Text = seciliOgrBilgileri.Id.ToString();
            this.txtAd.Text = seciliOgrBilgileri.Ad;
            this.txtSoyad.Text = seciliOgrBilgileri.Soyad;
            this.cmbDgmYeriDetay.Text = seciliOgrBilgileri.DogumYeri;

            int yilFarki = DateTime.Now.Year - seciliOgrBilgileri.DogumTarih.Year;
            this.txtYas.Text = yilFarki.ToString();

            double gunFarki = (DateTime.Now - seciliOgrBilgileri.DogumTarih).TotalDays;
            this.txtToplamGun.Text = gunFarki.ToString();

            double saatFarki = (DateTime.Now - seciliOgrBilgileri.DogumTarih).TotalHours;
            this.txtToplamSaat.Text = saatFarki.ToString();

            double dakikaFarki = (DateTime.Now - seciliOgrBilgileri.DogumTarih).TotalMinutes;
            this.txtToplamDk.Text = dakikaFarki.ToString();

            double saniyeFarki = (DateTime.Now - seciliOgrBilgileri.DogumTarih).TotalSeconds;
            this.txtToplamSaniye.Text = saniyeFarki.ToString();

            double milisaniyeFarki = (DateTime.Now - seciliOgrBilgileri.DogumTarih).TotalMilliseconds;
            this.txtToplamMilisaniye.Text = milisaniyeFarki.ToString();
        }

        private void cmbDgmYeriDetay_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormEkle frmEkle = new FormEkle();
        }
    }
}
