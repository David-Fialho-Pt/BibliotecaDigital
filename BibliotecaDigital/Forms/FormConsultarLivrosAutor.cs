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
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            var livros = GlobalConfig.Connection.ListarLivros();
            dgvConsultas.DataSource = livros;
        }
    }
}