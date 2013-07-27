using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem21
{
    class Class2 : ILookup<int, int>
    {
        

        public long findValues(Dictionary<int, int> dictionary) 
        {
            long sum = 0;

            var lookup = dictionary.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1);

            foreach (var item in lookup) 
            {
                var keys = item.Aggregate((s, v) => s + v);
                sum += keys;
                var message = "The sum of keys with values of " + item.Key + " is " + keys + ". The current sum is " + sum;

                Console.WriteLine(message);
            }

            return sum;
        }

        public void findValuesTest() 
        {
            Dictionary<int,int> testDictionary = new Dictionary<int,int>();
            Int64 sum = 0;

            for (var i=0; i < 5; i++) 
            {
                testDictionary.Add(i, i);
            }

            testDictionary.Add(5, 6);
            testDictionary.Add(6, 5);
            testDictionary.Add(7, 3);

            var lookup = testDictionary.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1);


            foreach (var item in lookup)
            {
                if (


                //var keys = item.Aggregate("", (s, v) => s + ", " + v);
                //var message = "The following keys have the value " + item.Key + ":" + keys;
                var keys = item.Aggregate((s,v) => s + v);
                sum += keys;
                var message = "The sum of keys with values of " + item.Key + " is " + keys + ". The current sum is " + sum;

                Console.WriteLine(message);
            }

            Console.WriteLine("The final sum is " + sum);
        }

        public bool Contains(int key)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<int> this[int key]
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator<IGrouping<int, int>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
