using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.cs.Entities
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string Name { get; set; }
        public string Senha { get; set; }
        public int ID { get; set; }
        public double Limit { get; set; }
        public List<string> extrato;
        public DateTime Date { get; set; }
        public Conta()
        {
            extrato = new List<string>();
        }
        public Conta(int iD, double saldo, double limit, string senha, string name)
        {
            Name = name;
            Saldo = saldo;
            ID = iD;
            Limit = limit;
            Senha = senha;
            extrato = new List<string>();
            Date = DateTime.Now;
            extrato.Add($"Conta Corrente {ID} criada com saldo inicial de {Saldo} e limite de {Limit} - Data/Hora da Criação da conta: {Date}");
            Senha = senha;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito feito com sucesso!");
            extrato.Add($"Depósito de {valor} realizado - Saldo atual: {Saldo} - Data/Hora da operação: {Date}");
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
                extrato.Add($"Saque de {valor} realizado - Saldo atual: {Saldo} - Data/Hora da operação: {Date}");
            }
        }
        public void Transferir(double valor,int id, Conta conta)
        {
            if (valor > Saldo + Limit && ID == id)
            {
                Console.WriteLine("Valor maior que o saldo e o limite.");
            }
            else
            {
                Saldo -= valor;
                conta.Depositar(valor);
                Console.WriteLine("Transferência feita com sucesso!");
                extrato.Add($"Transferência de {valor} para a conta {conta.ID} realizada. Saldo atual: {Saldo} - Data/Hora da operação: {Date}");
            }
        }
        public bool VerificaConta(string senha) => senha == Senha);

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da Conta {ID}:");
            foreach (string movimentacao in extrato)
            {
                Console.WriteLine(movimentacao);
            }
            Console.WriteLine();
        }
        public bool VerificaSenha(string senha)
        {
            if (senha == Senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Conta Corrente {ID}:\nSaldo: {Saldo}\n";
        }
    }
}
