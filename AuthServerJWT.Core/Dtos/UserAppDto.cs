﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Core.Dtos
{
    public class UserAppDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
