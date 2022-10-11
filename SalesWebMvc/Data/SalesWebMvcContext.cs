<<<<<<< HEAD
﻿using System;
=======
﻿
using System;
>>>>>>> 1fbcb036c74f308bde117697d3994403d9c6a160
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD
namespace SalesWebMvc.Data
=======
namespace SalesWebMvc.Models
>>>>>>> 1fbcb036c74f308bde117697d3994403d9c6a160
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.Models.Department> Department { get; set; }
    }
}