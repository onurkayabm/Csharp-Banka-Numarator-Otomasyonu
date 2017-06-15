using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    class Vezne
    {
        int _sayac = 0;
        const int BEKLEMESAYISI = 3;

        //siradaki müşterimizi belirleyen metot.
        public Numara SiradakiMusteri(List<Numara> siradakilerList) 
        {
            Numara numara = null;
            //vip müşteri varsa önce onlar gelir.
            if (SiraManagement.vipVarMi(siradakilerList))  
            {
                numara = siradakilerList.First(c => c.numaraSahibi is VipMusteri);
                //işlemi biten müşteri sıradan çıkar
                SiraManagement.SiradanCikar(numara, siradakilerList); 
                return numara;
            }

            //vip müşteriler bittikten sonra gişe müşterileri ve bireysel müşteriler arasında kontrol yapma
            else if (!SiraManagement.beklemeSayisiAsildiMi(_sayac, BEKLEMESAYISI))
            {
                //sıradaki müşteri gişe müşterisi ise
                if (siradakilerList[0].numaraSahibi is GiseMusteri)
                {
                    numara = siradakilerList[0];
                    SiraManagement.SiradanCikar(numara, siradakilerList);
                    //gişe olduğu için sayaç artıyor.
                    _sayac++; 
                    return numara;
                }

                else
                {
                    numara = siradakilerList[0];  
                    SiraManagement.SiradanCikar(numara, siradakilerList);
                    return numara;
                }
            }

            //3 gişe müşterisinin işlemi bittiyse
            else 
            {
                //sıradaki ilk müşteri gelir
                numara = siradakilerList.First(c => c.numaraSahibi is BireyselMusteri);
                SiraManagement.SiradanCikar(numara, siradakilerList);
                //sayacı sıfırlıyoruz.
                _sayac = 0; 
                return numara;
            }
        }
    }
}
