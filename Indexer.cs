using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
    class Indexer
    {
        private readonly int start;
        private readonly int length;
        private double[] array = null;

        public int Length
        {
            get { return length; }
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index > length)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[start + index];
            }
            set
            {
                if (index < 0 || index > length)
                {
                    throw new IndexOutOfRangeException();
                }
                array[start + index] = value;
            }
        }

        public Indexer(double[] array, int start, int length)
        {
            this.array = array;
            this.start = start;
            this.length = length;
        }
    }
}
