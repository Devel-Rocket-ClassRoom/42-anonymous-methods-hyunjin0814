using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.
Calculator anonymous = delegate (int x) { return x * x; };
Calculator lambda1 = (int x) =>
{
    return x * x;
};
Calculator lambda2 = x => x * x;

Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식 (블록): {lambda1(5)}");
Console.WriteLine($"람다식 (표현식): {lambda2(5)}");

EventHandler handler1 = delegate { Console.WriteLine("이벤트 처리됨"); };
EventHandler handler2 = (obj, args) => Console.WriteLine("이벤트 처리됨");

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);

GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };

onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);

onScoreChange += delegate (string eventName, int value) { Console.WriteLine($"[이벤트] {eventName}: {value}"); };
onScoreChange("점수 변경", 500);

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

ProcessData(numbers, delegate (int n)
{
    sum += n;
    Console.WriteLine($"처리 중: {n}, 누적: {sum}");
});

Console.WriteLine($"최종 합계: {sum}");

void ProcessData(int[] data, Action<int> callback)
{
    foreach (int i in data)
    {
        callback(i); 
    }
}

delegate int Calculator(int x);

delegate void EventHandler(object obj, EventArgs args);

delegate void GameEvent(string msg, int score);