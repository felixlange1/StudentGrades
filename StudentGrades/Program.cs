using System.Security.Cryptography;

namespace StudentGrades;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Student student1 = new Student()
        {
            Name = "John Doe",
            ID = 513,
        };
        students.Add(student1);
        student1.AddGrade(99.0);
        student1.AddGrade(100.0, 77.4, 89.8, 94.5);
        Console.WriteLine(student1.Grades);

        Student student2 = new Student()
        {
            Name = "Joe Blow",
            ID = 514,

        };
        students.Add(student2);
        student2.AddGrade(90.0);
        student2.AddGrade(93.8, 78.4, 99.8, 87.3);

        Student student3 = new Student()
        {
            Name = "Joe Jones",
            ID = 515,
        };
        students.Add(student3);
        student3.AddGrade(97.8);
        student3.AddGrade(98.1, 95.0, 94.3, 100.0);

        Student student4 = new Student()
        {
            Name = "Jane Doe",
            ID = 516,

        };
        students.Add(student4);
        student4.AddGrade(100.0);
        student4.AddGrade(100.0, 99.4, 98.7, 97.0);

        foreach (var student in students)
        {
            Console.WriteLine($"Student ID: {student.ID}, Name: {student.Name}");
            Console.WriteLine("Grades:");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"Grade Average: {student.CalculateAverageGrade().ToString("F2")}");
            Console.WriteLine("---------------------");
//             Alternative option without nested loops:            
//            Console.WriteLine($"Student ID: {student.ID}, Name: {student.Name}, Grades: {string.Join(", ", student.Grades.Select(grade => grade.ToString()))}, Grade Average: {student.CalculateAverageGrade()}");};
            
        }

    }
}


    
