using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public double area;

        public double angleAB;
        public double angleAC;
        public double angleBC;

        public bool rightAngled;

        public Triangle()
        {

        }

        public Triangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double GetSideC()
        {
            double c = 0;
            return c;
        }

        public double CalculateArea()
        {
            double calcArea = 0;
            calcArea = 0.5 * sideA * sideB;
            return calcArea;
        }

        public double GetMissingAngle()
        {
            double missingAngle = 0;

            return missingAngle;
        }

    }
}
