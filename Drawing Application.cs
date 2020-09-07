using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_application
{
    class Shape
    { 
       public virtual void Draw()
        {
            Console.WriteLine("Base class draw method");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
    class triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
            base.Draw();
        }

    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
            base.Draw();
        }

    }
    class Program
    {
        public static void Main(String[] args)
        {

            do
            {
                Console.WriteLine("Choose an option to draw");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Square");
                Console.WriteLine("Exit");
                Console.WriteLine("Enter your choice");
            }     
           /* var drawObjects = new List<Shape>
            {
                new Rectangle(),
                new Circle(),
                new triangle(),
                new Square()

            };
            foreach(Shape s in drawObjects)
            {
                s.Draw();
            }
            Console.ReadLine();*/
        }
    }
}