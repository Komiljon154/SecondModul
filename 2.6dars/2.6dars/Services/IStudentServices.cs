using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._2dars.Api.Models;

namespace ConsoleApp4.Services
{
    public interface IStudentServices
    {

        public Student AddStudent (Student student);
        public Student UpdateStudent (Student student);
        public void DeleteStudent (Student student);
        public IEnumerable<Student> GetAllStudents ();
        Student GetById(Guid id);
    }
}
