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
    public partial class Resim : UserControl
    {
        public Resim()
        {
            InitializeComponent();
        }
        int puan13 = 0;
        int puan14 = 0;
        int puan15 = 0;
        int puan = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Özenli bir şekilde çizilip boyanmış")
            {
                puan13 = puan13 + 100;
            }
            else if (comboBox1.Text== "Çizilmiş ama boyanmamış.")
            {
                puan13 = puan13 + 70;
            }
            else
            {
                puan13 = puan13 + 0;
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Özenli bir şekilde çizilip boyanmış")
            {
                puan14 = puan14 + 100;
            }
            else if (comboBox2.Text == "Çizilmiş ama boyanmamış.")
            {
                puan14 = puan14 + 70;
            }
            else
            {
                puan14 = puan14 + 0;
            }
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Özenli bir şekilde çizilip boyanmış")
            {
                puan15 = puan15 + 100;
            }
            else if (comboBox2.Text == "Çizilmiş ama boyanmamış.")
            {
                puan15 = puan15 + 70;
            }
            else
            {
                puan15 = puan15 + 0;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan13 = (puan13 * 30) / 100;
            puan14 = (puan14 * 30) / 100;
            puan15 = (puan15 * 40) / 100;
            puan = puan13 + puan14 + puan15;
            label10.Text = puan.ToString();
            if (puan >= 0 && puan <= 50)
            {
                label8.Text = "Geliştirilmeli";
            }
            else if (puan > 50 && puan <= 80)
            {
                label8.Text = "İyi";
            }
           
            else
            {
                label8.Text = "Çok İyi";
            }
        }
    }
}
