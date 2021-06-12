using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public sealed class Jornal : Publicacao
    {
        protected override int QuantidadeAnosDireitosAutorais { get; } = 2;

        public Jornal(string nome, DateTime dataLancamento) : base(nome, dataLancamento)
        {
        }
    }
}
