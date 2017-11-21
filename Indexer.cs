using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
    class Indexer
    {
        private readonly double[] originalArray;
        public double[] SubArray { get; private set; }
        
        public int Length
        {
            get { return SubArray.Length; }
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index > SubArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return SubArray[index];
            }
            set
            {
                if (index < 0 || index > SubArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                SubArray[index] = value;
            }
        }

        public Indexer(double[] array, int start, int length)
        {
            if (start < 0 || start > array.Length || length < 0 || length > array.Length - start)
            {
                throw new ArgumentException();
            }
            this.originalArray = array;
            SubArray = new double[length];
            SubArray = array.Skip(start).Take(length).ToArray() ;
        }

    }
}
