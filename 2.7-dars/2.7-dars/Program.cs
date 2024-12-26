using _2._7_dars.Services.DTOs;
using _2._7_dars.Services.Enums;
using System;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student details:");


            string firstName = GetInput("First Name: ");
            string lastName = GetInput("Last Name: ");
            int age = GetIntInput("Age: ");
            string email = GetInput("Email: ");
            GenderDto gender = GetEnumInput<GenderDto>("Gender (Male/Female): ");
            DegreeStatusDto degree = GetEnumInput<DegreeStatusDto>("Degree (Bachelor/Master/Phd): ");

            StudentGetDto student = new StudentGetDto
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Email = email,
                Gender = gender,
                Degree = degree
            };

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Gender: {student.Gender}");
            Console.WriteLine($"Degree: {student.Degree}");
        }

        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static int GetIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return result;
        }

        static T GetEnumInput<T>(string prompt) where T : struct
        {
            T result;
            while (true)
            {
                Console.Write(prompt);
                if (Enum.TryParse(Console.ReadLine(), true, out result) && Enum.IsDefined(typeof(T), result))
                {
                    break;
                }
                Console.WriteLine($"Invalid input. Please enter a valid {typeof(T).Name}.");
            }
            return result;
        }
    }
}
    