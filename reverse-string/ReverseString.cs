using System;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (String.IsNullOrWhiteSpace(input))
            return "";

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(input[i]);
        }

        return stringBuilder.ToString();
    }
}