using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFDbFirst.Entities;
namespace HandsOnEFDbFirst
{
    internal class StudentRepository
    {
        private readonly EMIDSDBContext db;
        public StudentRepository()
        {
        this.db=new EMIDSDBContext();
        }
        public List<Student> GetStudents()
        {
            return this.db.Students.ToList();
        }
        //GetStudentById
        //GetStudentsByCity
        //AddStudent
        //EditStudent
        //DeleteStudent

        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            List<Student> students = studentRepository.GetStudents();
            foreach(var item in students)
            {
                Console.WriteLine("{0} {1} {2}", item.StudFname, item.StudLname, item.Address);
            }
        }
    }
}
