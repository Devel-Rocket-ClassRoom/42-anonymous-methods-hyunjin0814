using System;

class CounterFactory
{
    static Func<int> CreateSimpleCounter()
    {
        int count = 0;
        return delegate
        {
            count++;
            return count;
        };
    }

    static Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        return delegate
        {
            count += step;
            return count;
        };
    }

    static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = 0;
        return delegate
        {
            count += step;
            return count;
        };
    }
}