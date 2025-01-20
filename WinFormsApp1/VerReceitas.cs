using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class VerReceitas : Form
    {

        private List<Receitas> ReceitasList = null;

        List<Receitas> receitaSearch = null;

        private bool search = false;

        public VerReceitas(List<Receitas> ReceitasList)
        {
            this.ReceitasList = ReceitasList;
            if (ReceitasList == null || ReceitasList.Count == 0)
            {
                MessageBox.Show("Não foram encontradas receitas.", "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                InitializeComponent();
                foreach (Receitas receit in ReceitasList)
                {
                    ReceitasView.Items.Add(receit.nome);
                }
                this.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = true;
            ReceitasView.Items.Clear();
            receitaSearch = SearchXml(CampoWid.Text, ValorWid.Text);
            if (receitaSearch == null)
            {
                MessageBox.Show("Erro ao encontrar informações da receita.", "Erro de leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                foreach (Receitas r in receitaSearch)
                {
                    ReceitasView.Items.Add(r.nome);
                }
            }
        }

        private void ReceitasView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReceitasView.SelectedIndices.Count == 0)
            {
                resetAll();
            }
            else
            {
                Receitas receita;
                if (search)
                {
                    receita = receitaSearch[ReceitasView.SelectedIndices[0]];
                }
                else
                {
                    receita = ReceitasList[ReceitasView.SelectedIndices[0]];
                }
                Prep.Text = receita.preparacao.ToString();
                cat.Text = receita.categoria;
                dif.Text = receita.dificuldadte;
                PessoasWid.Text = receita.numeroPessoas.ToString();
                for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                {
                    IngredientesList.Rows.Add(receita.ingredientes[ingrediente], receita.quantidade[ingrediente].ToString(), receita.medida[ingrediente]);
                }
            }
        }
        private void resetAll()
        {
            Prep.Text = "";
            PessoasWid.Text = "";
            dif.Text = "";
            cat.Text = "";
            IngredientesList.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = false;
            CampoWid.Text = "";
            ValorWid.Text = "";
            ReceitasView.Items.Clear();
            foreach (Receitas receita in ReceitasList)
            {
                ReceitasView.Items.Add(receita.nome);
            }
        }

     /*   private Receitas SearchXml0(string campo, string valor)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Receitas.xml");

            XmlNode receitaNo = xmlDoc.SelectSingleNode("//Receita");

            // XmlNode n = receitaNo.SelectSingleNode("//Nome");

            foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
            {
                XmlNode node = receitaE.SelectSingleNode(campo);
                if (node.InnerText == valor)
                {
                    Receitas receita = new Receitas();
                    receita.nome = receitaE.SelectSingleNode("Nome").InnerText;
                    receita.categoria = receitaE.SelectSingleNode("Categoria").InnerText;
                    receita.dificuldadte = receitaE.SelectSingleNode("Dificuldade").InnerText;
                    receita.descricao = receitaE.SelectSingleNode("Descricao").InnerText;
                    receita.preparacao = DateTime.Parse(receitaE.SelectSingleNode("Preparacao").InnerText);
                    receita.numeroPessoas =  Byte.Parse(receitaE.SelectSingleNode("Pessoas").InnerText);

                    XmlNodeList IngredientesNode = receitaE.SelectNodes("Ingredientes/Ingrediente");

                    for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                    {
                        XmlNode ingredienteNode = IngredientesNode[ingrediente];
                        receita.ingredientes.Add(ingredienteNode["Nome"].InnerText);
                        receita.quantidade.Add(byte.Parse(ingredienteNode["Quantidade"].InnerText));
                        receita.medida.Add(ingredienteNode["Medida"].InnerText);
                    }
                    return receita;
                }
            }
            return null;
        } */

        private List<Receitas> SearchXml(string campo, string valor)
        {

            List<Receitas> SearchReceitas = new List<Receitas>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Receitas.xml");

            XmlNode receitaNo = xmlDoc.SelectSingleNode("//Receita");

            // XmlNode n = receitaNo.SelectSingleNode("//Nome");

            foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
            {
                XmlNode node = receitaE.SelectSingleNode(campo);
                if (node.InnerText == valor)
                {
                    Receitas receita = new Receitas();
                    receita.nome = receitaE.SelectSingleNode("Nome").InnerText;
                    receita.categoria = receitaE.SelectSingleNode("Categoria").InnerText;
                    receita.dificuldadte = receitaE.SelectSingleNode("Dificuldade").InnerText;
                    receita.descricao = receitaE.SelectSingleNode("Descricao").InnerText;
                    receita.preparacao = DateTime.Parse(receitaE.SelectSingleNode("Preparacao").InnerText);
                    receita.numeroPessoas = Byte.Parse(receitaE.SelectSingleNode("Pessoas").InnerText);

                    XmlNodeList IngredientesNode = receitaE.SelectNodes("Ingredientes/Ingrediente");

                    for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                    {
                        XmlNode ingredienteNode = IngredientesNode[ingrediente];
                        receita.ingredientes.Add(ingredienteNode["Nome"].InnerText);
                        receita.quantidade.Add(byte.Parse(ingredienteNode["Quantidade"].InnerText));
                        receita.medida.Add(ingredienteNode["Medida"].InnerText);
                    }
                    SearchReceitas.Add( receita);
                }
            }
            return SearchReceitas.Count == 0 ? null : SearchReceitas;
        }

    }
}
