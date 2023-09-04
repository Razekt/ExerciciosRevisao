namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varejo empresaVarejista = new Varejo();
            empresaVarejista.CNPJ = "68.668.516/0001-42";
            empresaVarejista.Nome = "Atacadão";

            Empreiteira empreiteira = new Empreiteira();
            empreiteira.CNPJ = "56.854.754/0001-56";
            empreiteira.Nome = "MRV";

            List<IEmpresa> listaEmpresa = new List<IEmpresa>();
            listaEmpresa.Add(empresaVarejista);
            listaEmpresa.Add(empreiteira);

            foreach (IEmpresa item in listaEmpresa)
            {
                Console.WriteLine(item.ImprimirInfo());
                item.RealizarVenda();                        
            }
        }
    }
}

/*
Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
Após Realizar a venda, utilizaremos o método de EnviarNotificacao.
*/