using System.Collections.Generic;
using System.Linq;
using NUnitLite;
using Incapsulation.Weights;

class Program
{
	static void Main(string[] args)
	{
        double[] array = new double[] { 1, 2, 3, 4 };
        var indexer1 = new Indexer(array, 1, 2);
        var indexer2 = new Indexer(array, 0, 2);
        indexer1[0] = 100500;

        for (int i = 0; i < indexer1.Length; i++)
        {
            System.Console.WriteLine(indexer1[i]);
        }
        System.Console.WriteLine();
        for (int i = 0; i < indexer2.Length; i++)
        {
            System.Console.WriteLine(indexer2[i]);
        }

        new AutoRun().Execute(args);
	}
}
