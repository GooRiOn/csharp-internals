using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterators
{
    public class Program 
    {
        public static void Main()
        {
            var sequence = GetSequence().GetEnumerator();

            sequence.MoveNext();
            Console.WriteLine(sequence.Current);

            sequence.MoveNext();
            Console.WriteLine(sequence.Current);

            sequence.MoveNext();
            Console.WriteLine(sequence.Current);

            Console.ReadLine();
        }

        public static IEnumerable<int> GetSequence()
        {
            var a = 3;

            Console.WriteLine("I'm inside iterator!");
            yield return 1;

            Console.WriteLine("I know where to resume the execution!");
            yield return 2;

            Console.WriteLine("I did it once again!");
            yield return a;
        }
    }
}
