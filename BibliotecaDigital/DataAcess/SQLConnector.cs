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



    }
}
