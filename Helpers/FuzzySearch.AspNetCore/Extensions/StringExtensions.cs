using FuzzySearch.AspNetCore.Factory;
using System;

namespace FuzzySearch.AspNetCore.Extensions
{
    public static class Fuzzyness
    {
        public static bool IsFuzzySimilar(this string input, string parameter, int fuzzyness = 3, FuzzyAlgorithm fuzzyAlgorithm = FuzzyAlgorithm.LevenshteinDistance)
        {
            if (string.IsNullOrEmpty(parameter))
            {
                throw new ArgumentNullException($"parameter can't be empty or null");
            }

            if (fuzzyness < 0)
            {
                throw new InvalidOperationException($"fuzzyness can't be less than 0");
            }

            return (DistanceFactory.GetDistances(input, parameter) < fuzzyness) || input.Contains(parameter) || parameter.Contains(input);
        }
    }
}
