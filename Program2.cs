using System;

public class Rectangle
    {
        double Length;
        double Width;
        public double Area(double l, double w)
        {
            if (l < w) {
                throw new Exception("Length cannot be less than width!");
			} else {
				this.Length = l;
				this.Width = w;
			}
			
			double area = l * w;
			
			return area;
        }
        
    }
					
public class Program
    {
        public static void Main()
        {
            try
            {
                var r = new Rectangle();
				Console.WriteLine(r.Area(4,3));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
