using BANK;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                ContaBancaria conta;

                Console.Write("Entre o número da conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string titular = Console.ReadLine();   
                Console.Write("Haverá deposito inicial (s/n)? ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Entre com deposito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CI);
                    conta = new ContaBancaria(numero, titular, depositoInicial);
                }
                else {
                    conta = new ContaBancaria(numero, titular);
                }

                Console.WriteLine();
                Console.WriteLine("Dados da Conta ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre com um valor para deposito ");
                double quantia = double.Parse(Console.ReadLine(), CI);
                conta.Deposito(quantia);

                Console.WriteLine();
                Console.WriteLine("Dados da Conta Atualizado ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre com um valor para deposito ");
                quantia = double.Parse(Console.ReadLine(), CI);
                conta.Saque(quantia);

                Console.WriteLine();
                Console.WriteLine("Dados da Conta Atualizado ");
                Console.WriteLine(conta);
            }
        }
    }
}