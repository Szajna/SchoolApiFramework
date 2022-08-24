using MediatR;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Models;
using SchoolApiFramewirk.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SchoolApiFramewirk.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IStudentService _studentService;

        public GetStudentByIdHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudent(request.Id);
            if (student == null)
            {
                return null;
            }
            return student;
        }
    }
}