using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Rectangle
    {
        double Length;
        double Width;
        public Rectangle(double l, double w)
        {
            if (l < w)
                throw new Exception("Length cannot be less than width!");
            this.Length = l;
            this.Width = w;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r;
            try
            {
                r = new Rectangle(3,4);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
