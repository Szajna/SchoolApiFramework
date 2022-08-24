using SchoolApiFramewirk.Data;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SchoolApiFramewirk.Services
{
    public class StudentService : IStudentService
    {
        private DataContext _context = new DataContext();

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;

        }
        public async Task<Student> DeleteStudent(string id)
        {
            var DbStudent = await _context.Students.FindAsync(id);
            _context.Students.Remove(DbStudent);
            await _context.SaveChangesAsync();
            return DbStudent;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var dupa = await _context.Students.ToListAsync();
            return dupa;
        }

        public async Task<Student> GetStudent(string id)
        {
            var student = await _context.Students.FindAsync(id);
            return student;
        }

        public async Task<Student> UpdateStudent(Student request)
        {
            var DbStudent = await _context.Students.FindAsync(request.Id);

            DbStudent.FirstName = request.FirstName;
            DbStudent.LastName = request.LastName;
            DbStudent.Address = request.Address;
            DbStudent.City = request.City;
            DbStudent.PostCode = request.PostCode;

            await _context.SaveChangesAsync();
            return request;
        }
    }
}