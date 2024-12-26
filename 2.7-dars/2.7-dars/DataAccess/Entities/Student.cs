using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._7_dars.DataAccess.Enums;

namespace _2._7_dars.DataAccess.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public Gender Gender { get; set; }
    public DegreeStatus Degree {  get; set; }

}
