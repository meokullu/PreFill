using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefill
{
    /// <summary>
    /// Prefill, fills preceeding of value with desired character or string. E.g: PreFill(5) => 05 or 00000005 or "     5"
    /// </summary>
    public static class PreFill
    {
        #region GetNumberOfDigits

        /// <summary>
        /// Returns number of digits of given value (Signed byte, short, int, long)
        /// </summary>
        /// <param name="number">long number</param>
        /// <returns>Minimum 1, maximum 20 on negative integer numbers, maximum 19 on positive integer numbers.</returns>
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

        private static byte GetNumberOfDigitConditionOrdered(long number)
        {
            if (number > 0)
            {
                return (byte)Math.Floor(Math.Floor(Math.Log10(number) + 1));
            }
            else if (number == 0)
            {
                return 1;
            }
            else
            {
                return (byte)Math.Floor(Math.Log10(Math.Abs(number)) + 1 + 1);
            }
        }


        /// <summary>
        /// Returns number of digits of given value (Unsigned sbyte, ushort, uint, ulong)
        /// </summary>
        /// <param name="number">An unsigned long number</param>
        /// <returns>Minimum 0, maximum 19 on positive integer numbers.</returns>
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

        #region FillChar/FillString

        /// <summary>
        /// Returns prefilling value (dynamically)
        /// </summary>
        /// <param name="count">Number of filling</param>
        /// <param name="text">Selected character to fill before number</param>
        /// <returns>String</returns>
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
        /// Returns prefilling value (dynamically)
        /// </summary>
        /// <param name="count">Number of filling</param>
        /// <param name="text">Selected character to fill before number</param>
        /// <returns>String</returns>
        private static string FillString(int count, string text)
        {
            StringBuilder sb = new StringBuilder();

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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxNumberOfDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PrefilledCustom(long number, byte maxNumberOfDigit, string text = " ")
        {
            //
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxNumberOfDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PrefilledCustom(long number, byte maxNumberOfDigit, char text = ' ')
        {
            //
            return PreFillCustom(number, maxNumberOfDigit, text) + number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberList"></param>
        /// <param name="text"></param>
        /// <returns>Concentration of prefill string and number itself.</returns>
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
        /// 
        /// </summary>
        /// <param name="numberList"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PrefilledCustom(ulong number, byte maxDigit, string text = " ")
        {
            //
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PrefilledCustom(ulong number, byte maxDigit, char text = ' ')
        {
            //
            return PreFillCustom(number, maxDigit, text) + number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberList"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="numberList"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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

        #endregion Prefilled

        #region Signed (sbyte, short, int, long)

        // long
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxNumberOfDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreFillCustom(long number, int maxNumberOfDigit, string text = " ")
        {
            //
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            return FillString(fillCount, text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxNumberOfDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreFillCustom(long number, int maxNumberOfDigit, char text = ' ')
        {
            //
            int fillCount = maxNumberOfDigit - GetNumberOfDigit(number);

            return FillChar(fillCount, text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreFillCustom(ulong number, int maxDigit, string text = " ")
        {
            //
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            return FillString(digitNumber, text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxDigit"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreFillCustom(ulong number, int maxDigit, char text = ' ')
        {
            //
            int digitNumber = maxDigit - GetNumberOfDigit(number);

            return FillChar(digitNumber, text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        /// <returns></returns>
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
    }
}
