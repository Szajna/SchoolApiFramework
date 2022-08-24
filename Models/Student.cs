﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string GroupId { get; set; }
        public Student()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}