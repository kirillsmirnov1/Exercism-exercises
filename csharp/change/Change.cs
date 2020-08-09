using System;
using System.Collections.Generic;
using System.Linq;

public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {
        if(target < 0) throw new ArgumentException();
        
        List<List<int>> minCoins = new List<List<int>>(target + 1);
        minCoins.Insert(0,new List<int>());

        for (int amount = 1; amount <= target; ++amount)
        {
            minCoins.Insert(amount,coins.Where(coin => coin <= amount)
                .Select(coin => new List<int>(minCoins[amount - coin]) {coin})
                .Where(variant => variant.Sum() == amount)
                .OrderBy(variant => variant.Count)
                .FirstOrDefault() ?? new List<int>());
        }
        
        return (minCoins[target].Sum() == target) 
            ? minCoins[target].OrderBy(x => x).ToArray() 
            : throw new ArgumentException();
    }
}