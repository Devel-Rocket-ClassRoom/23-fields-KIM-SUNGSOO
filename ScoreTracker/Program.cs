using System;
using System.Security;

// README.md를 읽고 아래에 코드를 작성하세요.

ScoreTracker math = new ScoreTracker("수학");
math.ShowScore();
Console.WriteLine();

math.SetScore(85);
math.AddBonus(10);
math.AddBonus(20);
math.SetScore(-10);
Console.WriteLine();

math.ShowScore();


