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
    public partial class Matematik : UserControl
    {
        public Matematik()
        {
            InitializeComponent();
        }
        int puan4 = 0;
        int puan5 = 0;
        int puan6 = 0;
        int puan7 = 0;
        int puan8 = 0;
        int puan9 = 0;
        int puan = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hatasız ikişer ikişer saydı")
            {
                puan4 = puan4 + 100;
            }
            else if (comboBox1.Text == "Bazen hatalı ikişer ikişer saydı")
            {
                puan4 = puan4 + 90;
            }
            else if (comboBox1.Text == "Az çalışmış çalişması gerekiyor")
            {
                puan4 = puan4 + 70;
            }
            else if (comboBox1.Text == "Hiç ikişer ikişer saymamış")
            {
                puan4 = puan4 + 0;
            }
            
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Hatasız üçer üçer saydı")
            {
                puan5 = puan5 + 100;
            }
            else if (comboBox2.Text == "Bazen hatalı üçer üçer saydı")
            {
                puan5 = puan5 + 90;
            }
            else if (comboBox2.Text == "Az çalışmış çalişması gerekiyor")
            {
                puan5 = puan5 + 70;
            }
            else
            {
                puan5 = puan5 + 0;
            }

            
        }
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Hatasız dörder dörder saydı")
            {
                puan6 = puan6 + 100;
            }
            else if (comboBox3.Text == "Bazen hatalı dörder dörder saydı")
            {
                puan6 = puan6 + 90;
            }
            else if (comboBox3.Text == "Az çalışmış çalişması gerekiyor")
            {
                puan6 = puan6 + 70;
            }
            else
            {
                puan6 = puan6 + 0;
            }
          
        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Hatasız beşer beşer saydı")
            {
                puan7 = puan7 + 100;
            }
            else if (comboBox4.Text == "Bazen hatalı beşer beşer saydı")
            {
                puan7 = puan7 + 90;
            }
            else if (comboBox4.Text == "Az çalışmış çalişması gerekiyor")
            {
                puan7 = puan7 + 70;
            }
            else
            {
                puan7 = puan7 + 0;
            }
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text== "Hatasız toplamış.")
            {
                puan8 = puan8 + 100;
            }
            else if (comboBox5.Text=="Bazı yerleri eksik yapmıştır.")
            {
                puan8 = puan8 + 80;
            }
            else
            {
                puan8 = puan8 + 0;
            }
           
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text== "Hatasız çıkarmış.")
            {
                puan9 = puan9 + 100;
            }
            else if (comboBox6.Text== "Bazı yerleri eksik yapmıştır.")
            {
                puan9 = puan9 + 80;
            }
            else
            {
                puan9 = puan9 + 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan4 = (puan4 * 15) / 100;
            puan5 = (puan5 * 15) / 100;
            puan6 = (puan6 * 15) / 100;
            puan7 = (puan7 * 15) / 100;
            puan8 = (puan8 * 20) / 100;
            puan9 = (puan9 * 20) / 100;
            puan = puan4 + puan5 + puan6 + puan7 + puan8 + puan9;
            label12.Text = puan.ToString();
            if (puan >= 0 && puan <= 50)
            {
                label13.Text = "Geliştirilmeli";
            }
            else if (puan > 50 && puan <= 80)
            {
                label13.Text = "İyi";
            }
            
            else
            {
                label13.Text = "Çok İyi";
            }
        }
    }
}
