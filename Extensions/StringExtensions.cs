using System;

namespace Fuzzy_search_Demo.Extensions
{
    public static class StringExtensions
    {
        public static bool IsFuzzySimilar(this string input, string parameter, int fuzzyness = 3)
        {
            if (string.IsNullOrEmpty(parameter))
            {
                throw new ArgumentNullException($"parameter can't be empty or null");
            }

            if (fuzzyness < 0)
            {
                throw new InvalidOperationException($"fuzzyness can't be less than 0");
            }

            return (LevenshteinDistance.Compute(input, parameter) < fuzzyness) || input.Contains(parameter) || parameter.Contains(input);
        }
    }
}
