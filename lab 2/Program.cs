using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int size = 10;

            RomanNumber[] numbers = new RomanNumber[size];

            for (int i = 0; i < size; i++)
            {
                int tmp = rand.Next();
                ushort x = (ushort)tmp;
                numbers[i] = new RomanNumber(x);
                Console.WriteLine(numbers[i].ToString() + " " + x);
            }

            Array.Sort<RomanNumber>(numbers);
            Console.WriteLine();

            foreach (RomanNumber i in numbers)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}