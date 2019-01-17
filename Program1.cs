using System;

    public class Point
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
    

    public class Program
    {
        public static void Main(string[] args)
        {
            Point p = new Point(1, 2, 3);
            Console.WriteLine(p);
        }
    }
