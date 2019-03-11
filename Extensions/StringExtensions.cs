using System;

namespace Fuzzy_search_Demo.Extensions
{
    public static class StringExtensions
    {
        public static bool IsFuzzySimilar(this string input, string parameter, int threshold = 3)
        {
            if (string.IsNullOrEmpty(parameter))
            {
                throw new ArgumentNullException($"parameter can't be empty or null");
            }

            if (threshold < 0)
            {
                throw new InvalidOperationException($"threshold can't be less than 0");
            }

            return (LevenshteinDistance.Compute(input, parameter) < threshold) || input.Contains(parameter) || parameter.Contains(input);
        }
    }
}
