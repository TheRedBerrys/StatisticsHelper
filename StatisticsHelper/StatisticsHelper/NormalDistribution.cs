using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsHelper
{
    /// <summary>
    /// A static class providing methods relating to the Normal Distribution.
    /// For more information about the Normal Distribution, go to http://en.wikipedia.org/wiki/Normal_distribution
    /// </summary>
    public static class NormalDistribution
    {
        /// <summary>
        /// A private constant used in z-score calculations.
        /// </summary>
        private static double Z_MAX = 6;

        /// <summary>
        /// An enumerated type to allow for calculating proportion less than or greater than a particular number in a particular distribution.
        /// </summary>
        public enum Proportion
        {
            LessThan,
            GreaterThan
        }

        /// <summary>
        /// Calculates a z-score based on a given x-value, mean, and standard deviation.
        /// </summary>
        /// <param name="x">The x-value to use in calculation; the observed measurement for which to find a z-score.</param>
        /// <param name="avg">The mean of the distribution to use in the calculation.</param>
        /// <param name="stdev">The standard deviation of the distribution to use in the calculation.</param>
        /// <returns>The z-scored calculated based on the given inputs</returns>
        public static double SolveZFromX(double x, double avg, double stdev)
        {
            return Math.Round((x - avg) / stdev, 5);
        }

        /// <summary>
        /// Calculates an x-value based on a given z-score, standard deviation, and mean.
        /// </summary>
        /// <param name="z">The z-score of the measurement to find.</param>
        /// <param name="stdev">The standard deviation of the distribution to use in the calculation.</param>
        /// <param name="avg">The mean of the distribution to use in the calculation.</param>
        /// <returns>A measurement that will have the given z-score in the given distribution.</returns>
        public static double SolveXFromZ(double z, double stdev, double avg)
        {
            return Math.Round((z * stdev) + avg, 5);
        }

        /// <summary>
        /// Calculates a standard deviation based on a given x-value, mean, and z-score.
        /// </summary>
        /// <param name="x">The x-value to use in calculation; the observed measurement for which to find a standard deviation.</param>
        /// <param name="avg">The mean of the distribution to use in the calculation.</param>
        /// <param name="z">The z-score of the measurement used in the calculation.</param>
        /// <returns>The standard deviation that will return the given z-score for the given x-value in a distribution with the given mean.</returns>
        public static double SolveStDevFromZ(double x, double avg, double z)
        {
            return Math.Round((x - avg) / z, 5);
        }

        /// <summary>
        /// Calculates a mean from a given x-value, z-score, and standard deviation.
        /// </summary>
        /// <param name="x">The x-value to use in calculation; the observed measurement for which to find a mean.</param>
        /// <param name="z">The z-score of the measurement used in the calculation.</param>
        /// <param name="stdev">The standard deviation of the distribution to use in the calculation.</param>
        /// <returns>The mean that will return the given z-score for a given x-value and the given standard deviation.</returns>
        public static double SolveAvgFromZ(double x, double z, double stdev)
        {
            return Math.Round(x - (z * stdev), 5);
        }

        /// <summary>
        /// Calculates the proportion greater than or less than a given z-score.
        /// </summary>
        /// <param name="proportionType">Whether to calculate the proportion greater than or less than the given z-score.</param>
        /// <param name="z">The z-score for which to find the proportions.</param>
        /// <returns>The proportion either less than or greater than (based on the given proportion type) the given z-score.</returns>
        public static double GetProportionFromZ(Proportion proportionType, double z)
        {
            if (proportionType == Proportion.LessThan)
                return poz(z);
            else
                return 1 - poz(z);
        }

        /// <summary>
        /// Calculates the z-score for which a proportion greater than or less than is equal to a given p-value.
        /// </summary>
        /// <param name="proportionType">Whether to calculate the z-score for which the given p-value is greater than or less than.</param>
        /// <param name="p">The given p-value for which to calculate the z-score.</param>
        /// <returns>The z-score for which the amount less than or greater than (based on the given proportion type) is equal to the given p-value.</returns>
        public static double GetZFromProportion(Proportion proportionType, double p)
        {
            if (proportionType == Proportion.LessThan)
                return critz(p);
            else
                return critz(1 - p);
        }

        /// <summary>
        /// Calculates a z-score based on a p-value.
        /// Logic cribbed from http://www.fourmilab.ch/rpkp/experiments/analysis/zCalc.js
        /// </summary>
        /// <param name="p">The p-value for which to calculate the z-score.</param>
        /// <returns>The z-score that matches the given p-value.</returns>
        private static double critz(double p)
        {
            double Z_EPSILON = 0.000001;     /* Accuracy of z approximation */
            double minz = -Z_MAX;
            double maxz = Z_MAX;
            double zval = 0.0;
            double pval;

            if (p < 0.0 || p > 1.0)
            {
                return -1;
            }

            while ((maxz - minz) > Z_EPSILON)
            {
                pval = poz(zval);
                if (pval > p)
                {
                    maxz = zval;
                }
                else
                {
                    minz = zval;
                }
                zval = (maxz + minz) * 0.5;
            }
            return (Math.Round(zval, 5));
        }

        /// <summary>
        /// Calculates the p-value for a given z-score.
        /// Logic cribbed from http://www.fourmilab.ch/rpkp/experiments/analysis/zCalc.js
        /// </summary>
        /// <param name="z">The z-score for which to calculate the p-value.</param>
        /// <returns>The p-value that correlates to the given z-score.</returns>
        private static double poz(double z)
        {
            double y, x, w;

            if (z == 0.0)
            {
                x = 0.0;
            }
            else
            {
                y = 0.5 * Math.Abs(z);
                if (y > (Z_MAX * 0.5))
                {
                    x = 1.0;
                }
                else if (y < 1.0)
                {
                    w = y * y;
                    x = ((((((((0.000124818987 * w
                             - 0.001075204047) * w + 0.005198775019) * w
                             - 0.019198292004) * w + 0.059054035642) * w
                             - 0.151968751364) * w + 0.319152932694) * w
                             - 0.531923007300) * w + 0.797884560593) * y * 2.0;
                }
                else
                {
                    y -= 2.0;
                    x = (((((((((((((-0.000045255659 * y
                                   + 0.000152529290) * y - 0.000019538132) * y
                                   - 0.000676904986) * y + 0.001390604284) * y
                                   - 0.000794620820) * y - 0.002034254874) * y
                                   + 0.006549791214) * y - 0.010557625006) * y
                                   + 0.011630447319) * y - 0.009279453341) * y
                                   + 0.005353579108) * y - 0.002141268741) * y
                                   + 0.000535310849) * y + 0.999936657524;
                }
            }
            z = Math.Round(z, 5);
            return z > 0.0 ? ((x + 1.0) * 0.5) : ((1.0 - x) * 0.5);
        }
    }
}
