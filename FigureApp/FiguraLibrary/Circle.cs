using System;

namespace FigureLibrary
{
    public class Circle: IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            double s = 0;
            s = Math.PI * Math.Pow(radius, 2);
            return s;
        }

        
    }
}
