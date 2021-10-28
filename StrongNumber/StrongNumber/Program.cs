using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
	class Program
	{
		public static void Strong()
		{
            int number = 0, sum = 0;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            int quot = number;
            int remainder;
            while (quot != 0)
            {
                remainder = quot % 10;
                int fact = Factorial(remainder);
                quot = quot / 10;
                sum = sum + fact;
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a Strong Number");
            }
            else
            {
                Console.WriteLine(number + " is not a Strong Number");
            }
        }
        public static int Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
		{
            Strong();
		}
	}
}
