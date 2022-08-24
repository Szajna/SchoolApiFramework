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
    public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, Group>
    {
        private readonly IGroupService _groupService;
        public DeleteGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            var group = await _groupService.DeleteGroup(request.Id);
            if (group == null)
            {
                return null;
            }
            return group;
        }
    }
}