using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreFill
{
    /// <summary>
    /// PreFill, adds desired character or text on the left of value or list of values in order to align it/them to the right side.
    /// </summary>
    public static partial class PreFill
    {
        #region GetNumberOfDigits

        /// <summary>
        /// Calculates number of digit of a specified unsigned long number via using <see cref="Math.Log10(double)"/> method. If number is null returns zero. (Unsigned byte, ushort, uint, ulong)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied unsinged long number. If number is null returns 0.</returns>
        private static byte GetNumberOfDigit(ulong? number)
        {
            // If number is null.
            if (number == null)
            {
                // Null value doesn't have any digit.
                return 0;
            }
            // If number is zero.
            else if (number == 0)
            {
                // Number zero is one digit.
                return 1;
            }
            // If number is not zero, number of digit is calculating via formula.
            else
            {
                // Calculation of digit of number based on mathmatical logarithm base 10.
                return (byte)Math.Floor(Math.Log10(number.Value) + 1);
            }
        }

        /// <summary>
        /// Calculates number of digit of a specified unsigned long number via using <see cref="Math.Log10(double)"/> methot. (Unsigned byte, ushort, uint, ulong)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied unsinged long number.</returns>
        private static byte GetNumberOfDigit(ulong number)
        {
            // If number is zero.
            if (number == 0)
            {
                // Number zero is one digit.
                return 1;
            }
            // If number is not zero, number of digit is calculating via formula.
            else
            {
                // Calculation of digit of number based on mathmatical logarithm base 10.
                return (byte)Math.Floor(Math.Log10(number) + 1);
            }
        }

        /// <summary>
        /// Calculates number of digit of a specified long number via using <see cref="Math.Log10(double)"/> method.
        /// If number is null returns 0. If number is negative it adds one more digit for minus sign. (Signed sbyte, short, int, long)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied long number. If number is null returns 0. If number is negative returns one additional digit for minus sign.
        /// If number is zero returns 1.</returns>
        private static byte GetNumberOfDigit(long? number)
        {
            // If given number is null
            if (number == null)
            {
                // Null value doesn't have any digit.
                return 0;
            }
            // If number is zero.
            else if (number.Value == 0)
            {
                // Number zero is one digit.
                return 1;
            }
            // If number is negative, number of digit is calculating via formula. 
            else if (number.Value < 0)
            {
                // Calculation of digit of number based on mathmatical logarithm base 10. Second adding of 1 is for minus sign on negative numbers.
                return (byte)Math.Floor(Math.Log10(Math.Abs(number.Value)) + 1 + 1);
            }
            // if number is positive, number of digit is calculating via formula.
            else
            {
                // Calculation of digit of number based on mathmatical logarithm base 10.
                return (byte)Math.Floor(Math.Log10(number.Value) + 1);
            }
        }

        /// <summary>
        /// Calculates number of digit of a specified long number via using <see cref="Math.Log10(double)"/> methot. If number is negative it adds one more digit for minus sign. (Signed sbyte, short, int, long)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied long number. If number is negative returns one additional digit for minus sign. If number is zero returns 1.</returns>
        private static byte GetNumberOfDigit(long number)
        {
            // If number is zero.
            if (number == 0)
            {
                // Number zero is one digit.
                return 1;
            }
            // If number is negative, number of digit is calculating via formula.
            else if (number < 0)
            {
                // Calculation of digit of number based on mathmatical logarithm base 10. Second adding of 1 is for minus sign on negative numbers.
                return (byte)Math.Floor(Math.Log10(Math.Abs(number)) + 1 + 1);
            }
            // if number is positive, number of digit is calculating via formula.
            else
            {
                // Calculation of digit of number based on mathmatical logarithm base 10.
                return (byte)Math.Floor(Math.Log10(number) + 1);
            }
        }

        #endregion GetNumberOfDigits

        #region GetLengthOfText

        /// <summary>
        /// Calculates length of a specified text via using <see cref="string.Length"/>. (String)
        /// </summary>
        /// <param name="text">A text whose length to be found.</param>
        /// <returns>The number of characters of specified text. If text is null, it returns zero.</returns>
        private static int GetLengthOfString(string text)
        {
            // If text is null.
            if (text == null)
            {
                // Null value doesn't have length.
                return 0;
            }

            // Returning text's length via string.Length.
            return text.Length;
        }

        #endregion GetLengthOfText
    }
}
