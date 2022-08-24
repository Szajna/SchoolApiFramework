using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Supervisor { get; set; }
        public List<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
            Id = Guid.NewGuid().ToString();
        }
    }
}