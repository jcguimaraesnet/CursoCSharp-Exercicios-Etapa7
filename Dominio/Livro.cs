using System;

namespace Dominio
{
    public sealed class Livro : Publicacao
    {
        protected override int QuantidadeAnosDireitosAutorais { get; } = 5;

        public Livro(string nome, DateTime dataLancamento) : base(nome, dataLancamento)
        {
        }

    }
}
