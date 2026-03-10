using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Func<int> simpleCounter = CounterFactory.CreateSimpleCounter();
Func<int> stepCounter = CounterFactory.CreateStepCounter(3);
Func<int> boundedCounter = CounterFactory.CreateBoundedCounter(1, 3);
//Func<int> resettableCounter = CounterFactory.CreateResettableCounter();

Console.WriteLine("=== 단순 카운터 ===");
for(int i = 0; i < 5; i++)
{
    Console.Write($"{simpleCounter()} ");
}
Console.WriteLine();

Console.WriteLine("\n=== 스텝 카운터 (step=3) ===");
for (int i = 0; i < 4; i++)
{
    Console.Write($"{stepCounter()} ");
}
Console.WriteLine();

Console.WriteLine("\n=== 범위 카운터 (1~3) ===");
for (int i = 0; i < 7; i++)
{
    Console.Write($"{boundedCounter()} ");
}
Console.WriteLine();

Console.WriteLine("\n=== 리셋 가능 카운터 ===");
CounterFactory.CreateResettableCounter(out var increment, out var reset, out var get);
Console.Write("호출: ");
for (int i = 0; i < 3; i++)
{
    increment();
    Console.Write($"{get()} ");
}
Console.WriteLine();

reset();

Console.Write("리셋 후: ");
for (int i = 0; i < 2; i++)
{
    increment();
    Console.Write($"{get()} ");
}