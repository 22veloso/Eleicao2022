using Models;
using Servicos2;
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
    public partial class Cadastro_Urnas : System.Web.UI.Page
    {

        protected void BtnSalvarurna_Click1(object sender, EventArgs e)
        {

            Urnas ur = new Urnas();
            ur.Id = int.Parse(TbId.Text);
            ur.Escola = new Escola() { Id = int.Parse(DDEscola.SelectedValue.ToString()) };


            new UrnaServ().NovaUrna(ur);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEscola();
            }
        }

        private void LoadEscola()
        {
            DDEscola.DataSource = EscolaServ.Consulta(Escola.GETALL);
            DDEscola.DataValueField = "Id";
            DDEscola.DataTextField = "Nome";
            DDEscola.DataBind();
        }


    }
}



