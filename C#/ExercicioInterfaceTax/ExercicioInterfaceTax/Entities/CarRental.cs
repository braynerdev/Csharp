using ExercicioInterfaceTax.Services;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaceTax.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }

        public override string ToString()
        {
            return $"Basic payment: {Invoice.BasicPayment.ToString("F2",CultureInfo.InvariantCulture)}" +
                $"\nTax: {Invoice.Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {Invoice.TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
