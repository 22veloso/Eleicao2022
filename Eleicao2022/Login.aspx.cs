
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

            
            if (us.Admin == "" || us.Senha == "")
            {

                MessageBox.Show("Usuario e ou senha inválidos!");
                tbAdmin.Focus();
                return;
            }
            
            string sql = "SELECT * FROM Usuario Where Admin ='" + us.Admin + "' AND Senha='" + us.Senha + "'";//
            dt = UsuarioServ.Consuta(sql);
            if (dt.Rows.Count == 1) 
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