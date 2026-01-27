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

        public static List<string> CarregarFicheiro(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Livro> ConverterParaModeloLivro(this List<string> lines)
        {
            List<Livro> output = new List<Livro>();

            foreach (string line in lines)
            {

                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] cols = line.Split(';');


                if (cols.Length != 5)
                {
                    continue;
                }

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

        public static void SalvarLivro(this List<Livro> livros, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Livro l in livros)
            {
                lines.Add($"{l.IdLivro};{l.Titulo};{l.AnoPublicacao};{l.Editora};{l.ISBN}");
            }

            File.WriteAllLines(fileName.FullPath(), lines);
        }
    }
}
