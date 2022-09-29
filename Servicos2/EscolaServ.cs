using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos2
{
    public class EscolaServ

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

        static List<Escola> lst = new List<Escola>();
        public static void NovaEscola(Escola e)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Escola ( Nome, Id_Endereco) values (@Nome, @Id_Endereco);select last_insert_rowid()";
            cmd.Parameters.AddWithValue("@Nome", e.Nome);
            cmd.Parameters.AddWithValue("@Id_Endereco", e.Endereco.Id);
            lst.Add(e);
            Int64 Id_Escola = (Int64)cmd.ExecuteScalar();
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
}
}
    

