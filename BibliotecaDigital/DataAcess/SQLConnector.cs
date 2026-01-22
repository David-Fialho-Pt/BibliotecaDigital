using Dapper;
using Biblioteca_Digital.Modelos;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.DataAcess
{
    public class SQLConnector : IDataConnection
    {


        public void CriarLivro(Livro livro)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@Titulo", livro.Titulo);
                p.Add("@AnoPublicacao", livro.AnoPublicacao);
                p.Add("@Editora", livro.Editora);
                p.Add("@ISBN", livro.ISBN);

                connection.Execute("spAdicionarLivro", p, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Livro> ListarLivros()
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                return connection.Query<Livro>("spListarLivros",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void RemoverLivro(int idLivro)
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdLivro", idLivro);

                connection.Execute("spRemoverLivro", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void AtualizarLivro(Livro livro)
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdLivro", livro.IdLivro);
                p.Add("@Titulo", livro.Titulo);
                p.Add("@AnoPublicacao", livro.AnoPublicacao);
                p.Add("@Editora", livro.Editora);
                p.Add("@ISBN", livro.ISBN);

                connection.Execute("spAtualizarLivro", p, commandType: CommandType.StoredProcedure);
            }
        }



        public void CriarAutor(Autor autor)
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", autor.Nome);
                p.Add("@Nacionalidade", autor.Nacionalidade);
                p.Add("@AnoNascimento", autor.AnoNascimento);

                connection.Execute("dbo.spAdicionarAutor", p, commandType: CommandType.StoredProcedure);
            }
        }



        public List<Autor> ListarAutores()
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                return connection.Query<Autor>("spListarAutores",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }


        public void RemoverAutor(int idAutor)
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdAutor", idAutor);

                connection.Execute("spRemoverAutor", p, commandType: CommandType.StoredProcedure);
            }
        }


        public void AtualizarAutor(Autor autor)
        {
            using (IDbConnection connection =
                   new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdAutor", autor.IdAutor);
                p.Add("@Nome", autor.Nome);
                p.Add("@Nacionalidade", autor.Nacionalidade);
                p.Add("@AnoNascimento", autor.AnoNascimento);

                connection.Execute("dbo.spAtualizarAutor", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void AssociarLivroAutor(int idLivro, int idAutor)
        {
            using (IDbConnection connection =
                new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdLivro", idLivro);
                p.Add("@IdAutor", idAutor);

                connection.Execute("spAssociarLivroAutor", p,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<LivroAutor> ListarAssociacoes()
        {
            using (IDbConnection connection =
                new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                return connection.Query<LivroAutor>(
                    "spListarAssociacoes",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void RemoverLivroAutor(int idLivro, int idAutor)
        {
            using (IDbConnection connection =
                new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdLivro", idLivro);
                p.Add("@IdAutor", idAutor);

                connection.Execute("spRemoverLivroAutor", p,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<Livro> ListarLivrosPorAutor(int idAutor)
        {
            using (IDbConnection connection =
                new SqlConnection(GlobalConfig.CnnString("BibliotecaDigital")))
            {
                var p = new DynamicParameters();
                p.Add("@IdAutor", idAutor);

                return connection.Query<Livro>(
                    "spListarLivrosPorAutor",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }











    }
}
