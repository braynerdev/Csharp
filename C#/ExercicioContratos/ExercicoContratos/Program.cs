using ExercicoContratos.Entities.Enum;
using ExercicoContratos.Entities;
using System;
using System.Globalization;

namespace ExercicoContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string NameDepartaments = Console.ReadLine();

            Departament DepartamentWorker = new Departament(NameDepartaments); 



            Console.WriteLine("Enter worker Date: ");

            Console.Write("Name: ");
            string NameWorker = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel Level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double Salary  = double.Parse(Console.ReadLine());

            Worker WorkeRegister = new Worker(NameWorker, Level, Salary, DepartamentWorker);


            Console.Write("How many contracts to this worker? ");
            int AmountContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < AmountContract; i++)
            {
                Console.WriteLine($"Enter #{i} contract Date: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime Date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double ValuerHour = double.Parse(Console.ReadLine());

                Console.Write("Duraction (hours): ");
                int Duraction = int.Parse(Console.ReadLine());

                HourContract Contract = new HourContract(Date,ValuerHour,Duraction);
                WorkeRegister.AddContract(Contract);
            }

            Console.Write("Enter mouth and to calculate income (MM/YYYY): ");
            string MouthAndYear = Console.ReadLine();
            string[] SplitMouthAndYear = MouthAndYear.Split('/');
            int Mouth = int.Parse(SplitMouthAndYear[0]);
            int Year = int.Parse(SplitMouthAndYear[1]);
            Console.WriteLine(WorkeRegister.ToString());
            double ValueTotalGain = WorkeRegister.Income(Year,Mouth);

            Console.Write($"Income for {MouthAndYear}: {ValueTotalGain.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}