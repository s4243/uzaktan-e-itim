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
    public partial class Türkçe : UserControl
    {
        public Türkçe()
        {
            InitializeComponent();
        }
        int puan1 = 0;
        int puan2 = 0;
        int puan3 = 0;
        int puan = 0;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Yazım kurallarına uygun,düzenli ve okunaklı yazılmıştır.")
            {
                puan1 = puan1+100;
            }
            else if (comboBox1.Text== "Yazım kurallarına pek uyulmamış,düzenli okunaklı yazılmıştır.")
            {
                puan1 = puan1+90;
            }
            else if (comboBox1.Text== "Yazım kurallarına uygun ama düzensiz yazılmıştır.")
            {
                puan1 = puan1+80;
            }
            else if (comboBox1.Text== " Yazım kurallaına ve düzenli okunaklı yazması orta seviyedir.")
            {
                puan1 = puan1+70;
            }
            else if (comboBox1.Text== "Düzensiz ama okunaklı yazılmıştır.")
            {
                puan1 = puan1+60;
            }
           
            else if (comboBox1.Text== "Düzenli ama okunaksız yazılmıştır")
            {
                puan1 =puan1+ 40;
            }
            else
            {
                puan1 = puan1+0;
            }
           
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text== "Akıcı ,tane tane ve doğru okumuştur.")
            {
                puan2  = puan2 + 100;
            }
            else if (comboBox2.Text== "Tane tane ve doğru okumuştur.")
            {
                puan2 = puan2 + 90;
            }
            else if (comboBox2.Text== "Akıcı ,hızlı ve doğru okumuştur.")
            {
                puan2 = puan2 + 80;
            }
            else if (comboBox2.Text== "Yavaş ama doğru okumuştur.")
            {
                puan2 = puan2 + 70;
            }
            else if (comboBox2.Text== "Akıcı tane tane ve yanlış okumuştur.")
            {
                puan2 = puan2 + 60;
            }
            else if (comboBox2.Text== "Okuma konusunda iyi değilsin daha fazla çalışmalıdır.")
            {
                puan2 = puan2 + 50;
            }
            else
            {
                puan2 = puan2 + 0;
            }
           
        }
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text== "Tamamını ezberlemiş ve hatasız bir şekilde okuması")
            {
                puan3 = puan3 + 100;
            }
            else if (comboBox3.Text== "Tamamını ezberlemiş bazen yanlış okumuş")
            {
                puan3 = puan3 + 80;
            }
            else if (comboBox3.Text== "Kağıttan bakarak okumuş")
            {
                puan3 = puan3 + 60;
            }
            else 
            {
                puan3 = puan3 + 0;
            }
           
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            puan1 = (puan1 * 30) / 100;
            puan2 = (puan2 * 30) / 100;
            puan3 = (puan3 * 40) / 100;
            puan = puan1 + puan2 + puan3;

            label10.Text = puan.ToString();
            if (puan>=0 && puan<=50)
            {
                label11.Text = "Geliştirilmeli";
            }
            else if (puan>50 && puan<=80)
            {
                label11.Text = "İyi";
            }
            else
            {
                label11.Text = "Çok İyi";
            }
        }
    }
}
