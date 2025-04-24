using ConsoleApp28.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28.Services.Abstraction
{
    class IStudentService
    {
        public void Add(Student student);
        public Student GetById(int id);
        public void Remove(int id);
        public void Update(Student student);
        public List<Student> GetAll();
    }
}
