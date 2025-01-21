using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        private Image imagemPadrao;

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
            byte quantidade = (byte)quantidadeSpinner.Value;
            string medida = MedidaBox.Text;

            if (ingrediente != "" && quantidade != 0 && medida != "")
            {
                IngredientesMatriz.Rows.Add(ingrediente, quantidade, medida);
                freeIngredientes();
            }
            else
            {
                MessageBox.Show("Voce precida preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            imagemPadrao = Imagem.Image;
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
            CategoriaBox.SelectedIndex = -1;
            PessoasSpinner.Value = 1;
            IngredientesMatriz.Rows.Clear();
            Duracao.Value = DateTimePicker.MinimumDateTime;
            Imagem.Image = imagemPadrao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = NomeText.Text;
            string dificuldade = DificuldadeBox.Text;
            string descricao = PreparacaoText.Text;
            string categoria = CategoriaBox.Text;
            byte numeroPessoas = (byte)PessoasSpinner.Value;
            string preparacao = Duracao.Value.ToString("HH:mm:ss");
            byte numeroIngredientes = (byte)IngredientesMatriz.Rows.Count;

            string[] ingredientesNome = new string[numeroIngredientes];
            byte[] ingredientesQuantidade = new byte[numeroIngredientes];
            string[] ingredientesMedidas = new string[numeroIngredientes];

            for (byte ingredient = 0; ingredient < numeroIngredientes; ingredient++)
            {
                DataGridViewRow row = IngredientesMatriz.Rows[ingredient];
                ingredientesNome[ingredient] = row.Cells[0].Value.ToString();
                ingredientesQuantidade[ingredient] = (byte)row.Cells[1].Value;
                ingredientesMedidas[ingredient] = row.Cells[2].Value.ToString();
            }

            try
            {

                if (nome != "" && dificuldade != "" && descricao != "" && categoria != "" && numeroPessoas != 0 && !preparacao.Equals("00:00:00") && numeroIngredientes != 0 && !Imagem.Image.Equals(imagemPadrao))
                {

                    Receitas receita = new Receitas();
                    receita.nome = nome;
                    receita.categoria = categoria;
                    receita.descricao = descricao;
                    receita.dificuldadte = dificuldade;
                    receita.numeroPessoas = numeroPessoas;
                    receita.preparacao = preparacao;
                    receita.BitmapToBase64(new Bitmap(Imagem.Image));
                    receita.ingredientes = ingredientesNome.ToList<string>();
                    receita.quantidade = ingredientesQuantidade.ToList<byte>();
                    receita.medida = ingredientesMedidas.ToList<string>();

                    DataXML.writeXml(receita);

                    ReceitasList.Add(receita);

                    freeAll();
                }
                else
                {
                    MessageBox.Show("Voce precida preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar receita\n." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo jpg (*.jpg)|*.jpg | Arquivo png (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoCompleto = openFileDialog.FileName;
                    MemoryStream stream = new MemoryStream();
                    Image image = Image.FromFile(caminhoCompleto);

                    Bitmap bitmap = new Bitmap(image, 216, 160);

                    bitmap.Save(stream, ImageFormat.Bmp);

                    image.Dispose();
                    bitmap.Dispose();

                    Imagem.Image = new Bitmap(stream);

                }
                catch
                {
                    MessageBox.Show("Erro ao carregar imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
        }
    }
}
