using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefill
{
    /// <summary>
    /// PreFill, adds desired character or text on the left of value in order to align it to the right side.
    /// </summary>
    public static class PreFill
    {
        #region GetNumberOfDigits

        /// <summary>
        /// Calculates number of digit of a specified long number via using Math.Log10 methot. If number is negative it adds one more digit for minus sign. (Signed sbyte, short, int, long)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied long number. If number is negative returns one additional digit for minus sign. If number is zero returns 1.</returns>
        private static byte GetNumberOfDigit(long number)
        {
            //
            if (number == 0)
            {
                return 1;
            }
            //
            else if (number < 0)
            {
                return (byte)Math.Floor(Math.Log10(Math.Abs(number)) + 1 + 1);
            }
            //
            else
            {
                return (byte)Math.Floor(Math.Log10(number) + 1);
            }
        }

        /// <summary>
        /// Calculates number of digit of a specified unsigned long number via using Math.Log10 methot.  (Unsigned byte, ushort, uint, ulong)
        /// </summary>
        /// <param name="number">A number whose number of digit to be found.</param>
        /// <returns>Digit number of speficied unsinged long number.</returns>
        private static byte GetNumberOfDigit(ulong number)
        {
            //
            if (number == 0)
            {
                return 1;
            }
            //
            else
            {
                return (byte)Math.Floor(Math.Log10(number) + 1);
            }
        }

        #endregion GetNumberOfDigits

        #region GetLengthOfText

        /// <summary>
        /// Calculates length of a specified text via using string.Length. (String)
        /// </summary>
        /// <param name="text">A text whose length to be found.</param>
        /// <returns>The number of characters of specified text.</returns>
        private static int GetLengthOfString(string text)
        {
            return text.Length;
        }

        #endregion GetLengthOfText

        #region FillChar/FillString

        /// <summary>
        /// Creates a string value for prefilling value via repeating text with speficied count times.
        /// </summary>
        /// <param name="count">Number of filling.</param>
        /// <param name="text">Selected character to fill.</param>
        /// <returns>A string whose filled with specified char.</returns>
        private static string FillChar(int count, char text)
        {
            //
            StringBuilder sb = new StringBuilder();

            //
            while (count + 1 > 0)
            {
                //
                sb.Append(text);

                //
                count--;
            }

            //
            return sb.ToString();
        }

        /// <summary>
        /// Creates a string value for prefilling value via repeating text with specified count times.
        /// </summary>
        /// <param name="count">Number of filling string value.</param>
        /// <param name="text">Selected text to fill.</param>
        /// <returns>A string whose filled with specified string.</returns>
        private static string FillString(int count, string text)
        {
            //
            StringBuilder sb = new StringBuilder();

            //
            while (count + 1 > 0)
            {
                //
                sb.Append(text);

                //
                count--;
            }

            //
            return sb.ToString();
        }

        #endregion FillChar/FillString

        #region Prefilled

        #region Long

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PrefilledCustom(long number, byte maxNumberOfDigit, string text = " ")
        {
            //
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PrefilledCustom(long number, byte maxNumberOfDigit, char text = ' ')
        {
            //
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PrefilledCustom(List<long> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(numberList.Count);

            //
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            //
            foreach (var item in numberList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (char) and number value itself via using longest length as maximum length. 
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before numbers.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PrefilledCustom(List<long> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(numberList.Count);

            //
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            //
            foreach (var item in numberList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            return resultList;
        }

        #endregion Long

        #region ULong

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">A specified number whose prefilling value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself.</returns>
        public static string PrefilledCustom(ulong number, byte maxDigit, string text = " ")
        {
            //
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled string and number itself.</returns>
        public static string PrefilledCustom(ulong number, byte maxDigit, char text = ' ')
        {
            //
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PrefilledCustom(List<ulong> numberList, string text = " ")
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(numberList.Count);

            //
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            //
            foreach (var item in numberList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (string) and number value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="numberList">List of specified numbers.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled list of string and number itself.</returns>
        public static List<string> PrefilledCustom(List<ulong> numberList, char text = ' ')
        {
            // Null check for Enumarable.Max() System.ArgumentNullException
            if (numberList == null || numberList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(numberList.Count);

            //
            int maxFillCount = GetNumberOfDigit(numberList.Max());

            //
            foreach (var item in numberList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            return resultList;
        }

        #endregion ULong

        #region String

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (string) and concatenates it with string value itself at the end.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of text value with prefilling.</param>
        /// <param name="text">Specified text to be used for prefilling.</param>
        /// <returns>Concentration of prefilled string and context itself.</returns>
        public static string PrefilledCustom(string context, int maxLength, string text = " ")
        {
            //
            return string.Concat(PreFillCustom(context, maxLength, text), context);
        }

        /// <summary>
        /// Calls PreFillCustom() method to create prefilling value with specified values (char) and concatenates it with string value itself at the end.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of text value with prefilling.</param>
        /// <param name="text">Specified text to be used for prefilling.</param>
        /// <returns>Concentration of prefilled string and context itself.</returns>
        public static string PrefilledCustom(string context, int maxLength, char text = ' ')
        {
            //
            return string.Concat(PreFillCustom(context, maxLength, text), context);
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (string) and string value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="contextList">List of specified text.</param>
        /// <param name="text">Selected text to fill before context.</param>
        /// <returns>Concentration of prefilled list of string and context itself.</returns>
        public static List<string> PrefilledCustom(List<string> contextList, string text = " ")
        {
            // Null check
            if (contextList == null || contextList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(contextList.Count);

            // Maximum length of string on list.
            int maxFillCount = GetLengthOfString(contextList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));

            //
            foreach (var item in contextList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            //
            return resultList;
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls PreFillCustom() method to create prefilling value for each element. Creates a list of concatenated prefilling value (string) and string value itself via using longest length as maximum length.
        /// </summary>
        /// <param name="contextList">List of specified text.</param>
        /// <param name="text">Selected text to fill before context.</param>
        /// <returns>Concentration of prefilled list of string and context itself.</returns>
        public static List<string> PrefilledCustom(List<string> contextList, char text = ' ')
        {
            // Null check
            if (contextList == null || contextList.Count == 0)
            {
                return null;
            }

            //
            List<string> resultList = new List<string>(contextList.Count);

            // Maximum length of string on list.
            int maxFillCount = GetLengthOfString(contextList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));

            foreach(var item in contextList)
            {
                resultList.Add(string.Concat(PreFillCustom(item, maxFillCount, text), item));
            }

            //
            return resultList;
        }

        #endregion String

        #endregion Prefilled

        #region Prefill

        #region Signed (sbyte, short, int, long)

        // long
        /// <summary>
        /// Calculates number of digit of given number then creates string for prefilling value of specified text before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxNumberOfDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number.</returns>
        public static string PreFillCustom(long number, int maxNumberOfDigit, string text = " ")
        {
            //
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

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
            //
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            return FillChar(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto one character if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">A text that will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill1(long number, char text = ' ')
        {
            //
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 0)
            {
                return $"{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 1)
            {
                return $"{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 2)
            {
                return $"{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}";
            }
            else
            {
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
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 3)
            {
                return $"{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}";
            }
            else
            {
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
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 4)
            {
                return $"{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else
            {
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
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 5)
            {
                return $"{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else
            {
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
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 6)
            {
                return $"{text}";
            }
            else if (digitNumber == 5)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
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
            byte digitNumber = GetNumberOfDigit(number);

            if (digitNumber == 7)
            {
                return $"{text}";
            }
            else if (digitNumber == 6)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 5)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                return "";
            }
        }

        #endregion Signed (sbyte, short, int, long)

        #region Unsigned (byte, ushort, uint, ulong)

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFillCustom(ulong number, int maxDigit, string text = " ")
        {
            //
            int digitNumber = maxDigit - GetNumberOfDigit(number);

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
            //
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            return FillChar(digitNumber, text);
        }

        /// <summary>
        /// Calculates number of digit of specified number then adds upto one character if needed.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified number.</returns>
        public static string PreFill1(ulong number, char text = ' ')
        {
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 0)
            {
                return $"{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 1)
            {
                return $"{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 2)
            {
                return $"{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 3)
            {
                return $"{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 4)
            {
                return $"{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 5)
            {
                return $"{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 6)
            {
                return $"{text}";
            }
            else if (digitNumber == 5)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
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
            //
            byte digitNumber = GetNumberOfDigit(number);

            //
            if (digitNumber == 7)
            {
                return $"{text}";
            }
            else if (digitNumber == 6)
            {
                return $"{text}{text}";
            }
            else if (digitNumber == 5)
            {
                return $"{text}{text}{text}";
            }
            else if (digitNumber == 4)
            {
                return $"{text}{text}{text}{text}";
            }
            else if (digitNumber == 3)
            {
                return $"{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 2)
            {
                return $"{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 1)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}";
            }
            else if (digitNumber == 0)
            {
                return $"{text}{text}{text}{text}{text}{text}{text}{text}";
            }
            else
            {
                return "";
            }
        }

        #endregion Unsigned (byte, ushort, uint, ulong)

        #region String

        /// <summary>
        /// Calculates length of given text then creates string with prefilling value of specified character before given numtextber on limit of maximum length.
        /// </summary>
        /// <param name="text">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of context including specified number and prefilling.</param>
        /// <param name="stringValue">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified text.</returns>
        public static string PreFillCustom(string text, int maxLength, string stringValue = " ")
        {
            //
            int textLength = maxLength - GetLengthOfString(text);

            //
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
            // Char length is 1
            int textLength = maxLength - GetLengthOfString(text);

            //
            return FillChar(textLength, charValue);
        }

        #endregion String

        #endregion Prefill
    }
}
