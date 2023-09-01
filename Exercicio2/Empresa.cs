using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Empresa 
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string ImprimirInfo()
        {
            return $"Nome: {Nome}   -   CNPJ: {CNPJ}";
        }
        
    }
}
