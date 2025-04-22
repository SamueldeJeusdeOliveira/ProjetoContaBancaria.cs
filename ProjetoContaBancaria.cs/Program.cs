using ProjetoContaBancaria.cs.Entities;

namespace ProjetoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ContaCorrente> movimentacoes = new List<ContaCorrente>();

            ContaCorrente contaCorrente1 = new ContaCorrente(1000, 1, 500);

            movimentacoes.Add(contaCorrente1);
            ContaCorrente contaCorrente2 = new ContaCorrente(2000, 2, 1000);
            movimentacoes.Add(contaCorrente2);
            Console.WriteLine(contaCorrente1);

            contaCorrente1.Depositar(500);
            contaCorrente1.Sacar(200);
            contaCorrente1.Transferir(300, contaCorrente2);
            Console.WriteLine();
            contaCorrente1.ExibirExtrato();
            Console.WriteLine();
            contaCorrente2.ExibirExtrato();
        }
    }
}