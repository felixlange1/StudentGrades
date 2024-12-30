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
            Grades = { 4.0, 4.0, 3.0, 3.8, 3.5 }
        };

        Student student2 = new Student()
        {
            Name = "Joe Blow",
            ID = 514,
            Grades = { 2.0, 2.8, 3.0, 3.8, 4.0 }
        };

        Student student3 = new Student()
        {
            Name = "Joe Jones", 
            ID = 515,
            Grades = { 4.0, 4.0, 3.0, 3.8, 3.0 }
        };

        Student student4 = new Student()
        {
            Name = "Jane Doe",
            ID = 516,
            Grades = { 4.5, 4.0, 3.0, 4.0, 4.0 }
        };
        
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
    }
}