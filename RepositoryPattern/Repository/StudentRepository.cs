using RepositoryPattern.Models;


namespace RepositoryPattern.Repository
{
    internal class StudentRepository : IStudent
    {
        public List<Student> GetAllStudents()
        {
            return GetData();
           
        }

        public Student GetStudentById(int id)
        {
            return GetData().First(x => x.Id == id);    
        }

       
        private List<Student> GetData()
        {

            List<Student> Students = new List<Student> { 
            
            new Student{Class ="BSIT" , Email = "RashidNazeer@gmail.com",Id = 1, Name="Rashid Nazeer" },
            new Student{Class ="BSCS" , Email = "Asif@gmail.com",Id = 2, Name="M.Asif" },
            new Student{Class ="BSSE" , Email = "Saqib@gmail.com",Id = 3, Name="Saqib" },
            new Student{Class ="BSEE" , Email = "Asad@gmail.com",Id = 4, Name="Asad" },
            new Student{Class ="BSMC" , Email = "Tayyab@gmail.com",Id = 5, Name="M.Tayyab" },


            };   

            return Students;
          

        }
    }
}
