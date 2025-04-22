using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.cs.Entities
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public int ID { get; set; }
        public double Limit { get; set; }
        private List<string> extrato;
        public ContaCorrente(double saldo, int iD, double limit)
        {
            Saldo = saldo;
            ID = iD;
            Limit = limit;
            extrato = new List<string>();
            extrato.Add($"Conta Corrente {ID} criada com saldo inicial de {Saldo} e limite de {Limit}.");
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito feito com sucesso!");
            extrato.Add($"Depósito de {valor} realizado - Saldo atual: {Saldo}");
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo + Limit)
            {
                Console.WriteLine("Valor maior que o saldo e o limite.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque feito com sucesso!");
                extrato.Add($"Saque de {valor} realizado - Saldo atual: {Saldo}");
            }
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > Saldo + Limit)
            {
                Console.WriteLine("Valor maior que o saldo e o limite.");
            }
            else
            {
                Saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferência feita com sucesso!");
                extrato.Add($"Transferência de {valor} para a conta {contaDestino.ID} realizada. Saldo atual: {Saldo}");
            }
        }
        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da Conta {ID}:");
            foreach (string movimentacao in extrato)
            {
                Console.WriteLine(movimentacao);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Conta Corrente {ID}:\nSaldo: {Saldo}\n";
        }
    }
}
