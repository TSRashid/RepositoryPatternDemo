using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{
    internal interface IStudent
    {
        public Student GetStudentById(int id);
        public List<Student> GetAllStudents();
    }
}
