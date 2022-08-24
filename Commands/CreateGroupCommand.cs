using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Commands
{
    public class CreateGroupCommand : IRequest<Group>
    {
        public string Name { get; }
        public int Year { get; }
        public string Supervisor { get; }

        public CreateGroupCommand(Group group)
        {
            Name = group.Name;
            Year = group.Year;
            Supervisor = group.Supervisor;
        }
    }
}