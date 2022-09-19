using Models2;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos2
{
   public class EnderecoServ
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

        static List<Endereco> lst = new List<Endereco>();
        public static long NovoEndereco(Endereco e)
        {
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "insert into Endereco( Logradouro, Cep, Bairro,UF, Cidade,NumEscola ) values (@Logradouro, @Cep, @Bairro, @UF, @Cidade,@NumEscola);select last_insert_rowid()";
            cmd.Parameters.AddWithValue("@Logradouro", e.Logradouro);
            cmd.Parameters.AddWithValue("@Cep", e.Cep);
            cmd.Parameters.AddWithValue("@Bairro", e.Bairro);
            cmd.Parameters.AddWithValue("@UF", e.UF);
            cmd.Parameters.AddWithValue("Cidade", e.Cidade);
            cmd.Parameters.AddWithValue("@NumEscola", e.NumeroEscola);
            lst.Add(e);
            Int64 Id_Endereco = (Int64)cmd.ExecuteScalar();
            conexaoBanco().Close();
            return Id_Endereco;

        }
    }
}
    

