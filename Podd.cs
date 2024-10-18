using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodApp
{
    [Serializable]
    public class Podd
    {
        public string? Namn { get; set; }
        public string? Titel { get; set; }


        public Podd(string namn, string titel)
        {
            Namn = namn;
            Titel = titel;
            
        }
        public Podd() { 
        }
    }
}
