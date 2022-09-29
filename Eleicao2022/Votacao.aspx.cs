using Models;
using Servicos;
using Servicos2;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

            string IdUrna = Request.QueryString["IdUrna"];
            Votos votos = new Votos()
            {
                Data = DateTime.Now,
                Urnas = new Urnas() { Id = int.Parse(IdUrna) }
            };

            string Resultado = (TbResultado.Text);
            Candidatos candidato = new CandidatoServ().BuscaCandidato(Resultado);
            if (Resultado == "")
            {

                MessageBox.Show("Campo Vazio");
                TbResultado.Focus();
                return;
            }
            string sql = "select Candidatos.Id, Nome, sigla from Candidatos inner join Partido on Id_Partido = Partido.Id where NumPartido ='" + TbResultado.Text + "'";
            dt = CandidatoServ.Consulta(sql);
            if (dt.Rows.Count == 1)
            {
                votos.CandidatoVoto = new Candidatos() { Partido = new Partido() { NumPartido = Resultado } };
                VotosServ.IncluirVoto(IdUrna,votos);
                lblDados.Text = String.Format("Candidato {0}", candidato.Nome);
                WriteTxt(string.Format("Voto para {0} - Urna {1}", candidato.Nome, IdUrna));

                MessageBox.Show("Voto Computado com Sucesso!");
            }

   
            



            else
            {
                Response.Write("<script>alert('Candidato inválido!');</script>");
            }

        }
        protected void BtnNulo_Click(object sender, EventArgs e)
        {
            string IdUrna = Request.QueryString["IdUrna"];
            lblDados.Text = "Voto nulo";
            WriteTxt(string.Format("Voto nulo - Urna {0}", IdUrna));
        }
        protected void BtnBranco_Click(object sender, EventArgs e)
        {
            string IdUrna = Request.QueryString["IdUrna"];
            lblDados.Text = "Voto em branco";
            WriteTxt(string.Format("Voto em Branco - Urna {0}", IdUrna));
        }
        private void WriteTxt(string result)
        {
            string path = @"C:\Users\Lucas Veloso\Downloads\Eleicao2022\Eleicao22.txt";
            string readText = "";

            if (File.Exists(path))
            {
                readText = File.ReadAllText(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                if (readText != "")
                    writer.Write(readText);

                writer.WriteLine(DateTime.Now + ": " + result);
            }
        }

        protected void BtnCorrigir_Click(object sender, EventArgs e)
        {
            TbResultado.Text = "";
        }

    
    }
}

