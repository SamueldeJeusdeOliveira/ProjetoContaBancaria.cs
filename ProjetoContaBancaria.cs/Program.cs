using ProjetoContaBancaria.cs.Entities;

namespace ProjetoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                ContaCorrente contaCorrente1 = new ContaCorrente();
                ContaPoupanca contaPoupanca1 = new ContaPoupanca();
                Console.WriteLine(contaPoupanca1);
                Console.WriteLine(contaCorrente1);
                Console.WriteLine("Digite o número da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a senha: ");
                string senha = Console.ReadLine();
                contaCorrente1.VerificaSenha(senha);
                
                if(contaCorrente1.VerificaSenha(senha) == true)
                {
                    Console.WriteLine($"Bem vindo {contaCorrente1.Name}!");
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine($"1 - Verificar Saldo\n2 - Sacar\n3 - Depositar\n4 - Transferir");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine($"Seu saldo é: {contaCorrente1.Saldo}");
                            break;
                        case 2:
                            Console.WriteLine("Digite o valor a ser sacado: ");
                            double valorSaque = double.Parse(Console.ReadLine());
                            contaCorrente1.Sacar(valorSaque);
                            break;
                        case 3:
                            Console.WriteLine("Digite o valor a ser depositado: ");
                            double valorDeposito = double.Parse(Console.ReadLine());
                            contaCorrente1.Depositar(valorDeposito);
                            break;
                        case 4:
                            Console.Write("Digite o valor a ser transferido: "); double valorTransferencia = double.Parse(Console.ReadLine());
                            Console.Write("Digite o ID da conta para o valor ser transferido: ");  int id = int.Parse(Console.ReadLine());
                            contaCorrente1.Transferir(valorTransferencia, id);
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Senha incorreta.");
                    break;
                }
            }
            Console.WriteLine("Gostaria de realizar um outro acesso?(S/N)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "S")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Obrigado por usar nosso sistema!");
            }

            List<ContaCorrente> movimentacoes = new List<ContaCorrente>();

        }
    }
}