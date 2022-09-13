using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Voto
    {
        public int Id { get; set; }
        public Urnas Urnas { get; set; }
        public DateTime Data { get; set; }
        public Candidatos CandidatoVoto { get; set; }

    }
}
