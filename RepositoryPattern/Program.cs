using RepositoryPattern.Repository;
using RepositoryPattern.Models;

StudentRepository studentRepository = new StudentRepository();
Student student = studentRepository.GetStudentById(1);
Console.WriteLine(student.Name);