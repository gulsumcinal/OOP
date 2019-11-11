using OOPProject03;
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
    public partial class FormDegistir : Form
    {
        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        public FormDegistir()
        {
            InitializeComponent();
        }

        private void FormDegistir_Load(object sender, EventArgs e)
        {
            ComboSehirDoldur();
            this.txtIdDegistir.Text = seciliOgrBilgileri.Id.ToString();
            this.txtAdDegistir.Text = seciliOgrBilgileri.Ad;
            this.txtSoyadDegistir.Text = seciliOgrBilgileri.Soyad;
            this.cmbSehirDegistir.Text = seciliOgrBilgileri.DogumYeri;
            //cmbSehirDegistir.SelectedIndex = cmbSehirDegistir.FindStringExact(this.cmbSehirDegistir.Text);
            this.dtpDogTrhDegistir.Value = seciliOgrBilgileri.DogumTarih;
            this.dtpKursBitisDeg.Value = seciliOgrBilgileri.KursBitisTarih;
        }
        private void ComboSehirDoldur()
        {
            this.cmbSehirDegistir.Items.Clear();
            BAU cls = new BAU();

            foreach (string item in cls.SehirlerArray)
            {
                this.cmbSehirDegistir.Items.Add(item);
            }
        }

        private void btnDegistirFrm_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Id = Convert.ToInt32(this.txtIdDegistir.Text);
            ogr.Ad = this.txtAdDegistir.Text;
            ogr.Soyad = this.txtSoyadDegistir.Text;
            //ogr.DogumYeri = this.cmbSehirDegistir.SelectedItem.ToString();
            ogr.DogumYeri = this.cmbSehirDegistir.Text;
            ogr.DogumTarih = this.dtpDogTrhDegistir.Value;
            ogr.KursBitisTarih = this.dtpKursBitisDeg.Value;

            seciliOgrBilgileri = ogr;

            this.Hide();
        }
    }
}

