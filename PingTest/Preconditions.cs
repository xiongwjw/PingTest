using System;
//using LiveLogViewer.Properties;

namespace PingTest
{
    /// <summary>
    ///     Provides static helper methods for validating preconditions.
    /// </summary>
    public static class Preconditions
    {
        public static T CheckNotNull<T>(T value, string paramName = null)
            where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName ?? "value");
            }

            return value;
        }

        public static string CheckNotEmptyOrNull(string value, string paramName = null)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(paramName ?? "value");
            }

            return value;
        }

        public static void CheckArgumentRange( string paramName, long value, long minInclusive, long maxInclusive)
        {
            if (value < minInclusive || value > maxInclusive)
            {
               // throw new ArgumentOutOfRangeException(paramName, string.Format(Resources.Preconditions_CheckArgumentRange, minInclusive, maxInclusive));
            }
        }

        public static void CheckArgumentRange(string paramName, int value, int minInclusive, int maxInclusive)
        {
            if (value < minInclusive || value > maxInclusive)
            {
                //throw new ArgumentOutOfRangeException(paramName, string.Format(Resources.Preconditions_CheckArgumentRange, minInclusive, maxInclusive));
            }
        }

        public static void CheckArgument(bool expression,string parameter, string message)
        {
            if (!expression)
            {
                throw new ArgumentException(message, parameter);
            }
        }

        public static void CheckNotDefault<T>(T value, string paramName = null)
        {
            if (Equals(value, default(T)))
            {
               // throw new ArgumentException(Resources.Preconditions_CheckNotDefault_DefaultValue, paramName ?? "value");
            }
        }
    }
}