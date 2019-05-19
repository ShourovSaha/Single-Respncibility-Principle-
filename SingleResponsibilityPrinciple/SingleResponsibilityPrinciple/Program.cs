using System;
using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Services;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2.5);
            Square square = new Square(3);
            ShapeOuputService shapeOuput = new ShapeOuputService();
            Console.WriteLine("Circle Output: " + shapeOuput.GetHtmlFormatedOutput(circle));
            Console.WriteLine("Shape Output: " + shapeOuput.GetJSONFormatedOutput(square));
            Console.ReadKey();
        }
    }
}
