using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    private static Dictionary<string, int> _letterValues = new Dictionary<string, int>()
    {
        { "A",1 }, {"E",1 }, {"I",1 }, {"O",1 }, {"U",1 }, {"L",1 }, {"N",1 }, {"R",1 }, {"S",1 }, {"T", 1 },
        { "D",2 },{ "G", 2 },
        { "B",3 },{ "C",3 }, {"M",3 }, {"P", 3 },
        { "F",4 }, {"H",4 }, {"V",4 }, {"W",4 }, {"Y", 4 },
        { "K", 5 },
        { "J",8 }, {"X", 8 },
        { "Q",10 }, {"Z", 10 }
    };
    public static int Score(string input)
    {
        int score = 0;
        foreach (var ch in input.ToUpper())
        {
            if (char.IsLetter(ch))
            {
                _letterValues.TryGetValue(ch.ToString(), out int letterValue);
                score += letterValue;
            }
        }
        return score;
    }
    //"Extension" (Able to score from multiplewords)
    public static int Score(string[] input)
    {
        int score = 0;
        foreach (var word in input)
            foreach (var ch in word.ToUpper())
            {
                if (char.IsLetter(ch))
                {
                    _letterValues.TryGetValue(ch.ToString(), out int letterValue);
                    score += letterValue;
                }
            }
        return score;
    }
}