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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzaktan_Egitim_Ogrenci_Takip_Sistemi
{
    class Ogrenci
    {
        private string m_OgrAd;// Fields Ogrenci sınıfına ait tanımlanan alan
        private string m_OgrSoyad;
        private string m_OgrSevdigiDers;
        private string m_OgrAktivite;
        public string OgrAd//properties
        {
            get { return m_OgrAd; }
            set { this.m_OgrAd = value; }
        }
        public string OgrSoyad//properties
        {
            get { return m_OgrSoyad; }
            set { this.m_OgrSoyad = value; }
        }
        public string OgrSevdigiDers//properties
        {
            get { return m_OgrSevdigiDers; }
            set { this.m_OgrSevdigiDers = value; }
        }
        public string OgrAktivite//properties
        {
            get { return m_OgrAktivite; }
            set { this.m_OgrAktivite = value; }
        }
        public string yeni;
        public void duzenle() //Methods
        {
            yeni = "Öğrencinin Adı" + OgrAd + "Öğrencinin Soyadı" + OgrSoyad + "Öğrencinin En Sevdiği Ders" + OgrSevdigiDers + "Öğrencinin Aktivitesi" + OgrAktivite;
        }
    }
}
