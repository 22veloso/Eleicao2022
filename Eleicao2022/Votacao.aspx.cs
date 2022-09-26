using Models;
using Servicos;
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
    public partial class Votacao1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "0";
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "1";
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "2";
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "3";
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "4";
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "5";
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "6";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "7";
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "8";
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            TbResultado.Text += "9";
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
           
            

            string Resultado = (TbResultado.Text);
            Candidatos candidato = new CandidatoServ().NovoVoto(Resultado);
            if (Resultado == "")
            {

                MessageBox.Show("Campo Vazio");
                TbResultado.Focus();
                return;
            }
            string sql = "select Candidatos.Id, Nome, sigla from Candidatos inner join Partido on Id_Partido = Partido.Id where NumPartido ='"+ TbResultado.Text +"'";
          
           

            dt = CandidatoServ.Consulta(sql);
            if (dt.Rows.Count == 1)
            {

                new VotosServ().IncluirVoto(IdUrna, candidato.Id);
                lblDados.Text = String.Format("Candidato {0}",candidato.Nome);

              
                
              
            






            }
        

            else
            {
                MessageBox.Show("nao achou");
            }
           

        }
    }
}
