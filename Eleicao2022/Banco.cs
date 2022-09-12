using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class Banco
    {
        public static string Caminho = System.Environment.CurrentDirectory; // armazenando o caminho executavel do programa \System.Environment.CurrentDirectory= pegando o diretorio da aplicação
        public static string NomeBanco = "EleicaoDB"; // criando uma variavel com o nome do Banco do SQLite
        public static string CaminhoBanco = Caminho + @"\Banco\"; // criando uma variavel c
    }
}
