using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Exercises 2.1 -----");
            CountDiv();
            Console.WriteLine("----- Exercises 2.2 -----");
            SumNum();
            Console.WriteLine("----- Exercises 2.3 -----");
            Factorial();
            Console.WriteLine("----- Exercises 2.4 -----");
            Max();
            Console.WriteLine("----- Exercises 2.5 -----");
            Random();
        }

        static void CountDiv()
        {
            int countD = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    countD += 1;
                }
            }
            Console.WriteLine(countD);
        }

        static void SumNum()
        {
            var sum = 0;
            int i = 0;

            var number = "";

            while (number != "ok" )
            {
                Console.Write("Enter your number : ");
                number = Console.ReadLine();
                if (number == "ok")
                {
                    break;
                }
                sum +=  Convert.ToInt32(number) ;
                i++;
            }

            Console.WriteLine("Sum = " + sum);
        }

        static void Factorial()
        {
            var number = 0;
            int fac = 1;
            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number ; i++)
            {
                fac = fac * i ;
            }
            Console.WriteLine(number + "! = " + fac);

        }

        static void Max()
        {
            Console.Write("Enter a series of number :");
            var num = Console.ReadLine();
            var numbers = num.Split(',');
            var max = 0;
            foreach (var item in numbers)
            {
                var intItem = Convert.ToInt32(item);
                max = (intItem > max) ? intItem : max;
            }
            Console.WriteLine("Maximum = " + max );
        }

        static void Random()
        {
            Random random = new Random();
            var randomNumber = random.Next(1, 10);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter your number : ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("You Won");
                    break;
                }
            }
            Console.WriteLine("You lost");
        }

    }
}
