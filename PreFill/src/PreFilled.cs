using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreFill
{
    /// <summary>
    /// Prefilled
    /// </summary>
    public static partial class PreFill
    {
        /// <summary>
        /// Calls <see cref="PreFillCustom(ulong?, int, string)"/> method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
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
        /// Calls <see cref="PreFillCustom(ulong?, int, char)"/> method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
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
        /// Calls <see cref="PreFillCustom(ulong, int, string)"/> method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
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
        /// Calls <see cref="PreFillCustom(ulong?, int, char)"/> method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
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
        /// Calls <see cref="PreFillCustom(long?, int, string)"/> method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// If number is null, it returns only prefillling value.
        /// </summary>
        /// <param name="number">Number of filling. If number is null, it returns prefilling value depends on maxNumberOfDigit.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.  If number is null, it returns only prefillling value.</returns>
        public static string PreFilledCustom(long? number, byte maxDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls <see cref="PreFillCustom(long?, int, char)"/> method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// If number is null, it returns only prefillling value.
        /// </summary>
        /// <param name="number">Number of filling. If number is null, it returns prefilling value depends on maxNumberOfDigit.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set. If number is null, it returns only prefillling value.</returns>
        public static string PreFilledCustom(long? number, byte maxDigit, char text = ' ')
        {
            // Calling PreFillCustom to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls <see cref="PreFillCustom(long, int, string)"/> method to create prefilling value with specified values (string) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PreFilledCustom(long number, byte maxDigit, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls <see cref="PreFillCustom(long, int, char)"/> method to create prefilling value with specified values (char) and concatenates it with number value itself at the end.
        /// </summary>
        /// <param name="number">Number of filling.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Selected text to fill before number.</param>
        /// <returns>Concentration of prefilled by selected text with maximum digit set.</returns>
        public static string PreFilledCustom(long number, byte maxDigit, char text = ' ')
        {
            // Calling PreFillCustom to get prefilling string and concatting it with number.
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// Calls <see cref="PreFillCustom(string, int, string)"/> method to create prefilling value with specified values (string) and concatenates it with string value itself at the end.
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
        /// Calls <see cref="PreFillCustom(string, int, char)"/> method to create prefilling value with specified values (char) and concatenates it with string value itself at the end.
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
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreFilledCustom<T>(T value, int maxLength, string text = " ")
        {
            // Calling PreFillCustom method to get prefilling string and concatting it with number.
            return string.Concat(PreFillCustom(value, maxLength, text), value);
        }

        /// <summary>
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{ulong?}, string)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{ulong?}, char)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{ulong}, string)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{ulong}, char)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{long?}, string)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{long?}, char)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{long}, string)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{long}, char)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{string}, string)"/> method to create prefilling value for each element.
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
        /// Checks if provided list is null or empty if not finds longest length and calls <see cref="PreFilledCustom(List{string}, char)"/> method to create prefilling value for each element.
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
}
