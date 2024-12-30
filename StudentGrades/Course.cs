namespace StudentGrades;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    
    private List<string> _enrolledStudents;

    public List<string> EnrolledStudents
    {
        get { return _enrolledStudents; }
    }

    public Course()
    {
        _enrolledStudents = new List<string>();
    }

    public void EnrollStudent(string studentName)
    {
            if (EnrolledStudents.Contains(studentName))
            {
                Console.WriteLine($"{studentName} is already enrolled");
            }
            else
            {
                EnrolledStudents.Add(studentName);
            }
            
            // if (student == studentName)
            // {
            //     Console.WriteLine($"{studentName} is already enrolled");
            // }
            // else {EnrolledStudents.Add(studentName);}
        
    }


    
}