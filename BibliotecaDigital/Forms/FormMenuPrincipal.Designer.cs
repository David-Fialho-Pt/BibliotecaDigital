namespace BibliotecaDigital
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnGerirLivros = new Button();
            btnGerirAutores = new Button();
            btnConsularLivrosAutor = new Button();
            btnGestaoAssociacoes = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(264, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu Principal";
            // 
            // btnGerirLivros
            // 
            btnGerirLivros.BackColor = SystemColors.ButtonFace;
            btnGerirLivros.Cursor = Cursors.Hand;
            btnGerirLivros.FlatStyle = FlatStyle.Popup;
            btnGerirLivros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerirLivros.ForeColor = SystemColors.WindowText;
            btnGerirLivros.Location = new Point(285, 142);
            btnGerirLivros.Name = "btnGerirLivros";
            btnGerirLivros.Size = new Size(220, 35);
            btnGerirLivros.TabIndex = 1;
            btnGerirLivros.Text = "Gerir Livros";
            btnGerirLivros.UseVisualStyleBackColor = false;
            btnGerirLivros.Click += btnGerirLivros_Click;
            // 
            // btnGerirAutores
            // 
            btnGerirAutores.BackColor = SystemColors.ButtonFace;
            btnGerirAutores.Cursor = Cursors.Hand;
            btnGerirAutores.FlatStyle = FlatStyle.Popup;
            btnGerirAutores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerirAutores.ForeColor = SystemColors.WindowText;
            btnGerirAutores.Location = new Point(285, 211);
            btnGerirAutores.Name = "btnGerirAutores";
            btnGerirAutores.Size = new Size(220, 35);
            btnGerirAutores.TabIndex = 2;
            btnGerirAutores.Text = "Gerir Autores";
            btnGerirAutores.UseVisualStyleBackColor = false;
            btnGerirAutores.Click += btnGerirAutores_Click;
            // 
            // btnConsularLivrosAutor
            // 
            btnConsularLivrosAutor.BackColor = SystemColors.ButtonFace;
            btnConsularLivrosAutor.Cursor = Cursors.Hand;
            btnConsularLivrosAutor.FlatStyle = FlatStyle.Popup;
            btnConsularLivrosAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsularLivrosAutor.ForeColor = SystemColors.WindowText;
            btnConsularLivrosAutor.Location = new Point(285, 349);
            btnConsularLivrosAutor.Name = "btnConsularLivrosAutor";
            btnConsularLivrosAutor.Size = new Size(220, 35);
            btnConsularLivrosAutor.TabIndex = 4;
            btnConsularLivrosAutor.Text = "Consultar Livros/Autor";
            btnConsularLivrosAutor.UseVisualStyleBackColor = false;
            btnConsularLivrosAutor.Click += btnConsularLivrosAutor_Click;
            // 
            // btnGestaoAssociacoes
            // 
            btnGestaoAssociacoes.BackColor = SystemColors.ButtonFace;
            btnGestaoAssociacoes.Cursor = Cursors.Hand;
            btnGestaoAssociacoes.FlatStyle = FlatStyle.Popup;
            btnGestaoAssociacoes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestaoAssociacoes.ForeColor = SystemColors.WindowText;
            btnGestaoAssociacoes.Location = new Point(285, 280);
            btnGestaoAssociacoes.Name = "btnGestaoAssociacoes";
            btnGestaoAssociacoes.Size = new Size(220, 35);
            btnGestaoAssociacoes.TabIndex = 3;
            btnGestaoAssociacoes.Text = "Associar Livros/Autor";
            btnGestaoAssociacoes.UseVisualStyleBackColor = false;
            btnGestaoAssociacoes.Click += btnGestaoAssociacoes_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ButtonFace;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.WindowText;
            btnSair.Location = new Point(674, 409);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 30);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnGestaoAssociacoes);
            Controls.Add(btnConsularLivrosAutor);
            Controls.Add(btnGerirAutores);
            Controls.Add(btnGerirLivros);
            Controls.Add(lblTitulo);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnGerirLivros;
        private Button btnGerirAutores;
        private Button btnConsularLivrosAutor;
        private Button btnGestaoAssociacoes;
        private Button btnSair;
    }
}
