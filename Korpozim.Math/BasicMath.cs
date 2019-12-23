using System;
using System.Collections.Generic;
using System.Text;

namespace Korpozim.Math
{
    /// <summary>
    /// Basic Math Static Class
    /// </summary>
    public static class BasicMath
    {
        /// <summary>
        /// Sum Method
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double Sum(params double[] list)
        {
            double sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// Difference Method
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static double Difference(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Multiplication Method
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double Multiplication(params double[] list)
        {
            double sum = 1;

            foreach (var item in list)
            {
                sum *= item;
            }

            return sum;
        }

        /// <summary>
        /// Division Method
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static double Division(double firstNumber, double secondNumber)
        {
            return secondNumber == 0 ? 1 : firstNumber / secondNumber;
        }
    }
}
