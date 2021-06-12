using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura
{
    public class LivroRepositorio
    {
        private static List<Livro> listaLivros = new List<Livro>();

        public List<Livro> Pesquisar(string nomeOuParteNomeLivro)
        {
            return listaLivros.Where(x => x.Nome.ToLower().Contains(nomeOuParteNomeLivro.ToLower()))
                                                       .ToList();
        }

        public void Adicionar(Livro livro)
        {
            listaLivros.Add(livro);
        }
    }
}
