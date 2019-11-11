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
    public partial class FormEkle : Form
    {
        public Ogrenci yeniOgrBilgileri = new Ogrenci();
        private int theBiggestId;
        public FormEkle(int n)
        {
            theBiggestId = n;
            InitializeComponent();
        }

        public FormEkle()
        {
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            Ogrenci ogr = new Ogrenci();

            ogr.Id = Convert.ToInt32(txtIdEkle.Text);
            ogr.Ad = txtAdEkle.Text;
            ogr.Soyad = txtSoyadEkle.Text;
            ogr.DogumYeri = cmbSehirEkle.SelectedItem.ToString();
            ogr.DogumTarih = dateTimePickerDogumTarihiEkle.Value;
            ogr.KursBitisTarih = dateTimePickerKursBitisEkle.Value;

            yeniOgrBilgileri = ogr;
            this.Hide();

        }
        private void FormEkle_Load(object sender, EventArgs e)
        {
            this.txtIdEkle.Text = (theBiggestId + 1).ToString();
            ComboSehirDoldur();
            this.cmbSehirEkle.SelectedIndex = 0;
        }
        private int FindTheBiggestIdNumber()
        {
            int idBiggest = 1;
            return idBiggest;
        }
        private void ComboSehirDoldur()
        {
            this.cmbSehirEkle.Items.Clear();
            BAU cls = new BAU();

            foreach (string item in cls.SehirlerArray)
            {
                this.cmbSehirEkle.Items.Add(item);
            }
            //this.cmbSehirEkle.Items.AddRange(cls.SehirlerArray);
        }
    }
}

