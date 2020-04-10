using FuzzySearch.AspNetCore.Factory;
using System;
using System.Linq;

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


            var string1 = "";
            var string2 = ""; 

            return (DistanceFactory.GetDistances(GetCanonicalForm(input), GetCanonicalForm(parameter)) < fuzzyness) || input.Contains(parameter) || parameter.Contains(input);
        }

        private static string GetCanonicalForm(string stringTerm)
        {
            if (stringTerm == null) throw new ArgumentNullException("stringTerm");

            return stringTerm
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate("", (x, y) => $"{x} {y}")
                .Trim();
        }
    }
}
