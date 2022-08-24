using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Commands
{
    public class DeleteGroupCommand : IRequest<Group>
    {
        public string Id { get; }

        public DeleteGroupCommand(string id)
        {
            Id = id;
        }
    }
}