using ExercicioTryCatch.Entities;
using ExercicioTryCatch.Entities.Exception;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account1 = new Account(123, "Brayner", 4000.00, 2500.00);

                Console.WriteLine($"Balance {account1.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

                account1.Deposit(875.00);

                Console.WriteLine($"New Balance " +
                    $"{account1.Balance.ToString("F2",CultureInfo.InvariantCulture)}");

                account1.Withdraw(766000.00);

                Console.WriteLine($"New Balance " +
                    $"{account1.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}