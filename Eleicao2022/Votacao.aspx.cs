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
    public partial class Votacao : System.Web.UI.Page
    {
        protected void BtnLimpar_Click(object sender, EventArgs e)
        {
            TbNomeCan.Text = "";
            TbTelefoneCan.Text = "";
            TbDescPartido.Text = "";
            TbSigla.Text = "";
            TbNumPartido.Text = "";
           

           
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
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
                part.NumPartido = int.Parse((TbNumPartido.Text).ToString());

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
}