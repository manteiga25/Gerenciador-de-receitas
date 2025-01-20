namespace WinFormsApp1
{
    partial class VerReceitas
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            CampoWid = new ComboBox();
            ValorWid = new TextBox();
            ReceitasView = new ListView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cat = new Label();
            dif = new Label();
            PessoasWid = new Label();
            Prep = new Label();
            IngredientesList = new DataGridView();
            Ingrediente = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientesList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CampoWid);
            groupBox1.Controls.Add(ValorWid);
            groupBox1.Location = new Point(19, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultas";
            // 
            // button2
            // 
            button2.Location = new Point(193, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Repor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 91);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Campo";
            // 
            // CampoWid
            // 
            CampoWid.DropDownStyle = ComboBoxStyle.DropDownList;
            CampoWid.FormattingEnabled = true;
            CampoWid.Items.AddRange(new object[] { "Nome", "Categoria", "Dificuldade", "Nº Pessoas", "Tempo de Preparação" });
            CampoWid.Location = new Point(73, 22);
            CampoWid.Name = "CampoWid";
            CampoWid.Size = new Size(195, 23);
            CampoWid.TabIndex = 1;
            // 
            // ValorWid
            // 
            ValorWid.Location = new Point(73, 56);
            ValorWid.Name = "ValorWid";
            ValorWid.Size = new Size(195, 23);
            ValorWid.TabIndex = 0;
            // 
            // ReceitasView
            // 
            ReceitasView.Location = new Point(19, 150);
            ReceitasView.MultiSelect = false;
            ReceitasView.Name = "ReceitasView";
            ReceitasView.Size = new Size(291, 288);
            ReceitasView.TabIndex = 1;
            ReceitasView.UseCompatibleStateImageBehavior = false;
            ReceitasView.SelectedIndexChanged += ReceitasView_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Ingredientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 87);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 87);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Dificuldade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(628, 45);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 9;
            label6.Text = "Nº Pessoas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 44);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 10;
            label7.Text = "Horas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 42);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 11;
            label8.Text = "Tempo Preparação";
            // 
            // cat
            // 
            cat.BorderStyle = BorderStyle.FixedSingle;
            cat.Location = new Point(699, 83);
            cat.Name = "cat";
            cat.Size = new Size(105, 24);
            cat.TabIndex = 12;
            // 
            // dif
            // 
            dif.BorderStyle = BorderStyle.FixedSingle;
            dif.Location = new Point(453, 84);
            dif.Name = "dif";
            dif.Size = new Size(124, 23);
            dif.TabIndex = 13;
            // 
            // PessoasWid
            // 
            PessoasWid.BorderStyle = BorderStyle.FixedSingle;
            PessoasWid.Location = new Point(699, 45);
            PessoasWid.Name = "PessoasWid";
            PessoasWid.Size = new Size(30, 20);
            PessoasWid.TabIndex = 14;
            // 
            // Prep
            // 
            Prep.BorderStyle = BorderStyle.FixedSingle;
            Prep.Location = new Point(453, 41);
            Prep.Name = "Prep";
            Prep.Size = new Size(80, 20);
            Prep.TabIndex = 15;
            // 
            // IngredientesList
            // 
            IngredientesList.AllowUserToAddRows = false;
            IngredientesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientesList.Columns.AddRange(new DataGridViewColumn[] { Ingrediente, Quantidade, Medida });
            IngredientesList.Location = new Point(342, 150);
            IngredientesList.Margin = new Padding(2);
            IngredientesList.MultiSelect = false;
            IngredientesList.Name = "IngredientesList";
            IngredientesList.ReadOnly = true;
            IngredientesList.RowHeadersVisible = false;
            IngredientesList.RowHeadersWidth = 62;
            IngredientesList.Size = new Size(503, 288);
            IngredientesList.TabIndex = 16;
            // 
            // Ingrediente
            // 
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.MinimumWidth = 8;
            Ingrediente.Name = "Ingrediente";
            Ingrediente.ReadOnly = true;
            Ingrediente.Width = 200;
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
            Medida.Resizable = DataGridViewTriState.True;
            Medida.Width = 150;
            // 
            // VerReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(IngredientesList);
            Controls.Add(Prep);
            Controls.Add(PessoasWid);
            Controls.Add(dif);
            Controls.Add(cat);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(ReceitasView);
            Controls.Add(groupBox1);
            Name = "VerReceitas";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox CampoWid;
        private TextBox ValorWid;
        private Button button2;
        private Button button1;
        private ListView ReceitasView;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label cat;
        private Label dif;
        private Label PessoasWid;
        private Label Prep;
        private DataGridView IngredientesList;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Medida;
    }
}