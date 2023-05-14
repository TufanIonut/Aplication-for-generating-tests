using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire
{
     public class Elev : Persoana
    {
        bool eElev;
        public Elev(string a, string b, bool f = true) :base(a,b){
            eElev = f;
        }
    }
}
