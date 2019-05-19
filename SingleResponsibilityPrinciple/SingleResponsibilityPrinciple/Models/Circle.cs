using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.Iterfaces;

namespace SingleResponsibilityPrinciple.Models
{
    public class Circle : IShape
    {
        public double Radious { get; set; }

        public Circle(double radious)
        {
            this.Radious = radious;
        }

        public double GetArea()
        {
            return 2 * Math.PI * this.Radious;
        }

        public double GetPatameter()
        {
            return Math.PI * Math.Pow(this.Radious, 2);
        }
    }
}
