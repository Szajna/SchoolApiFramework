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
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IStudentService _studentService;

        public UpdateStudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToUpdate = new Student
            {
                Address = request.Address,
                Birthdate = request.Birthdate,
                City = request.City,
                LastName = request.LastName,
                FatherName = request.FatherName,
                FirstName = request.FirstName,
                PostCode = request.PostCode,
            };
            var student = await _studentService.UpdateStudent(studentToUpdate);
            return student;
        }
    }
}