using Biblioteca_Digital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.DataAcess
{
    public interface IDataConnection
    {
        void CriarLivro(Livro livro);
        List<Livro> ListarLivros();

        void RemoverLivro(int idLivro);

        void AtualizarLivro(Livro livro);



    }
}
