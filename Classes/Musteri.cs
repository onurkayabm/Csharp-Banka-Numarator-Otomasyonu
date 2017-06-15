using BaBank_v2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank_v2.Classes
{
    //abstract class
    abstract public class Musteri : IMusteri  
    {
        public string TCKimlikNo { get; set; }      

        public abstract void NumaraAl();
    }
}

