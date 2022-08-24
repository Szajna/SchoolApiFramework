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
    public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, Group>
    {
        private readonly IGroupService _groupService;
        public CreateGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var groupToAdd = new Group
            {
                Name = request.Name,
                Year = request.Year,
                Supervisor = request.Supervisor
            };
            var group = await _groupService.AddGroup(groupToAdd);
            return group;
        }
    }
}