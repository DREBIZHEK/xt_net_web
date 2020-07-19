using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1
{
	public static class SuperArray
	{
		public static IEnumerable<T> Modify<T>(this IEnumerable<T> collection, Func<T,T> func)
		{
			if (!collection.Any())
			{
				throw new ArgumentException("Collection cannot be empty");
			}
			if (func == null)
			{
				throw new ArgumentNullException("Function cannot be empty");
			}

			return collection.Select(element => func(element)).ToArray();
		}

		public static double SumOfElements(this double[] collection)
		{
			return collection.Sum();
		}

		public static double AvarageOfElements(this double[] collection)
		{
			return collection.Average();
		}

		public static double RepeatedElement(this double[] collection)
		{
			double mostRepeated = collection.GroupBy(item => item).OrderByDescending(g => g.Count()).First().Key;
			return mostRepeated;
		}

	}
}
