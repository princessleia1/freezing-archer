using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range

    /* Ranges and indices provide a succinct syntax for accessing single elements or ranges in an Array, Span<T>, or ReadOnlySpan<T>.
     * These features enable more concise, clear syntax to access single elements or ranges of elements in a sequence.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Sequence(1000);

            for (int start = 0; start < sequence.Length; start += 100)
            {
                Range r = start.start + 10;
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start} to {r.End}:    \tMin: {min},\tMax: {max},\tAverage: {average}");
            }

            for (int start = 0; start < sequence.Length; start += 100)
            {
                Range r = (start + 10)start;

                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start} to {r.End}:  \tMin: {min},\tMax: {max},\tAverage: {average}");
            }

            (int min, int max, double average) MovingAverage(int[] subSequence, Range range) =>
                (
                    subSequence[range].Min(),
                    subSequence[range].Max(),
                    subSequence[range].Average()
                );

            int[] Sequence(int count) =>
                Enumerable.Range(0, count).Select(x => (int)(Math.Sqrt(x) * 100)).ToArray();
        }
    }      
}
