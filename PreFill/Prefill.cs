using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreFill
{
    /// <summary>
    /// PreFill, adds desired character or text on the left of value or list of values in order to align it/them to the right side.
    /// </summary>
    public static partial class PreFill
    {
        #region GetNumberOfDigits

        /// <summary>
        /// Calculates number of digit of a specified unsigned long number via using Math.Log10 method. If number is null returns zero. (Unsigned byte, ushort, uint, ulong)
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
        /// Calculates number of digit of a specified unsigned long number via using Math.Log10 methot. (Unsigned byte, ushort, uint, ulong)
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
        /// Calculates number of digit of a specified long number via using Math.Log10 method.
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
        /// Calculates number of digit of a specified long number via using Math.Log10 methot. If number is negative it adds one more digit for minus sign. (Signed sbyte, short, int, long)
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
        /// Calculates length of a specified text via using string.Length. (String)
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

        #region FillChar/FillString

        /// <summary>
        /// Creates a string value for prefilling value via repeating text with specified count times.
        /// </summary>
        /// <param name="count">Number of filling string value.</param>
        /// <param name="text">Selected text to fill.</param>
        /// <returns>A string whose filled with specified string.</returns>
        private static string FillString(int count, string text)
        {
            // Creating an instance of StringBuilder().
            StringBuilder sb = new StringBuilder();

            // Loop of count.
            while (count + 1 > 0)
            {
                // Adding text into StringBuilder instance.
                _ = sb.Append(text);

                // Decreasing count on the loop.
                count--;
            }

            // Returning of StringBuilder instance.
            return sb.ToString();
        }

        /// <summary>
        /// Creates a string value for prefilling value via repeating text with speficied count times.
        /// </summary>
        /// <param name="count">Number of filling.</param>
        /// <param name="text">Selected character to fill.</param>
        /// <returns>A string whose filled with specified char.</returns>
        private static string FillChar(int count, char text)
        {
            // Creating an instance of StringBuilder().
            StringBuilder sb = new StringBuilder();

            // Loop of count.
            while (count + 1 > 0)
            {
                // Adding text into StringBuilder instance.
                _ = sb.Append(text);

                // Decreasing count on the loop.
                count--;
            }

            // Returning of StringBuilder instance.
            return sb.ToString();
        }

        #endregion FillChar/FillString
    }

    /// <summary>
    /// Prefilled
    /// </summary>
    public static partial class PreFill
    {
        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">A specified number whose prefilling value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself. If given number is null, it returns only prefilling value.</returns>
        public static string PreFilledCustom(ulong? number, byte maxDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself. If given number is null, it returns only prefilling value.</returns>
        public static string PreFilledCustom(ulong? number, byte maxDigit, char text = ' ')
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">A specified number whose prefilling value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself.</returns>
        public static string PreFilledCustom(ulong number, byte maxDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself.</returns>
        public static string PreFilledCustom(ulong number, byte maxDigit, char text = ' ')
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// If number is null, it returns only prefillling value.
        /// </summary>
        /// <param name="number">Number of filling. If number is null, it returns prefilling value depends on maxNumberOfDigit.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.  If number is null, it returns only prefillling value.</returns>
        public static string PreFilledCustom(long? number, byte maxNumberOfDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// If number is null, it returns only prefillling value.
        /// </summary>
        /// <param name="number">Number of filling. If number is null, it returns prefilling value depends on maxNumberOfDigit.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set. If number is null, it returns only prefillling value.</returns>
        public static string PreFilledCustom(long? number, byte maxNumberOfDigit, char text = ' ')
        {
            // Calling PreFillCustom to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PreFilledCustom(long number, byte maxNumberOfDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PreFilledCustom(long number, byte maxNumberOfDigit, char text = ' ')
        {
            // Calling PreFillCustom to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with string value itself at the end.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of text value with prefilling.</param>
        /// <param name="text">Specified text to be used for prefilling.</param>
        /// <returns>Concentration of prefilled string and context itself.</returns>
        public static string PreFilledCustom(string context, int maxLength, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return string.Concat(PreFillCustom(context, maxLength, text), context);
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with string value itself at the end.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of text value with prefilling.</param>
        /// <param name="text">Specified text to be used for prefilling.</param>
        /// <returns>Concentration of prefilled string and context itself.</returns>
        public static string PreFilledCustom(string context, int maxLength, char text = ' ')
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return string.Concat(PreFillCustom(context, maxLength, text), context);
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself. If element is null, adds only prefilling value into list.</returns>
        public static List<string> PreFilledCustom(List<ulong?> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (ulong? item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself. If element is null, adds only prefilling value into list.</returns>
        public static List<string> PreFilledCustom(List<ulong?> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (ulong? item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PreFilledCustom(List<ulong> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (ulong item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PreFilledCustom(List<ulong> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (ulong item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself. If element is null, adds only prefilling value into list.</returns>
        public static List<string> PreFilledCustom(List<long?> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (long? item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (char) and number value itself via using longest length as maximum length. 
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself. If element is null, adds only prefilling value into list.</returns>
        public static List<string> PreFilledCustom(List<long?> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (long? item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PreFilledCustom(List<long> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (long item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (char) and number value itself via using longest length as maximum length. 
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PreFilledCustom(List<long> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(numberList.Count);

            // Getting biggest number's digit number of biggest value of the given number.
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            // Loop for list.
            foreach (long item in numberList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and string value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="contextList">List of specified text.</param>
        /// <param name="text">Selected text to fill before context.</param>
        /// <returns>Concentration of prefilled list of string and context itself.</returns>
        public static List<string> PreFilledCustom(List<string> contextList, string text = " ")
        {
            // Null check
            if (contextList == null || contextList.Count == 0)
            {
                // Returning null value to indicate contextList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(contextList.Count);

            // Maximum length of string on list.
            int maxFillCount = GetLengthOfString(contextList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));

            // Loop for list.
            foreach (string item in contextList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element.
        /// Creates a list of concatenated prefilling value (string) and string value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="contextList">List of specified text.</param>
        /// <param name="text">Selected text to fill before context.</param>
        /// <returns>Concentration of prefilled list of string and context itself.</returns>
        public static List<string> PreFilledCustom(List<string> contextList, char text = ' ')
        {
            // Null check
            if (contextList == null || contextList.Count == 0)
            {
                // Returning null value to indicate that numberList is null or empty.
                return null;
            }

            // Creating a list.
            List<string> resultList = new List<string>(contextList.Count);

            // Maximum length of string on list.
            int maxFillCount = GetLengthOfString(contextList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));

            // Loop for list.
            foreach (string item in contextList)
            {
                // Adding prefilling string concatting item of the list itself.
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            // Returning result as a list.
            return resultList;
        }
    }

    /// <summary>
    /// Prefill
    /// </summary>
    public static partial class PreFill
    {
        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(ulong? number, int maxDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(digitNumber, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(ulong? number, int maxDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(digitNumber, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFillCustom(ulong number, int maxDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(digitNumber, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFillCustom(ulong number, int maxDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(digitNumber, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string for prefilling value of specified text before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(long? number, int maxNumberOfDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(long? number, int maxNumberOfDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string for prefilling value of specified text before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number.</returns>
        public static string PreFillCustom(long number, int maxNumberOfDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number.</returns>
        public static string PreFillCustom(long number, int maxNumberOfDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(fillCount, text);
        }

        /// <summary>
        /// Calculates length of given text then creates string with prefilling value of specified character before given numtextber on limit of maximum length.
        /// </summary>
        /// <param name="text">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of context including specified number and prefilling.</param>
        /// <param name="stringValue">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified text.</returns>
        public static string PreFillCustom(string text, int maxLength, string stringValue = " ")
        {
            // Getting length of given text.
            int textLength = maxLength - GetLengthOfString(text);

            // Calling FillString method to get prefilling value.
            return FillString(textLength, stringValue);
        }

        /// <summary>
        /// Calculates length of given text then creates string with prefilling value of specified character before given numtextber on limit of maximum length.
        /// </summary>
        /// <param name="text">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of context including specified number and prefilling.</param>
        /// <param name="charValue">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified text.</returns>
        public static string PreFillCustom(string text, int maxLength, char charValue = ' ')
        {
            // Getting length of given text.
            int textLength = maxLength - GetLengthOfString(text);

            // Calling FillChar method to get prefilling value.
            return FillChar(textLength, charValue);
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto one character if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill1(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 0)
            {
                //
                return $"{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto one character if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">A text that will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill1(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 0)
            {
                // Returning given parameters as prefilling string.
                return $"{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto two characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill2(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 1)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto two characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill2(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 1)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto three characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill3(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 2)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto three characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill3(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 2)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto four characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill4(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 3)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto four characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill4(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 3)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto five characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill5(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 4)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto five characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill5(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 4)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto six characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill6(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 5)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto six characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill6(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 5)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto seven characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill7(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 6)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 5)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto seven characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill7(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 6)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 5)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto eight characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill8(ulong number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 7)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 6)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 5)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto eight characters if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill8(long number, char text = ' ')
        {
            // Getting number of digit of given number.
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 7)
            {
                //
                return $"{text}";
            }
            else if (digitNumber == 6)
            {
                //
                return $"{text}{text}";
            }
            else if (digitNumber == 5)
            {
                //
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 4)
            {
                //
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                //
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                //
                return $"{text}{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                // Returning empty string to indicate that prefilling text doesn't have a space with given number. 
                return "";
            }
        }
    }
}