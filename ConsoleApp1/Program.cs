using Dominio;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicacoes = new List<Publicacao>();

            var revista = new Revista("Veja", new DateTime(2015, 07, 30));
            var jornal = new Jornal("O Globo", new DateTime(2015, 07, 30));
            var livro = new Livro("Clean Code", new DateTime(2015, 07, 30));

            publicacoes.AddRange(new List<Publicacao>() { revista, jornal, livro });

            foreach (var publicacao in publicacoes)
            {
                Console.WriteLine();
                Console.WriteLine($"Nome: {publicacao.Nome}");
                Console.WriteLine($"Tipo Publicação: {publicacao.GetType().Name}");
                Console.WriteLine($"Data de lançamento: {publicacao.DataLancamento:dd/MM/yyyy}");
                Console.WriteLine($"Direitos autorais: {publicacao.DireitosAutorais()}"); //polimorfismo
            }
        }
    }
}
