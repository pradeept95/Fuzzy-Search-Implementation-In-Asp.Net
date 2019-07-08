using System;
using System.Collections.Generic;
using System.Text;

namespace FuzzySearch.AspNetCore
{
    public enum FuzzyAlgorithm
    {
        LevenshteinDistance = 1,
        DamerauLevenshteinDistance = 2,
        HammingDistance = 3
    }
}
