﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext() : base("name=RegistrationDBContext")
        {
        }

        public DbSet<RegistrationDetail> RegistrationDetails { get; set; }
    }

}

