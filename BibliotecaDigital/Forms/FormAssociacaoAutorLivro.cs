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
    public partial class FormAssociacaoAutorLivro : Form
    {

        int idLivroSelecionado = 0;
        int idAutorSelecionado = 0;
       
        public FormAssociacaoAutorLivro()
        {
            InitializeComponent();
        }

        private void btnVolttar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAssociacaoAutorLivro_Load(object sender, EventArgs e)
        {
            CarregarLivros();
            CarregarAutores();
            CarregarAssociacoes();
        }

        private void CarregarLivros()
        {
            var livros = GlobalConfig.Connection.ListarLivros();
            cbLivros.DataSource = livros;
            cbLivros.DisplayMember = "Titulo";
            cbLivros.ValueMember = "IdLivro";
        }

        private void CarregarAutores()
        {
            var autores = GlobalConfig.Connection.ListarAutores();
            cbAutores.DataSource = autores;
            cbAutores.DisplayMember = "Nome";
            cbAutores.ValueMember = "IdAutor";
        }

        private void CarregarAssociacoes()
        {
            var associacoes = GlobalConfig.Connection.ListarAssociacoes();
            dgvAssociacoes.DataSource = associacoes;
            dgvAssociacoes.Columns["Nome"].Visible = false;
            dgvAssociacoes.Columns["Titulo"].Visible = false;
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            if (cbLivros.SelectedItem == null || cbAutores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um livro e um autor.");
                return;
            }
            int idLivro = (int)cbLivros.SelectedValue;
            int idAutor = (int)cbAutores.SelectedValue;
            try
            {
                GlobalConfig.Connection.AssociarLivroAutor(idLivro, idAutor);
                MessageBox.Show("Associação criada com sucesso.");
                CarregarAssociacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao associar: " + ex.Message);
            }
        }

        private void dgvAssociacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssociacoes.Rows[e.RowIndex];
                idLivroSelecionado = Convert.ToInt32(row.Cells["IdLivro"].Value);
                idAutorSelecionado = Convert.ToInt32(row.Cells["IdAutor"].Value);
                cbLivros.SelectedValue = idLivroSelecionado;
                cbAutores.SelectedValue = idAutorSelecionado;
            }
        }

        private void btnDesassociar_Click(object sender, EventArgs e)
        {
            if (idLivroSelecionado == 0 || idAutorSelecionado == 0)
            {
                MessageBox.Show("Selecione uma associação primeiro.");
                return;
            }

            GlobalConfig.Connection.DesassociarLivroAutor(idLivroSelecionado, idAutorSelecionado);
            MessageBox.Show("Associação removida com sucesso!");
            CarregarAssociacoes();
            idLivroSelecionado = 0;
            idAutorSelecionado = 0;
        }
    }
}

