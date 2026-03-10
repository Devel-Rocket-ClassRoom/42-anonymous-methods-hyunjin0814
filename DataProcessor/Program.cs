using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
DataProcessor dataProcessor = new DataProcessor();
dataProcessor.nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("=== 원본 배열 출력 ===");
dataProcessor.ForEach(delegate (int x) { Console.Write($"{x} "); });
Console.WriteLine();

Console.WriteLine("\n=== 2배로 변환 ===");
int[] two = dataProcessor.Transform(delegate (int x) { return x * 2; });
foreach (int x in two)
{
    Console.Write($"{x} ");
}
Console.WriteLine();

Console.WriteLine("\n=== 짝수만 필터링 ===");

Console.WriteLine();

Console.WriteLine("\n=== 합계 계산 ===");

Console.WriteLine();