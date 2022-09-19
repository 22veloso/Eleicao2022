using Models;
using Servicos;
using System;
using System.Windows.Forms;
using System.Data;
using Models2;
using Servicos2;

namespace Eleicao2022
{
    public partial class Votacao : System.Web.UI.Page
    {
       
       
        protected void BtnLimpar_Click(object sender, EventArgs e)
        {
            //TbNomeCan.Text = "";
            //TbTelefoneCan.Text = "";
           // TbDescPartido.Text = "";
           // TbSigla.Text = "";
           // TbNumPartido.Text = "";
        }

        protected void BtnPesquisar_Click(object sender, EventArgs e)
        {
            get_cep();
        }
        private void get_cep()
        {

            string cep = TbCep.Text;
            string _resultado;
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml");
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _resultado = ds.Tables[0].Rows[0]["resultado"].ToString();
                    switch (_resultado)
                    {
                        case "1":
                            TbUf.Text = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            TbCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            TbBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            TbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            break;
                        default:
                            MessageBox.Show("CEP NAO ENCONTRADO");
                            break;
                    }
                }
            }
        }

        protected void BtnCadCandidato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro_Candidato.aspx");
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.Logradouro= TbLogradouro.Text;
            end.Bairro = TbBairro.Text;
            end.Cep = TbCep.Text;
            end.UF = TbUf.Text;
            end.Cidade =TbCidade.Text;
            end.NumeroEscola = TbNumEs.Text;
            long Id_Endereco = EnderecoServ.NovoEndereco(end);

            Escola es = new Escola();
           es.Nome= TbNomeEscola.Text;
      
            es.Endereco = new Endereco() { Id = (int) Id_Endereco};
           EscolaServ.NovaEscola(es);

        }

        protected void BtnGerarUrnas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro_Urnas.aspx");
        }
    }
    }
    
