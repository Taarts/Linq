using System;
using System.Linq;

using System.Collections.Generic;

namespace linq
{
    class Program
    {
        // static int MultiplyBy2(int value)
        // {
        //     return value * 2;
        // }
        static void Main(string[] args)
        {
            // Here is our original array
            var scores = new List<int> { 42, 100, 98, 15 };

            // Here is our handy Double-er
            Func<int, int> MultiplyBy2 = value => value * 2;

            var newScores = scores.Select(MultiplyBy2);
            foreach (var score in newScores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine(scores.Count()); /* <--- "using Linq" adding () to scores.Count is valid*/
            Console.WriteLine(newScores.Count());

            // // Make a new list to store the results
            // var newScores = new List<int>();

            // // Go through each score in the scores list
            // foreach (var score in scores)
            // {
            //     // Make a doubling of that score
            //     var doubled = MultiplyBy2(score);

            //     // Add it to our new list
            //     newScores.Add(doubled);
            // }

            // Print out the scores comma separated
            Console.WriteLine(String.Join(',', newScores));
        }
    }
}