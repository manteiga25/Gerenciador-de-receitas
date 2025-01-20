namespace WinFormsApp1
{
    public struct Receitas
    {
        public string nome, categoria, descricao, dificuldadte;
        public List<string> ingredientes;
        public List<byte> quantidade;
        public List<string> medida;
        public byte numeroPessoas;
        public DateTime preparacao;
        public float preco;


        // Constructor
        public Receitas()
        {
            ingredientes = new List<string>();
              quantidade = new List<byte>();
             medida = new List<string>();
        }

    }
}
