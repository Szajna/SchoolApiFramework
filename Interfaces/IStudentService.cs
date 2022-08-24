using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiFramewirk.Interfaces
{
    public interface IStudentService
    {
        Task<Student> AddStudent(Student student);
        Task<Student> DeleteStudent(string id);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudent(string id);
        Task<Student> UpdateStudent(Student request);
    }
}
