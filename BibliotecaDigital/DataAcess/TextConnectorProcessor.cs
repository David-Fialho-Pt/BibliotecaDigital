using Biblioteca_Digital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.DataAcess
{
    public static class TextConnectorProcessor
    {
        public static string FullPath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> CarregarFicheiro(this string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                return new List<string>();
            }
            return File.ReadAllLines(ficheiro).ToList();
        }

        public static List<Livro> ConverterParaModeloLivro(this List<string> linhas)
        {
            List<Livro> output = new List<Livro>();
            foreach (string linha in linhas)
            {
                string[] cols = linha.Split(';');
                Livro livro = new Livro();
                livro.IdLivro = int.Parse(cols[0]);
                livro.Titulo = cols[1];
                livro.AnoPublicacao = int.Parse(cols[2]);
                livro.Editora = cols[3];
                livro.ISBN = cols[4];
                output.Add(livro);
            }
            return output;
        }

        public static List<Autor> ConverterParaModeloAutor(this List<string> linhas)
        {
            List<Autor> output = new List<Autor>();
            foreach (string linha in linhas)
            {
                string[] cols = linha.Split(';');
                Autor autor = new Autor();
                autor.IdAutor = int.Parse(cols[0]);
                autor.Nome = cols[1];
                autor.Nacionalidade = cols[2];
                autor.AnoNascimento = int.Parse(cols[3]);
                output.Add(autor);
            }
            return output;
        }

        public static List<LivroAutor> ConverterParaModeloLivroAutor(this List<string> linhas)
        {
            List<LivroAutor> output = new List<LivroAutor>();
            foreach (string linha in linhas)
            {
                string[] cols = linha.Split(';');
                LivroAutor livroautor = new LivroAutor();
                livroautor.IdLivro = int.Parse(cols[0]);
                livroautor.IdAutor = int.Parse(cols[1]);
                output.Add(livroautor);
            }
            return output;
        }

        public static void SalvarLivro(this List<Livro> livros, string ficheiro)
        {
            List<string> linhas = new List<string>();

            foreach (Livro livro in livros)
            {
                linhas.Add($"{livro.IdLivro};{livro.Titulo};{livro.AnoPublicacao};{livro.Editora};{livro.ISBN}");
            }
            File.WriteAllLines(ficheiro.FullPath(), linhas);
        }

        public static void SalvarAutor(this List<Autor> autores, string ficheiro)
        {
            List<string> linhas = new List<string>();

            foreach (Autor autor in autores)
            {
                linhas.Add($"{autor.IdAutor};{autor.Nome};{autor.Nacionalidade};{autor.AnoNascimento}");
            }
            File.WriteAllLines(ficheiro.FullPath(), linhas);
        }

        public static void SalvarLivroAutor(this List<LivroAutor> associacoes, string ficheiro)
        {
            List<string> linhas = new List<string>();

            foreach (LivroAutor livroautor in associacoes)
            {
                linhas.Add($"{livroautor.IdLivro};{livroautor.IdAutor}");
            }
            File.WriteAllLines(ficheiro.FullPath(), linhas);
        }
    }
}
