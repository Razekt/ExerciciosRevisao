using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Empreiteira : Empresa, IEmpresa
    {
        public void RealizarVenda()
        {
            Console.WriteLine("Vende Serviço!"); 
        }
    }
}
