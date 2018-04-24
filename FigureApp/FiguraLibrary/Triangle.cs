using System;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        private float storonaA;
        private float storonaB;
        private float storonaC;
        public Triangle(float storonaA,float storonaB,float storonaC)
        {
            this.storonaA = storonaA;
            this.storonaB = storonaB;
            this.storonaC = storonaC;
        }
        public double GetArea()
        {
            double p = 0,s=0;
            p = (storonaA + storonaB + storonaC) / 2;
            s = Math.Sqrt(p*(p-storonaA)*(p-storonaB)*(p-storonaC));
            return s;
        }
        public bool IsRightTriangle()
        {
            bool result = false;
            float a = 0, b = 0, c = 0;
            if (storonaA > storonaB && storonaA > storonaC)
            {
                c = storonaA;
                a = storonaB;
                b = storonaC;
            }
            else
            if (storonaB > storonaA && storonaB > storonaC)
            {
                c = storonaB;
                a = storonaA;
                b = storonaC;
            }
            else
            if (storonaC > storonaA && storonaC > storonaB)
            {
                c = storonaC;
                a = storonaA;
                b = storonaB;
            }
            else
                return false;
            result = Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2));
            return result;
        }
    }
}
