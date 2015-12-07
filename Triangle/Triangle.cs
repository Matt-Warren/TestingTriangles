/*
* FILE : Triangle.cs
* PROGRAMMER : Matt Warren
* FIRST VERSION : 2015-12-07
* DESCRIPTION :
* The functions in this file are used to emulate a triangle
*/
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

        public double sideA; //sides of triangle
        public double sideB;
        public double sideC;

        public double area; //area of triangle, not used

        public double angleA; //angles of triangle
        public double angleB;
        public double angleC;

        public bool rightAngled; //right angled or not, not used

        //Default constructor
        public Triangle()
        {
            angleA = 60;
            angleB = 60;
            angleC = 60;
            sideA = 3;
            sideB = 3;
            sideC = 3;
        }


        //create triangle with angles, no sides
        //int is just to make it different than side constructor
        public Triangle(double angleA, double angleB, int a)
        {
            this.angleA = angleA;
            this.angleB = angleB;
        }

        //create triangle with sides
        public Triangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        //calculate angles based on sides, not used
        public double Cosine(char side)
        {
            double retval = 0;

            switch (side)
            {
                case 'a': //get side a
                    sideA = Math.Sqrt(Math.Pow(sideB, 2) * Math.Pow(sideC, 2) - (2 * sideB * sideC) * Math.Cos(angleA * Math.PI / 180));
                    retval = sideA;
                    break;
                case 'b': //get side b
                    sideB = Math.Sqrt( Math.Pow(sideA, 2) + Math.Pow(sideC, 2) - (2 * sideA * sideB) * Math.Cos(angleB * Math.PI / 180));
                    retval = sideB;
                    break;
                case 'c': //get side c
                    sideC = Math.Sqrt( (Math.Pow(sideA, 2)) + (Math.Pow(sideB, 2)) - (2 * sideA * sideB * (Math.Cos(angleC*Math.PI/180))) );
                    retval = sideC;
                    break;

            }
            return Math.Round(retval, 4); //round answer to 4 decimals before returning(looks nice)
        }

        //pythagorean to get side c
        public double GetSideC()
        {
            double c = 0; 
            c = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)),4);
            return c;
        }

        
        //gets area of right angle triangle
        public double CalculateArea()
        {
            double calcArea = 0; 
            calcArea = Math.Round(0.5 * sideA * sideB , 4);
            return calcArea;
        }

        //finds whatever angle is missing
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
