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
        private const string FicheiroLivroAutor = "LivroAutor.csv";

        public bool LivroExiste(string isbn)
        {
            List<Livro> livros = FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
            return livros.Any(l => l.ISBN == isbn);
        }

        public void CriarAutor(Autor autor)
        {
            List<Autor> autores = FicheiroAutores.FullPath().CarregarFicheiro().ConverterParaModeloAutor();
            int currentId = 1;
            if (autores.Count > 0)
            {
                currentId = autores.OrderByDescending(a => a.IdAutor).First().IdAutor + 1;
            }
            autor.IdAutor = currentId;
            autores.Add(autor);
            autores.SalvarAutor(FicheiroAutores);
        }

        public void CriarLivro(Livro livro)
        {
            List<Livro> livros = FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
            int currentId = 1;
            if (livros.Count > 0)
            {
                currentId = livros.OrderByDescending(x => x.IdLivro).First().IdLivro + 1;
            }
            livro.IdLivro = currentId;
            livros.Add(livro);
            livros.SalvarLivro(FicheiroLivros);
        }

        public void AtualizarAutor(Autor autor)
        {
            List<Autor> autores = FicheiroAutores.FullPath().CarregarFicheiro().ConverterParaModeloAutor();
            Autor autorAntigo = autores.FirstOrDefault(a => a.IdAutor == autor.IdAutor);
            if (autorAntigo != null)
            {
                autorAntigo.Nome = autor.Nome;
                autorAntigo.Nacionalidade = autor.Nacionalidade;
                autorAntigo.AnoNascimento = autor.AnoNascimento;
                autores.SalvarAutor(FicheiroAutores);
            }
        }

        public void AtualizarLivro(Livro livro)
        {
            List<Livro> livros = FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
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

        public List<Autor> ListarAutores()
        {
            return FicheiroAutores.FullPath().CarregarFicheiro().ConverterParaModeloAutor();
        }

        public List<Livro> ListarLivros()
        {
            return FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
        }

        public void RemoverAutor(int idAutor)
        {
            List<Autor> autores = FicheiroAutores.FullPath().CarregarFicheiro().ConverterParaModeloAutor();
            Autor autor = autores.FirstOrDefault(a => a.IdAutor == idAutor);
            if (autor != null)
            {
                autores.Remove(autor);
                autores.SalvarAutor(FicheiroAutores);
            }
        }

        public void RemoverLivro(int idLivro)
        {
            List<Livro> livros = FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
            Livro livro = livros.FirstOrDefault(l => l.IdLivro == idLivro);
            if (livro != null)
            {
                livros.Remove(livro);
                livros.SalvarLivro(FicheiroLivros);
            }
        }

        public void AssociarLivroAutor(int idLivro, int idAutor)
        {
            List<LivroAutor> associacoes = FicheiroLivroAutor.FullPath().CarregarFicheiro().ConverterParaModeloLivroAutor();
            bool existe = associacoes.Any(x => x.IdLivro == idLivro && x.IdAutor == idAutor);
            if (!existe)
            {
                associacoes.Add(new LivroAutor { IdLivro = idLivro, IdAutor = idAutor });
                associacoes.SalvarLivroAutor(FicheiroLivroAutor);
            }
        }

        public void DesassociarLivroAutor(int idLivro, int idAutor)
        {
            List<LivroAutor> associacoes = FicheiroLivroAutor.FullPath().CarregarFicheiro().ConverterParaModeloLivroAutor();
            LivroAutor assoc = associacoes.FirstOrDefault(x => x.IdLivro == idLivro && x.IdAutor == idAutor);
            if (assoc != null)
            {
                associacoes.Remove(assoc);
                associacoes.SalvarLivroAutor(FicheiroLivroAutor);
            }
        }

        public List<LivroAutor> ListarAssociacoes()
         {
            return FicheiroLivroAutor.FullPath().CarregarFicheiro().ConverterParaModeloLivroAutor();
         }

        public List<Livro> ListarLivrosPorAutor(int idAutor)
        {
            var associacoes = FicheiroLivroAutor.FullPath().CarregarFicheiro().ConverterParaModeloLivroAutor();
            var livros = FicheiroLivros.FullPath().CarregarFicheiro().ConverterParaModeloLivro();
            return livros.Where(l => associacoes.Any(a => a.IdAutor == idAutor && a.IdLivro == l.IdLivro)).ToList();
        }
    }
}

