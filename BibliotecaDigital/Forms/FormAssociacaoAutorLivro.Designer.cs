namespace Forms
{
    partial class FormAssociacaoAutorLivro
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
            lblAssociacaoAutorLivro = new Label();
            lblAutores = new Label();
            lbLiveos = new Label();
            cbLivros = new ComboBox();
            cbAutores = new ComboBox();
            btnVolttar = new Button();
            dgvAssociacoes = new DataGridView();
            button1 = new Button();
            btnDesassociar = new Button();
            btnAssociar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAssociacoes).BeginInit();
            SuspendLayout();
            // 
            // lblAssociacaoAutorLivro
            // 
            lblAssociacaoAutorLivro.AutoSize = true;
            lblAssociacaoAutorLivro.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssociacaoAutorLivro.Location = new Point(59, 27);
            lblAssociacaoAutorLivro.Name = "lblAssociacaoAutorLivro";
            lblAssociacaoAutorLivro.Size = new Size(336, 40);
            lblAssociacaoAutorLivro.TabIndex = 20;
            lblAssociacaoAutorLivro.Text = "Associação Autor/Livro";
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutores.Location = new Point(68, 144);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(66, 20);
            lblAutores.TabIndex = 22;
            lblAutores.Text = "Autores:";
            // 
            // lbLiveos
            // 
            lbLiveos.AutoSize = true;
            lbLiveos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLiveos.Location = new Point(68, 101);
            lbLiveos.Name = "lbLiveos";
            lbLiveos.Size = new Size(53, 20);
            lbLiveos.TabIndex = 21;
            lbLiveos.Text = "Livros:";
            // 
            // cbLivros
            // 
            cbLivros.FormattingEnabled = true;
            cbLivros.Location = new Point(187, 98);
            cbLivros.Name = "cbLivros";
            cbLivros.Size = new Size(121, 23);
            cbLivros.TabIndex = 23;
            // 
            // cbAutores
            // 
            cbAutores.FormattingEnabled = true;
            cbAutores.Location = new Point(187, 141);
            cbAutores.Name = "cbAutores";
            cbAutores.Size = new Size(121, 23);
            cbAutores.TabIndex = 24;
            // 
            // btnVolttar
            // 
            btnVolttar.BackColor = SystemColors.ButtonFace;
            btnVolttar.Cursor = Cursors.Hand;
            btnVolttar.FlatStyle = FlatStyle.Popup;
            btnVolttar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolttar.Location = new Point(697, 533);
            btnVolttar.Name = "btnVolttar";
            btnVolttar.Size = new Size(82, 32);
            btnVolttar.TabIndex = 25;
            btnVolttar.Text = "Voltar";
            btnVolttar.UseVisualStyleBackColor = false;
            btnVolttar.Click += btnVolttar_Click;
            // 
            // dgvAssociacoes
            // 
            dgvAssociacoes.AllowUserToAddRows = false;
            dgvAssociacoes.AllowUserToDeleteRows = false;
            dgvAssociacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssociacoes.BackgroundColor = SystemColors.ControlLightLight;
            dgvAssociacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociacoes.Cursor = Cursors.No;
            dgvAssociacoes.Location = new Point(68, 273);
            dgvAssociacoes.Name = "dgvAssociacoes";
            dgvAssociacoes.ReadOnly = true;
            dgvAssociacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociacoes.Size = new Size(613, 221);
            dgvAssociacoes.TabIndex = 26;
            dgvAssociacoes.CellClick += dgvAssociacoes_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(570, 125);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDesassociar
            // 
            btnDesassociar.BackColor = SystemColors.ButtonFace;
            btnDesassociar.Cursor = Cursors.Hand;
            btnDesassociar.FlatStyle = FlatStyle.Popup;
            btnDesassociar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDesassociar.Location = new Point(187, 203);
            btnDesassociar.Name = "btnDesassociar";
            btnDesassociar.Size = new Size(143, 29);
            btnDesassociar.TabIndex = 29;
            btnDesassociar.Text = "Desassociar";
            btnDesassociar.UseVisualStyleBackColor = false;
            btnDesassociar.Click += btnDesassociar_Click;
            // 
            // btnAssociar
            // 
            btnAssociar.BackColor = SystemColors.ButtonFace;
            btnAssociar.Cursor = Cursors.Hand;
            btnAssociar.FlatStyle = FlatStyle.Popup;
            btnAssociar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAssociar.Location = new Point(68, 203);
            btnAssociar.Name = "btnAssociar";
            btnAssociar.Size = new Size(84, 29);
            btnAssociar.TabIndex = 28;
            btnAssociar.Text = "Associar";
            btnAssociar.UseVisualStyleBackColor = false;
            btnAssociar.Click += btnAssociar_Click;
            // 
            // FormAssociacaoAutorLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 577);
            Controls.Add(btnDesassociar);
            Controls.Add(btnAssociar);
            Controls.Add(button1);
            Controls.Add(dgvAssociacoes);
            Controls.Add(btnVolttar);
            Controls.Add(cbAutores);
            Controls.Add(cbLivros);
            Controls.Add(lblAutores);
            Controls.Add(lbLiveos);
            Controls.Add(lblAssociacaoAutorLivro);
            Name = "FormAssociacaoAutorLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Associar Livro/Autor";
            Load += FormAssociacaoAutorLivro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssociacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAssociacaoAutorLivro;
        private Label lblAutores;
        private Label lbLiveos;
        private ComboBox cbLivros;
        private ComboBox cbAutores;
        private Button btnVolttar;
        private DataGridView dgvAssociacoes;
        private Button button1;
        private Button btnDesassociar;
        private Button btnAssociar;
    }
}