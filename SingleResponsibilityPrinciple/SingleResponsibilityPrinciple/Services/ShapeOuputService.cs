using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Iterfaces;

namespace SingleResponsibilityPrinciple.Services
{
    public class ShapeOuputService 
    {
        public string GetHtmlFormatedOutput(IShape shape)
        {
            return $"<p>area: {shape.GetArea()} \n parameter: {shape.GetPatameter()}</p>";
        }

        public string GetJSONFormatedOutput(IShape shape)
        {
            return $"{{\"area\" : {shape.GetArea()} , \"parameter\": {shape.GetPatameter()}}}";
        }
    }
}
