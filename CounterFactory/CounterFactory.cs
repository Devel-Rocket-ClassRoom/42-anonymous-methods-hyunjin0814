using System;

class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int count = 0;
        return delegate
        {
            count++;
            return count;
        };
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        return delegate
        {
            count += step;
            return count;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = 0;
        return delegate
        {
            count++;
            if(count > max)
            {
                count = min;
            }
            return count;
        };
    }

    public static void CreateResettableCounter(
        out Action increment,
        out Action reset,
        out Func<int> getCurrent)
    {
        int count = 0;

        increment = delegate { count++; };
        reset = delegate { count = 0; };
        getCurrent = delegate { return count; };
    }
}