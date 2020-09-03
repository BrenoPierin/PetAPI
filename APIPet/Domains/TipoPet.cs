using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Domains
{
    public class TipoPet
    {
        public int IdTipoPet { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
