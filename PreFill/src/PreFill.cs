namespace PreFill
{
    /// <summary>
    /// PreFill
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
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(long? number, int maxDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int fillCount = maxDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number. If number is null, it returns prefilling value depends on maxNumberOfDigit.</returns>
        public static string PreFillCustom(long? number, int maxDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int fillCount = maxDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string for prefilling value of specified text before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number.</returns>
        public static string PreFillCustom(long number, int maxDigit, string text = " ")
        {
            // Getting number of digit of given number.
            int fillCount = maxDigit - GetNumberOfDigit(number);

            // Calling FillString method to get prefilling value.
            return FillString(fillCount, text);
        }

        /// <summary>
        /// Calculates number of digit of given number then creates string with prefilling value of specified character before given number on limit of maximum number of digit.
        /// </summary>
        /// <param name="number">A number whose prefill value to be found.</param>
        /// <param name="maxDigit">Maximum number of digit including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for a specified number.</returns>
        public static string PreFillCustom(long number, int maxDigit, char text = ' ')
        {
            // Getting number of digit of given number.
            int fillCount = maxDigit - GetNumberOfDigit(number);

            // Calling FillChar method to get prefilling value.
            return FillChar(fillCount, text);
        }

        /// <summary>
        /// Calculates length of given text then creates string with prefilling value of specified character before given numtextber on limit of maximum length.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of context including specified number and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified text.</returns>
        public static string PreFillCustom(string context, int maxLength, string text = " ")
        {
            // Getting length of given text.
            int textLength = maxLength - GetLengthOfString(context);

            // Calling FillString method to get prefilling value.
            return FillString(textLength, text);
        }

        /// <summary>
        /// Calculates length of given text then creates string with prefilling value of specified character before given numtextber on limit of maximum length.
        /// </summary>
        /// <param name="context">A text whose prefill value to be found.</param>
        /// <param name="maxLength">Maximum length of context including specified number and prefilling.</param>
        /// <param name="text">Specified character whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for specified text.</returns>
        public static string PreFillCustom(string context, int maxLength, char text = ' ')
        {
            // Getting length of given text.
            int textLength = maxLength - GetLengthOfString(context);

            // Calling FillChar method to get prefilling value.
            return FillChar(textLength, text);
        }

        /// <summary>
        /// Calculates length of given generic type of data then creates string with prefilling value of specified character before given data on limit of maximum length.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="value">Generic type of data.</param>
        /// <param name="maxLength">Maximum length of context including specified generic type of data as string and prefilling.</param>
        /// <param name="text">Specified text whose will be used for prefilling.</param>
        /// <returns>Returns prefill value for generic type of data as string.</returns>
        public static string PreFillCustom<T>(T value, int maxLength, string text = " ")
        {
            // Getting length of given text.
            int textLength = maxLength - GetLengthOfString(value.ToString());

            // Calling FillChar method to get prefilling value.
            return FillString(textLength, text);
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
