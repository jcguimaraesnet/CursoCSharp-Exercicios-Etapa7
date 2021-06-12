using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public sealed class Revista : Publicacao
    {
        protected override int QuantidadeAnosDireitosAutorais { get; } = 1;

        public Revista(string nome, DateTime dataLancamento) : base(nome, dataLancamento)
        {
        }
    }
}
