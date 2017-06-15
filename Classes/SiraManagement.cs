using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    static class SiraManagement 
    {

        static public bool vipVarMi(List<Numara> sira)    
        {
            //kuyrukta vip müşteri varsa :
            return sira.Any(c => c.numaraSahibi is VipMusteri);
        }


        static public bool beklemeSayisiAsildiMi(int sayac, int beklemeSayisi)  
        {
            //3 gişe müşterisinden sonra 1 bireysel müşterinin işleme girme şartı.
            if (sayac < beklemeSayisi)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //işlemi biten müşteriyi sıradan çıkarıyoruz.
        static public void SiradanCikar(Numara numara, List<Numara> sira)
        {
            sira.Remove(numara);
        }


    }
}
