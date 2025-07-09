using ExercicioInterfaceTax.Entities;
using ExercicioInterfaceTax.Services;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Civic");

            CarRental carRental = new CarRental(
                DateTime.ParseExact("25/06/2018 10:30", "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture),
                DateTime.ParseExact("25/06/2018 14:40", "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture),
                vehicle
            );

            RentslService rentslService = new RentslService(10.00, 130.00, new BrazilTaxService());
            rentslService.ProcessInvoice(carRental);
            Console.WriteLine(carRental);
        }
    }
}