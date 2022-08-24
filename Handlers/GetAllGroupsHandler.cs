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
    public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsQuery, List<Group>>
    {
        private readonly IGroupService _groupService;
        public GetAllGroupsHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public async Task<List<Group>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
        {
            return await _groupService.GetAllGroups();
        }
    }
}