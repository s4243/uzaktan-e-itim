/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:
** ÖĞRENCİ ADI............:Sümeyya AKBULUT
** ÖĞRENCİ NUMARASI.......:B191200043
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzaktan_Egitim_Ogrenci_Takip_Sistemi
{
    public partial class Ogrenci_Yetenekleri : UserControl
    {
        public Ogrenci_Yetenekleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();//Ogrenci sınıfına yeni öğrenci eklemek için kullanılır
            ogrenci1.OgrAd = textBox1.Text; 
            ogrenci1.OgrSoyad = textBox2.Text;
            ogrenci1.OgrSevdigiDers = textBox3.Text;
            ogrenci1.OgrAktivite = textBox4.Text;
            ogrenci1.duzenle();//Ogrenci sınıfındaki yazdığımız özelliklerin hepsini gösterir.
            listBox1.Items.Add(ogrenci1.yeni);//yukarıda yazdıklarız burada yazar.
        }
    }
}
