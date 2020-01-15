
using System;
using System.Linq;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            var raises = new double[] { 99, 65, 79, 75, 87, 81 };
            var runs = new double[] { 43, 21, 25, 42, 57, 59 };
            LinearRegression(raises, runs, 6, out var yin, out var slope);

            Class1.LinearRegression(runs, raises, 0, 6, out var rsm, out var yin1, out var slope1);
            Console.WriteLine("Hello World!");
        }

        //https://www.statisticshowto.datasciencecentral.com/probability-and-statistics/regression-analysis/find-a-linear-regression-equation
        public static void LinearRegression(double[] raiseValues, double[] runValues, int size, out double yIntercept, out double slope)
        {
            var sumX = 0D;
            var sumY = 0D;
            var sumXY = 0D;
            var sumXsq = 0D;
            var sumYsq = 0D;

            for (var i = 0; i < size; i++)
            {
                var x = runValues[i];
                var y = raiseValues[i];
                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumXsq += x * x;
                sumYsq += y * y;
            }

            //The y-intercept is the point where a graph crosses the y-axis. 
            //https://calculushowto.com/y-intercept/
            yIntercept = ((sumY * sumXsq) - (sumX * sumXY)) / ((size * sumXsq) - (sumX * sumX));

            //it’s a number that describes both the direction (positive or negative) and the steepness of the line.
            //https://calculushowto.com/what-is-a-slope/
            slope = ((size * sumXY) - (sumX * sumY)) / ((size * sumXsq) - (sumX * sumX));


        }
    }
}
