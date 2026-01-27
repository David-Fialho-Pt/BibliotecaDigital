using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Digital.Modelos;

namespace Biblioteca_Digital.DataAcess
{
    public class TextConnector: IDataConnection

    {
        private const string FicheiroLivros = "Livros.csv";
        private const string FicheiroAutores = "Autores.csv";
        private const string FicheiroAutores_Livros = "LivroAutor.csv";
        

        public void AssociarLivroAutor(int idLivro, int idAutor)
        {
            throw new NotImplementedException();
        }

        public void AtualizarAutor(Autor autor)
        {
            throw new NotImplementedException();
        }

        public void AtualizarLivro(Livro livro)
        {
            List<Livro> livros = FicheiroLivros
           .FullPath()
           .CarregarFicheiro()
           .ConverterParaModeloLivro();

            Livro livroAntigo = livros.FirstOrDefault(l => l.IdLivro == livro.IdLivro);

            if (livroAntigo != null)
            {
                livroAntigo.Titulo = livro.Titulo;
                livroAntigo.AnoPublicacao = livro.AnoPublicacao;
                livroAntigo.Editora = livro.Editora;
                livroAntigo.ISBN = livro.ISBN;

                livros.SalvarLivro(FicheiroLivros);
            }
        }

        public void CriarAutor(Autor autor)
        {
            throw new NotImplementedException();
        }

        public void CriarLivro(Livro livro)
        {
            List<Livro> livros = FicheiroLivros
            .FullPath()
            .CarregarFicheiro()
            .ConverterParaModeloLivro();

            int currentId = 1;

            if (livros.Count > 0)
            {
                currentId = livros.OrderByDescending(x => x.IdLivro).First().IdLivro + 1;
            }

            livro.IdLivro = currentId;
            livros.Add(livro);

            livros.SalvarLivro(FicheiroLivros);
        }

        public List<LivroAutor> ListarAssociacoes()
        {
            throw new NotImplementedException();
        }

        public List<Autor> ListarAutores()
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListarLivros()
        {
            return FicheiroLivros
            .FullPath()
            .CarregarFicheiro()
            .ConverterParaModeloLivro();
        }

        public List<Livro> ListarLivrosPorAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        public bool LivroExiste(string isbn)
        {
            List<Livro> livros = FicheiroLivros
            .FullPath()
            .CarregarFicheiro()
            .ConverterParaModeloLivro();

            return livros.Any(l => l.ISBN == isbn);
        }

        public void RemoverAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        public void RemoverLivro(int idLivro)
        {
            List<Livro> livros = FicheiroLivros
            .FullPath()
            .CarregarFicheiro()
            .ConverterParaModeloLivro();

            Livro livro = livros.FirstOrDefault(l => l.IdLivro == idLivro);

            if (livro != null)
            {
                livros.Remove(livro);
                livros.SalvarLivro(FicheiroLivros);
            }
        }

        public void RemoverLivroAutor(int idLivro, int idAutor)
        {
            throw new NotImplementedException();
        }
    }
}

