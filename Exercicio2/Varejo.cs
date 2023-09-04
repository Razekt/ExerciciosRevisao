using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Varejo : Empresa, IEmpresa
    {
        private readonly EnviarNotificacaoWhatsApp enviarNotificacao;
        public Varejo()
        {
            enviarNotificacao = new EnviarNotificacaoWhatsApp();
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vende Produto!");
            enviarNotificacao.EnviarMensagemCliente();
        }
    }
}
