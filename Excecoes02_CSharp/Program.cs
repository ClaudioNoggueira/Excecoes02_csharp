using Entities;
using Entities.Exceptions;
using System;

namespace Excecoes02_CSharp {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdray limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEnter the amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                account.WithDraw(withdraw);

                Console.Write("\n\nNew balance: " + account.Balance.ToString("F2"));

            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
