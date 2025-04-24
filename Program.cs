using ConsoleApp28.Models;
using ConsoleApp28.Services.Abstraction;
using ConsoleApp28.Services.Implements;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studentservice studentservice = new Studentservice();
            Student student = new Student
            {
                Name = "Arzuman",
                Surname = "Amiraslanov"
            };
            studentservice.Add(student);
            studentservice.Update(new Student { Id = 1, Name = "New", Surname = "Ad" });
            studentservice.Remove(1);

            var student1 = studentservice.GetById(1);
            if (student != null)
                Console.WriteLine($"Tapıldı: {student.Name} {student.Surname}");
        }
    }
}


