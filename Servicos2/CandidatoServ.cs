
using Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            conexao = new SQLiteConnection(@"Data Source =C:\Users\Lucas Veloso\OneDrive\Área de Trabalho\Eleicao2022\Eleicao2022\obj\Debug\Banco\EleicaoDB.db");

            {
                conexao.Open();
                return conexao;
            }
        }

        static List<Candidatos> lst = new List<Candidatos>();
        public static void NovoCandidato(Candidatos c)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Candidatos ( Nome, Telefone, Id_Partido, Voto) values (@Nome, @Telefone, @Id_Partido, @Voto)";
            cmd.Parameters.AddWithValue("@Nome", c.Nome);
            cmd.Parameters.AddWithValue("@Telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@Id_Partido", c.Partido.Id);
            cmd.Parameters.AddWithValue("@Voto", c.Voto);
            lst.Add(c);

            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }

        public static DataTable Consulta(string sql)// retornando minha consulta
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {

                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;// passando o parametro sql
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close(); // fechando a conexao
                    return dt;

                }
            }
            catch (Exception ex)
            {

                conexaoBanco().Close();
                throw ex;
            }
       
   

       }
        public Candidatos BuscaCandidato(string NumPartido)
       {
         var cmd = conexaoBanco().CreateCommand();
           cmd.CommandText = "select Candidatos.Id,Nome,Partido.Sigla from Candidatos inner join  Partido on Id_Partido = Partido.Id where NumPartido =@NumPartido;";
           cmd.Parameters.AddWithValue("@NumPartido",NumPartido);
           cmd.ExecuteNonQuery();

            Candidatos candidatos =null;
           using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
               if (reader.Read())
               {
                   candidatos = new Candidatos();
                    candidatos.Id = int.Parse(reader["Id"].ToString());
                    candidatos.Nome = reader["Nome"].ToString();
               }
            }
            conexaoBanco().Close();
            return candidatos;
        }

        }
    }


