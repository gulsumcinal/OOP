using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProject03;

namespace OOPProject03_1
{
    public partial class Form1 : Form
    {
        // Projemizin bu katmanına UI katmanı diyebiliriz.
        // OOPProject03'te oluşturduğumuz Class Library bu projede 
        // yani OOPProject03-1'de kullanılacaktır.
        // OOPProject03 - Class Library (Veri üretmek için hazırladığımız bir kütüphanedir.)
        // OOPProject03-1 - UI (User Interface) katmanı
        // OOPProject03-1 UI katmanının , OOPProject03 class library'sini kullanabilmesi için
        // bu library'nin OOPProject03-1 projesine dahil edilmesi gerekmektedir.
        // Dahil etmek için  OOPProject03 önce referance'lara eklenir, 
        // sonra using satırı eklenir.

       
        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        //public List<Ogrenci> sonSilmeListesi = new List<Ogrenci>();
        public Dictionary<string, Ogrenci> sonIslemlerDictionary = new Dictionary<string, Ogrenci>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUretveDoldur_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci ogr = new Ogrenci();

                BAU sourceOfData = new BAU();
                ogr.Id = i;
                ogr.Ad = sourceOfData.GetName();
                ogr.Soyad = sourceOfData.GetSurname();
                ogr.DogumYeri = sourceOfData.GetCity();
                ogr.DogumTarih = sourceOfData.GetBackDate(30);
                ogr.KursBitisTarih = sourceOfData.GetForwardDate(5);


                // Object Initializer yöntemi ile class'ın instance'ının oluşturulması 
                // ve değerlerinin doldurulması
                //Ogrenci ogr = new Ogrenci()
                //{
                //    Ad = "Gizem",
                //    Soyad = "Sürer",
                //    DogumYeri = "Hatay",
                //    DogumTarih = Convert.ToDateTime("07 / 05 / 1992"),
                //    Id = i,
                //    KursBitisTarih = Convert.ToDateTime("31/10/2019")
                //};
                olist.Add(ogr);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili satırın detayını görmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr==DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else
            {
                FormDetay frmDet = new FormDetay();
                frmDet.seciliOgrBilgileri = this.seciliOgrBilgileri;
                frmDet.ShowDialog();
            }
        }

        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            int n = EnBuyukIdNumarasiniVer();
            //if (dataGridView1.RowCount == 0)
            //{
            //    n = n - 1;
            //}
            FormEkle frmEkle = new FormEkle(n);
            frmEkle.ShowDialog();

            //string str = frmEkle.yeniOgrBilgileri.Id + "\n" +
            //    frmEkle.yeniOgrBilgileri.Ad + "\n" +
            //    frmEkle.yeniOgrBilgileri.Soyad + "\n" +
            //    frmEkle.yeniOgrBilgileri.DogumYeri + "\n" +
            //    frmEkle.yeniOgrBilgileri.DogumTarih + "\n" +
            //    frmEkle.yeniOgrBilgileri.KursBitisTarih + "\n";

            //MessageBox.Show(str);

            List<Ogrenci> ogrList = new List<Ogrenci>();
            
            if (dataGridView1.RowCount > 0)
                ogrList = (List<Ogrenci>)dataGridView1.DataSource;
            sonIslemlerDictionary.Add("Add" + frmEkle.yeniOgrBilgileri.Id, frmEkle.yeniOgrBilgileri);

            ogrList.Add(frmEkle.yeniOgrBilgileri); //silme için eklendi

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = ogrList;
            btnSonIslemGeriAl.Enabled = true;
        }
        private int EnBuyukIdNumarasiniVer()
        {
            int enBuyukIdLst = 0;
            int enBuyukId = 0;
            int tmpId = 1;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                tmpId = (int)row.Cells[0].Value;
                if (tmpId > enBuyukId)
                {
                    enBuyukId = tmpId;
                }
            }
            foreach (KeyValuePair<string,Ogrenci> item in sonIslemlerDictionary)
            {
                List<int> idList = new List<int>();
                string sKey = item.Key;
                string sId = "";

                if (sKey.Contains("Add"))
                {
                    sId = sKey.Substring(3, sKey.Length - 3);
                }
                if (item.Key.Contains("Change") || item.Key.Contains("Delete"))
                {
                    sId = sKey.Substring(6, sKey.Length - 6);
                }
                idList.Add(Convert.ToInt32(sId));
                if (Convert.ToInt32(sId) > enBuyukIdLst)
                {
                    enBuyukIdLst = Convert.ToInt32(sId);
                }
            }
            if (enBuyukId > enBuyukIdLst)
                return enBuyukId;
            else
                return enBuyukIdLst;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

                seciliOgrBilgileri.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                seciliOgrBilgileri.Ad = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                seciliOgrBilgileri.Soyad = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                seciliOgrBilgileri.DogumYeri = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                seciliOgrBilgileri.DogumTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                seciliOgrBilgileri.KursBitisTarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);

            // İkinci Yol:
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    seciliOgrBilgileri.Id = Convert.ToInt32(row.Cells[0].Value);
            //    seciliOgrBilgileri.Ad = row.Cells[1].Value.ToString();
            //    seciliOgrBilgileri.Soyad = row.Cells[2].Value.ToString();
            //    seciliOgrBilgileri.DogumYeri = row.Cells[3].Value.ToString();
            //    seciliOgrBilgileri.DogumTarih = Convert.ToDateTime(row.Cells[4].Value);
            //    seciliOgrBilgileri.KursBitisTarih = Convert.ToDateTime(row.Cells[5].Value);
            //}

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            DialogResult dr = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                ogrList = (List<Ogrenci>)dataGridView1.DataSource;

                Ogrenci ogrTmp = ogrList[dataGridView1.CurrentRow.Index];
                //sonSilmeListesi.Add(ogrTmp);
                sonIslemlerDictionary.Add("Delete" + ogrTmp.Id, ogrTmp);

                ogrList.RemoveAt(dataGridView1.CurrentRow.Index);

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = ogrList;
                btnSonIslemGeriAl.Enabled = true;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lütfen Çoklu Sil butonunu kullanınız!");
            }

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            FormDegistir frmDegistir = new FormDegistir();
            frmDegistir.seciliOgrBilgileri = this.seciliOgrBilgileri;

            //sonIslemlerDictionary.Add("Change" + this.seciliOgrBilgileri.Id, this.seciliOgrBilgileri);

            string s = "Change" + this.seciliOgrBilgileri.Id;
            if(sonIslemlerDictionary.Keys.Contains(s)==false)
            {
                sonIslemlerDictionary.Add(s, this.seciliOgrBilgileri);
            }
            frmDegistir.ShowDialog();
            this.seciliOgrBilgileri = frmDegistir.seciliOgrBilgileri;

            dataGridView1.CurrentRow.Cells[0].Value = seciliOgrBilgileri.Id;
            dataGridView1.CurrentRow.Cells[1].Value = seciliOgrBilgileri.Ad;
            dataGridView1.CurrentRow.Cells[2].Value = seciliOgrBilgileri.Soyad;
            dataGridView1.CurrentRow.Cells[3].Value = seciliOgrBilgileri.DogumYeri;
            dataGridView1.CurrentRow.Cells[4].Value = seciliOgrBilgileri.DogumTarih;
            dataGridView1.CurrentRow.Cells[5].Value = seciliOgrBilgileri.KursBitisTarih;
        }

        private void btnCokluSil_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            DialogResult dr = MessageBox.Show("Seçili satırları silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show("Lütfen Tekli Sil butonunu kullanınız!");
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                ogrList = (List<Ogrenci>)dataGridView1.DataSource;
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    Ogrenci ogrTmp = ogrList[item.Index];

                    // sonSilmeListesi.Add(ogrTmp);
                    sonIslemlerDictionary.Add("Delete" + ogrTmp.Id, ogrTmp);

                    ogrList.RemoveAt(item.Index);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
                btnSonIslemGeriAl.Enabled = true;
            }
        }
            private void btnSonIslemGeriAl_Click(object sender, EventArgs e)
        {
            //if(sonSilmeListesi.Count > 0) //silme için eklendi
            if (sonIslemlerDictionary.Count > 0)
            {
                List<Ogrenci> ogrList = new List<Ogrenci>();
                //foreach (Ogrenci item in sonSilmeListesi) //silme için eklendi

                foreach (KeyValuePair<string, Ogrenci> item in sonIslemlerDictionary)
                {
                    if (dataGridView1.RowCount > 0)
                        ogrList = (List<Ogrenci>)dataGridView1.DataSource;

                    //ogrList.Add(item); //silme için eklendi
                    string sKey = item.Key;
                    if (item.Key.Contains("Add"))
                    {
                        string sId = "";
                        sId = sKey.Substring(3, sKey.Length - 3);
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if (item2.Id == Convert.ToInt32(sId))
                            {
                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                    }
                    if( item.Key.Contains("Delete"))
                    {
                        ogrList.Add(item.Value);
                    }
                    if (item.Key.Contains("Change"))
                    {
                        string sId = "";
                        sId = sKey.Substring(6, sKey.Length - 6);
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if (item2.Id == Convert.ToInt32(sId))
                            {
                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                            ogrList.Add(item.Value);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;

                btnSonIslemGeriAl.Enabled = false;
                //sonSilmeListesi.Clear(); //silme için eklendi
                sonIslemlerDictionary.Clear();
            }
        }

        private void btnLogListele_Click(object sender, EventArgs e)
        {
            FormLogKayıtları frmLog = new FormLogKayıtları(sonIslemlerDictionary);
            frmLog.Show();
        }
    }  
}
