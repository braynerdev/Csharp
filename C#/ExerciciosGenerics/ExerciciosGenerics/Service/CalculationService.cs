using ExerciciosGenerics.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciciosGenerics.Service
{
    internal class CalculationService
    {
        public T Comparable<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 1)
            {
                throw new ArgumentException("Lista Vazia");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
