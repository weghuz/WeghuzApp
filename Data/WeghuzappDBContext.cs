using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Data
{
    public class WeghuzappDBContext : IdentityDbContext
    {
        public WeghuzappDBContext(DbContextOptions<WeghuzappDBContext> options)
            : base(options)
        {

        }
    }
}
