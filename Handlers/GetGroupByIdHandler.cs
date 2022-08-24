using MediatR;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using SchoolApiFramewirk.Models;

namespace SchoolApiFramewirk.Handlers
{
    public class GetGroupByIdHandler : IRequestHandler<GetGroupByIdQuery, Group>
    {
        private readonly IGroupService _groupService;

        public GetGroupByIdHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public async Task<Group> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupService.GetGroup(request.Id);
            if (group == null)
            {
                return null;
            }
            return group;
        }
    }
}