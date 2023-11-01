using System.Data.SqlTypes;

namespace assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape shape=null;
            Console.WriteLine("Enter shape type");
            int c = Byte.Parse(Console.ReadLine());
            if (c == 1)
            {
                shape = new Square();
            }
            else if(c==2)
            {
                shape = new Rectangle();
            }
            
            Check ch = new Check();
            ch.CheckShape(shape);
        }
    }
    class Check
    {
        public void CheckShape(Shape shape)
        {
            if(shape is Square)
            {
                foo((Square)shape);     
            }
            else if(shape is Rectangle)
            {
                foo((Rectangle)shape);
            }
            
        }
        public void foo(Square square)
        {
            square.Sq();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();
        }
        public void foo(Rectangle rectangle)
        {
            rectangle.Re();
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();
        }
    }
}