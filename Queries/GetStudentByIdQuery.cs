using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public string Id { get; }

        public GetStudentByIdQuery(string id)
        {
            Id = id;
        }
    }
}