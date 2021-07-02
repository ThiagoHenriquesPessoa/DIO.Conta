using System;
using System.Collections.Generic;
using System.Linq;
using DIO.Bank;

namespace DIO.BanK.Views
{
    class Tela
    {
        static List<Conta> listContas = new List<Conta>();
        private string MenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();

            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("x- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.Clear();

            return opcaoUsuario;
        }
        public void Menu()
        {
            string opcaoUsuario = MenuPrincipal();
            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        TransferirConta();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;                    
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = MenuPrincipal();
            }
        }
        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
            
            Console.WriteLine("Digite (V) para voltar ao menu principal: ");
            string opcao = Console.ReadLine();
            while (opcao.ToUpper() != "V")
            {
                Console.WriteLine("Opção incorreta digite (V) para voltar ao menu principal");
                opcao = Console.ReadLine();
            }
            Console.Clear();
        }

        private static void InserirConta()
        {
            Console.WriteLine("inserir nova conta");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(
                tipoConta: (TipoConta)entradaTipoConta,
                saldo: entradaSaldo,
                credito: entradaCredito,
                nome: entradaNome);

            listContas.Add(novaConta);

            Console.WriteLine("Digite (V) para voltar ao menu principal: ");
            string opcao = Console.ReadLine();
            while (opcao.ToUpper() != "V")
            {
                Console.WriteLine("Opção incorreta digite (V) para voltar ao menu principal");
                opcao = Console.ReadLine();
            }
            Console.Clear();
        }

        private static void TransferirConta()
        {
            Console.WriteLine("Digite o número da conta de origem");
            int indeceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino");
            int indeceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indeceContaOrigem].Transferir(valorTransferencia, listContas[indeceContaDestino]);

            Console.WriteLine("Digite (V) para voltar ao menu principal: ");
            string opcao = Console.ReadLine();
            while (opcao.ToUpper() != "V")
            {
                Console.WriteLine("Opção incorreta digite (V) para voltar ao menu principal");
                opcao = Console.ReadLine();
            }
            Console.Clear();
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta");
            int indeceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indeceConta].Sacar(valorSaque);

            Console.WriteLine("Digite (V) para voltar ao menu principal: ");
            string opcao = Console.ReadLine();
            while (opcao.ToUpper() != "V")
            {
                Console.WriteLine("Opção incorreta digite (V) para voltar ao menu principal");
                opcao = Console.ReadLine();
            }
            Console.Clear();
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta");
            int indeceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indeceConta].Depositar(valorDeposito);

            Console.WriteLine("Digite (V) para voltar ao menu principal: ");
            string opcao = Console.ReadLine();
            while (opcao.ToUpper() != "V")
            {
                Console.WriteLine("Opção incorreta digite (V) para voltar ao menu principal");
                opcao = Console.ReadLine();
            }
            Console.Clear();
        }

    }
}
