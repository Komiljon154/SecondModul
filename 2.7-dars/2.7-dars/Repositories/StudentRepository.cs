using System.Data;
using System.Text.Json;
using _2._7_dars.DataAccess.Entities;

namespace _2._7_dars.Repositories
{
    public interface StudentRepository : IStudentRepository
    {
        private readonly string _path;
        private List<Student> _student;


        public void StudentRepository()
        {
            _path = "../../../DataAccess/Data/Students.json";
            _student = new List<Student>();

            if (!File.Exists(_path))
            {
                File.WriteAllText(_path, "[]");
            }

            _student = ReadAllStudents();
        }

        public void EmailContains(string email)
        {
            foreach (var student in _student)
            {
                if (student.Email == email)
                {
                    throw new Exception("This email already excist, please try again");
                }
            }
        }

        public Student GetStudentById(Guid studentId)
        {
            foreach (var student in _student)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
            }
            throw new Exception($"Bunday : {studentId} li talaba yo'q");
        }
        public List<Student> ReadAllStudents()
        {
            var studentJson = File.ReadAllText(_path);
            var students = JsonSerializer.Deserialize<List<Student>>(studentJson);
            return students;
        }

        public void RemoveStudent(Guid studentId)
        {
            var student = GetStudentById(studentId);
            _student.Remove(student);
            SaveData();
        }
        public void UpdateStudent(Student student)
        {
            var updatingStudent = GetStudentById(student.Id);
            var index = _student.IndexOf(updatingStudent);
            _student[index] = student;
            SaveData();
            
        }
        public Guid WriteStudent(Student student)
        {
            _student.Add(student);
            SaveData();
            return student.Id;
        }
        public void SaveData()
        {
            var studentJson = JsonSerializer.Serialize( _student );
            File.WriteAllText(_path, studentJson );
        }
    }
}