using System;
using System.Text;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        StringBuilder cleanNumber = new StringBuilder();
        int firstDigit = 0;
        foreach (var ch in phoneNumber)
        {
            if (Char.IsDigit(ch)) {
                var currentDigit = int.Parse(ch.ToString());

                if (firstDigit == 0)
                    firstDigit = currentDigit;

                switch (cleanNumber.Length)
                {
                    case 0:
                    case 3:
                        if (currentDigit <= 9 && currentDigit >= 2)
                            cleanNumber.Append(ch);
                        break;
                    case 10:
                        if (firstDigit != 1)
                            throw new ArgumentException();
                        cleanNumber.Remove(0, 1);
                        cleanNumber.Append(ch);
                        break;
                    default:
                        cleanNumber.Append(ch);
                        break;
                }
            }
        }
        return cleanNumber.Length == 10 ? cleanNumber.ToString() : throw new ArgumentException("PhoneNumber is not complete");
    }
}