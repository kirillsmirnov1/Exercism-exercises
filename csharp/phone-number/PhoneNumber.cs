using System;

public class PhoneNumber
{
    private static readonly string[] removables = { "+", "(", ")", "-", ".", " " };
    public static string Clean(string phoneNumber)
    {
        foreach (string c in removables)
        {
            phoneNumber = phoneNumber.Replace(c, "");
        }

        if (phoneNumber.StartsWith("1"))
        {
            phoneNumber = phoneNumber.Remove(0, 1);
        }

        if(phoneNumber.Length != 10)
        {
            throw new ArgumentException();
        }

        CheckZeroAndOne(phoneNumber[0]);
        CheckZeroAndOne(phoneNumber[3]);

        return phoneNumber;
    }

    private static void CheckZeroAndOne(char c)
    {
        if (c == '0' || c == '1')
        {
            throw new ArgumentException();
        }
    }
}