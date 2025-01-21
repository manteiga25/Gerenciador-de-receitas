namespace WinFormsApp1
{
    partial class NovaReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaReceita));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            MedidaBox = new ComboBox();
            quantidadeSpinner = new NumericUpDown();
            Inserir = new Button();
            IngredientesMatriz = new DataGridView();
            Ingrediente = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            IngredientText = new TextBox();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            NomeText = new TextBox();
            PreparacaoText = new RichTextBox();
            PessoasSpinner = new NumericUpDown();
            DificuldadeBox = new ComboBox();
            CategoriaBox = new ComboBox();
            Duracao = new DateTimePicker();
            Imagem = new PictureBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantidadeSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientesMatriz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PessoasSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrediente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 218);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Preparação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Dificuldade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 139);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 181);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 5;
            label6.Text = "Nº Pessoas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 57);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "horas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 56);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 7;
            label8.Text = "Tempo de preparação";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MedidaBox);
            groupBox1.Controls.Add(quantidadeSpinner);
            groupBox1.Controls.Add(Inserir);
            groupBox1.Controls.Add(IngredientesMatriz);
            groupBox1.Controls.Add(IngredientText);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 278);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredientes";
            // 
            // MedidaBox
            // 
            MedidaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MedidaBox.FormattingEnabled = true;
            MedidaBox.Items.AddRange(new object[] { "Quilograma", "Decigrama", "Grama", "Litro", "Deccilitro", "Mililitro", "Unidade" });
            MedidaBox.Location = new Point(203, 61);
            MedidaBox.Name = "MedidaBox";
            MedidaBox.Size = new Size(164, 23);
            MedidaBox.TabIndex = 17;
            // 
            // quantidadeSpinner
            // 
            quantidadeSpinner.Location = new Point(92, 62);
            quantidadeSpinner.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            quantidadeSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantidadeSpinner.Name = "quantidadeSpinner";
            quantidadeSpinner.ReadOnly = true;
            quantidadeSpinner.Size = new Size(58, 23);
            quantidadeSpinner.TabIndex = 17;
            quantidadeSpinner.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Inserir
            // 
            Inserir.Location = new Point(370, 62);
            Inserir.Name = "Inserir";
            Inserir.Size = new Size(75, 23);
            Inserir.TabIndex = 14;
            Inserir.Text = "Inserir";
            Inserir.UseVisualStyleBackColor = true;
            Inserir.Click += Inserir_Clicked;
            // 
            // IngredientesMatriz
            // 
            IngredientesMatriz.AllowUserToAddRows = false;
            IngredientesMatriz.AllowUserToDeleteRows = false;
            IngredientesMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientesMatriz.Columns.AddRange(new DataGridViewColumn[] { Ingrediente, Quantidade, Medida });
            IngredientesMatriz.Location = new Point(6, 91);
            IngredientesMatriz.Name = "IngredientesMatriz";
            IngredientesMatriz.ReadOnly = true;
            IngredientesMatriz.RowHeadersVisible = false;
            IngredientesMatriz.RowHeadersWidth = 62;
            IngredientesMatriz.Size = new Size(548, 181);
            IngredientesMatriz.TabIndex = 13;
            IngredientesMatriz.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ingrediente
            // 
            Ingrediente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.MinimumWidth = 8;
            Ingrediente.Name = "Ingrediente";
            Ingrediente.ReadOnly = true;
            Ingrediente.Width = 250;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 8;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 150;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.MinimumWidth = 8;
            Medida.Name = "Medida";
            Medida.ReadOnly = true;
            Medida.Width = 150;
            // 
            // IngredientText
            // 
            IngredientText.Location = new Point(91, 26);
            IngredientText.Name = "IngredientText";
            IngredientText.Size = new Size(232, 23);
            IngredientText.TabIndex = 12;
            IngredientText.TextChanged += IngredientText_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 65);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 3;
            label10.Text = "Quantidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 66);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 2;
            label9.Text = "Medida";
            // 
            // button1
            // 
            button1.Location = new Point(504, 583);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 583);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "sair";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += close;
            // 
            // NomeText
            // 
            NomeText.Location = new Point(76, 19);
            NomeText.Name = "NomeText";
            NomeText.Size = new Size(232, 23);
            NomeText.TabIndex = 11;
            // 
            // PreparacaoText
            // 
            PreparacaoText.Location = new Point(96, 218);
            PreparacaoText.Name = "PreparacaoText";
            PreparacaoText.Size = new Size(483, 75);
            PreparacaoText.TabIndex = 12;
            PreparacaoText.Text = "";
            // 
            // PessoasSpinner
            // 
            PessoasSpinner.Location = new Point(104, 179);
            PessoasSpinner.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            PessoasSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PessoasSpinner.Name = "PessoasSpinner";
            PessoasSpinner.ReadOnly = true;
            PessoasSpinner.Size = new Size(58, 23);
            PessoasSpinner.TabIndex = 13;
            PessoasSpinner.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DificuldadeBox
            // 
            DificuldadeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DificuldadeBox.FormattingEnabled = true;
            DificuldadeBox.Items.AddRange(new object[] { "Muito Fácil", "Fácil", "Moderado", "Difícil", "Muito Difícil" });
            DificuldadeBox.Location = new Point(104, 100);
            DificuldadeBox.Name = "DificuldadeBox";
            DificuldadeBox.Size = new Size(164, 23);
            DificuldadeBox.TabIndex = 14;
            // 
            // CategoriaBox
            // 
            CategoriaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaBox.FormattingEnabled = true;
            CategoriaBox.Items.AddRange(new object[] { "Entradas", "Sopa", "Carne", "Peixe", "Marísco", "Molhos e Temperos", "Saladas", "Pastelaria", "Sobremesas" });
            CategoriaBox.Location = new Point(104, 139);
            CategoriaBox.Name = "CategoriaBox";
            CategoriaBox.Size = new Size(164, 23);
            CategoriaBox.TabIndex = 15;
            // 
            // Duracao
            // 
            Duracao.CustomFormat = "HH:mm:ss";
            Duracao.Format = DateTimePickerFormat.Custom;
            Duracao.Location = new Point(155, 54);
            Duracao.Name = "Duracao";
            Duracao.ShowUpDown = true;
            Duracao.Size = new Size(79, 23);
            Duracao.TabIndex = 16;
            Duracao.Value = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            // 
            // Imagem
            // 
            Imagem.Image = (Image)resources.GetObject("Imagem.Image");
            Imagem.InitialImage = (Image)resources.GetObject("Imagem.InitialImage");
            Imagem.Location = new Point(363, 42);
            Imagem.Name = "Imagem";
            Imagem.Size = new Size(216, 160);
            Imagem.TabIndex = 17;
            Imagem.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(363, 18);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 18;
            button3.Text = "Select Image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // NovaReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 655);
            Controls.Add(button3);
            Controls.Add(Imagem);
            Controls.Add(Duracao);
            Controls.Add(CategoriaBox);
            Controls.Add(DificuldadeBox);
            Controls.Add(PessoasSpinner);
            Controls.Add(PreparacaoText);
            Controls.Add(NomeText);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "NovaReceita";
            Text = "Form2";
            Load += NovaReceita_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantidadeSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientesMatriz).EndInit();
            ((System.ComponentModel.ISupportInitialize)PessoasSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private DataGridView IngredientesMatriz;
        private TextBox IngredientText;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox NomeText;
        private RichTextBox PreparacaoText;
        private NumericUpDown PessoasSpinner;
        private ComboBox DificuldadeBox;
        private ComboBox CategoriaBox;
        private DateTimePicker Duracao;
        private ComboBox MedidaBox;
        private NumericUpDown quantidadeSpinner;
        private Button Inserir;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Medida;
        private PictureBox Imagem;
        private Button button3;
    }
}