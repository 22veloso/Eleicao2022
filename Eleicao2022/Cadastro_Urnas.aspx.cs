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
        DataTable dt = new DataTable();
        protected void BtnPesES_Click(object sender, EventArgs e)
        {
            Escola es = new Escola();
            es.Nome = TbPesEs.Text;

            if (es.Nome == "")
            {

                MessageBox.Show("Campo Vazio!");

                TbPesEs.Focus();
                return;

            }
            string sql = "SELECT I Nome FROM Escola ='" + es.Nome + "'";
            dt = EscolaServ.Consulta(sql);
            if (dt.Rows.Count == 1)
            {
                TbResEs.Text = TbPesEs.Text + "";
            }
        

            else
            {
                MessageBox.Show("Escola não encontrado!");
            }

        }

        protected void BtnSalvarUrna_Click(object sender, EventArgs e)
        {
            Urnas ur = new Urnas();
            ur.Id = TbGerarUrna.Text;
          

            UrnaServ.NovaUrna(ur);
            
        }
    }
}

