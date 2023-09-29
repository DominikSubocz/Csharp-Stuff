using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public class BasicMaths
    {
        public double AreaByRadius(double rad)
        {

            double area = 0;
            area = Math.PI * rad *rad;

            return area;
        }

        public double PercentageOf(double current, double maximum) 
        {
            double percentage = 0;
            percentage = (current / maximum) * 100;
            return percentage;

        }

        public double VolumeOfCube(double side)
        {
             double volume = 0;
             volume = side * side * side;
             return volume;
        }

        public double AverageOf(double num1, double num2, double num3, double num4)
        {
            double average = 0;
            average = (num1 + num2 + num3 + num4) / 4;
            return average;
        }

        public double IsGreater(double num1, double num2)
        {

            if(num1 > num2)
            {
                return num1;

            }

            else
            {
                return num2;

            }


        }

    }
}
