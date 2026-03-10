using System;
using System.Collections.Generic;

class DataProcessor
{
    public int[] nums;

    public void ForEach(Action<int> action)
    {
        foreach(int num in nums)
        {
            action(num); 
        }
    }

    public int[] Transform(Func<int, int> transformer)
    {
        int[] ints = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            ints[i] = transformer(nums[i]);
        }
        return ints;
    }

    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> ints = new List<int>();
        foreach (int num in nums)
        {
            if (predicate(num))
            {
                ints.Add(num); 
            }
        }
        return ints;
    }

    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int sum = initialValue;
        foreach (int num in nums)
        {
            sum = reducer(sum, num);
        }
        return sum;
    }
}