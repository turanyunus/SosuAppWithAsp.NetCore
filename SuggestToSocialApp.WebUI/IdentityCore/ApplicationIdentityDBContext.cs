﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.IdentityCore
{
    public class ApplicationIdentityDBContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityDBContext(DbContextOptions<ApplicationIdentityDBContext> options)
            : base(options)
        {

        }
    }
}
