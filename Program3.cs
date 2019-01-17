using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{

    public class  MyArray
    {
        double[] data;
        public MyArray()
        {
            this.data = new double[15];
        }
        public double this[int k]
        {
            get { return this.data[k + 5]; }
            set { this.data[k + 5] = value; }
        }
    }
        

    public class Program
    {
        public static void Main(string[] args)
        {
            MyArray ma = new MyArray();
            for (int k = -5; k <= 9; k++)
                ma[k] = k * k;
            for (int k = -5; k <= 9; k++)
                Console.WriteLine(ma[k]);
        }
    }
}
