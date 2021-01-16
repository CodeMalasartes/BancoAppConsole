using System;
using System.Globalization;

namespace BancoAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta; 

            Console.Write("Digite o nº da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Deposito Inicial (s/n)? : ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite valor a depositar: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine("Deseja efectuar mais operações?: ");
            char s = char.Parse(Console.ReadLine());
            if (s == 's' || s == 'S')
            {
                Console.Write("Deseja levantar quantia?: ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')
                {
                    Console.WriteLine();
                    Console.Write("Digite valor a levantar: ");
                    double levantamento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Levantamento(levantamento);
                    Console.WriteLine("Saldo atualizado: " + conta);

                }
                else
                {
                    Console.WriteLine("Obrigado");
                }
            }
            else
            {
                Console.WriteLine("Obrigado");
            }
           
            

            
            

        }
    }
}
