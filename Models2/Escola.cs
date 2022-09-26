using Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Escola
    {
        public const string GETALL = "select * from Escola";
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
