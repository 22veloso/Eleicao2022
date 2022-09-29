using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void NovaUrna(Urnas u)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Urnas ( Id, Id_Escola) values (@Id, @Id_Escola)";
            cmd.Parameters.AddWithValue("@Id", u.Id);
            cmd.Parameters.AddWithValue("@Id_Escola", u.Escola.Id);
            lst.Add(u);

            cmd.ExecuteNonQuery();
            conexaoBanco().Close();

        }
        public static DataTable dml(string q, string msgOK = null, string msgERRO = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                return dt;
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
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
