using System;

namespace Proje1_TelefonRehberi
{
    public class KisiKarti
    {
        string isim;
        string soyisim;
        string telefonNumarasi;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }

        public KisiKarti(string isim, string soyisim, string telefonNumarasi)
        {
            Isim = isim;
            Soyisim = soyisim;
            TelefonNumarasi = telefonNumarasi;
        }

        public KisiKarti()
        {
        }
    }
}
