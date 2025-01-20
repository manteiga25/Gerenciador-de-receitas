using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class NovaReceita : Form
    {

        private List<Receitas> ReceitasList = null;

        public NovaReceita(List<Receitas> ReceitasList)
        {
            this.ReceitasList = ReceitasList;
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IngredientText_TextChanged(object sender, EventArgs e)
        {
            string ingrediente = IngredientText.Text;
        }

        private void Inserir_Clicked(object sender, EventArgs e)
        {
            string ingrediente = IngredientText.Text;
            byte quantidade = (byte) quantidadeSpinner.Value;
            string medida = MedidaBox.Text;

            if (ingrediente != "" && quantidade != 0 && medida != "") {
                IngredientesMatriz.Rows.Add(ingrediente, quantidade, medida);
                freeIngredientes();
            } else
            {
                MessageBox.Show("Voce precida preencher todos os campos.");
            }

        }

        private void freeIngredientes()
        {
            IngredientText.Text = "";
            quantidadeSpinner.Value = 1;
            MedidaBox.SelectedIndex = -1;
        }

        private void NovaReceita_Load(object sender, EventArgs e)
        {
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void freeAll()
        {
            NomeText.Text = "";
            DificuldadeBox.SelectedIndex = -1;
            PreparacaoText.Text = "";
            DificuldadeBox.SelectedIndex = -1;
            CategoriaBox.Text = "";
            PessoasSpinner.Value = 1;
            IngredientesMatriz.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = NomeText.Text;
            string dificuldade = DificuldadeBox.Text;
            string descricao = PreparacaoText.Text;
            string categoria = CategoriaBox.Text;
            byte numeroPessoas = (byte) PessoasSpinner.Value;
            DateTime preparacao = Duracao.Value;
            byte numeroIngredientes = (byte) IngredientesMatriz.Rows.Count;

            string[] ingredientesNome = new string[numeroIngredientes];
            byte[] ingredientesQuantidade = new byte[numeroIngredientes];
            string[] ingredientesMedidas = new string[numeroIngredientes];

            for (byte ingredient = 0; ingredient < numeroIngredientes; ingredient++)
            {
                DataGridViewRow row = IngredientesMatriz.Rows[ingredient];
                ingredientesNome[ingredient] = row.Cells[0].Value.ToString();
                ingredientesQuantidade[ingredient] = (byte) row.Cells[1].Value;
                ingredientesMedidas[ingredient] = row.Cells[2].Value.ToString();
            }

            if (nome != "" && dificuldade != "" && descricao != "" && categoria != "" && numeroPessoas != 0 && !preparacao.Equals("00:00:00") && numeroIngredientes != 0)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Receitas.xml");

                XmlElement root = xmlDoc.DocumentElement;

                XmlElement child = xmlDoc.CreateElement("Receita");

                XmlElement nomeAttr = xmlDoc.CreateElement("Nome");
                nomeAttr.InnerText = nome;
                XmlElement categoriaAttr = xmlDoc.CreateElement("Categoria");
                categoriaAttr.InnerText = categoria;
                XmlElement dificuldadeAttr = xmlDoc.CreateElement("Dificuldade");
                dificuldadeAttr.InnerText = dificuldade;
                XmlElement descricaoAttr = xmlDoc.CreateElement("Descricao");
                descricaoAttr.InnerText = descricao;
                XmlElement preparacaoAttr = xmlDoc.CreateElement("Preparacao");
                preparacaoAttr.InnerText = preparacao.ToString();
                XmlElement pessoasAttr = xmlDoc.CreateElement("Pessoas");
                pessoasAttr.InnerText = numeroPessoas.ToString();

                XmlElement IngredientesRoot = xmlDoc.CreateElement("Ingredientes");

                for (byte ingrediente = 0; ingrediente < numeroIngredientes; ingrediente++)
                {
                    XmlElement ingredienteChild = xmlDoc.CreateElement("Ingrediente");
                    XmlElement nomeIngredienteAttr = xmlDoc.CreateElement("Nome");
                    nomeIngredienteAttr.InnerText = ingredientesNome[ingrediente];
                    XmlElement QuantidadeIngredienteAttr = xmlDoc.CreateElement("Quantidade");
                    QuantidadeIngredienteAttr.InnerText = ingredientesQuantidade[ingrediente].ToString();
                    XmlElement MedidaIngredienteAttr = xmlDoc.CreateElement("Medida");
                    MedidaIngredienteAttr.InnerText = ingredientesMedidas[ingrediente];

                    ingredienteChild.AppendChild(nomeIngredienteAttr);
                    ingredienteChild.AppendChild(QuantidadeIngredienteAttr);
                    ingredienteChild.AppendChild(MedidaIngredienteAttr);

                    IngredientesRoot.AppendChild(ingredienteChild);

                }

                child.AppendChild(nomeAttr);
                child.AppendChild(categoriaAttr);
                child.AppendChild(dificuldadeAttr);
                child.AppendChild(descricaoAttr);
                child.AppendChild(preparacaoAttr);
                child.AppendChild(pessoasAttr);
                child.AppendChild(IngredientesRoot);

                root.AppendChild(child);

                xmlDoc.Save("Receitas.xml");

                freeAll();

                Receitas receita = new Receitas();
                receita.nome = nome;
                receita.categoria = categoria;
                receita.descricao = descricao;
                receita.dificuldadte = dificuldade;
                receita.numeroPessoas = numeroPessoas;
                receita.preparacao = preparacao;
                receita.ingredientes = ingredientesNome.ToList<string>();
                receita.quantidade = ingredientesQuantidade.ToList<byte>();
                receita.medida = ingredientesMedidas.ToList<string>();

                ReceitasList.Add(receita);

            } else
            {
                MessageBox.Show("Voce precida preencher todos os campos.");
            }

        }
    }
}
