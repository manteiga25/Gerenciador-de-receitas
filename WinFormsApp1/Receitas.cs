using System.Reflection.Metadata.Ecma335;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public struct Receitas
    {
        public string nome, categoria, descricao, dificuldadte, preparacao, imagem;
        public List<string> ingredientes;
        public List<byte> quantidade;
        public List<string> medida;
        public byte numeroPessoas;
        public float preco;

        public Bitmap getImage()
        {
            byte[] byteBuffer = Convert.FromBase64String(imagem);
            using (MemoryStream memoryStream = new MemoryStream(byteBuffer))
            {
                return new Bitmap(memoryStream);
            }
        }

        public void BitmapToBase64(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png); // Salva o Bitmap no formato PNG
                byte[] byteArray = ms.ToArray(); // Converte para um array de bytes
                imagem = Convert.ToBase64String(byteArray); // Codifica em Base64
            }
        }

        public Bitmap Base64ToBitmap(string base64String)
        {
            byte[] byteArray = Convert.FromBase64String(base64String); // Decodifica de Base64
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms); // Converte os bytes para um Bitmap
            }
        }

        public Bitmap getBitmap()
        {
            byte[] byteArray = Convert.FromBase64String(imagem); // Decodifica de Base64
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms); // Converte os bytes para um Bitmap
            }
        }


        // Constructor
        public Receitas()
        {
            ingredientes = new List<string>();
              quantidade = new List<byte>();
             medida = new List<string>();
        }

    }
}
