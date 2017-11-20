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
        System.Console.WriteLine(indexer2[0]);

        new AutoRun().Execute(args);
	}
}
