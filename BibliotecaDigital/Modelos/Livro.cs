using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Digital.Modelos
{
   
        public class Livro
        {
            public int IdLivro { get; set; }
            public string Titulo { get; set; }
            public int AnoPublicacao { get; set; }
            public string Editora { get; set; }
            public string ISBN { get; set; }
        

       }
}
