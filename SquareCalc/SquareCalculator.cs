using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc
{
    public static class SquareCalculator
    {
        public static double SquareRoot(double x)
        {
            // Start with an initial guess at the square root of x
            double guess = 1.0;

            // Set a maximum number of iterations
            int maxIterations = 100;

            // Set a tolerance for the error between the square of the guess and x
            double tolerance = 0.00001;

            // Iterate until the error is within the tolerance or the maximum number of iterations is reached
            for (int i = 0; i < maxIterations; i++)
            {
                // Calculate the error between the square of the guess and x
                double error = (guess * guess) - x;

                // If the error is within the tolerance, return the guess as the approximate square root
                if (Math.Abs(error) < tolerance)
                {
                    return guess;
                }

                // Refine the guess by taking the average of the guess and the number divided by the guess
                guess = (guess + (x / guess)) / 2.0;
            }

            // If the maximum number of iterations is reached, return the final guess as the approximate square root
            return guess;
        }
    }
}
