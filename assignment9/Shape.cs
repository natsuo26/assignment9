using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    class Square : Shape
    {
        int side;

        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter side");
            side = Byte.Parse(Console.ReadLine());
        }
        public void Sq()
        {
            Console.WriteLine("this is a sqaure");
        }
    }
    class Rectangle : Shape
    {
        int length, breadth;

        public override void GetDimensions()
        {
            Console.WriteLine("Enter length");
            length = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Byte.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }
        public void Re()
        {
            Console.WriteLine("this is a Rectangle");
        }

    }

}
