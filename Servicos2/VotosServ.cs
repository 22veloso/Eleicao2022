using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos2
{
    public class VotosServ
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()

        {
            conexao = new SQLiteConnection(@"Data Source =C:\Users\Lucas Veloso\OneDrive\Área de Trabalho\Eleicao2022\Eleicao2022\obj\Debug\Banco\EleicaoDB.db");

            {
                conexao.Open();
                return conexao;
            }
        }


        public static void IncluirVoto(string IdUrna,int IdCandidato)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Votos ( Id_Urnas, Id_Candidato, Data) values (@Id_Urnas, @Id_Candidato, @Data);";
            cmd.Parameters.AddWithValue("@Id_Urnas",IdUrna);
            cmd.Parameters.AddWithValue("@Data", DateTime.Now);
            cmd.Parameters.AddWithValue("@Id_Candidato", IdCandidato);
            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }
    }
}
