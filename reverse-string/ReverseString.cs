using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (String.IsNullOrWhiteSpace(input))
            return "";

        string returnString = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            returnString += input[i];
        }

        return returnString;
    }
}