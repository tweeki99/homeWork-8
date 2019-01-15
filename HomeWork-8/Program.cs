using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexator indexator = new Indexator();

            for(int i = 0;i < indexator.array.Length; i++)
            {
                indexator[i] = i + 2;
                Console.Write(indexator[i] + "\t");
            }

            Console.ReadLine();
        }
    }
    class Indexator
    {
        public int[] array = new int[5];
        
        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value * value; }
        }
    }
}
