using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
    class Indexer
    {
        readonly double[] originalArray;
        public double[] SubArray { get; private set; }

        public Indexer(double[] array, int start, int length)
        {
            this.originalArray = array;
            SubArray = new double[length - start];
            Array.Copy(originalArray, start, SubArray, 0, length);
        }

    }
}
