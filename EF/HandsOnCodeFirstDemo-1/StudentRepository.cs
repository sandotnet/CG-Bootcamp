using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnCodeFirstDemo_1.Entities;
namespace HandsOnCodeFirstDemo_1
{
    internal class StudentRepository
    {
        private readonly SMS516DBContext db;
        public StudentRepository()
        {
            this.db = new SMS516DBContext();
        }
        public void AddStudent(Student student)
        {
            this.db.Students.Add(student);
            this.db.SaveChanges();
        }
        public void EditStudent(Student student)
        {
            this.db.Students.Update(student);
            this.db.SaveChanges();
        }
        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            return db.Students.Find(id); //id is primary key
        }
    }
    class Test
    {
        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            //studentRepository.AddStudent(new Student() { Name = "Ranjeet", Age = 21, City = "Pune", Address = "Pune" });
            //studentRepository.AddStudent(new Student() { Name = "Rahul", Age = 21, City = "Mumbai", Address = "Mubai" });
            List<Student> students=studentRepository.GetStudents();
            foreach(var item in students)
            {
                Console.WriteLine("{0} {1} {2} {3} ", item.Id, item.Name, item.Age, item.City);
            }
        }
    }
}
