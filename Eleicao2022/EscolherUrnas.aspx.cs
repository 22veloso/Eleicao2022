using Models;
using Servicos2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eleicao2022
{
    public partial class EscolherUrnas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEscola();
            LoadUrna();
        }

        
            private void LoadEscola()
            {
                DDEscola0.DataSource = EscolaServ.Consulta(Escola.GETALL);
                DDEscola0.DataValueField = "Id";
                DDEscola0.DataTextField = "Nome";
                DDEscola0.DataBind();
            }
            private void LoadUrna()
            {
                DDUrna.DataSource = UrnaServ.Consulta(Urnas.GETALL);
                DDUrna.DataValueField = "Id";
                DDUrna.DataTextField = "Id";
                DDUrna.DataBind();
            }

        protected void BtnSelecionar_Click(object sender, EventArgs e)
        {
            string IdEscola = DDEscola0.SelectedValue;
            string IdUrna= DDUrna.SelectedValue;

            Response.Redirect("~/Votacao.aspx");
        }
    }
    }
