using System;
using System.Collections.Generic;
using DIO.BanK.Views;

namespace DIO.Bank
{
    class Program
    {        
        static void Main(string[] args)
        {
            Tela Tela = new Tela();
            Tela.Menu();

            System.Console.WriteLine("Obrigado por usar nossos serviços.");
            Console.ReadLine();
        }
        
    }
}
