using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        return n <= 64 ? (ulong)System.Numerics.BigInteger.Pow(2, (n - 1)) : (ulong)System.Numerics.BigInteger.Pow(2, -1);
    }

    public static ulong Total()
    {
        return System.Numerics.BigInteger.Pow(2, 64) >= ulong.MaxValue ? ulong.MaxValue : (ulong)System.Numerics.BigInteger.Pow(2, 64);
    }
}