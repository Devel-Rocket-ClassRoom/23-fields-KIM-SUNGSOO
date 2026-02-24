using System;
using System.Collections.Generic;
using System.Text;

class ScoreTracker
{
    const int MaxScore = 100;
    const int MinScore = 0;
    readonly string subject;
    private int currentScore = 0;
    private int bonusCount = 0;

    public ScoreTracker(string subject)
    {
        this.subject = subject;
    }

    public void SetScore(int currentScore)
    {
        if (currentScore <= MaxScore && currentScore >= MinScore)
        {
            this.currentScore = currentScore;
            Console.WriteLine($"점수: {currentScore}/ {MaxScore}");
        }
        else
        {
            Console.WriteLine($"점수는 0~100 사이여야합니다.");
        }
    }

    public void AddBonus(int bonus)
    {
        currentScore += bonus;
        bonusCount++;
        if (currentScore > MaxScore)
        {
            currentScore = MaxScore;
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수 : {currentScore}(최대 점수 도달)");
        }
        else
        {
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수 : {currentScore}");
        }

    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {subject} ===");
        Console.WriteLine($"점수 {currentScore}/ {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonusCount}");
    }
}
