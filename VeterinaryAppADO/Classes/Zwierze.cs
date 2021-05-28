using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Zwierze : Opiekun
    {
        public int IdZwierze { get; set; }
        public string ImieZwierze { get; set; }
        public string TypZwierze { get; set; }
        public string Gatunek { get; set; }

        public int Wiek { get; set; }

    }
}
