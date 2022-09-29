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


        public static void IncluirVoto(string IdUrna,Votos votos)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Votos ( Id_Candidato, Data ,Id_Urnas) values ( @Id_Candidato, @Data,@Id_Urnas);";
            ;
            cmd.Parameters.AddWithValue("@Data", DateTime.Now);
            cmd.Parameters.AddWithValue("@Id_Candidato", votos.CandidatoVoto.Partido.NumPartido);
            cmd.Parameters.AddWithValue("@Id_Urnas", votos.Urnas.Id);
            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

           AtualizarUrnas(IdUrna);



        }
        public static void AtualizarUrnas(string IdUrna)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "update Urnas set NumerosVotos = NumerosVotos + 1 where Id = @Id_urnas; ";
            cmd.Parameters.AddWithValue("@Id_urnas", IdUrna);


            cmd.ExecuteNonQuery();
            conexaoBanco().Close();
        }
    }
}