using ConsoleApp28.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp28.Services.Implements
{
    internal class Studentservice : Abstraction.IStudentService
    {
        AddDbContext _context = new AddDbContext();
        public void Add(Student student)
        {
            string command = $"insert into Student values('{student.Name}, {student.Surname}')";
            int result = _context.ExecuteNonQuery(command);
            if (result != 0)
            {
                Console.WriteLine("student elave olundu");
            }
            else
            {
                Console.WriteLine("xeta");
            }
        }
        public Student? GetById(int id)
        {
            string query = $"select * from Students where Id=[id]";
            DataTable dataTable = _context.ExecuteQuery(query);
            Student student = new Student();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                student.Id = (int)dataRow[id];
                student.Name = dataRow["Name"].ToString();
                student.Surname = dataRow["Surname"].ToString();
            }
            ;
            return student;
        }
        public List<Student> GetAll()
        {
            string query = "select * from Students";
            DataTable dataTable = _context.ExucuteQuery(query);
            List<Student> students = new List<Student>();

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Student student = new Student
                {
                    Id = (int)dataRow["Id"],
                    Name = dataRow["Name"].ToString(),
                    Surname = dataRow["Surname"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
        public void Remove(int Id)
        {
            string command = $"Delete from students where Id={Id}";
            int result = _context.ExecuteNonQuery(command);
            if (result != 0)
            {
                Console.WriteLine("Silindii");
            }
            else
            {
                Console.WriteLine("Silinmedi");
            }
        }
        public void Update(Student student)
        {
            string command = $"Update students set Name='{student.Name}',Surname='{student.Surname}' where Id={student.Id}";
            int result = _context.ExecuteNonQuery(command);
            if (result != 0)
            {
                Console.WriteLine(" Deyisdi ");
            }
            else
            {
                Console.WriteLine("Deyismedi");
            }
        }
    }

    }

    internal class AddDbContext
    {
        public AddDbContext()
        {
        }

        internal int ExecuteNonQuery(string command)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        internal DataTable ExucuteQuery(string query)
        {
            throw new NotImplementedException();
        }
    }


