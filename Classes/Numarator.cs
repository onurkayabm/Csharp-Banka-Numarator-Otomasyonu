using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    class Numarator
    {

        //Numara ver metodunu generic yaptık, böylece esneklik arttı
        public Numara NumaraVer<T>(T musteri) where T : Musteri             
        {
            //müşteri tipine göre ona özel numara üretip, listeye ekledik.
            Numara no = new Numara(musteri);
            no.siraNo = musteri.GetType().ToString().Substring(0, 1) + " - " + Listelerim.listeSec(musteri).Count() + 1;
            Listelerim.listeSec(musteri).Add(no);
            return no;
        }

    }
}
