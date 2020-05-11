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
    public partial class Hayat_Bilgisi : UserControl
    {
        public Hayat_Bilgisi()
        {
            InitializeComponent();
        }
        int puan10 = 0;
        int puan11 = 0;
        int puan12 = 0;
        int puan = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Eksiksiz yazmış.")
            {
                puan10 = puan10 + 100;
            }
            else if (comboBox1.Text== "Eksikleri var.")
            {
                puan10 = puan10 + 80;
            }
            else
            {
                puan10 = puan10 + 0;
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text== "Yapmış.")
            {
                puan11 = puan11 + 100;
            }
            else 
            {
                puan11 = puan11 + 0;
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text== "Yazıp okuyup videosunu atmış.")
            {
                puan12 = puan12 + 100;
            }
            else if (comboBox3.Text== "Yazıp okumamış.")
            {
                puan12 = puan12 + 80;
            }
            else if (comboBox3.Text== "Kendi yazmamış hazır metni okumuş.")
            {
                puan12 = puan12 + 60;
            }
            else
            {
                puan12 = puan12 + 0;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan10 = (puan10 * 30) / 100;
            puan11 = (puan11 * 20) / 100;
            puan12 = (puan12 * 50) / 100;
            puan = puan10 + puan11 + puan12;
           label10.Text = puan.ToString();
            if (puan >= 0 && puan <= 50)
            {
               label9.Text= "Geliştirilmeli";
            }
            else if (puan > 50 && puan <= 80)
            {
                label9.Text = "İyi";
            }
            else
            {
                label9.Text = "Çok İyi";
            }
        }
    }
}
