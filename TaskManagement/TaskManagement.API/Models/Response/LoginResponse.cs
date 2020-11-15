﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.API.Models.Response
{
    public class LoginResponse
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
    }
}
