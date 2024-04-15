using System.Text;

namespace PreFill
{
    public partial class PreFill
    {
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
}
