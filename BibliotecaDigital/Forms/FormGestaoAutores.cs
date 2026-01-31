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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Forms
{
    public partial class FormGestaoAutores : Form
    {

        int idAutorSelecionado = 0;

        public FormGestaoAutores()
        {
            InitializeComponent();
        }

        private void FormGestaoAutores_Load(object sender, EventArgs e)
        {
            CarregarAutores();
        }

        private void btnVolttar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbAnonascimento.Clear();
            tbNacionalidade.Clear();    
        }

        private void btnAdicionarAutor_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
                string.IsNullOrWhiteSpace(tbNacionalidade.Text) ||
                string.IsNullOrWhiteSpace(tbAnonascimento.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            if (!tbNome.Text.All(char.IsLetter))
            {
                MessageBox.Show("O nome só pode conter letras.");
                tbNome.Focus();
                return;
            }

            if (!tbNacionalidade.Text.All(char.IsLetter))
            {
                MessageBox.Show("A nacionalidade só pode conter letras.");
                tbNacionalidade.Focus();
                return;
            }

            int anoAtual = DateTime.Now.Year;

            if (!int.TryParse(tbAnonascimento.Text, out int ano))
            {
                MessageBox.Show($"O campo só pode conter números.");
                tbAnonascimento.Clear();
                tbAnonascimento.Focus();
                return;
            }

            if ( tbAnonascimento.Text.Length != 4 ||ano < 1400 || ano > anoAtual)
            {
                MessageBox.Show($"O ano de nascimento deve ter 4 números e estar entre 1400 e {anoAtual}.");
                tbAnonascimento.Clear();
                tbAnonascimento.Focus();
                return;
            }

            try
            {
                Autor autor = new Autor
                {
                    Nome = tbNome.Text,
                    Nacionalidade = tbNacionalidade.Text,
                    AnoNascimento = ano
                };

                GlobalConfig.Connection.CriarAutor(autor);

                MessageBox.Show("Autor adicionado com sucesso!");

                CarregarAutores();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar autor: " + ex.Message);
                LimparCampos();
            }
        }

        private void btnLimparFormularioAutor_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAutores.Rows[e.RowIndex];

                idAutorSelecionado = Convert.ToInt32(row.Cells["IdAutor"].Value);
                tbNome.Text = row.Cells["Nome"].Value.ToString();
                tbNacionalidade.Text = row.Cells["Nacionalidade"].Value.ToString();
                tbAnonascimento.Text = row.Cells["AnoNascimento"].Value.ToString();
            }
        }

        private void CarregarAutores()
        {
            var autores = GlobalConfig.Connection.ListarAutores();
            dgvAutores.DataSource = autores;
        }

        private void btnRemoverAutor_Click(object sender, EventArgs e)
        {
            if (idAutorSelecionado == 0)
            {
                MessageBox.Show("Selecione um autor primeiro.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem a certeza que quer remover este autor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                GlobalConfig.Connection.RemoverAutor(idAutorSelecionado);
                MessageBox.Show("Autor removido com sucesso!");

                CarregarAutores();
                LimparCampos();
                idAutorSelecionado = 0;
            }
        }

        private void btnAtualizarAutor_Click(object sender, EventArgs e)
        {
            if (idAutorSelecionado == 0)
            {
                MessageBox.Show("Selecione um autor primeiro.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
               string.IsNullOrWhiteSpace(tbNacionalidade.Text) ||
               string.IsNullOrWhiteSpace(tbAnonascimento.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            if (!tbNome.Text.All(char.IsLetter))
            {
                MessageBox.Show("O nome só pode conter letras.");
                tbNome.Focus();
                return;
            }

            if (!tbNacionalidade.Text.All(char.IsLetter))
            {
                MessageBox.Show("A nacionalidade só pode conter letras.");
                tbNacionalidade.Focus();
                return;
            }

            int anoAtual = DateTime.Now.Year;
            if (!int.TryParse(tbAnonascimento.Text, out int ano))
            {
                MessageBox.Show($"O campo só pode conter números.");
                tbAnonascimento.Clear();
                tbAnonascimento.Focus();
                return;
            }
            if (tbAnonascimento.Text.Length != 4 || ano < 1400 || ano > anoAtual)
            {
                MessageBox.Show($"O ano de nascimento deve ter 4 números e estar entre 1400 e {anoAtual}.");
                tbAnonascimento.Clear();
                tbAnonascimento.Focus();
                return;
            }

            try
            {
                Autor autor = new Autor
                {
                    IdAutor = idAutorSelecionado,
                    Nome = tbNome.Text,
                    Nacionalidade = tbNacionalidade.Text,
                    AnoNascimento = ano
                };

                GlobalConfig.Connection.AtualizarAutor(autor);

                MessageBox.Show("Autor atualizado com sucesso!");

                CarregarAutores();
                LimparCampos();
                idAutorSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar autor: " + ex.Message);
            }
        }

    }
}

