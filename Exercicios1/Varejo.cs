using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    public class Varejo : Empresa
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Vende Produto!");
        }
    }
}
