using System;

namespace HighLowLab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int low = GetLow();
            int high = GetHigh(low);
            Console.WriteLine("The difference is " + (high - low));
            List<int> ints = Enumerable.Range(low, high - low).ToList();
            ints.Reverse();
            StreamWriter writer = new StreamWriter("numbers.txt");
            foreach (int i in ints)
            {
                writer.WriteLine(i);
            }
            Console.WriteLine("Prime Numbers:");
            ints.Reverse();
            foreach (int i in ints)
            {
                if (GetPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            writer.Close();
        }

        public static int GetLow()
        {
            int low = 0;
            while (low <= 0)
            {
                Console.WriteLine("Please input the low number: (must be greater than zero)");
                low = int.Parse(Console.ReadLine());
            }
            return low;
        }

        public static int GetHigh(int low)
        {
            int high = 0;
            while (high <= low)
            {
                Console.WriteLine("Please input the high number: (must be greater than low number)");
                high = int.Parse(Console.ReadLine());
            }
            return high;
        }

        public static bool GetPrime(int num)
        {
            if(num == 2 || num == 3)
                return true;
            if(num % 2 == 0 || num == 1)
                return false;
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num % i  == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
