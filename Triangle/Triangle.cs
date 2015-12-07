using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public static double maxAngle = 180;

        public double sideA;
        public double sideB;
        public double sideC;

        public double area;

        public double angleA;
        public double angleB;
        public double angleC;

        public bool rightAngled;

        public Triangle()
        {
            angleA = 60;
            angleB = 60;
            angleC = 60;
            sideA = 3;
            sideB = 3;
            sideC = 3;
        }

        public Triangle(double angleA, double angleB, int a)
        {
            this.angleA = angleA;
            this.angleB = angleB;
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
                    sideA = Math.Sqrt(Math.Pow(sideB, 2) * Math.Pow(sideC, 2) - (2 * sideB * sideC) * Math.Cos(angleA * Math.PI / 180));
                    retval = sideA;
                    break;
                case 'b':
                    sideB = Math.Sqrt( Math.Pow(sideA, 2) + Math.Pow(sideC, 2) - (2 * sideA * sideB) * Math.Cos(angleB * Math.PI / 180));
                    retval = sideB;
                    break;
                case 'c':
                    sideC = Math.Sqrt( (Math.Pow(sideA, 2)) + (Math.Pow(sideB, 2)) - (2 * sideA * sideB * (Math.Cos(angleC*Math.PI/180))) );
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

        public double GetMissingAngle(char angle)
        {
            double missingAngle = 0;
            double max = maxAngle;
            switch (angle)
            {
                case 'a':
                    missingAngle = max - angleB - angleC;
                    break;
                case 'b':
                    missingAngle = max - angleA - angleC;
                    break;
                case 'c':
                    missingAngle = max - angleA - angleB;
                    break;
            }
            return missingAngle;
        }

    }
}
