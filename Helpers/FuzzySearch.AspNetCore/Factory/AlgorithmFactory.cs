using FuzzySearch.AspNetCore.DamerauLevenshteinDistances;
using FuzzySearch.AspNetCore.HammingDistances;
using FuzzySearch.AspNetCore.LevenshteinDistances;
using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzySearch.AspNetCore.Factory
{
    public static class DistanceFactory
    {
        public static int GetDistances(string s, string t, FuzzyAlgorithm algorithm = FuzzyAlgorithm.LevenshteinDistance)
        {
            int distance = 100000;
            switch (algorithm)
            {
                case FuzzyAlgorithm.LevenshteinDistance:
                    distance = LevenshteinDistance.GetLevenshteinDistance(s, t);
                    break;
                case FuzzyAlgorithm.DamerauLevenshteinDistance:
                    distance = DamerauLevenshteinDistance.GetDamerauLevenshteinDistance(s, t);
                    break;
                case FuzzyAlgorithm.HammingDistance:
                    distance = HammingDistance.GetHammingDistance(s, t);
                    break;
                default:
                    distance = LevenshteinDistance.GetLevenshteinDistance(s, t);
                    break; 
            }

            return distance;
        }
    }
}
