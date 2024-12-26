using _2._7_dars.Services.Enums;

namespace _2._7_dars.Services.DTOs;

public class BaseStudentDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public GenderDto Gender { get; set; }
    public DegreeStatusDto Degree { get; set; }
}
