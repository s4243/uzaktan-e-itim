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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzaktan_Egitim_Ogrenci_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePan.Height = button9.Height;
            SidePan.Top = button9.Top;
            türkçe1.BringToFront();
            SidePan2.Height = button10.Height;
            SidePan2.Top = button10.Top;
            matematik1.BringToFront();
            SidePan3.Height = button11.Height;
            SidePan3.Top = button11.Top;
            hayat_Bilgisi2.BringToFront();
            SidePan4.Height = button12.Height;
            SidePan4.Top = button12.Top;
            resim1.BringToFront();
            SidePan5.Height = button13.Height;
            SidePan5.Top = button13.Top;
            ogrenci_Yetenekleri1.BringToFront();
            SidePan6.Height = button17.Height;
            SidePan6.Top = button17.Top;
            ogrenci_Secimi3.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SidePan.Height = button9.Height;
            SidePan.Top = button9.Top;//Denetimin üst kenarı ve kapsayıcısının istemci alanının üst kenarı arasındaki mesafeyi piksel cinsinden alır veya ayarlar.
            türkçe1.BringToFront();// metodu ile görüntülenen formu,diğer formlara göre en önde görüntüleyebiliriz.türkçe1 en öne getirir.
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SidePan2.Height = button10.Height;
            SidePan2.Top = button10.Top; 
            matematik1.BringToFront();//matematik1 formunu  en öne getir.
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SidePan3.Height = button11.Height;
            SidePan3.Top = button11.Top;
            hayat_Bilgisi2.BringToFront();//hayat_Bilgisi2 formunu en öne getirir.
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SidePan4.Height = button12.Height;
            SidePan4.Top = button12.Top;
            resim1.BringToFront();//resim formunu en öne getirir.
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SidePan5.Height = button13.Height;
            SidePan5.Top = button13.Top;
            ogrenci_Yetenekleri1.BringToFront();//ogrenci_Yetenekleri1 formunu en öne getirilir.
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SidePan6.Height = button17.Height;
            SidePan6.Top = button17.Top;
            ogrenci_Secimi3.BringToFront();//ogrenci_Secimi3 formunu en öne getirilir.
        }
    }
}
