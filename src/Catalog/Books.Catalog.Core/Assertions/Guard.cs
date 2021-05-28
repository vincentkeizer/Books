using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Catalog.Core.Assertions
{
    public static class Guard
    {
        public static void IsNotNull([NotNull] object value, string parameterName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
        
        public static void IsNotDefault<T>(T value, string parameterName) 
            where T : struct
        {
            if (value.Equals(default (T)))
            {
                throw new ArgumentNullException(parameterName);
            }
        }
        
        public static void IsNotNullOrWhitespace([NotNull] string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(parameterName);
            }
        }

        public static void DoesNotExceedLength(int maxLength, string value, string parameterValue)
        {
            if (value is not null && value.Length > maxLength)
            {
                throw new ArgumentException($"parameter '{parameterValue}' exceeds length {maxLength}");
            }
        }
    }
}
