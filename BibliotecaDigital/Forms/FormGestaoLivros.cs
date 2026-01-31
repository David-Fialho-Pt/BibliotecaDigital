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
        string isbnOriginal = "";

        public FormGestaoLivros()
        {
            InitializeComponent();
        }
       
        private void FormGestaoLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void btnVolttar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            tbTitulo.Clear();
            tbAno.Clear();
            tbEditora.Clear();
            tbIsbn.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (GlobalConfig.Connection.LivroExiste(tbIsbn.Text))
            {
                MessageBox.Show("Já existe um livro com esse ISBN.");
                tbIsbn.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTitulo.Text) ||
                string.IsNullOrWhiteSpace(tbAno.Text) ||
                string.IsNullOrWhiteSpace(tbEditora.Text) ||
                string.IsNullOrWhiteSpace(tbIsbn.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            
            int anoAtual = DateTime.Now.Year;

            if (!int.TryParse(tbAno.Text, out int ano))
            {
                MessageBox.Show($"O campo só pode conter números.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }

            if (tbAno.Text.Length != 4 || ano < 1500 || ano > anoAtual)
            {
                MessageBox.Show($"O ano de publicação deve ter 4 números e estar entre 1500 e {anoAtual}.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }

            if (tbIsbn.Text.Length != 13 )
            {
                MessageBox.Show("O ISBN deve conter exatamente 13 números.");
                tbIsbn.Clear();
                tbIsbn.Focus();
                return;
            }


            if (!tbIsbn.Text.All(char.IsDigit))
            {
                MessageBox.Show($"O campo só pode conter números.");
                tbIsbn.Clear();
                tbIsbn.Focus();
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

        private void btnLimparFormularioLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
      
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
                isbnOriginal = row.Cells["ISBN"].Value.ToString();

            }
        }

        private void CarregarLivros()
        {
            var livros = GlobalConfig.Connection.ListarLivros();
            dgvLivros.DataSource = livros;
        }

        private void btnRemoverLivro_Click(object sender, EventArgs e)
        {

            if (idLivroSelecionado == 0)
            {
                MessageBox.Show("Selecione um livro primeiro.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem a certeza que quer remover este livro?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                GlobalConfig.Connection.RemoverLivro(idLivroSelecionado);
                MessageBox.Show("Livro removido com sucesso!");

                CarregarLivros();
                LimparCampos();
                idLivroSelecionado = 0;
            }
        }

        private void btnAtualizarLivro_Click(object sender, EventArgs e)
        {

            if (tbIsbn.Text != isbnOriginal)
            {
                if (GlobalConfig.Connection.LivroExiste(tbIsbn.Text))
                {
                    MessageBox.Show("Já existe um livro com esse ISBN.");
                    tbIsbn.Focus();
                    return;
                }
            }

            if (idLivroSelecionado == 0)
            {
                MessageBox.Show("Selecione um livro primeiro.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbTitulo.Text) ||
                string.IsNullOrWhiteSpace(tbAno.Text) ||
                string.IsNullOrWhiteSpace(tbEditora.Text) ||
                string.IsNullOrWhiteSpace(tbIsbn.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            int anoAtual = DateTime.Now.Year;

            if (!int.TryParse(tbAno.Text, out int ano))
            {
                MessageBox.Show($"O campo só pode conter números.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }
            if (tbAno.Text.Length != 4 || ano < 1500 || ano > anoAtual)
            {
                MessageBox.Show($"O ano de publicação deve ter 4 números e estar entre 1500 e {anoAtual}.");
                tbAno.Clear();
                tbAno.Focus();
                return;
            }

            if (tbIsbn.Text.Length != 13 || !tbIsbn.Text.All(char.IsDigit))
            {
                MessageBox.Show("O ISBN deve conter exatamente 13 números.");
                tbIsbn.Clear();
                tbIsbn.Focus();
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
