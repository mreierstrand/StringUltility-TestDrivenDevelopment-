using System;

namespace StringUltility
{
    public class StringUtility
    {
        public int CountOcurrences(string stringToCheck, string findLetter)
        {
            var stringAsCharArray = stringToCheck.ToLowerInvariant().ToCharArray();
            var stringCheckForAsChar = findLetter.ToLowerInvariant().ToCharArray()[0];
            var occuranceCount = 0;

            for (var charIndex = 0; charIndex < stringAsCharArray.GetUpperBound(0); charIndex++)
            {
                if (stringAsCharArray[charIndex] == stringCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }


    }
}

