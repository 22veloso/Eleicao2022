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
    public class PartidoServ
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

        static List<Partido> lst = new List<Partido>();
        public static long NovoPartido(Partido p)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Partido ( Descricao, NumPartido, Sigla) values (@Descricao, @NumPartido, @Sigla); select last_insert_rowid()";
            cmd.Parameters.AddWithValue("@Descricao", p.Descricao);
            cmd.Parameters.AddWithValue("@NumPartido", p.NumPartido);
            cmd.Parameters.AddWithValue("@Sigla", p.Sigla);
            lst.Add(p);
            Int64 Id_Partido = (Int64)cmd.ExecuteScalar();
            conexaoBanco().Close();
            return Id_Partido;

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
    }

    }

    

