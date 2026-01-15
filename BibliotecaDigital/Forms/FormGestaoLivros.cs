using Biblioteca_Digital.DataAcess;
using Biblioteca_Digital.Modelos;
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
    public partial class FormGestaoLivros : Form
    {
        int idLivroSelecionado = 0;

        public FormGestaoLivros()
        {
            InitializeComponent();
        }
        //Irá carregar os livros no data grid view ao iniciar o formulário
        private void FormGestaoLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void btnVolttar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Irá limpar os campos do formulário
        private void LimparCampos()
        {
            tbTitulo.Clear();
            tbAno.Clear();
            tbEditora.Clear();
            tbIsbn.Clear();
        }

        //Irá adicionar um novo livro ao clicar no botão adicionar, verificará se o ano é um número válido, e em caso de erro mostrará uma mensagem ao utilizador. Se o livro for adicionado com sucesso, atualizará a lista de livros e limpará os campos do formulário.
        //Se ocorrer um erro ao adicionar o livro, mostrará uma mensagem de erro na variável ex e limpará os campos do formulário.
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbAno.Text, out int ano))
            {
                MessageBox.Show("O ano de publicação tem de ser um número válido.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }

            try
            {
                Livro livro = new Livro
                {
                    Titulo = tbTitulo.Text,
                    AnoPublicacao = ano,
                    Editora = tbEditora.Text,
                    ISBN = tbIsbn.Text
                };

                GlobalConfig.Connection.CriarLivro(livro);

                MessageBox.Show("Livro adicionado com sucesso!");

                CarregarLivros();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar livro: " + ex.Message);
                LimparCampos();
            }


        }
        //Irá limpar os campos do formulário ao clicar no botão limpar
        private void btnLimparFormularioLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Irá preencher os campos do formulário com os dados do livro selecionado no data grid view
        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLivros.Rows[e.RowIndex];

                idLivroSelecionado = Convert.ToInt32(row.Cells["IdLivro"].Value);

                tbTitulo.Text = row.Cells["Titulo"].Value.ToString();
                tbAno.Text = row.Cells["AnoPublicacao"].Value.ToString();
                tbEditora.Text = row.Cells["Editora"].Value.ToString();
                tbIsbn.Text = row.Cells["ISBN"].Value.ToString();
            }
        }

        //Irá carregar a lista de livros no data grid view
        private void CarregarLivros()
        {
            var livros = GlobalConfig.Connection.ListarLivros();
            dgvLivros.DataSource = livros;
        }


        //Irá remover o livro selecionado ao clicar no botão remover, após confirmar a ação com o utilizador. Se o livro for removido com sucesso, atualizará a lista de livros e limpará os campos do formulário.
        private void btnRemoverLivro_Click(object sender, EventArgs e)
        {

            if (idLivroSelecionado == 0)
            {
                MessageBox.Show("Selecione um livro primeiro.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Tem a certeza que quer remover este livro?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                GlobalConfig.Connection.RemoverLivro(idLivroSelecionado);
                MessageBox.Show("Livro removido com sucesso!");

                CarregarLivros();
                LimparCampos();
                idLivroSelecionado = 0;

            }

        }

        //Irá atualizar o livro selecionado ao clicar no botão atualizar, verificará se o ano é um número válido, e em caso de erro mostrará uma mensagem ao utilizador. Se o livro for atualizado com sucesso, atualizará a lista de livros e limpará os campos do formulário.
        //Se ocorrer um erro ao atualizar o livro, mostrará uma mensagem de erro na variável ex.
        private void btnAtualizarLivro_Click(object sender, EventArgs e)
        {
            if (idLivroSelecionado == 0)
            {
                MessageBox.Show("Selecione um livro primeiro.");
                return;
            }

            if (!int.TryParse(tbAno.Text, out int ano))
            {
                MessageBox.Show("O ano de publicação tem de ser um número.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }

            try
            {
                Livro livro = new Livro
                {
                    IdLivro = idLivroSelecionado,
                    Titulo = tbTitulo.Text,
                    AnoPublicacao = ano,
                    Editora = tbEditora.Text,
                    ISBN = tbIsbn.Text
                };

                GlobalConfig.Connection.AtualizarLivro(livro);

                MessageBox.Show("Livro atualizado com sucesso!");

                CarregarLivros();
                LimparCampos();
                idLivroSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar livro: " + ex.Message);
            }
        }

    }
}
