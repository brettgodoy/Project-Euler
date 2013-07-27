using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem21
{
    public class Class1
    {
        public int findProperDivisorsSum(int num) 
        {
            int sum = 0;

            for (int i = 1; i < num; i++) 
            {
                if ((num % i == 0) && (num != i)) 
                {
                    sum += i;
                }
            }

            return sum;

        }

        public long findAmicableNumbers()
        {
            Dictionary<int, int> numDictionary = new Dictionary<int, int>();

            for (int i = 1; i < 100; i++)
            {

                int sumOfDivisors = findProperDivisorsSum(i);
                numDictionary.Add(i, sumOfDivisors);

            }

            Class2 class2 = new Class2();
            long finalSum =  class2.findValues(numDictionary);
            return finalSum;
        }


        static void Main(string[] args) 
        {
            Class1 class1 = new Class1();
            var answer = class1.findAmicableNumbers();

            Console.WriteLine(answer);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
