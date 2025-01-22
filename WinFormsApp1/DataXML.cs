using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    internal abstract class DataXML
    {
        public static List<Receitas> readXML(string file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            List<Receitas> NovasReceitas = new List<Receitas>();

            foreach (XmlNode no in doc.SelectNodes("//Receita"))
            {
                Receitas receitas = new Receitas();

                receitas.nome = no["Nome"].InnerText;
                receitas.categoria = no["Categoria"].InnerText;
                receitas.dificuldadte = no["Dificuldade"].InnerText;
                receitas.descricao = no["Descricao"].InnerText;
                receitas.preparacao = no["Preparacao"].InnerText;
                receitas.preco = float.Parse(no["Preco"].InnerText);
                receitas.numeroPessoas = byte.Parse(no["Pessoas"].InnerText);
                receitas.preco = float.Parse(no["Preco"].InnerText);
                receitas.imagem = no["Imagem"].InnerText;

                XmlNodeList IngredientesNode = no.SelectNodes("Ingredientes/Ingrediente");

                for (byte ingrediente = 0; ingrediente < IngredientesNode.Count; ingrediente++)
                {
                    XmlNode ingredienteNode = IngredientesNode[ingrediente];
                    receitas.ingredientes.Add(ingredienteNode["Nome"].InnerText);
                    receitas.quantidade.Add(byte.Parse(ingredienteNode["Quantidade"].InnerText));
                    receitas.medida.Add(ingredienteNode["Medida"].InnerText);
                }

                NovasReceitas.Add(receitas);

            }
            return NovasReceitas;
        }

        public static List<Receitas> SearchXml(string campo, string valor)
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
                    receita.preparacao = receitaE.SelectSingleNode("Preparacao").InnerText;
                    receita.preco = float.Parse(receitaE.SelectSingleNode("Preco").InnerText);
                    receita.numeroPessoas = Byte.Parse(receitaE.SelectSingleNode("Pessoas").InnerText);
                    receita.preco = float.Parse(receitaE.SelectSingleNode("Preco").InnerText);
                    receita.imagem = receitaE.SelectSingleNode("Imagem").InnerText;

                    XmlNodeList IngredientesNode = receitaE.SelectNodes("Ingredientes/Ingrediente");

                    for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                    {
                        XmlNode ingredienteNode = IngredientesNode[ingrediente];
                        receita.ingredientes.Add(ingredienteNode["Nome"].InnerText);
                        receita.quantidade.Add(byte.Parse(ingredienteNode["Quantidade"].InnerText));
                        receita.medida.Add(ingredienteNode["Medida"].InnerText);
                    }
                    SearchReceitas.Add(receita);
                }
            }
            return SearchReceitas.Count == 0 ? null : SearchReceitas;
        }

        public static void writeXml(XmlDocument xmlDoc, List<Receitas> receitas)
        {
            XmlElement root = xmlDoc.DocumentElement;

            foreach (Receitas receita in receitas)
            {

                XmlElement child = xmlDoc.CreateElement("Receita");

                XmlElement nomeAttr = xmlDoc.CreateElement("Nome");
                nomeAttr.InnerText = receita.nome;
                XmlElement categoriaAttr = xmlDoc.CreateElement("Categoria");
                categoriaAttr.InnerText = receita.categoria;
                XmlElement dificuldadeAttr = xmlDoc.CreateElement("Dificuldade");
                dificuldadeAttr.InnerText = receita.dificuldadte;
                XmlElement descricaoAttr = xmlDoc.CreateElement("Descricao");
                descricaoAttr.InnerText = receita.descricao;
                XmlElement preparacaoAttr = xmlDoc.CreateElement("Preparacao");
                preparacaoAttr.InnerText = receita.preparacao;
                XmlElement precoAttr = xmlDoc.CreateElement("Preco");
                precoAttr.InnerText = receita.preco.ToString();
                XmlElement pessoasAttr = xmlDoc.CreateElement("Pessoas");
                pessoasAttr.InnerText = receita.numeroPessoas.ToString();
                XmlElement imagemAttr = xmlDoc.CreateElement("Imagem");
                imagemAttr.InnerText = receita.imagem;

                XmlElement IngredientesRoot = xmlDoc.CreateElement("Ingredientes");

                for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                {
                    XmlElement ingredienteChild = xmlDoc.CreateElement("Ingrediente");
                    XmlElement nomeIngredienteAttr = xmlDoc.CreateElement("Nome");
                    nomeIngredienteAttr.InnerText = receita.ingredientes[ingrediente];
                    XmlElement QuantidadeIngredienteAttr = xmlDoc.CreateElement("Quantidade");
                    QuantidadeIngredienteAttr.InnerText = receita.quantidade[ingrediente].ToString();
                    XmlElement MedidaIngredienteAttr = xmlDoc.CreateElement("Medida");
                    MedidaIngredienteAttr.InnerText = receita.medida[ingrediente];

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
                child.AppendChild(precoAttr);
                child.AppendChild(pessoasAttr);
                child.AppendChild(imagemAttr);
                child.AppendChild(IngredientesRoot);

                root.AppendChild(child);
            }
        }

        public static void writeXml(Receitas receita)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Receitas.xml");

            XmlElement root = xmlDoc.DocumentElement;

                XmlElement child = xmlDoc.CreateElement("Receita");

                XmlElement nomeAttr = xmlDoc.CreateElement("Nome");
                nomeAttr.InnerText = receita.nome;
                XmlElement categoriaAttr = xmlDoc.CreateElement("Categoria");
                categoriaAttr.InnerText = receita.categoria;
                XmlElement dificuldadeAttr = xmlDoc.CreateElement("Dificuldade");
                dificuldadeAttr.InnerText = receita.dificuldadte;
                XmlElement descricaoAttr = xmlDoc.CreateElement("Descricao");
                descricaoAttr.InnerText = receita.descricao;
                XmlElement preparacaoAttr = xmlDoc.CreateElement("Preparacao");
                preparacaoAttr.InnerText = receita.preparacao;
                XmlElement precoAttr = xmlDoc.CreateElement("Preco");
                precoAttr.InnerText = receita.preco.ToString();
                XmlElement pessoasAttr = xmlDoc.CreateElement("Pessoas");
                pessoasAttr.InnerText = receita.numeroPessoas.ToString();
                XmlElement imagemAttr = xmlDoc.CreateElement("Imagem");
                imagemAttr.InnerText = receita.imagem;

                XmlElement IngredientesRoot = xmlDoc.CreateElement("Ingredientes");

                for (byte ingrediente = 0; ingrediente < receita.ingredientes.Count; ingrediente++)
                {
                    XmlElement ingredienteChild = xmlDoc.CreateElement("Ingrediente");
                    XmlElement nomeIngredienteAttr = xmlDoc.CreateElement("Nome");
                    nomeIngredienteAttr.InnerText = receita.ingredientes[ingrediente];
                    XmlElement QuantidadeIngredienteAttr = xmlDoc.CreateElement("Quantidade");
                    QuantidadeIngredienteAttr.InnerText = receita.quantidade[ingrediente].ToString();
                    XmlElement MedidaIngredienteAttr = xmlDoc.CreateElement("Medida");
                    MedidaIngredienteAttr.InnerText = receita.medida[ingrediente];

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
                child.AppendChild(precoAttr);
                child.AppendChild(pessoasAttr);
                child.AppendChild(imagemAttr);
                child.AppendChild(IngredientesRoot);

                root.AppendChild(child);

            xmlDoc.Save("Receitas.xml");

        }

        public static void modifyNode(Receitas receita, string nodeName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Receitas.xml");

            XmlNode receitaNo = xmlDoc.SelectSingleNode("//Receita");

            // XmlNode n = receitaNo.SelectSingleNode("//Nome");

            foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
            {
                XmlNode node = receitaE.SelectSingleNode("Nome");
                if (node.InnerText == nodeName)
                {
                    node.InnerText = receita.nome;
                    receitaE.SelectSingleNode("Categoria").InnerText = receita.categoria;
                    receitaE.SelectSingleNode("Dificuldade").InnerText = receita.dificuldadte;
                    receitaE.SelectSingleNode("Descricao").InnerText = receita.descricao;
                    receitaE.SelectSingleNode("Preparacao").InnerText = receita.preparacao;
                    receitaE.SelectSingleNode("Preco").InnerText = receita.preco.ToString();
                    receitaE.SelectSingleNode("Pessoas").InnerText = receita.numeroPessoas.ToString();
                    receitaE.SelectSingleNode("Imagem").InnerText = receita.imagem;

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
        }

        public static void removeNode(string nodeName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Receitas.xml");

            foreach (XmlNode receitaE in xmlDoc.SelectNodes("//Receita"))
            {
                XmlNode node = receitaE.SelectSingleNode("Nome");
                if (node.InnerText.Trim() == nodeName.Trim())
                {
                    receitaE.ParentNode.RemoveChild(receitaE);
                    break;
                }
            }

            xmlDoc.Save("Receitas.xml");
        }

        public static void createXML()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Receitas");
            xmldoc.AppendChild(root);
            xmldoc.Save("Receitas.xml");
        }

    }
}
