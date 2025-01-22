namespace WinFormsApp1
{
    partial class GerirReceitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirReceitas));
            toolStrip1 = new ToolStrip();
            edit = new ToolStripButton();
            cancelar = new ToolStripButton();
            save = new ToolStripButton();
            remove = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            IngredientesList = new DataGridView();
            Ingrediente = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewComboBoxColumn();
            nomeText = new TextBox();
            Duracao = new DateTimePicker();
            PessoasSpinner = new NumericUpDown();
            DificuldadeBox = new ComboBox();
            CategoriaBox = new ComboBox();
            PreparacaoText = new RichTextBox();
            ReceitasView = new ListView();
            label9 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            Imagem = new PictureBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            PrecoBox = new MaskedTextBox();
            label10 = new Label();
            ImagemBotao = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PessoasSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { edit, cancelar, save, remove });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(911, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // edit
            // 
            edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            edit.Enabled = false;
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.ImageTransparentColor = Color.Magenta;
            edit.Name = "edit";
            edit.Size = new Size(41, 22);
            edit.Text = "Editar";
            edit.Click += edit_Click;
            // 
            // cancelar
            // 
            cancelar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelar.Enabled = false;
            cancelar.Image = (Image)resources.GetObject("cancelar.Image");
            cancelar.ImageTransparentColor = Color.Magenta;
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(57, 22);
            cancelar.Text = "Cancelar";
            cancelar.Click += cancelar_Click;
            // 
            // save
            // 
            save.DisplayStyle = ToolStripItemDisplayStyle.Text;
            save.Enabled = false;
            save.Image = (Image)resources.GetObject("save.Image");
            save.ImageTransparentColor = Color.Magenta;
            save.Name = "save";
            save.Size = new Size(53, 22);
            save.Text = "Guardar";
            save.Click += save_Click;
            // 
            // remove
            // 
            remove.DisplayStyle = ToolStripItemDisplayStyle.Text;
            remove.Enabled = false;
            remove.Image = (Image)resources.GetObject("remove.Image");
            remove.ImageTransparentColor = Color.Magenta;
            remove.Name = "remove";
            remove.Size = new Size(58, 22);
            remove.Text = "Remover";
            remove.Click += remove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Dificuldade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "Nº pessoas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 82);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Horas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 82);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "Preparação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 179);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 6;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 95);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 197);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 8;
            label8.Text = "Descrição";
            // 
            // IngredientesList
            // 
            IngredientesList.AllowUserToAddRows = false;
            IngredientesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientesList.Columns.AddRange(new DataGridViewColumn[] { Ingrediente, Quantidade, Medida });
            IngredientesList.Location = new Point(11, 277);
            IngredientesList.Margin = new Padding(2);
            IngredientesList.MultiSelect = false;
            IngredientesList.Name = "IngredientesList";
            IngredientesList.RowHeadersVisible = false;
            IngredientesList.RowHeadersWidth = 62;
            IngredientesList.Size = new Size(468, 135);
            IngredientesList.TabIndex = 9;
            IngredientesList.CellValidating += IngredientesList_CellValidating;
            // 
            // Ingrediente
            // 
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.MinimumWidth = 8;
            Ingrediente.Name = "Ingrediente";
            Ingrediente.Width = 200;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 8;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 150;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.Items.AddRange(new object[] { "Quilograma", "Decigrama", "Grama", "Litro", "Deccilitro", "Mililitro", "Unidade" });
            Medida.MinimumWidth = 8;
            Medida.Name = "Medida";
            Medida.Resizable = DataGridViewTriState.True;
            Medida.SortMode = DataGridViewColumnSortMode.Automatic;
            Medida.Width = 150;
            // 
            // nomeText
            // 
            nomeText.Enabled = false;
            nomeText.Location = new Point(71, 50);
            nomeText.Margin = new Padding(2);
            nomeText.Name = "nomeText";
            nomeText.Size = new Size(181, 23);
            nomeText.TabIndex = 10;
            // 
            // Duracao
            // 
            Duracao.CustomFormat = "HH:mm:ss";
            Duracao.Enabled = false;
            Duracao.Format = DateTimePickerFormat.Custom;
            Duracao.Location = new Point(90, 76);
            Duracao.Name = "Duracao";
            Duracao.ShowUpDown = true;
            Duracao.Size = new Size(79, 23);
            Duracao.TabIndex = 17;
            Duracao.Value = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            // 
            // PessoasSpinner
            // 
            PessoasSpinner.Enabled = false;
            PessoasSpinner.Location = new Point(90, 105);
            PessoasSpinner.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            PessoasSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PessoasSpinner.Name = "PessoasSpinner";
            PessoasSpinner.ReadOnly = true;
            PessoasSpinner.Size = new Size(58, 23);
            PessoasSpinner.TabIndex = 18;
            PessoasSpinner.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DificuldadeBox
            // 
            DificuldadeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DificuldadeBox.Enabled = false;
            DificuldadeBox.FormattingEnabled = true;
            DificuldadeBox.Items.AddRange(new object[] { "Muito Fácil", "Fácil", "Moderado", "Difícil", "Muito Difícil" });
            DificuldadeBox.Location = new Point(88, 141);
            DificuldadeBox.Name = "DificuldadeBox";
            DificuldadeBox.Size = new Size(151, 23);
            DificuldadeBox.TabIndex = 19;
            // 
            // CategoriaBox
            // 
            CategoriaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaBox.Enabled = false;
            CategoriaBox.FormattingEnabled = true;
            CategoriaBox.Items.AddRange(new object[] { "Entradas", "Sopa", "Carne", "Peixe", "Marísco", "Molhos e Temperos", "Saladas", "Pastelaria", "Sobremesas" });
            CategoriaBox.Location = new Point(88, 179);
            CategoriaBox.Name = "CategoriaBox";
            CategoriaBox.Size = new Size(164, 23);
            CategoriaBox.TabIndex = 20;
            // 
            // PreparacaoText
            // 
            PreparacaoText.Enabled = false;
            PreparacaoText.Location = new Point(76, 197);
            PreparacaoText.Name = "PreparacaoText";
            PreparacaoText.Size = new Size(402, 75);
            PreparacaoText.TabIndex = 21;
            PreparacaoText.Text = "";
            // 
            // ReceitasView
            // 
            ReceitasView.Location = new Point(614, 45);
            ReceitasView.Margin = new Padding(2);
            ReceitasView.MultiSelect = false;
            ReceitasView.Name = "ReceitasView";
            ReceitasView.Size = new Size(262, 445);
            ReceitasView.TabIndex = 22;
            ReceitasView.UseCompatibleStateImageBehavior = false;
            ReceitasView.View = View.List;
            ReceitasView.SelectedIndexChanged += ReceitasView_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(614, 28);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 23;
            label9.Text = "Receitas";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Imagem
            // 
            Imagem.Image = (Image)resources.GetObject("Imagem.Image");
            Imagem.Location = new Point(331, 22);
            Imagem.Name = "Imagem";
            Imagem.Size = new Size(216, 160);
            Imagem.TabIndex = 24;
            Imagem.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(PrecoBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(ImagemBotao);
            groupBox1.Controls.Add(Imagem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(PreparacaoText);
            groupBox1.Controls.Add(IngredientesList);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 462);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receita";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(83, 425);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 28;
            label11.Text = "€";
            // 
            // PrecoBox
            // 
            PrecoBox.Location = new Point(54, 420);
            PrecoBox.Mask = "00.00";
            PrecoBox.Name = "PrecoBox";
            PrecoBox.Size = new Size(33, 23);
            PrecoBox.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 424);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 26;
            label10.Text = "Preço";
            // 
            // ImagemBotao
            // 
            ImagemBotao.Enabled = false;
            ImagemBotao.Location = new Point(245, 22);
            ImagemBotao.Name = "ImagemBotao";
            ImagemBotao.Size = new Size(85, 23);
            ImagemBotao.TabIndex = 25;
            ImagemBotao.Text = "Select Image";
            ImagemBotao.UseVisualStyleBackColor = true;
            ImagemBotao.Click += button3_Click;
            // 
            // GerirReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 506);
            Controls.Add(label9);
            Controls.Add(ReceitasView);
            Controls.Add(CategoriaBox);
            Controls.Add(DificuldadeBox);
            Controls.Add(PessoasSpinner);
            Controls.Add(Duracao);
            Controls.Add(nomeText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "GerirReceitas";
            Text = "GerirReceitas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)PessoasSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton edit;
        private ToolStripButton cancelar;
        private ToolStripButton save;
        private ToolStripButton remove;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView IngredientesList;
        private TextBox nomeText;
        private DateTimePicker Duracao;
        private NumericUpDown PessoasSpinner;
        private ComboBox DificuldadeBox;
        private ComboBox CategoriaBox;
        private RichTextBox PreparacaoText;
        private ListView ReceitasView;
        private Label label9;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewComboBoxColumn Medida;
        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox groupBox1;
        private PictureBox Imagem;
        private Button ImagemBotao;
        private Label label10;
        private Label label11;
        private MaskedTextBox PrecoBox;
    }
}