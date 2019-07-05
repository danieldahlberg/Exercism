using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        int currentSum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                currentSum += i;

            if (currentSum == number)
                return Classification.Perfect;
        }

        return currentSum > number ? Classification.Abundant : Classification.Deficient;
    }
}
