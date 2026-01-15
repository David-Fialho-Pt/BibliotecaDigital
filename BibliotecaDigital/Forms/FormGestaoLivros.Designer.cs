namespace Forms
{
    partial class FormGestaoLivros
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
            lblTituloLivro = new Label();
            lblAnoPublicacao = new Label();
            lblEditora = new Label();
            lblISBN = new Label();
            tbTitulo = new TextBox();
            tbAno = new TextBox();
            tbEditora = new TextBox();
            tbIsbn = new TextBox();
            btnAdicionarLivro = new Button();
            btnRemoverLivro = new Button();
            btnLimparFormularioLivro = new Button();
            btnAtualizarLivro = new Button();
            dgvLivros = new DataGridView();
            lblGestaoLivros = new Label();
            btnVolttar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLivro
            // 
            lblTituloLivro.AutoSize = true;
            lblTituloLivro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLivro.Location = new Point(79, 106);
            lblTituloLivro.Name = "lblTituloLivro";
            lblTituloLivro.Size = new Size(52, 20);
            lblTituloLivro.TabIndex = 0;
            lblTituloLivro.Text = "Título:";
            // 
            // lblAnoPublicacao
            // 
            lblAnoPublicacao.AutoSize = true;
            lblAnoPublicacao.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnoPublicacao.Location = new Point(79, 149);
            lblAnoPublicacao.Name = "lblAnoPublicacao";
            lblAnoPublicacao.Size = new Size(140, 20);
            lblAnoPublicacao.TabIndex = 1;
            lblAnoPublicacao.Text = "Ano de Publicação:";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditora.Location = new Point(79, 192);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(62, 20);
            lblEditora.TabIndex = 2;
            lblEditora.Text = "Editora:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(79, 235);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(46, 20);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // tbTitulo
            // 
            tbTitulo.Cursor = Cursors.IBeam;
            tbTitulo.Location = new Point(233, 103);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(100, 23);
            tbTitulo.TabIndex = 4;
            // 
            // tbAno
            // 
            tbAno.Cursor = Cursors.IBeam;
            tbAno.Location = new Point(233, 146);
            tbAno.Name = "tbAno";
            tbAno.Size = new Size(100, 23);
            tbAno.TabIndex = 5;
            // 
            // tbEditora
            // 
            tbEditora.Cursor = Cursors.IBeam;
            tbEditora.Location = new Point(233, 189);
            tbEditora.Name = "tbEditora";
            tbEditora.Size = new Size(100, 23);
            tbEditora.TabIndex = 6;
            // 
            // tbIsbn
            // 
            tbIsbn.Cursor = Cursors.IBeam;
            tbIsbn.Location = new Point(233, 232);
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(100, 23);
            tbIsbn.TabIndex = 7;
            // 
            // btnAdicionarLivro
            // 
            btnAdicionarLivro.BackColor = SystemColors.ButtonFace;
            btnAdicionarLivro.Cursor = Cursors.Hand;
            btnAdicionarLivro.FlatStyle = FlatStyle.Popup;
            btnAdicionarLivro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdicionarLivro.Location = new Point(77, 296);
            btnAdicionarLivro.Name = "btnAdicionarLivro";
            btnAdicionarLivro.Size = new Size(95, 29);
            btnAdicionarLivro.TabIndex = 8;
            btnAdicionarLivro.Text = "Adicionar";
            btnAdicionarLivro.UseVisualStyleBackColor = false;
            btnAdicionarLivro.Click += btnAdicionar_Click;
            // 
            // btnRemoverLivro
            // 
            btnRemoverLivro.BackColor = SystemColors.ButtonFace;
            btnRemoverLivro.Cursor = Cursors.Hand;
            btnRemoverLivro.FlatStyle = FlatStyle.Popup;
            btnRemoverLivro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRemoverLivro.Location = new Point(313, 296);
            btnRemoverLivro.Name = "btnRemoverLivro";
            btnRemoverLivro.Size = new Size(84, 29);
            btnRemoverLivro.TabIndex = 9;
            btnRemoverLivro.Text = "Remover";
            btnRemoverLivro.UseVisualStyleBackColor = false;
            btnRemoverLivro.Click += btnRemoverLivro_Click;
            // 
            // btnLimparFormularioLivro
            // 
            btnLimparFormularioLivro.BackColor = SystemColors.ButtonFace;
            btnLimparFormularioLivro.Cursor = Cursors.Hand;
            btnLimparFormularioLivro.FlatStyle = FlatStyle.Popup;
            btnLimparFormularioLivro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLimparFormularioLivro.Location = new Point(419, 296);
            btnLimparFormularioLivro.Name = "btnLimparFormularioLivro";
            btnLimparFormularioLivro.Size = new Size(75, 29);
            btnLimparFormularioLivro.TabIndex = 10;
            btnLimparFormularioLivro.Text = "Limpar";
            btnLimparFormularioLivro.UseVisualStyleBackColor = false;
            btnLimparFormularioLivro.Click += btnLimparFormularioLivro_Click;
            // 
            // btnAtualizarLivro
            // 
            btnAtualizarLivro.BackColor = SystemColors.ButtonFace;
            btnAtualizarLivro.Cursor = Cursors.Hand;
            btnAtualizarLivro.FlatStyle = FlatStyle.Popup;
            btnAtualizarLivro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAtualizarLivro.Location = new Point(194, 296);
            btnAtualizarLivro.Name = "btnAtualizarLivro";
            btnAtualizarLivro.Size = new Size(97, 29);
            btnAtualizarLivro.TabIndex = 11;
            btnAtualizarLivro.Text = "Atualizar";
            btnAtualizarLivro.UseVisualStyleBackColor = false;
            btnAtualizarLivro.Click += btnAtualizarLivro_Click;
            // 
            // dgvLivros
            // 
            dgvLivros.AllowDrop = true;
            dgvLivros.AllowUserToAddRows = false;
            dgvLivros.AllowUserToDeleteRows = false;
            dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLivros.BackgroundColor = SystemColors.ControlLightLight;
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Cursor = Cursors.No;
            dgvLivros.Location = new Point(77, 350);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.ReadOnly = true;
            dgvLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivros.Size = new Size(613, 221);
            dgvLivros.TabIndex = 12;
            dgvLivros.CellClick += dgvLivros_CellClick;
            // 
            // lblGestaoLivros
            // 
            lblGestaoLivros.AutoSize = true;
            lblGestaoLivros.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoLivros.Location = new Point(70, 20);
            lblGestaoLivros.Name = "lblGestaoLivros";
            lblGestaoLivros.Size = new Size(244, 40);
            lblGestaoLivros.TabIndex = 13;
            lblGestaoLivros.Text = "Gestão de Livros";
            // 
            // btnVolttar
            // 
            btnVolttar.BackColor = SystemColors.ButtonFace;
            btnVolttar.Cursor = Cursors.Hand;
            btnVolttar.FlatStyle = FlatStyle.Popup;
            btnVolttar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolttar.Location = new Point(638, 616);
            btnVolttar.Name = "btnVolttar";
            btnVolttar.Size = new Size(82, 32);
            btnVolttar.TabIndex = 14;
            btnVolttar.Text = "Voltar";
            btnVolttar.UseVisualStyleBackColor = false;
            btnVolttar.Click += btnVolttar_Click;
            // 
            // FormGestaoLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(750, 660);
            Controls.Add(btnVolttar);
            Controls.Add(lblGestaoLivros);
            Controls.Add(dgvLivros);
            Controls.Add(btnAtualizarLivro);
            Controls.Add(btnLimparFormularioLivro);
            Controls.Add(btnRemoverLivro);
            Controls.Add(btnAdicionarLivro);
            Controls.Add(tbIsbn);
            Controls.Add(tbEditora);
            Controls.Add(tbAno);
            Controls.Add(tbTitulo);
            Controls.Add(lblISBN);
            Controls.Add(lblEditora);
            Controls.Add(lblAnoPublicacao);
            Controls.Add(lblTituloLivro);
            Name = "FormGestaoLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Livros";
            Load += FormGestaoLivros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLivro;
        private Label lblAnoPublicacao;
        private Label lblEditora;
        private Label lblISBN;
        private TextBox tbTitulo;
        private TextBox tbAno;
        private TextBox tbEditora;
        private TextBox tbIsbn;
        private Button btnAdicionarLivro;
        private Button btnRemoverLivro;
        private Button btnLimparFormularioLivro;
        private Button btnAtualizarLivro;
        private DataGridView dgvLivros;
        private Label lblGestaoLivros;
        private Button btnVolttar;
    }
}