using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Miras inheritance  
    // müsteride olan ozellikler artık gercek musteride de vardır
    // tüzel müsteri bir müşteridir
    internal class TuzelMusteri:Musteri 

    {

        public string Sirketadi { get; set; }

        public string VergiNo { get; set; }

    }
}
