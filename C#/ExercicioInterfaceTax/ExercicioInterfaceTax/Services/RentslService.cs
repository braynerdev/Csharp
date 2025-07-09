using ExercicioInterfaceTax.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaceTax.Services
{
    internal class RentslService
    {
        private ITaxService _taxService;
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public RentslService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double taxService = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, taxService);
        }
    }
}
