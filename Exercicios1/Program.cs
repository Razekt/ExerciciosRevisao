namespace Exercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varejo empresaVarejista = new Varejo();
            empresaVarejista.CNPJ = "68.668.516/0001-42";
            empresaVarejista.Nome = "Atacadão";
            Console.WriteLine(empresaVarejista.ImprimirInfo());
            empresaVarejista.RealizarVenda();

            Empreiteira empreiteira = new Empreiteira();
            empreiteira.CNPJ = "56.854.754/0001-56";
            empreiteira.Nome = "MRV";
            Console.WriteLine(empreiteira.ImprimirInfo());
            empreiteira.RealizarVenda();
        }
    }
}