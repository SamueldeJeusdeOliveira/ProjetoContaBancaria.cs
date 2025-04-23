using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.cs.Entities
{
    public class ContaCorrente : Conta
    {
        private List<string> extrato;
        public ContaCorrente(int iD, double saldo, double limit, string senha, string name) : base(saldo, iD, limit, senha, name)
        {
            Saldo = saldo;
            Senha = senha;
            extrato = new List<string>();
        }
        public void Depositar(double valor)
        {
            Saldo += valor - 5;
            Console.WriteLine("Depósito feito com sucesso!");
            extrato.Add($"Depósito de {valor} realizado - Saldo atual: {Saldo} - Data/Hora da operação: {Date}");
        }
    }
}
