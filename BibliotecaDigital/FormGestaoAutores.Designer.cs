namespace Forms
{
    partial class FormGestaoAutores
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
            tbEditora = new TextBox();
            tbAno = new TextBox();
            tbTitulo = new TextBox();
            lblAnoNascimento = new Label();
            lblNacionalidade = new Label();
            lbNomeAutor = new Label();
            btnAtualizarAutor = new Button();
            btnLimparFormularioAutor = new Button();
            btnRemoverAutor = new Button();
            btnAdicionarAutor = new Button();
            dgvAutores = new DataGridView();
            btnVolttar = new Button();
            lblGestaoAutores = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // tbEditora
            // 
            tbEditora.Cursor = Cursors.IBeam;
            tbEditora.Location = new Point(233, 189);
            tbEditora.Name = "tbEditora";
            tbEditora.Size = new Size(100, 23);
            tbEditora.TabIndex = 12;
            // 
            // tbAno
            // 
            tbAno.Cursor = Cursors.IBeam;
            tbAno.Location = new Point(233, 146);
            tbAno.Name = "tbAno";
            tbAno.Size = new Size(100, 23);
            tbAno.TabIndex = 11;
            // 
            // tbTitulo
            // 
            tbTitulo.Cursor = Cursors.IBeam;
            tbTitulo.Location = new Point(233, 103);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(100, 23);
            tbTitulo.TabIndex = 10;
            // 
            // lblAnoNascimento
            // 
            lblAnoNascimento.AutoSize = true;
            lblAnoNascimento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnoNascimento.Location = new Point(79, 192);
            lblAnoNascimento.Name = "lblAnoNascimento";
            lblAnoNascimento.Size = new Size(147, 20);
            lblAnoNascimento.TabIndex = 9;
            lblAnoNascimento.Text = "Ano de Nascimento:";
            // 
            // lblNacionalidade
            // 
            lblNacionalidade.AutoSize = true;
            lblNacionalidade.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNacionalidade.Location = new Point(79, 149);
            lblNacionalidade.Name = "lblNacionalidade";
            lblNacionalidade.Size = new Size(112, 20);
            lblNacionalidade.TabIndex = 8;
            lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lbNomeAutor
            // 
            lbNomeAutor.AutoSize = true;
            lbNomeAutor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNomeAutor.Location = new Point(79, 106);
            lbNomeAutor.Name = "lbNomeAutor";
            lbNomeAutor.Size = new Size(55, 20);
            lbNomeAutor.TabIndex = 7;
            lbNomeAutor.Text = "Nome:";
            // 
            // btnAtualizarAutor
            // 
            btnAtualizarAutor.BackColor = SystemColors.ButtonFace;
            btnAtualizarAutor.Cursor = Cursors.Hand;
            btnAtualizarAutor.FlatStyle = FlatStyle.Popup;
            btnAtualizarAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAtualizarAutor.Location = new Point(194, 296);
            btnAtualizarAutor.Name = "btnAtualizarAutor";
            btnAtualizarAutor.Size = new Size(97, 29);
            btnAtualizarAutor.TabIndex = 16;
            btnAtualizarAutor.Text = "Atualizar";
            btnAtualizarAutor.UseVisualStyleBackColor = false;
            // 
            // btnLimparFormularioAutor
            // 
            btnLimparFormularioAutor.BackColor = SystemColors.ButtonFace;
            btnLimparFormularioAutor.Cursor = Cursors.Hand;
            btnLimparFormularioAutor.FlatStyle = FlatStyle.Popup;
            btnLimparFormularioAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLimparFormularioAutor.Location = new Point(419, 296);
            btnLimparFormularioAutor.Name = "btnLimparFormularioAutor";
            btnLimparFormularioAutor.Size = new Size(75, 29);
            btnLimparFormularioAutor.TabIndex = 15;
            btnLimparFormularioAutor.Text = "Limpar";
            btnLimparFormularioAutor.UseVisualStyleBackColor = false;
            // 
            // btnRemoverAutor
            // 
            btnRemoverAutor.BackColor = SystemColors.ButtonFace;
            btnRemoverAutor.Cursor = Cursors.Hand;
            btnRemoverAutor.FlatStyle = FlatStyle.Popup;
            btnRemoverAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRemoverAutor.Location = new Point(313, 296);
            btnRemoverAutor.Name = "btnRemoverAutor";
            btnRemoverAutor.Size = new Size(84, 29);
            btnRemoverAutor.TabIndex = 14;
            btnRemoverAutor.Text = "Remover";
            btnRemoverAutor.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarAutor
            // 
            btnAdicionarAutor.BackColor = SystemColors.ButtonFace;
            btnAdicionarAutor.Cursor = Cursors.Hand;
            btnAdicionarAutor.FlatStyle = FlatStyle.Popup;
            btnAdicionarAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdicionarAutor.Location = new Point(77, 296);
            btnAdicionarAutor.Name = "btnAdicionarAutor";
            btnAdicionarAutor.Size = new Size(95, 29);
            btnAdicionarAutor.TabIndex = 13;
            btnAdicionarAutor.Text = "Adicionar";
            btnAdicionarAutor.UseVisualStyleBackColor = false;
            // 
            // dgvAutores
            // 
            dgvAutores.BackgroundColor = SystemColors.ControlLightLight;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Cursor = Cursors.No;
            dgvAutores.Location = new Point(77, 350);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.ReadOnly = true;
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.Size = new Size(613, 221);
            dgvAutores.TabIndex = 17;
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
            btnVolttar.TabIndex = 18;
            btnVolttar.Text = "Voltar";
            btnVolttar.UseVisualStyleBackColor = false;
            // 
            // lblGestaoAutores
            // 
            lblGestaoAutores.AutoSize = true;
            lblGestaoAutores.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoAutores.Location = new Point(70, 20);
            lblGestaoAutores.Name = "lblGestaoAutores";
            lblGestaoAutores.Size = new Size(270, 40);
            lblGestaoAutores.TabIndex = 19;
            lblGestaoAutores.Text = "Gestão de Autores";
            // 
            // FormGestaoAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(750, 660);
            Controls.Add(lblGestaoAutores);
            Controls.Add(btnVolttar);
            Controls.Add(dgvAutores);
            Controls.Add(btnAtualizarAutor);
            Controls.Add(btnLimparFormularioAutor);
            Controls.Add(btnRemoverAutor);
            Controls.Add(btnAdicionarAutor);
            Controls.Add(tbEditora);
            Controls.Add(tbAno);
            Controls.Add(tbTitulo);
            Controls.Add(lblAnoNascimento);
            Controls.Add(lblNacionalidade);
            Controls.Add(lbNomeAutor);
            Name = "FormGestaoAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão Autores";
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEditora;
        private TextBox tbAno;
        private TextBox tbTitulo;
        private Label lblAnoNascimento;
        private Label lblNacionalidade;
        private Label lbNomeAutor;
        private Button btnAtualizarAutor;
        private Button btnLimparFormularioAutor;
        private Button btnRemoverAutor;
        private Button btnAdicionarAutor;
        private DataGridView dgvAutores;
        private Button btnVolttar;
        private Label lblGestaoAutores;
    }
}