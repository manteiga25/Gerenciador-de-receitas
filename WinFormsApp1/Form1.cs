using System.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private List<Receitas> ReceitasList = new List<Receitas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Receitas.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Receitas.xml");

                foreach (XmlNode no in doc.SelectNodes("//Receita"))
                {
                    Receitas receitas = new Receitas();

                    receitas.nome = no["Nome"].InnerText;
                    receitas.categoria = no["Categoria"].InnerText;
                    receitas.dificuldadte = no["Dificuldade"].InnerText;
                    receitas.descricao = no["Descricao"].InnerText;
                    receitas.preparacao = DateTime.Parse(no["Preparacao"].InnerText);
                    receitas.numeroPessoas = byte.Parse(no["Pessoas"].InnerText);

                    XmlNodeList IngredientesNode = no.SelectNodes("Ingredientes/Ingrediente");

                    for (byte ingrediente = 0; ingrediente < IngredientesNode.Count; ingrediente++)
                    {
                        XmlNode ingredienteNode = IngredientesNode[ingrediente];
                        receitas.ingredientes.Add(ingredienteNode["Nome"].InnerText);
                        receitas.quantidade.Add(byte.Parse(ingredienteNode["Quantidade"].InnerText));
                        receitas.medida.Add(ingredienteNode["Medida"].InnerText);
                    }

                    ReceitasList.Add(receitas);

                }
            }
            else
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement root = xmldoc.CreateElement("Receitas");
                xmldoc.AppendChild(root);
                xmldoc.Save("Receitas.xml");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NovaReceita window = new NovaReceita(ReceitasList);
            window.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VerReceitas window = new VerReceitas(ReceitasList);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GerirReceitas window = new GerirReceitas(ReceitasList);
        }

        private void vScrollBar1_MouseEnter(object sender, EventArgs e)
        {
            NovaReceita window = new NovaReceita(ReceitasList);
            window.ShowDialog();
        }

        private void label1_MouseCaptureChanged(object sender, EventArgs e)
        {
            NovaReceita window = new NovaReceita(ReceitasList);
            window.ShowDialog();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            VerReceitas window = new VerReceitas(ReceitasList);
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            GerirReceitas window = new GerirReceitas(ReceitasList);
        }
    }
}
