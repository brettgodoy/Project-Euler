using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        bool isPrime (Int64 number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (Int64 i = 2;  i < number; i++) 
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public Int64 calculateSum()
        {
            try
            {
                Int64 sum = new Int64();
                sum = 2;

                for (Int64 i = 3; i < 2000000; i++)
                {
                    if (isPrime(i) == true)
                    {
                        sum += i;
                        Console.WriteLine("Sum is " + sum + ", current number is " + i);
                    }

                }
                
                return sum;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Int64 answer = program.calculateSum();
            Console.WriteLine(answer);
            Console.WriteLine("Done");
            Console.ReadLine();
            
        }
    }
}
