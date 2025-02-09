﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertyInspection_WebApp.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int RoleID { get; set; }
    }
}

