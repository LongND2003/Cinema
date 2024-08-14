﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Role : IdentityRole<int>
    {
        public string Code { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
