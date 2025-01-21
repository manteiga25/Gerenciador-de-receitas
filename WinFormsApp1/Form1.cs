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
                try
                {
                    ReceitasList = DataXML.readXML("Receitas.xml");
                } catch(Exception ex) {
                    MessageBox.Show("Erro ao inicializar.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                try
                {
                    DataXML.createXML();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inicializar.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
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

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo xml (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    List<Receitas> NovasReceitas = DataXML.readXML(openFileDialog.FileName);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Receitas.xml");

                    DataXML.writeXml(xmlDoc, NovasReceitas);

                    xmlDoc.Save("Receitas.xml");

                    ReceitasList.AddRange(NovasReceitas);

                    MessageBox.Show("Sucesso ao importar receitas.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao importar receitas.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (ReceitasList.Count != 0)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo xml (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string caminhoCompleto = saveFileDialog.FileName;
                        File.Copy("Receitas.xml", caminhoCompleto);
                        MessageBox.Show("Sucesso ao exportar receitas.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao exportar receitas.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                MessageBox.Show("Não a receitas para exportar.", "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
