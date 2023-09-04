/*Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e 
nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class EnviarNotificacaoWhatsApp : IEnviarNotificacao
    {
        public void EnviarMensagemCliente()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente!");
        }
    }
}