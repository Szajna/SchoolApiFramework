using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Commands
{
    public class DeleteStudentCommand : IRequest<Student>
    {
        public string Id { get; }

        public DeleteStudentCommand(string id)
        {
            Id = id;
        }
    }
}