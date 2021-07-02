using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
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
                        case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario =  ObterOpcaoUsuario();
            }
            System.Console.WriteLine("Obrigado por usar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarContas()
        {
            throw new NotImplementedException();
        }

        private static void InserirConta()
        {
            throw new NotImplementedException();
        }

        private static void TransferirConta()
        {
            throw new NotImplementedException();
        }

        private static void Sacar()
        {
            throw new NotImplementedException();
        }

        private static void Depositar()
        {
            throw new NotImplementedException();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine( );
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("x- Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
