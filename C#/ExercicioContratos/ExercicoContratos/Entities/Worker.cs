using ExercicoContratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoContratos.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Dep { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament dep)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dep = dep;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDepartaments: {Dep.Name}";
        }

        public void AddContract(HourContract Contract)
        {
            Contracts.Add(Contract);
        }
        public void RemoveContract(HourContract Contract)
        {
            Contracts.Remove(Contract);
        }
        public Double Income(int year, int mouth)
        {
            double sum = BaseSalary;
            foreach (HourContract Contract in Contracts)
            {
                if (Contract.Date.Year == year && Contract.Date.Month == mouth)
                {
                    sum += Contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
