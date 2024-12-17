using _2._2dars.Api.Models;
using ConsoleApp4.Services;
using System.Text.Json;

namespace _2._2_dars.Services;

public class StudentService : IStudentServices
{
    private string studentFilePath;
    private List<Student> students;
    public StudentService()
    {
        studentFilePath = "../../../Data/Student.json";
        if (File.Exists(studentFilePath) is false)
        {
            File.WriteAllText(studentFilePath, "[]");
        }

        students = new List<Student>();
        students = GetAllStudents();
    }
    
    public bool ChekPassword(string username, string password)
    {
        

        foreach (var student in students)
        {
            if (student.UserName == username && student.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        var students = GetStudents();
        students.Add(student);
        SaveData(students);
        return student;
    }
    public Student GetById(Guid StudentId) 
    {
        foreach( var student in students)
        {
            if (student.Id == StudentId)
            {
                return student;
            }
        }
        return null;
    }
    public bool DeleteStudent(Guid studentId)
    {
        var studentFromDb = GetById(studentId);
        if (studentFromDb is null)
        {
            return false;
        }
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                students.Remove(student);
                break;
            }
        }
        SaveData(students);
        return true;
    }
    public bool UpdateStudent(Student student)
    {
 
        var studentFromDb = GetById(student.Id);
        if (studentFromDb is null)
        {
            return false;
        }

        for (var i = 0; i < students.Count; i++)
        {
            if (students[i].Id == student.Id)
            {
                students[i] = student;
                break;
            }
        }

        SaveData(students);
        return true;
    }


    public List<Student> GetAllStudents()
    {
        return GetStudents();
    }
    private void SaveData(List<Student> students)
    {
        var studentsJson = JsonSerializer.Serialize(students);
        File.WriteAllText(studentFilePath, studentsJson);
    }
    private List<Student> GetStudents()
    {
        var studentsJson = File.ReadAllText(studentFilePath);
        var students = JsonSerializer.Deserialize<List<Student>>(studentsJson);
        return students;
    }

    Student IStudentServices.UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(Student student)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Student> IStudentServices.GetAllStudents()
    {
        throw new NotImplementedException();
    }
}