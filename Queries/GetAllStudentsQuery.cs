using MediatR;
using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Queries
{
    public class GetAllStudentsQuery : IRequest<List<Student>>
    {
    }
}