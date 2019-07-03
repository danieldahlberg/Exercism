using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var usedChars = new HashSet<char>();
        foreach (var ch in word.ToLower())
        {
            if (Char.IsLetter(ch) && usedChars.Contains(ch))
                return false;
            usedChars.Add(ch);
        }
        return true;
    }
}
