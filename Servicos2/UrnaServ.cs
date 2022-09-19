using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos2
{
    public class UrnaServ
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

        static List<Urnas> lst = new List<Urnas>();
        public static void NovaUrna(Urnas u)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Urnas ( Id, Id_Escola,NumerosVotos) values (@Id, @Id_Escola,@NumerosVotos)";
            cmd.Parameters.AddWithValue("@Id", u.Id);
            cmd.Parameters.AddWithValue("@NumerosVotos", u.NumeroVotos);
            cmd.Parameters.AddWithValue("@Id_Escola", u.Escola.Id);
            lst.Add(u);

            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }
    }
}

//INSERT INTO Urnas (
                  //    Id,
                   //   NumerosVotos,
                 //     Id_Escola,
                 //     Id_candidato
                 // )
               //   VALUES(
                //      '1',
                //      2,
                 //     4,
                //      8
               //   );
