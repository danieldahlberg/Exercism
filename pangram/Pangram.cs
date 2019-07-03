using System;
using System.Globalization;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        //US alphabet
        return input.ToLower().Where(x=> Char.IsLetter(x)).GroupBy(x=> x).Count() == 26;
    }
}
