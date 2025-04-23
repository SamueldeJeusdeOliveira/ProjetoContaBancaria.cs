using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.cs.Entities
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {
            extrato = new List<string>();
        }
        public ContaPoupanca(int iD, double saldo, double limit, string senha, string name) : base(saldo, iD, limit, senha, name)
        {
            Saldo = saldo;
            Senha = senha;
        }
    }
    }
}
