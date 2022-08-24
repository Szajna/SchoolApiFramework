using MediatR;
using SchoolApiFramewirk.Commands;
using SchoolApiFramewirk.Data;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Models;
using SchoolApiFramewirk.Queries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SchoolApiFramewirk.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> GetAll()
        {
            var query = new GetAllStudentsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> GetStudent(string id)
        {
            var query = new GetStudentByIdQuery(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> PutStudent(Student request)
        {
            var query = new UpdateStudentCommand(request);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> AddStudent(Student student)
        {
            var query = new CreateStudentCommand(student);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> DeleteStudent(string id)
        {
            var query = new DeleteStudentCommand(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
