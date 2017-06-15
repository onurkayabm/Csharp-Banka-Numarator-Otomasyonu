using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    class MusteriFactory
    { 
        //Müşteri tipine göre nesne üreten metot
        public Musteri TipeGoreMusteriNenesiUret(MusteriTipi tip)      
        {
            Musteri musteri = null;   

            //tip kontrolu yapıyoruz. 
            switch (tip)
            {
                case MusteriTipi.Vip:
                    musteri = new VipMusteri();
                    break;
                case MusteriTipi.Bireysel:
                    musteri = new BireyselMusteri();
                    break;
                case MusteriTipi.Gise:
                    musteri = new GiseMusteri();
                    break;
                default:
                    break;
            }
            return musteri;
        }

        //burada oluşturulan  nesneyi Numaratörün NumaraVer() metotuna parametre olarak yollamamız gerekiyor.
    }

}
