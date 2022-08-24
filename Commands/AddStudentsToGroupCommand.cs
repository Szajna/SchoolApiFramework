using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Commands
{
    public class AddStudentsToGroupCommand : IRequest<Group>
    {
        public string GroupId { get; }
        public List<string> Students { get; }

        public AddStudentsToGroupCommand(string groupId, List<string> students)
        {
            GroupId = groupId;
            Students = students;
        }
    }
}