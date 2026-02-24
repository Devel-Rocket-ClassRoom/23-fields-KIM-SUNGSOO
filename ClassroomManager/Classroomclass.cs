using System;
using System.Collections.Generic;
using System.Text;

class ClassroomManager
{
    const int MaxStudents = 5;
    private readonly string className;
    private string[] studentsNames;
    private int CurrentStudents = 0;
    private static int totalClass = 0;


    public ClassroomManager(string className)
    {
        this.className = className;
        studentsNames = new string[MaxStudents];
        totalClass++;
    }
    public void AddStudent(string name)

    {
        if (CurrentStudents > MaxStudents)
        {
            Console.WriteLine("정원이 초과되었습니다");
            return;
        }
        studentsNames[CurrentStudents] = name;
        CurrentStudents++;
    }
    public void ShowStudents()
    {
        Console.WriteLine($"=== {className} 목록 ({CurrentStudents}/{MaxStudents})===");
        for (int i = 0; i < CurrentStudents; i++)
        {
            Console.WriteLine($"{i + 1}. {studentsNames[i]}");
        }
    }
    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"총 교실 수: {totalClass}");
    }

}

