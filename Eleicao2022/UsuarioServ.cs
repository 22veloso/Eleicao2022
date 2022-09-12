using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace Eleicao2022
{
    public class UsuarioServ
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()

        {
            conexao = new SQLiteConnection(@"Data Source =C:\Users\Lucas Veloso\OneDrive\Área de Trabalho\Eleicao\Eleicao2022\Eleicao2022\obj\Debug\Banco\EleicaoDB.db");

            {
                conexao.Open();
                return conexao;
            }
        }
        public static DataTable Consuta(string sql)// retornando minha consulta
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
