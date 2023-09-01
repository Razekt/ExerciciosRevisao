using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    public abstract class Empresa
    {
        public string Nome { get; set; }
        public string CNPJ { get; set;}

        public string ImprimirInfo()
        {
            return $"Nome: {Nome}   -   CNPJ: {CNPJ}";
        }

        public abstract void RealizarVenda();
    }
}
