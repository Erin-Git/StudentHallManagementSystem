﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHallManagement.Models
{
    public class Login
    {
        [Key]
        public int UserID { get; set; }
        public String UserName { get; set; }
        public int UserRoleID { get; set; }
        public int Password { get; set; }
    }
}
