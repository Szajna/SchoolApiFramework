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
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        public GetAllStudentsHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<List<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetAllStudents();
        }
    }
}