﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.DomainModels
{
    public class Student
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }        
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
