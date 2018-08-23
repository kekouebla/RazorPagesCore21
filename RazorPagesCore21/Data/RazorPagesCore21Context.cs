using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesCore21.Models
{
    public class RazorPagesCore21Context : DbContext
    {
        public RazorPagesCore21Context (DbContextOptions<RazorPagesCore21Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCore21.Models.Movie> Movie { get; set; }
    }
}
