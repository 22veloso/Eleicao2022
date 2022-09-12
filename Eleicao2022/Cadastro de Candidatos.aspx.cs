
using Models;
using Servicos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Eleicao2022
{
    public partial class Cadastro_de_Candidatos : System.Web.UI.Page
    {
        DataTable dt = new DataTable();// criando um dataTable para receber os dados da nossa consulta
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_salvar_Click(object sender, EventArgs e)
        {

            //Response.Redirect("~/Votacao.aspx");
        }

        protected void btnsalvar_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Admin = tbAdmin.Text;
            us.Senha = tbSenha.Text;

            // verificando se os campos estao preenchidos
            if (us.Admin == "" || us.Senha == "")
            {

                MessageBox.Show("Usuario e ou senha inválidos!");
                tbAdmin.Focus();
                return;// caso esse if for verdadeiro o return vai servir para encerrar o programa e nao dar continuidade
            }
            // criando a string sql para fazer uma consulta no banco se existe os dados inseridos. se retornadar algum registro é porque ele encontrou o usuario
            string sql = "SELECT * FROM Usuario Where Admin ='" + us.Admin + "' AND Senha='" + us.Senha + "'";//
            dt = UsuarioServ.Consuta(sql);// chamando o mmetodo consulta e amarzenando no datatable// rebebendo como parametro uma string(sql) contendo a consulta
            if (dt.Rows.Count == 1)//  verificando se o datatable retorna uma linha 
            {
                Response.Redirect("~/Votacao.aspx");

            }
        

            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }

        }
    }
}