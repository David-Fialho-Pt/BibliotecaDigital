namespace Forms
{
    partial class FormConsultarLivrosAutor
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
            cbAutor = new ComboBox();
            lblAutor = new Label();
            btnConsultar = new Button();
            btnVolttar = new Button();
            dgvConsultas = new DataGridView();
            lblConsultas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // cbAutor
            // 
            cbAutor.FormattingEnabled = true;
            cbAutor.Location = new Point(146, 112);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(121, 23);
            cbAutor.TabIndex = 26;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(58, 111);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(53, 20);
            lblAutor.TabIndex = 25;
            lblAutor.Text = "Autor:";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.ButtonFace;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConsultar.Location = new Point(58, 168);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(91, 29);
            btnConsultar.TabIndex = 29;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnVolttar
            // 
            btnVolttar.BackColor = SystemColors.ButtonFace;
            btnVolttar.Cursor = Cursors.Hand;
            btnVolttar.FlatStyle = FlatStyle.Popup;
            btnVolttar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolttar.Location = new Point(706, 503);
            btnVolttar.Name = "btnVolttar";
            btnVolttar.Size = new Size(82, 32);
            btnVolttar.TabIndex = 30;
            btnVolttar.Text = "Voltar";
            btnVolttar.UseVisualStyleBackColor = false;
            // 
            // dgvConsultas
            // 
            dgvConsultas.BackgroundColor = SystemColors.ControlLightLight;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Cursor = Cursors.No;
            dgvConsultas.Location = new Point(58, 232);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.ReadOnly = true;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.Size = new Size(613, 221);
            dgvConsultas.TabIndex = 31;
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultas.Location = new Point(45, 31);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(382, 40);
            lblConsultas.TabIndex = 32;
            lblConsultas.Text = "Consultar Livros por Autor";
            // 
            // FormConsultarLivrosAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 547);
            Controls.Add(lblConsultas);
            Controls.Add(dgvConsultas);
            Controls.Add(btnVolttar);
            Controls.Add(btnConsultar);
            Controls.Add(cbAutor);
            Controls.Add(lblAutor);
            Name = "FormConsultarLivrosAutor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Livros/Autor";
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAutor;
        private Label lblAutor;
        private Button btnConsultar;
        private Button btnVolttar;
        private DataGridView dgvConsultas;
        private Label lblConsultas;
    }
}