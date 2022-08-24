using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Queries
{
    public class GetGroupByIdQuery : IRequest<Group>
    {
        public string Id { get; }

        public GetGroupByIdQuery(string id)
        {
            Id = id;
        }
    }
}