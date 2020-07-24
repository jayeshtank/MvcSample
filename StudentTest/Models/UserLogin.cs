﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentTest.Models
{
    public class UserLogin
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}