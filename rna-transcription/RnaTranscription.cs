using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if (String.IsNullOrWhiteSpace(nucleotide))
            return "";

        string rnaNucleotide = "";
        foreach (var ch in nucleotide.ToUpper())
        {
            rnaNucleotide += $"{ch.TranslateCharToRna()}";
        }
        return rnaNucleotide;
    }
    private static char TranslateCharToRna(this char ch)
    {
        switch (ch)
        {
            case 'G':
                return 'C';
            case 'C':
                return 'G';
            case 'T':
                return 'A';
            case 'A':
                return 'U';
        }
        return ch;
    }
}