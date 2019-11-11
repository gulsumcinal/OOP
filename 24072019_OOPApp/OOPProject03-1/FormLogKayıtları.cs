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
    public partial class FormLogKayıtları : Form
    {
        private Dictionary<string, Ogrenci> logDictionary = new Dictionary<string, Ogrenci>();
        public FormLogKayıtları(Dictionary<string, Ogrenci> logDic)
        {
            logDictionary = logDic;
            InitializeComponent();
        }

        private void FormLogKayıtları_Load(object sender, EventArgs e)
        {
            this.dataGridViewLog.DataSource = null;
            List<Ogrenci> listValues = logDictionary.Values.ToList();
            List<string> listKeys = logDictionary.Keys.ToList();
            //List<string> logList = new List<string>();
            int listCount = listKeys.Count;
            for(int i =0; i<listCount; i++)
            {
                string sKey = listKeys[i];
                if (sKey.Contains("Delete") || sKey.Contains("Change"))
                    sKey = sKey.Substring(0, 6);
                else //sKey.Contains("Add")
                    sKey = sKey.Substring(0, 3);

                string s = sKey + " " + " " + listValues[i].Id + " " + listValues[i].Ad + " " + listValues[i].Soyad + " " + listValues[i].DogumYeri + " " + listValues[i].DogumTarih + " " + listValues[i].KursBitisTarih;

                //logList.Add(s);
                dataGridViewLog.Rows.Add(s);

                if (sKey == "Delete")
                    dataGridViewLog.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else if (sKey == "Change")
                    dataGridViewLog.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                else //if (sKey == "Add")
                    dataGridViewLog.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
            //this.dataGridViewLog.DataSource = logList.Select(XmlReadMode => new { Value = XmlReadMode }).ToList();
        }
        private void btnOkLog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
