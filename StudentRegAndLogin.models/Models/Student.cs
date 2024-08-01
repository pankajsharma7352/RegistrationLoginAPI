﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegAndLogin.models.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
       
        [Required]
        public string Address { get; set; }
    }

    public class ServiceResponse 
    {
        public bool IsSuccess  { get; set; }

        public string Message { get; set; }
        public object Data { get; set; }
        public int StatusCode { get; set; }
    }
}
