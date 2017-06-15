using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    //müşteri tiplerini tanımlama
    enum MusteriTipi
    {
        Vip,
        Bireysel,
        Gise
    }
    class Tip
    {
        //tc kimlik numarasına göre müşteri tiplerini tanımlama
        public MusteriTipi TipBelirle(string TcKimlikNo) 
        {
            var db = DBPlaceholder.KayitlariGetir();

            if (db.ContainsKey(TcKimlikNo))
            {
                if (db[TcKimlikNo] == "Vip")
                {
                    return MusteriTipi.Vip;
                }
                else if (db[TcKimlikNo] == "Bireysel")
                {
                    return MusteriTipi.Bireysel;
                }
            }
            return MusteriTipi.Gise;

        }
    }
}
