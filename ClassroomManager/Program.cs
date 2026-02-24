using System;
using System.Numerics;

// README.md를 읽고 아래에 코드를 작성하세요.


ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();
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
        if(CurrentStudents > MaxStudents)
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
        for (int i = 0; i < studentsNames.Length; i++)
        {
            Console.WriteLine($"{i+1}. {studentsNames[i]}");
        }
    }
    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"총 교실 수: {totalClass}");
    }
    
}
