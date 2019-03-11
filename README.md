# Fuzzy Search Implementation in Asp.Net
# Intorduction
This is a demo application to implement fuzzy search in asp.net application using Levenshtein Distance algorithm.

## Levenshtein Distance Implementation in C#
Levenshtein. In 1965 Vladmir Levenshtein created a distance algorithm. This tells us the number of edits needed to turn one string into another. With Levenshtein distance, we measure similarity and match approximate strings with fuzzy logic.
Info:
Returns the number of character edits (removals, inserts, replacements) that must occur to get from string A to string B.

Levenshtein distance computations

Words:                ant, aunt
Levenshtein distance: 1
Note:                 Only 1 edit is needed.
                      The 'u' must be added at index 2.

Words:                Samantha, Sam
Levenshtein distance: 5
Note:                 The final 5 letters must be removed.

Words:                Flomax, Volmax
Levenshtein distance: 3
Note:                 The first 3 letters must be changed
                      Drug names are commonly confused.
                      
## Extension Method to String to Implementation of an Comparision

Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 

An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.

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
