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
