using Forms;

namespace BibliotecaDigital
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGerirLivros_Click(object sender, EventArgs e)
        {
            FormGestaoLivros form = new FormGestaoLivros();
            form.Show();
        }

        private void btnGerirAutores_Click(object sender, EventArgs e)
        {
            FormGestaoAutores form = new FormGestaoAutores();
            form.Show();
        }

        private void btnGestaoAssociacoes_Click(object sender, EventArgs e)
        {
            FormAssociacaoAutorLivro form = new FormAssociacaoAutorLivro();
            form.Show();
        }

        private void btnConsularLivrosAutor_Click(object sender, EventArgs e)
        {
            FormConsultarLivrosAutor form = new FormConsultarLivrosAutor();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
