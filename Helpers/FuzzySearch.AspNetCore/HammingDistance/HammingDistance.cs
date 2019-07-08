using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzySearch.AspNetCore.HammingDistances
{
    public static class HammingDistance
    {
        public static int GetHammingDistance(string s, string t)
        {
            if (s.Length != t.Length)
            {
                throw new Exception("Strings must be equal length");
            }

            int distance =
                s.ToCharArray()
                .Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }
    }
}
