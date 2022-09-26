using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Urnas
    {
        public const string GETALL = "select * from Urnas";
        public int Id { get; set; }
        public int NumeroVotos { get; set; }
        public Candidatos Candidatos { get; set; }
        public Escola Escola { get; set; }

    }
}
