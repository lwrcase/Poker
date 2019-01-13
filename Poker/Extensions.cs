using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    /// <summary>
    /// Custom extensions class.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Random instantiator.
        /// </summary>
        public static Random rng = new Random();
        /// <summary>
        /// Shuffles list of items.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="list">List object.</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        /// <summary>
        /// Determines if an array is in sequential order.
        /// </summary>
        /// <param name="array">Integer array.</param>
        /// <returns>Boolean</returns>
        public static bool IsSequential(this int[] array)
        {
            return array.Zip(array.Skip(1), (a, b) => (a + 1) == b).All(x => x);
        }
    }
}
