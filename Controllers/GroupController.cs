using MediatR;
using SchoolApiFramewirk.Commands;
using SchoolApiFramewirk.Models;
using SchoolApiFramewirk.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SchoolApiFramewirk.Controllers
{
    public class GroupController : ApiController
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> GetAllGroups()
        {
            var query = new GetAllGroupsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> GetGroup(string id)
        {
            var query = new GetGroupByIdQuery(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> PutGroup(Group request)
        {
            var query = new UpdateGroupCommand(request);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> AddGroup(Group group)
        {
            var query = new CreateGroupCommand(group);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> DeleteGroup(string id)
        {
            var query = new DeleteGroupCommand(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
