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
using System.Xml.Linq;

namespace WinFormsApp1
{

    public partial class GerirReceitas : Form
    {

        private List<Receitas> ReceitasList = null;

        private int ReceitaAtual;
        private string nomeAntigo;
        public GerirReceitas(List<Receitas> ReceitasList)
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

        private bool CheckItems(Receitas receita)
        {
            if (receita.nome != "" && receita.dificuldadte != "" && receita.descricao != "" && receita.categoria != "" && receita.numeroPessoas != 0 && !receita.preparacao.Equals("00:00:00") && receita.ingredientes.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void ReceitasView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReceitasView.SelectedIndices.Count == 0)
            {
                edit.Enabled = false;
                remove.Enabled = false;
            }
            else
            {
                edit.Enabled = true;
                remove.Enabled = true;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            save.Enabled = true;
            cancelar.Enabled = true;
            remove.Enabled = false;
            stateWidgets(true);
            ReceitaAtual = ReceitasView.SelectedIndices[0];
            Receitas receita = ReceitasList[ReceitaAtual];
            nomeText.Text = receita.nome;
            PessoasSpinner.Value = receita.numeroPessoas;
            DificuldadeBox.Text = receita.dificuldadte;
            CategoriaBox.Text = receita.categoria;
            PreparacaoText.Text = receita.descricao;
            Duracao.Value = receita.preparacao;

            for (int ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
            {
                IngredientesList.Rows.Add(receita.ingredientes[ingrediente], receita.quantidade[ingrediente], receita.medida[ingrediente]);
            }

        }

        private void IngredientesList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (IngredientesList.Columns[e.ColumnIndex].HeaderText == "Quantidade") { }
            // Verifique se o valor da célula é nulo ou vazio
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()) || IngredientesList.Columns[e.ColumnIndex].HeaderText == "Quantidade" && (Convert.ToByte(e.FormattedValue.ToString()) <= 0 || Convert.ToByte(e.FormattedValue.ToString()) > 10))
            {
                // Exibe uma mensagem de erro, alertando o usuário
                MessageBox.Show("Este campo não pode ser vazio", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Cancela a edição e mantém o valor original da célula
                e.Cancel = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Receitas receita = new Receitas();
            receita.nome = nomeText.Text;
            receita.numeroPessoas = (byte)PessoasSpinner.Value;
            receita.dificuldadte = DificuldadeBox.Text;
            receita.categoria = CategoriaBox.Text;
            receita.descricao = PreparacaoText.Text;
            receita.preparacao = Duracao.Value;

            List<string> ingredientesNome = new List<string>();
            List<byte> IngredientesQuantidade = new List<byte>();
            List<string> IngredientesMedidas = new List<string>();

            for (byte ingredient = 0; ingredient < IngredientesList.Rows.Count; ingredient++)
            {
                Console.WriteLine(ingredient);
                DataGridViewRow row = IngredientesList.Rows[ingredient];
                ingredientesNome.Add(row.Cells[0].Value.ToString());
                IngredientesQuantidade.Add(Convert.ToByte(row.Cells[1].Value));
                IngredientesMedidas.Add(row.Cells[2].Value.ToString());
            }

            receita.ingredientes = ingredientesNome;
            receita.quantidade = IngredientesQuantidade;
            receita.medida = IngredientesMedidas;

            if (CheckItems(receita))
            {

                nomeAntigo = ReceitasList[ReceitaAtual].nome;

                ReceitasList[ReceitaAtual] = receita;

                if (saveXML(receita))
                {
                    ReceitasView.Enabled = true;
                    ReceitasView.SelectedItems[0].Text = receita.nome;
                    resetAll();
                    stateWidgets(false);
                    ReceitasView.SelectedItems[0].Selected = false;
                    resetMenu();
                }
            } else
            {
                MessageBox.Show("Preencha todos os campos", "SSem campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void stateWidgets(bool state)
        {
            ReceitasView.Enabled = !state;
            nomeText.Enabled = state;
            PessoasSpinner.Enabled = state;
            DificuldadeBox.Enabled = state;
            CategoriaBox.Enabled = state;
            PreparacaoText.Enabled = state;
            Duracao.Enabled = state;
        }

        private void resetAll()
        {
            nomeText.Text = "";
            PessoasSpinner.Value = 1;
            DificuldadeBox.SelectedIndex = -1;
            CategoriaBox.SelectedIndex = -1;
            PreparacaoText.Text = "";
            Duracao.Value = DateTime.Parse("00:00:00");
            IngredientesList.Rows.Clear();
        }

        private void resetMenu()
        {
            if (ReceitasView.SelectedIndices.Count == 0)
            {
                edit.Enabled = false;
            }
            cancelar.Enabled = false;
            save.Enabled = false;
            remove.Enabled = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            resetAll();
            stateWidgets(false);
            resetMenu();
        }

        private bool saveXML(Receitas receita)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Receitas.xml");

                XmlNode receitaNo = xmlDoc.SelectSingleNode("//Receita");

               // XmlNode n = receitaNo.SelectSingleNode("//Nome");

                foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
                {
                    XmlNode node = receitaE.SelectSingleNode("Nome");
                    if (node.InnerText == nomeAntigo)
                    {
                        node.InnerText = receita.nome;
                        receitaE.SelectSingleNode("Categoria").InnerText = receita.categoria;
                        receitaE.SelectSingleNode("Dificuldade").InnerText = receita.dificuldadte;
                        receitaE.SelectSingleNode("Descricao").InnerText = receita.descricao;
                        receitaE.SelectSingleNode("Preparacao").InnerText = receita.preparacao.ToString();
                        receitaE.SelectSingleNode("Pessoas").InnerText = receita.numeroPessoas.ToString();

                        XmlNode ingredientesNode = receitaE.SelectSingleNode("Ingredientes");

                        if (ingredientesNode != null)
                        {
                            // Iterar sobre cada ingrediente
                            int pos = 0;
                            foreach (XmlNode ingrediente in ingredientesNode.SelectNodes("Ingrediente"))
                            {
                                ingrediente.SelectSingleNode("Nome").InnerText = receita.ingredientes[pos];
                                ingrediente.SelectSingleNode("Quantidade").InnerText = receita.quantidade[pos].ToString();
                                ingrediente.SelectSingleNode("Medida").InnerText = receita.medida[pos];
                                pos++;
                            }
                        }
                        break;
                    }
                }
                xmlDoc.Save("Receitas.xml");
                MessageBox.Show("XML Success", "Dados salvos com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("XML Error", "Erro ao salvar alterações.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool removeXML()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Receitas.xml");

                foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
                {
                    XmlNode node = receitaE.SelectSingleNode("Nome");
                    if (node.InnerText.Trim() == nomeAntigo.Trim())
                    {
                        receitaE.ParentNode.RemoveChild(receitaE);
                        break;
                    }
                }

                 xmlDoc.Save("Receitas.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            ReceitaAtual = ReceitasView.SelectedIndices[0];
            nomeAntigo = ReceitasList[ReceitaAtual].nome;
            if (!removeXML())
            {
                MessageBox.Show("XML Error", "Erro ao salvar alterações.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                ReceitasList.Remove(ReceitasList[ReceitaAtual]);
                ReceitasView.Items.RemoveAt(ReceitaAtual);
                MessageBox.Show("XML Success", "Dados salvos com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
