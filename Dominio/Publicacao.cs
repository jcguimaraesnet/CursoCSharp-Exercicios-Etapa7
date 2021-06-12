using System;

namespace Dominio
{
    public abstract class Publicacao
    {
        public string Nome { get; private set; }
        public DateTime DataLancamento { get; private set; }
        protected abstract int QuantidadeAnosDireitosAutorais { get; }

        public Publicacao(string nome, DateTime dataLancamento)
        {
            Nome = nome;
            DataLancamento = dataLancamento;
        }

        public string DireitosAutorais()
        {
            return $"Direitos autorais protegidos " +
                $"até a {DataLancamento.AddYears(QuantidadeAnosDireitosAutorais):dd/MM/yyyy}";
        }
    }
}
