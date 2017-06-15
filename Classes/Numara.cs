using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    public class Numara
    {
        public Musteri numaraSahibi { get; set; }

        //müşteriye verilen numaranın tutulduğu field
        public string siraNo { get; set; }

        //numara metodu müsteri tipinden bir parametre alır
        public Numara(Musteri musteri)
        {
            //numarayla müşteriyi birleştiriyoruz.
            numaraSahibi = musteri; 
            //müşteriyi listeye ekliyoruz.
            Listelerim.SiradakilerListesi.Add(this);    
        }
    }
}
