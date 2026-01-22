using Biblioteca_Digital.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormConsultarLivrosAutor : Form
    {
        public FormConsultarLivrosAutor()
        {
            InitializeComponent();
        }

        private void btnVolttar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormConsultarLivrosAutor_Load(object sender, EventArgs e)
        {
            CarregarAutores();
        }

        private void CarregarAutores()
        {
            var autores = GlobalConfig.Connection.ListarAutores();
            cbAutor.DataSource = autores;
            cbAutor.DisplayMember = "Nome";
            cbAutor.ValueMember = "IdAutor";
        }

        private void cbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAutor.SelectedValue == null)
                return;

            int idAutor = (int)cbAutor.SelectedValue;
            CarregarLivros(idAutor);
        }

        private void CarregarLivros(int idAutor)
        {
            var livros = GlobalConfig.Connection.ListarLivrosPorAutor(idAutor);
            dgvConsultas.DataSource = livros;

            dgvConsultas.Columns["IdLivro"].Visible = false;
            dgvConsultas.Columns["AnoPublicacao"].Visible = true;
            dgvConsultas.Columns["Editora"].Visible = true;
            dgvConsultas.Columns["ISBN"].Visible = true;

            dgvConsultas.Columns["Titulo"].HeaderText = "Livro";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbAutor.SelectedItem == null)
            {
                MessageBox.Show("Selecione um autor.");
                return;
            }

            int idAutor = (int)cbAutor.SelectedValue;
            CarregarLivros(idAutor);
        }


    }
}