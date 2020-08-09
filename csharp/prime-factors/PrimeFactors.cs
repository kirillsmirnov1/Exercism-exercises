using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> factors = new List<long>();

        int divisor = 2;

        while(number > 1)
        {
            if(number % divisor == 0)
            {
                factors.Add(divisor);
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        return factors.ToArray();
    }
}