using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Point
    {
        int x;
        int y;
        int z;
        public Point(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return "(" + this.x + "," + this.y + "," + this.z + ")";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 2, 3);
            Console.WriteLine(p);
        }
    }
}
