using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    //veritabanının olduğu sınıf
    static class DBPlaceholder  
    {
        //müşterilerin kayıtlarının TcKimlik ve müşteritipi olarak tutulduğu metot.
        static public Dictionary<string, string> KayitlariGetir()
        {
            var dbDictionary = new Dictionary<string, string>();
            dbDictionary.Add("14405406992", "Bireysel");
            dbDictionary.Add("14405406993", "Bireysel");
            dbDictionary.Add("14405406994", "Bireysel");
            dbDictionary.Add("14405406995", "Vip");
            dbDictionary.Add("14405406996", "Vip");
            dbDictionary.Add("14405406997", "Vip");

            return dbDictionary;
        }
    }
}
