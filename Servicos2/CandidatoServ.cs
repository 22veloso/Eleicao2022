
using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
      
    public class CandidatoServ

    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()

        {
            conexao = new SQLiteConnection(@"Data Source =C:\Users\logatti\Desktop\Eleicao2022\Eleicao2022\obj\Debug\Banco\EleicaoDB.db");

            {
                conexao.Open();
                return conexao;
            }
        }

        static List<Candidatos> lst = new List<Candidatos>();
        public static void NovoCandidato(Candidatos c)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Candidatos ( Nome, Telefone, Id_Partido) values (@Nome, @Telefone, @Id_Partido)";
            cmd.Parameters.AddWithValue("@Nome", c.Nome);
            cmd.Parameters.AddWithValue("@Telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@Id_Partido", c.Partido.Id);
            lst.Add(c);

            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }
    }
}