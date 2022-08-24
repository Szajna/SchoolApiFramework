using MediatR;
using SchoolApiFramewirk.Commands;
using SchoolApiFramewirk.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using SchoolApiFramewirk.Models;

namespace SchoolApiFramewirk.Handlers
{
    public class AddStudentsToGroupHandler : IRequestHandler<AddStudentsToGroupCommand, Group>
    {
        private readonly IGroupService _groupService;

        public AddStudentsToGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(AddStudentsToGroupCommand request, CancellationToken cancellationToken)
        {
            var group = await _groupService.AddStudentsToGroup(request.GroupId, request.Students);
            return group;
        }
    }
}