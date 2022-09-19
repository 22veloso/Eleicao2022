using Models;
using Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Eleicao2022
{
    public partial class Cadastro_Candidato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvarCan_Click(object sender, EventArgs e)
        {
            {
                if (TbNomeCan.Text == "" || TbTelefoneCan.Text == "" || TbDescPartido.Text == "" || TbSigla.Text == "" || TbNumPartido.Text == "")
                {
                    MessageBox.Show("Atenção, algum Campo ficou sem preencher!");
                    TbNomeCan.Focus();
                    return;

                }
                else
                {
                    Partido part = new Partido();
                    part.Sigla = TbSigla.Text;
                    part.Descricao = TbDescPartido.Text;
                    part.NumPartido = TbNumPartido.Text;

                    long Id_Partido = PartidoServ.NovoPartido(part);

                    Candidatos cand = new Candidatos();
                    cand.Nome = TbNomeCan.Text;
                    cand.Telefone = TbTelefoneCan.Text;
                    cand.Partido = new Partido() { Id = (int)Id_Partido };
                    CandidatoServ.NovoCandidato(cand);




                    MessageBox.Show("Candidato inserido!!");
                }
            }
        }

        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro.aspx");
        }
    }
}