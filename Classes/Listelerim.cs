using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    //müşteri tipine göre gelen müşteriyi listeye ekleyen sınıf
    public static class Listelerim 
    {

        public static List<Numara> VipListesi { get; set; }

        public static List<Numara> BireyselListesi { get; set; }

        public static List<Numara> GiseListesi { get; set; }

        public static List<Numara> SiradakilerListesi { get; set; }

        public static List<Numara> listeSec(Musteri musteri)
        {
            List<Numara> liste = null;
            switch (musteri.GetType().ToString())
            {
                case "VipMusteri":
                    liste = VipListesi;
                    break;
                case "BireyselMusteri":
                    liste = BireyselListesi;
                    break;
                case "GiseMusteri":
                    liste = GiseListesi;
                    break;
                default:
                    break;
            }
            return liste;
        }

    }
}
