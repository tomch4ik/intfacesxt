using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intfacesxt
{
    public class Array : ICalc, IOutput2, ICalc2
    {
        private int[] elements;
        public Array(int[] elements)
        {
            this.elements = elements;
        }
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public void ShowEven()
        {
            Console.WriteLine("Четные значения в массиве:");
            foreach (int element in elements)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            Console.WriteLine("Нечетные значения в массиве:");
            foreach (int element in elements)
            {
                if (element % 2 != 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }
        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

