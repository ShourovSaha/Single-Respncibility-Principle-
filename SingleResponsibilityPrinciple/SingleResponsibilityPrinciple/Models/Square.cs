using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.Iterfaces;

namespace SingleResponsibilityPrinciple.Models
{
    public class Square : IShape
    {
        public double Length { get; set; }

        public Square(double length)
        {
            this.Length = length;
        }

        public double GetArea()
        {
            return this.Length * this.Length;
        }

        public double GetPatameter()
        {
            return 4 * this.Length;
        }
    }
}
