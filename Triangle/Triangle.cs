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

        public double Cosine(char side)
        {
            double retval = 0;
            switch (side)
            {
                case 'a':
                    sideA = Math.Sqrt(Math.Pow(sideB, 2) * Math.Pow(sideC, 2) - (2 * sideB * sideC) * Math.Cos(angleBC));
                    retval = sideA;
                    break;
                case 'b':
                    sideB = Math.Sqrt(Math.Pow(sideA, 2) * Math.Pow(sideC, 2) - (2 * sideA * sideB) * Math.Cos(angleAC));
                    retval = sideB;
                    break;
                case 'c':
                    sideC = Math.Sqrt(Math.Pow(sideA, 2) * Math.Pow(sideB, 2) - (2 * sideA * sideB) * Math.Cos(angleAB));
                    retval = sideC;
                    break;

            }
            return Math.Round(retval, 4);
        }


        public double GetSideC()
        {
            double c = 0;
            c = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)),4);
            return c;
        }

        

        public double CalculateArea()
        {
            double calcArea = 0;
            calcArea = Math.Round(0.5 * sideA * sideB , 4);
            return calcArea;
        }

        public double GetMissingAngle()
        {
            double missingAngle = 0;

            return missingAngle;
        }

    }
}
