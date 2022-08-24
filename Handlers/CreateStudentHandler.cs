using MediatR;
using SchoolApiFramewirk.Commands;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace SchoolApiFramewirk.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentService _studentService;

        public CreateStudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToAdd = new Student
            {
                Address = request.Address,
                Birthdate = request.Birthdate,
                City = request.City,
                LastName = request.LastName,
                FatherName = request.FatherName,
                FirstName = request.FirstName,
                PostCode = request.PostCode,
            };
            var student = await _studentService.AddStudent(studentToAdd);
            return student;
        }
    }
}